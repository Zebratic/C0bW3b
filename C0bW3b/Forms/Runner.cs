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

            if (!Directory.Exists(Environment.CurrentDirectory + @"\Dorks"))
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\Dorks");
            if (!Directory.Exists(Environment.CurrentDirectory + @"\Matches"))
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\Matches");
            if (!Directory.Exists(Environment.CurrentDirectory + @"\Proxies"))
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\Proxies");
            if (!Directory.Exists(Environment.CurrentDirectory + @"\Hits"))
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\Hits");
        }

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
        }


        public void AddScrapeHit(Scraper.ScrapeHit scrapeHit)
        {
            // print data to log
            string log = $"URL: https://{scrapeHit.Url.Replace("www.", "")} | Matches: {scrapeHit.Matches.Count} | Dork: {scrapeHit.Dork}\n";
            txtHits.Invoke((MethodInvoker)delegate { txtHits.AppendText(log); });

            // get time file
            try { File.AppendAllText(Environment.CurrentDirectory + $@"\Hits\{Time}.txt", log); } catch { }
        }

        public void UpdateStats()
        {
            while (true)
            {
                lblHits.Invoke((MethodInvoker)delegate { lblHits.Text = "Hits: " + Hits; });
                lblBad.Invoke((MethodInvoker)delegate { lblBad.Text = "Bad: " + Bad; });
                lblRetries.Invoke((MethodInvoker)delegate { lblRetries.Text = "Retries: " + Retries; });

                // update listThreads with current running threads
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

                Thread.Sleep(100);
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
                    Scraper.Start(Convert.ToInt32(numThreads.Value), cbProxyless.Checked, cbRegexMatches.Checked, cbAllowDuplicates.Checked, cbLogFullURL.Checked, Convert.ToInt32(numMinMatch.Value), txtTarget.Text);
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
                a.Start();
                btnStart.Text = "Stopping threads...";
                a.Join();
                Running = false;
                LockElements(true);
                btnStart.Text = "Start";
            }
        }

        private void GUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            new Thread(UpdateStats).Start();
        }
    }
}