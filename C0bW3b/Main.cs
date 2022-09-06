using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace C0bW3b
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region Window Drag
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void pnlBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        #region Bar
        private void Main_Load(object sender, EventArgs e)
        {
            string CurrentVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
            var response = new WebClient().DownloadString("https://raw.githubusercontent.com/Zebratic/C0bW3b/main/C0bW3b/Properties/AssemblyInfo.cs");
            List<string> AssemblyInfo = new List<string>(response.Split('\n'));
            var LatestVersion = AssemblyInfo[AssemblyInfo.FindIndex(str => str.Contains("[assembly: AssemblyFileVersion"))].Split('"')[1];
            lblTitle.Text = $"C0bW3b [{CurrentVersion}]";
            if (CurrentVersion != LatestVersion)
                if (MessageBox.Show("It seems like you are using a outdated version, would you like to update?", "C0bW3b", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    Process.Start("https://github.com/Zebratic/C0bW3b/");
        }
        private void btnClose_Click(object sender, EventArgs e) => Environment.Exit(0);
        private void btnMaximize_Click(object sender, EventArgs e) => this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        private void btnMinimize_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;
        #endregion

        #region Override Form Params
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= 0x20000; // Drop Shadow
                cp.ClassStyle |= 0x00020000; // Double Buffer
                return cp;
            }
        }
        #endregion
    }
}