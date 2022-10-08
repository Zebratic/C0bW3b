using C0bW3b.Forms;
using C0bW3b.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C0bW3b
{
    public class ConfigSystem
    {
        public static Config config = new Config();
        public static void SaveConfig()
        {
            try
            {
                string content = JsonConvert.SerializeObject(config, Formatting.Indented);
                File.WriteAllText("config.json", content);
            }
            catch (Exception ex) { MessageBox.Show(" FAILED TO SAVE CONFIG!!!\n" + ex.Message, "C0bW3b ~ Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        public static void LoadConfig()
        {
            try
            {
                if (!File.Exists("config.json"))
                {
                    // fix output format
                    config.OutputFormat = new Dictionary<string, bool>()
                    {
                        { "Url", true },
                        { "Dork", false },
                        { "Matches", false },
                        { "Match Count", true },
                        { "User Agent", false },
                        { "Proxy", false },
                        { "Engine", false }
                    };

                    SaveConfig();
                }

                string content = File.ReadAllText("config.json");
                config = JsonConvert.DeserializeObject<Config>(content);
            }
            catch (Exception ex) { MessageBox.Show(" FAILED TO LOAD CONFIG!!!\n" + ex.Message, "C0bW3b ~ Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
    }

    public class Config
    {
        // RUNNER TAB
        public int Threads = 100;
        public bool AllowDuplicates = false;
        public bool LogFullUrl = false;
        public int MinimumMatches = 1;
        public bool RecursiveSearch = true;
        public int RecursiveLimit = 2;
        public int UrlLimit = 100;

        // SETTINGS TAB
        // > GENERAL
        public bool UpdateThreadStatus = true;
        public bool AutoSave = true;
        public int AutoSaveInterval = 5;

        // > OUTPUT
        public Dictionary<string, bool> OutputFormat = new Dictionary<string, bool>();
        public string Seperator = "|";

        // > THEME
        public Theme CurrentTheme = new Theme();

        // ENGINES TAB
        public List<SearchEngine> SearchEngines = new List<SearchEngine>();
    }
}
