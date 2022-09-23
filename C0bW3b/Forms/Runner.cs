using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace C0bW3b.Forms
{
    public partial class Runner : Form
    {
        public static string[] Dorks = new string[] { };
        public static string[] Matches = new string[] { };
        public static WebProxy[] Proxies = new WebProxy[] { };
        public static bool Running = false;
        public static Runner instance;
        public string Time = DateTime.Now.ToString("dd-MM-yyyy HH;mm");

        public int Hits = 0;
        public int Bad = 0;
        public int Retries = 0;

        public Runner()
        {
            InitializeComponent();
            instance = this;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);


            if (!Directory.Exists(Environment.CurrentDirectory + @"\Dorks"))
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\Dorks");
            if (!Directory.Exists(Environment.CurrentDirectory + @"\Matches"))
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\Matches");
            if (!Directory.Exists(Environment.CurrentDirectory + @"\Proxies"))
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\Proxies");
            if (!Directory.Exists(Environment.CurrentDirectory + @"\Hits"))
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\Hits");
        }

        private void GUI_Load(object sender, EventArgs e) => new Thread(UpdateStats).Start();

        public void LockElements(bool enabled)
        {
            lblTarget.ForeColor = enabled ? Color.FromArgb(255, 255, 255) : Color.FromArgb(3, 3, 3);
            txtTarget.Enabled = enabled;

            btnLoadDorks.Enabled = enabled;

            btnLoadMatches.Enabled = enabled;
            cbRegexMatches.Enabled = enabled;

            btnLoadProxies.Enabled = enabled;
            cbProxyless.Enabled = enabled;

            lblThreads.ForeColor = enabled ? Color.FromArgb(255, 255, 255) : Color.FromArgb(3, 3, 3);
            numThreads.Enabled = enabled;

            cbAllowDuplicates.Enabled = enabled;
            cbLogFullURL.Enabled = enabled;

            lblMinMatch.ForeColor = enabled ? Color.FromArgb(255, 255, 255) : Color.FromArgb(3, 3, 3);
            numMinMatch.Enabled = enabled;

            cbRecursiveSearch.Enabled = enabled;
            lblRecursiveLimit.ForeColor = enabled ? Color.FromArgb(255, 255, 255) : Color.FromArgb(3, 3, 3);
            numRecursiveLimit.Enabled = enabled;
        }

        public void AddScrapeHit(Scraper.ScrapeHit scrapeHit)
        {
            // print data to log
            string output = string.Empty;
            foreach (string variable in Main.instance.settings.OutputFormat)
            {
                try
                {
                    if (!string.IsNullOrWhiteSpace(output))
                        output += $" {Main.instance.settings.Seperator} ";

                    // get variable value
                    switch (variable.ToUpper())
                    {
                        case "URL": output += $"{variable.ToUpper()} = https://{scrapeHit.Url.Replace("www.", "")}"; break;
                        case "DORK": output += $"{variable.ToUpper()} = {scrapeHit.Dork}"; break;
                        case "HTML": output += $"{variable.ToUpper()} = {scrapeHit.Html}"; break;
                        case "MATCHES": output += $"{variable.ToUpper()} = {string.Join(", ", scrapeHit.Matches)}"; break;
                        case "MATCH COUNT": output += $"{variable.ToUpper()} = {scrapeHit.Matches.Count}"; break;
                        case "PROXY": output += $"{variable.ToUpper()} = {scrapeHit.Proxy.Address}"; break;
                        case "USER AGENT": output += $"{variable.ToUpper()} = {scrapeHit.UserAgent}"; break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            txtHits.Invoke((MethodInvoker)delegate { txtHits.AppendText(output + "\n"); });

            try { File.AppendAllText(Environment.CurrentDirectory + $@"\Hits\{Time}.txt", output + "\n"); } catch { }
        }

        public void UpdateStats()
        {
            while (true)
            {
                try
                {
                    lblHits.Invoke((MethodInvoker)delegate { lblHits.Text = "Hits: " + Hits; });
                    lblBad.Invoke((MethodInvoker)delegate { lblBad.Text = "Bad: " + Bad; });
                    lblRetries.Invoke((MethodInvoker)delegate { lblRetries.Text = "Retries: " + Retries; });

                    if (Main.instance.settings.UpdateThreadStatus)
                    {
                        // update listThreads with current threads
                        if (listThreads.Items.Count != Scraper.RunningScrapers.Count)
                        {
                            listThreads.Invoke((MethodInvoker)delegate
                            {
                                listThreads.Items.Clear();
                                foreach (Scraper.RunnerThread s in Scraper.RunningScrapers)
                                {
                                    ListViewItem item = new ListViewItem();
                                    item.Text = s.ID.ToString();
                                    item.SubItems.Add(s.Proxy == null ? "Proxyless" : s.Proxy.Address.ToString());
                                    item.SubItems.Add(s.Status);
                                    item.SubItems.Add(s.Dork);

                                    listThreads.Items.Add(item);
                                }
                            });
                        }
                        else
                        {
                            // update changed threads

                            foreach (Scraper.RunnerThread s in Scraper.RunningScrapers)
                            {
                                listThreads.Invoke((MethodInvoker)delegate
                                {
                                    var item = listThreads.Items[s.ID];
                                    if (item != null)
                                    {
                                        if (item.SubItems[1].Text != (s.Proxy == null ? "Proxyless" : s.Proxy.Address.ToString())) item.SubItems[1].Text = s.Proxy == null ? "Proxyless" : s.Proxy.Address.ToString();
                                        if (item.SubItems[2].Text != s.Status) item.SubItems[2].Text = s.Status;
                                        if (item.SubItems[3].Text != s.Dork) item.SubItems[3].Text = s.Dork;
                                    }
                                });
                            }
                        }
                    }
                    else
                    {
                        listThreads.Invoke((MethodInvoker)delegate
                        {
                            if (listThreads.Items.Count > 0)
                                listThreads.Items.Clear();
                        });
                    }

                    Thread.Sleep(100);
                }
                catch { Thread.Sleep(1000); }
            }
        }

        private void cbProxyless_CheckedChanged(object sender, EventArgs e) => btnLoadProxies.Enabled = !cbProxyless.Checked;
        private void txtHits_LinkClicked(object sender, LinkClickedEventArgs e) => Process.Start(e.LinkText);

        private void btnLoadDorks_Click(object sender, EventArgs e)
        {
            // open file dialog
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files|*.txt";
            ofd.Title = "Select a dork file";
            ofd.InitialDirectory = Environment.CurrentDirectory + @"\Dorks";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] dorks = File.ReadAllLines(ofd.FileName);
                Dorks = dorks;

                btnLoadDorks.Text = $"Load Dorks [{Dorks.Length}]";
            }
        }

        private void btnLoadMatches_Click(object sender, EventArgs e)
        {
            // open file dialog
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files|*.txt";
            ofd.Title = "Select a matches file";
            ofd.InitialDirectory = Environment.CurrentDirectory + @"\Matches";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] matches = File.ReadAllLines(ofd.FileName);
                Matches = matches;
                btnLoadMatches.Text = $"Load Matches [{Matches.Length}]";
            }
        }

        private void btnLoadProxies_Click(object sender, EventArgs e)
        {
            // open file dialog
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files|*.txt";
            ofd.Title = "Select a proxies file";
            ofd.InitialDirectory = Environment.CurrentDirectory + @"\Proxies";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] proxies = File.ReadAllLines(ofd.FileName);
                Proxies = new WebProxy[proxies.Length];
                for (int i = 0; i < proxies.Length; i++)
                {
                    try
                    {
                        string ip = proxies[i].Split(':')[0];
                        int port = int.Parse(proxies[i].Split(':')[1]);
                        // get username and password if they exist
                        string username = "";
                        string password = "";
                        if (proxies[i].Split(':').Length > 2)
                        {
                            username = proxies[i].Split(':')[2];
                            password = proxies[i].Split(':')[3];
                        }

                        Proxies[i] = new WebProxy(ip, port);
                    }
                    catch { }
                }

                btnLoadProxies.Text = $"Load Proxies [{Proxies.Length}]";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!Running)
            {
                if (Dorks.Length != 0 && Matches.Length != 0)
                {
                    Time = DateTime.Now.ToString("dd-MM-yyyy HH;mm");
                    Running = true;
                    LockElements(false);
                    btnStart.Text = "Stop";
                    Hits = 0;
                    Bad = 0;
                    Retries = 0;
                    txtHits.Clear();
                    Scraper.ScrapeHits.Clear();
                    Scraper.Start(
                        Convert.ToInt32(numThreads.Value),
                        cbProxyless.Checked,
                        cbRegexMatches.Checked,
                        cbAllowDuplicates.Checked,
                        cbLogFullURL.Checked,
                        Convert.ToInt32(numMinMatch.Value),
                        txtTarget.Text,
                        cbRecursiveSearch.Checked,
                        Convert.ToInt32(numRecursiveLimit.Value),
                        Convert.ToInt32(numUrlLimit.Value)
                   );
                }
                else
                    MessageBox.Show("Dorks or Matches are empty!");
            }
            else
            {
                Thread a = new Thread(() =>
                {
                    foreach (Scraper.RunnerThread r in Scraper.RunningScrapers)
                    {
                        r.Thread.Interrupt();
                        r.Thread.Abort();
                    }
                    Scraper.RunningScrapers.Clear();
                });
                new Thread(() =>
                {
                    a.Start();
                    this.Invoke((MethodInvoker)delegate { btnStart.Text = "Stopping threads..."; });
                    a.Join();
                    Running = false;
                    this.Invoke((MethodInvoker)delegate { LockElements(true); });
                    this.Invoke((MethodInvoker)delegate { btnStart.Text = "Start"; });
                }).Start();
            }
        }

        private void GUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }
    }
}