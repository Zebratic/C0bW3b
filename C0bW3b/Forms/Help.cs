using C0bW3b.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace C0bW3b.Forms
{
    public partial class Help : Form
    {
        public static Help instance;

        public Help()
        {
            InitializeComponent();
            instance = this;
        }

        #region Disable Horizontal Scrollbar
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);

        private enum ScrollBarDirection
        {
            SB_HORZ = 0,
            SB_VERT = 1,
            SB_CTL = 2,
            SB_BOTH = 3
        }

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            ShowScrollBar(pnlContributors.Handle, (int)ScrollBarDirection.SB_HORZ, false);
            base.WndProc(ref m);
        }
        #endregion

        private void Contributor_Click(object sender, EventArgs e) => Process.Start("https://github.com/" + ((Label)sender).Text);
        private void Lbl_MouseLeave(object sender, EventArgs e) => ((Label)sender).ForeColor = Color.White;
        private void Lbl_MouseEnter(object sender, EventArgs e) => ((Label)sender).ForeColor = Color.FromArgb(87, 178, 255);

        private void Help_Load(object sender, System.EventArgs e)
        {
            List<Contributor> contributors = new List<Contributor>();

            using (WebClient wc = new WebClient())
            {
                wc.Headers.Add("User-Agent", "C0bW3b");
                string response = wc.DownloadString("https://api.github.com/repos/zebratic/c0bw3b/contributors");
                contributors = JsonConvert.DeserializeObject<List<Contributor>>(response);
            }

            int scale = 50;
            int margin = 10;
            int y = margin;

            foreach (Contributor contributor in contributors)
            {
                // add PictureBox to panel
                PictureBox img = new PictureBox();
                img.ImageLocation = contributor.AvatarUrl.ToString();
                img.SizeMode = PictureBoxSizeMode.Zoom;
                img.Size = new Size(scale, scale);
                img.Location = new Point(margin, y);
                img.Region = Region.FromHrgn(Rendering.CreateRoundRectRgn(0, 0, scale, scale, scale, scale));
                pnlContributors.Controls.Add(img);

                // add label to panel
                Label lbl = new Label();
                lbl.Text = contributor.Login;
                lbl.TextAlign = ContentAlignment.MiddleLeft;
                lbl.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
                lbl.Size = new Size(pnlContributors.Width - (margin * 2) - scale - margin, scale / 2);
                lbl.Location = new Point((scale + (margin * 2)), y);
                lbl.Cursor = Cursors.Hand;
                lbl.Click += Contributor_Click;
                lbl.MouseEnter += Lbl_MouseEnter;
                lbl.MouseLeave += Lbl_MouseLeave;
                pnlContributors.Controls.Add(lbl);

                // add label to panel
                Label lbl2 = new Label();
                lbl2.Text = contributor.Contributions.ToString() + " contributions";
                lbl2.TextAlign = ContentAlignment.MiddleLeft;
                lbl2.ForeColor = Color.DarkGray;
                lbl2.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                lbl2.Size = new Size(pnlContributors.Width - (margin * 2) - scale - margin, scale / 2);
                lbl2.Location = new Point((scale + (margin * 2)), y + (scale / 2));
                pnlContributors.Controls.Add(lbl2);

                y += img.Height + margin;
            }
        }
    }
}