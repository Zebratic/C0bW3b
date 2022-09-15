using C0bW3b.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace C0bW3b
{
    public partial class Main : Form
    {
        public Page CurrentPage = Page.Runner;
        public Runner runner = new Runner();
        public Settings settings = new Settings();
        public static Main instance;

        public Main()
        {
            InitializeComponent();
            HighlightButton();

            instance = this;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            InitializeForms();
        }

        #region Form Initializer
        public void InitializeForms()
        {
            runner.TopLevel = false;
            runner.AutoScroll = true;
            runner.Dock = DockStyle.Fill;
            pnlPageViewer.Controls.Add(runner);

            settings.TopLevel = false;
            settings.AutoScroll = true;
            settings.Dock = DockStyle.Fill;
            pnlPageViewer.Controls.Add(settings);
        }
        #endregion

        #region Window Drag & Resize
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

        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
            pnlFooter.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlFooter.Width, pnlFooter.Height * 2, 20, 20));
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
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

        #region Rounding
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
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

        #region Menu Buttons
        private void btnRunner_Click(object sender, EventArgs e) { CurrentPage = Page.Runner; HighlightButton(); }
        private void btnSettings_Click(object sender, EventArgs e) { CurrentPage = Page.Settings; HighlightButton(); }

        public void HighlightButton()
        {
            btnRunner.ForeColor = CurrentPage == Page.Runner ? Color.FromArgb(0, 150, 255) : Color.FromArgb(255, 255, 255);
            btnSettings.ForeColor = CurrentPage == Page.Settings ? Color.FromArgb(0, 150, 255) : Color.FromArgb(255, 255, 255);

            UpdatePage();
        }
        #endregion

        #region Page Manager
        public void UpdatePage()
        {
            switch (CurrentPage)
            {
                case Page.Runner:
                    this.MinimumSize = new Size(runner.MinimumSize.Width + (12 * 2), runner.MinimumSize.Height + 87 + 29);
                    runner.Show();
                    settings.Hide();
                    break;

                case Page.Settings:
                    this.MinimumSize = new Size(settings.MinimumSize.Width + (12 * 2), settings.MinimumSize.Height + 87 + 29);
                    runner.Hide();
                    settings.Show();
                    break;
            }
        }
        #endregion
    }

    public enum Page
    {
        Runner,
        Settings
    }
}