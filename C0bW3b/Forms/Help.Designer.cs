namespace C0bW3b.Forms
{
    partial class Help
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.lblTitle = new System.Windows.Forms.Label();
            this.gpContributors = new System.Windows.Forms.GroupBox();
            this.pnlContributors = new System.Windows.Forms.Panel();
            this.gpContributors.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Yu Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(973, 50);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "C0bW3b";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gpContributors
            // 
            this.gpContributors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gpContributors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.gpContributors.Controls.Add(this.pnlContributors);
            this.gpContributors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpContributors.ForeColor = System.Drawing.Color.White;
            this.gpContributors.Location = new System.Drawing.Point(12, 53);
            this.gpContributors.Name = "gpContributors";
            this.gpContributors.Size = new System.Drawing.Size(481, 474);
            this.gpContributors.TabIndex = 29;
            this.gpContributors.TabStop = false;
            this.gpContributors.Text = "Contributors";
            // 
            // pnlContributors
            // 
            this.pnlContributors.AutoScroll = true;
            this.pnlContributors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContributors.Location = new System.Drawing.Point(3, 16);
            this.pnlContributors.Name = "pnlContributors";
            this.pnlContributors.Size = new System.Drawing.Size(475, 455);
            this.pnlContributors.TabIndex = 0;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(973, 539);
            this.Controls.Add(this.gpContributors);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(613, 482);
            this.Name = "Help";
            this.Text = "C0bW3b";
            this.Load += new System.EventHandler(this.Help_Load);
            this.gpContributors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gpContributors;
        private System.Windows.Forms.Panel pnlContributors;
    }
}

