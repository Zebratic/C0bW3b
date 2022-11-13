using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

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
            public string UserAgent;
            public string Engine;

            public ScrapeHit(string dork, string url, string html, List<string> matches, WebProxy proxy, string userAgent, string engine)
            {
                this.Dork = dork;
                this.Url = url;
                this.Html = html;

                if (matches != null)
                    this.Matches = matches;
                else
                    this.Matches = new List<string>();

                this.Proxy = proxy;
                this.UserAgent = userAgent;
                this.Engine = engine;
            }
        }

        public static RunnerThread GetThread(int id) => RunningScrapers.Find(x => x.ID == id);

        public static void Start(int threads, bool proxyless, bool regexmatches, bool allowduplicates, bool logfullurl, int minmatch, string itemtarget, bool recursive, int recursivelimit, int urllimit)
        {
            for (int i = 0; i < threads; i++)
            {
                int id = i;
                Thread t = new Thread(() => Scrape(id, proxyless, regexmatches, allowduplicates, logfullurl, minmatch, itemtarget, recursive, recursivelimit, urllimit));
                RunningScrapers.Add(new RunnerThread(t, id));
                t.Start();
            }
        }

        public static void Scrape(int id, bool proxyless, bool regexmatches, bool allowduplicates, bool logfullurl, int minmatch, string itemtarget, bool recursive, int recursivelimit, int urllimit)
        {
            while (true)
            {
                try
                {
                    GetThread(id).Status = "INITIALIZING";

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

                    foreach (Forms.SearchEngine engine in ConfigSystem.config.SearchEngines)
                    {
                        if (engine.Banned) continue; // Ignore banned engines

                        string name = engine.SearchURL;
                        try { Uri uri = new Uri(engine.SearchURL); name = uri.Host; } catch { }
                        GetThread(id).Status = $"DORKING [{name.ToUpper()}]";
                        try { results.AddRange(Search(engine, dork, useragent, proxyless, logfullurl, proxy)); } catch { }
                    }

                    if (recursive)
                    {
                        List<ScrapeHit> recursivehits = new List<ScrapeHit>();
                        for (int i = 0; i < recursivelimit; i++)
                        {
                            try
                            {
                                List<ScrapeHit> recursiveresults = results;
                                GetThread(id).Status = $"RECURSING [{recursivehits.Count}/{i}/{recursivelimit}]";
                                foreach (ScrapeHit result in recursiveresults)
                                {
                                    try
                                    {
                                        result.Html = AnalyseURL(result);

                                        // find all urls
                                        List<string> urls = new List<string>();
                                        Regex regex = new Regex(@"((http|ftp|https):\/\/[\w\-_]+(\.[\w\-_]+)+([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?)");
                                        foreach (Match match in regex.Matches(result.Html))
                                        {
                                            string url = match.Groups[1].Value;
                                            if (url.Contains("https://") || url.Contains("http://"))
                                            {
                                                if (recursivehits.FindAll(x => x.Url == url).Count == 0 && recursiveresults.FindAll(x => x.Url == url).Count == 0)
                                                {
                                                    recursivehits.Add(new ScrapeHit(dork, logfullurl ? url.Replace("https://", "").Replace("http://", "").Split('"')[0] : new Uri(url).Host, null, null, proxy, useragent, result.Engine));
                                                    if (recursivehits.Count >= urllimit)
                                                        goto stop;
                                                }
                                            }
                                        }
                                    }
                                    catch { }
                                }
                                recursiveresults = recursivehits;
                            }
                            catch { }
                        }
                    stop:

                        results.AddRange(recursivehits);
                    }

                    if (results != null && results.Count > 0)
                    {
                        int i = 1;
                        int m = 0;
                        foreach (ScrapeHit result in results)
                        {
                            try
                            {
                                if (!ConfigSystem.config.Blacklist.Contains(result.Url.Replace("www.", "").Replace("https://", "").Replace("http://", "")))
                                {

                                    GetThread(id).Status = $"ANALYSING [{m}/{i}/{results.Count + 1}]";
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
                            }
                            catch (Exception ex)
                            {
                                Forms.Runner.instance.Retries++;
                                try { GetThread(id).Status = $"{ex.Message.ToUpper()}"; } catch { }
                            }

                            i++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Forms.Runner.instance.Retries++;
                    try { GetThread(id).Status = $"{ex.Message.ToUpper()}"; } catch { }
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

        public static List<ScrapeHit> Search(Forms.SearchEngine engine, string dork, string useragent, bool proxyless, bool logfullurl, WebProxy proxy = null)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(engine.SearchURL.Replace("%DORK%", dork));
                if (!proxyless)
                    request.Proxy = proxy;

                request.UserAgent = useragent;
                request.Timeout = engine.Timeout;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string html = reader.ReadToEnd();
                reader.Close();
                response.Close();


                // get result urls
                List<ScrapeHit> results = new List<ScrapeHit>();
                try
                {
                    string searches = html.Split(new string[] { engine.LString }, StringSplitOptions.None)[1].Split(new string[] { engine.RString }, StringSplitOptions.None)[0];

                    // get all urls from search results using regex and add to list
                    Regex regex = new Regex(engine.URLRegex);
                    foreach (Match match in regex.Matches(searches))
                    {
                        try
                        {
                            string url = match.Groups[1].Value;

                            if (url.Contains("https://") || url.Contains("http://"))
                            {
                                string name = engine.SearchURL;
                                try { Uri uri = new Uri(engine.SearchURL); name = uri.Host; } catch { }
                                results.Add(new ScrapeHit(dork, logfullurl ? url.Replace("https://", "").Replace("http://", "").Split('"')[0] : new Uri(url).Host, null, null, proxy, useragent, name.ToUpper()));
                            }
                        }
                        catch { Forms.Runner.instance.Retries++; }
                    }
                }
                catch { Forms.Runner.instance.Retries++; }

                return results;
            }
            catch (WebException webex)
            {
                string name = engine.SearchURL;
                try { Uri uri = new Uri(engine.SearchURL); name = uri.Host; } catch { }

                switch (((HttpWebResponse)webex?.Response)?.StatusCode)
                {
                    case HttpStatusCode.Forbidden:
                        Main.instance.PrintFooter($"Banned {name}", ConfigSystem.config.CurrentTheme.Warning);
                        engine.Banned = true;
                        break;
                    case HttpStatusCode.RequestTimeout:
                        Main.instance.PrintFooter($"Banned {name}", ConfigSystem.config.CurrentTheme.Warning);
                        engine.Banned = true;
                        break;
                    case HttpStatusCode.NotFound:
                        Main.instance.PrintFooter($"Banned {name}", ConfigSystem.config.CurrentTheme.Warning);
                        engine.Banned = true;
                        break;
                    case HttpStatusCode.InternalServerError:
                        Main.instance.PrintFooter($"Banned {name}", ConfigSystem.config.CurrentTheme.Warning);
                        engine.Banned = true;
                        break;
                    case HttpStatusCode.BadGateway:
                        Main.instance.PrintFooter($"Banned {name}", ConfigSystem.config.CurrentTheme.Warning);
                        engine.Banned = true;
                        break;
                    default:
                        Forms.Runner.instance.Retries++;
                        break;
                }
            }
            catch (IndexOutOfRangeException) { } 
            catch (Exception) { Forms.Runner.instance.Retries++; }

            return new List<ScrapeHit>();
        }
    }
}