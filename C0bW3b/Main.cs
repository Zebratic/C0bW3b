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
        public Hits hits = new Hits();
        public Settings settings = new Settings();
        public Plugins plugins = new Plugins();
        public Engines engines = new Engines();
        public static Main instance;

        public Size OldSize;
        public bool IsSnapped = false;

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

            hits.TopLevel = false;
            hits.AutoScroll = true;
            hits.Dock = DockStyle.Fill;
            pnlPageViewer.Controls.Add(hits);

            settings.TopLevel = false;
            settings.AutoScroll = true;
            settings.Dock = DockStyle.Fill;
            pnlPageViewer.Controls.Add(settings);

            plugins.TopLevel = false;
            plugins.AutoScroll = true;
            plugins.Dock = DockStyle.Fill;
            pnlPageViewer.Controls.Add(plugins);

            engines.TopLevel = false;
            engines.AutoScroll = true;
            engines.Dock = DockStyle.Fill;
            pnlPageViewer.Controls.Add(engines);
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
                if (IsSnapped) // unsnap
                {
                    this.WindowState = FormWindowState.Normal;
                    this.Size = OldSize;
                    IsSnapped = false;
                }

                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

                // if window is is above screens height, then snap to screen
                foreach (Screen s in Screen.AllScreens)
                {
                    // if window is above screen height, then snap to screen
                    Point mousePos = Cursor.Position;
                    if (mousePos.Y == 0) // top of screen
                    {
                        this.WindowState = FormWindowState.Maximized;
                    }
                    else if (mousePos.X == s.Bounds.X) // left side of screen
                    {
                        IsSnapped = true;
                        OldSize = this.Size;
                        this.Height = s.Bounds.Height;
                        this.Width = s.Bounds.Width / 2;
                        this.Location = new Point(0, 0);
                    }
                    else if (mousePos.X == s.Bounds.Width - 1) // right side of screen
                    {
                        IsSnapped = true;
                        OldSize = this.Size;
                        this.Height = s.Bounds.Height;
                        this.Width = s.Bounds.Width / 2;
                        this.Location = new Point(s.Bounds.Width / 2, 0);
                    }
                }
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
        private void btnHits_Click(object sender, EventArgs e) { CurrentPage = Page.Hits; HighlightButton(); }
        private void btnSettings_Click(object sender, EventArgs e) { CurrentPage = Page.Settings; HighlightButton(); }
        private void btnPlugins_Click(object sender, EventArgs e) { CurrentPage = Page.Plugins; HighlightButton(); }
        private void btnEngines_Click(object sender, EventArgs e) { CurrentPage = Page.Engines; HighlightButton(); }

        public void HighlightButton()
        {
            btnRunner.ForeColor = CurrentPage == Page.Runner ? Color.FromArgb(0, 150, 255) : Color.FromArgb(255, 255, 255);
            btnHits.ForeColor = CurrentPage == Page.Hits ? Color.FromArgb(0, 150, 255) : Color.FromArgb(255, 255, 255);
            btnSettings.ForeColor = CurrentPage == Page.Settings ? Color.FromArgb(0, 150, 255) : Color.FromArgb(255, 255, 255);
            btnPlugins.ForeColor = CurrentPage == Page.Plugins ? Color.FromArgb(0, 150, 255) : Color.FromArgb(255, 255, 255);
            btnEngines.ForeColor = CurrentPage == Page.Engines ? Color.FromArgb(0, 150, 255) : Color.FromArgb(255, 255, 255);

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
                    hits.Hide();
                    settings.Hide();
                    plugins.Hide();
                    engines.Hide();
                    break;

                case Page.Hits:
                    this.MinimumSize = new Size(hits.MinimumSize.Width + (12 * 2), hits.MinimumSize.Height + 87 + 29);
                    runner.Hide();
                    hits.Show();
                    settings.Hide();
                    plugins.Hide();
                    engines.Hide();
                    break;

                case Page.Settings:
                    this.MinimumSize = new Size(settings.MinimumSize.Width + (12 * 2), settings.MinimumSize.Height + 87 + 29);
                    runner.Hide();
                    hits.Hide();
                    settings.Show();
                    plugins.Hide();
                    engines.Hide();
                    break;

                case Page.Plugins:
                    this.MinimumSize = new Size(plugins.MinimumSize.Width + (12 * 2), plugins.MinimumSize.Height + 87 + 29);
                    runner.Hide();
                    hits.Hide();
                    settings.Hide();
                    plugins.Show();
                    engines.Hide();
                    break;

                case Page.Engines:
                    this.MinimumSize = new Size(engines.MinimumSize.Width + (12 * 2), engines.MinimumSize.Height + 87 + 29);
                    runner.Hide();
                    hits.Hide();
                    settings.Hide();
                    plugins.Hide();
                    engines.Show();
                    break;
            }
        }
        #endregion
    }

    #region Pages
    public enum Page
    {
        Runner,
        Hits,
        Settings,
        Plugins,
        Engines
    }
    #endregion
}