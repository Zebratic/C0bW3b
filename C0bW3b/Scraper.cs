using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;

namespace C0bW3b
{
    public class Scraper
    {
        public static List<RunnerThread> RunningScrapers = new List<RunnerThread>();
        public static List<ScrapeHit> ScrapeHits = new List<ScrapeHit>();

        public class RunnerThread
        {
            public Thread Thread;

            public int ID;
            public WebProxy Proxy;
            public string Status;
            public string Dork;

            public RunnerThread(Thread thread, int id)
            {
                Thread = thread;
                ID = id;
            }
        }


        public class ScrapeHit
        {
            public string Dork;
            public string Url;
            public string Html;
            public List<string> Matches = new List<string>();
            public WebProxy Proxy;

            public ScrapeHit(string dork, string url, string html, List<string> matches, WebProxy proxy)
            {
                this.Dork = dork;
                this.Url = url;
                this.Html = html;

                if (matches != null)
                    this.Matches = matches;
                else
                    this.Matches = new List<string>();

                this.Proxy = proxy;
            }
        }

        public static RunnerThread GetThread(int id) => RunningScrapers.Find(x => x.ID == id);

        public static void Start(int threads, bool proxyless, bool regexmatches, bool allowduplicates, bool logfullurl, int minmatch, string itemtarget)
        {
            for (int i = 0; i < threads; i++)
            {
                Thread t = new Thread(() => Scrape(i - 1, proxyless, regexmatches, allowduplicates, logfullurl, minmatch, itemtarget));
                RunningScrapers.Add(new RunnerThread(t, i));
                t.Start();
                Thread.Sleep(1000);
            }
        }

        public static void Scrape(int id, bool proxyless, bool regexmatches, bool allowduplicates, bool logfullurl, int minmatch, string itemtarget)
        {
            while (true)
            {
                try
                {
                    GetThread(id).Status = "<<INITIALIZING>>";
                    
                    string dork = Forms.Runner.Dorks[new Random().Next(Forms.Runner.Dorks.Length)];
                    dork = dork.Replace("%ITEM%", itemtarget);
                    GetThread(id).Dork = dork;
                    string useragent = UserAgents.Agents[new Random().Next(UserAgents.Agents.Length)];
                    WebProxy proxy = null;
                    List<ScrapeHit> results = new List<ScrapeHit>();

                    if (!proxyless)
                    {
                        proxy = Forms.Runner.Proxies[new Random().Next(Forms.Runner.Proxies.Length)];
                        GetThread(id).Proxy = proxy;
                    }

                    GetThread(id).Status = "<<DORKING [GOOGLE]>>";
                    try { results.AddRange(Google(dork, useragent, proxyless, allowduplicates, logfullurl, proxy)); } catch { }
                    
                    GetThread(id).Status = "<<DORKING [BING]>>";
                    try { results.AddRange(Bing(dork, useragent, proxyless, allowduplicates, logfullurl, proxy)); } catch { }

                    if (results != null && results.Count > 0)
                    {
                        int i = 1;
                        int m = 0;
                        foreach (ScrapeHit result in results)
                        {
                            try
                            {
                                GetThread(id).Status = $"<<ANALYSING [{m}/{i}/{results.Count + 1}]>>";
                                result.Html = AnalyseURL(result);

                                foreach (string match in Forms.Runner.Matches)
                                {
                                    string match2 = match.Replace("%ITEM%", itemtarget);

                                    if (!regexmatches)
                                    {
                                        if (result.Html.Contains(match2))
                                            result.Matches.Add(match2);
                                    }
                                    else
                                    {
                                        Regex regex = new Regex(match2);
                                        foreach (Match rmatch in regex.Matches(result.Html))
                                            result.Matches.Add(rmatch.Groups[1].Value);
                                    }
                                }

                                if (result.Matches.Count >= minmatch)
                                {
                                    if (allowduplicates || ScrapeHits.FindAll(x => x.Url == result.Url).Count == 0)
                                    {
                                        m++;
                                        ScrapeHits.Add(result);
                                        Forms.Runner.instance.Hits++;
                                        Forms.Runner.instance.AddScrapeHit(result);
                                    }
                                }
                                else
                                    Forms.Runner.instance.Bad++;
                                
                            }
                            catch (Exception ex)
                            {
                                Forms.Runner.instance.Retries++;
                                try { GetThread(id).Status = $"<<{ex.Message.ToUpper()}>>"; } catch { }
                            }

                            i++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Forms.Runner.instance.Retries++;
                    try { GetThread(id).Status = $"<<{ex.Message.ToUpper()}>>"; } catch { }
                }
            }
        }

        public static string AnalyseURL(ScrapeHit hit)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://" + hit.Url);
            request.Proxy = hit.Proxy;

            request.UserAgent = UserAgents.Agents[new Random().Next(UserAgents.Agents.Length)];
            request.Timeout = 2000;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string html = reader.ReadToEnd();
            reader.Close();
            response.Close();

            return html;
        }

        public static List<ScrapeHit> Google(string dork, string useragent, bool proxyless, bool allowduplicates, bool logfullurl, WebProxy proxy = null)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.google.com/search?q=" + dork);
                if (!proxyless)
                    request.Proxy = proxy;

                request.UserAgent = useragent;
                request.Timeout = 2000;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string html = reader.ReadToEnd();
                reader.Close();
                response.Close();


                // get result urls
                List<ScrapeHit> results = new List<ScrapeHit>();
                try
                {
                    string searches = html.Split(new string[] { "id=\"rso\">" }, StringSplitOptions.None)[1].Split(new string[] { "<div id=\"bottomads\">" }, StringSplitOptions.None)[0];

                    // get all urls from search results using regex and add to list´
                    Regex regex = new Regex(@"<a href=""(.*?)"">");
                    foreach (Match match in regex.Matches(searches))
                    {
                        try
                        {
                            string url = match.Groups[1].Value;

                            if (url.Contains("https://"))
                                results.Add(new ScrapeHit(dork, logfullurl ? url.Replace("https://", "").Split('"')[0] : new Uri(url).Host, null, null, proxy));
                        }
                        catch { Forms.Runner.instance.Retries++; }
                    }
                }
                catch { Forms.Runner.instance.Retries++; }

                return results;
            }
            catch { Forms.Runner.instance.Retries++; }

            return new List<ScrapeHit>();
        }

        public static List<ScrapeHit> Bing(string dork, string useragent, bool proxyless, bool allowduplicates, bool logfullurl, WebProxy proxy = null)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://bing.com/search?q=" + dork);
                if (!proxyless)
                    request.Proxy = proxy;

                request.UserAgent = useragent;
                request.Timeout = 2000;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string html = reader.ReadToEnd();
                reader.Close();
                response.Close();

                List<ScrapeHit> results = new List<ScrapeHit>();
                try
                {
                    string searches = html.Split(new string[] { "<ol id=\"b_results\" class=\"\">" }, StringSplitOptions.None)[1].Split(new string[] { "<aside aria-label=\"Additional Results\">" }, StringSplitOptions.None)[0];

                    // get all urls from search results using regex and add to list
                    Regex regex = new Regex(@"<a href=""(.*?)"">");
                    foreach (Match match in regex.Matches(searches))
                    {
                        try
                        {
                            string url = match.Groups[1].Value;
                            if (url.Contains("https://"))
                                results.Add(new ScrapeHit(dork, logfullurl ? url.Replace("https://", "").Split('"')[0] : new Uri(url).Host, null, null, proxy));
                        }
                        catch { Forms.Runner.instance.Retries++; }
                    }
                }
                catch { Forms.Runner.instance.Retries++; }
                return results;
            }
            catch { Forms.Runner.instance.Retries++; }
            return new List<ScrapeHit>();
        }
    }
}