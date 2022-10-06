using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;
using System.Xml.Linq;

namespace C0bW3b.Forms
{
    public partial class Engines : Form
    {
        public static Engines instance;

        public Engines()
        {
            InitializeComponent();
            instance = this;

            if (ConfigSystem.config.SearchEngines.Count == 0)
            {
                // add default engines
                ConfigSystem.config.SearchEngines.Add(new SearchEngine("https://google.com/search?q=%DORK%", "id=\"rso\">", "<div id=\"bottomads\">", "<a href=\"(.*?)\">"));
                ConfigSystem.config.SearchEngines.Add(new SearchEngine("https://bing.com/search?q=%DORK%", "<ol id=\"b_results\" class=\"\">", "<aside aria-label=\"Additional Results\">", "<a href=\"(.*?)\">"));
            }

            UpdateEngines();
            try { cbSearchEngines.SelectedIndex = 0; } catch { }
        }

        private void UpdateEngines()
        {
            cbSearchEngines.Items.Clear();
            // add engines to cbSearchEngines
            foreach (SearchEngine engine in ConfigSystem.config.SearchEngines)
            {
                try
                {
                    // get root url from engine url
                    string name = engine.SearchURL;
                    try { Uri uri = new Uri(engine.SearchURL); name = uri.Host; } catch { }
                    cbSearchEngines.Items.Add(name);
                }
                catch { }
            }
            ConfigSystem.SaveConfig();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ConfigSystem.config.SearchEngines.Add(new SearchEngine("SEARCH URL HERE (use %DORK% to determine where to input the dork)", "LEFT STRING SECTION", "RIGHT STRING SECTION", "REGEX TO EXTRACT URL's"));
            UpdateEngines();
            try { cbSearchEngines.SelectedIndex = cbSearchEngines.Items.Count - 1; } catch { }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this engine?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int index = cbSearchEngines.SelectedIndex;
                    ConfigSystem.config.SearchEngines.RemoveAt(cbSearchEngines.SelectedIndex);
                    UpdateEngines();
                    try { cbSearchEngines.SelectedIndex = index - 1; } catch { cbSearchEngines.SelectedIndex = 0; }
                }
                catch { }
            }
        }

        private void cbSearchEngines_SelectedIndexChanged(object sender, EventArgs e)
        {
            // reset all textboxes
            txtSearchURL.Text = "";
            txtLString.Text = "";
            txtRString.Text = "";
            txtURLRegex.Text = "";
            numTimeout.Value = 5000;


            // load data into groupbox
            try
            {
                SearchEngine engine = ConfigSystem.config.SearchEngines[cbSearchEngines.SelectedIndex];
                txtSearchURL.Text = engine.SearchURL;
                txtLString.Text = engine.LString;
                txtRString.Text = engine.RString;
                txtURLRegex.Text = engine.URLRegex;
                numTimeout.Value = engine.Timeout;
            }
            catch { cbSearchEngines.SelectedIndex = 0; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // save the new engine
            ConfigSystem.config.SearchEngines[cbSearchEngines.SelectedIndex].SearchURL = txtSearchURL.Text;
            ConfigSystem.config.SearchEngines[cbSearchEngines.SelectedIndex].LString = txtLString.Text;
            ConfigSystem.config.SearchEngines[cbSearchEngines.SelectedIndex].RString = txtRString.Text;
            ConfigSystem.config.SearchEngines[cbSearchEngines.SelectedIndex].URLRegex = txtURLRegex.Text;
            ConfigSystem.config.SearchEngines[cbSearchEngines.SelectedIndex].Timeout = Convert.ToInt32(numTimeout.Value);

            ConfigSystem.SaveConfig();
            MessageBox.Show($"Successfully saved {cbSearchEngines.SelectedItem}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public partial class SearchEngine
    {
        public SearchEngine(string searchurl, string lstring, string rstring, string urlregex, int timeout = 5000)
        {
            SearchURL = searchurl;
            LString = lstring;
            RString = rstring;
            URLRegex = urlregex;
            Timeout = timeout;
        }

        public string SearchURL { get; set; }
        public string LString { get; set; }
        public string RString { get; set; }
        public string URLRegex { get; set; }
        public int Timeout { get; set; }
    }
}