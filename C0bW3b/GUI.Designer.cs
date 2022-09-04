namespace C0bW3b
{
    partial class GUI
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
            this.txtHits = new System.Windows.Forms.RichTextBox();
            this.btnLoadDorks = new System.Windows.Forms.Button();
            this.btnLoadProxies = new System.Windows.Forms.Button();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.cbRegexMatches = new System.Windows.Forms.CheckBox();
            this.lblRetries = new System.Windows.Forms.Label();
            this.lblBad = new System.Windows.Forms.Label();
            this.lblHits = new System.Windows.Forms.Label();
            this.btnLoadMatches = new System.Windows.Forms.Button();
            this.lblThreads = new System.Windows.Forms.Label();
            this.numThreads = new System.Windows.Forms.NumericUpDown();
            this.cbProxyless = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbAllowDuplicates = new System.Windows.Forms.CheckBox();
            this.cbLogFullURL = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHits
            // 
            this.txtHits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txtHits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHits.ForeColor = System.Drawing.Color.White;
            this.txtHits.Location = new System.Drawing.Point(0, 0);
            this.txtHits.Name = "txtHits";
            this.txtHits.ReadOnly = true;
            this.txtHits.Size = new System.Drawing.Size(483, 311);
            this.txtHits.TabIndex = 0;
            this.txtHits.Text = "";
            this.txtHits.WordWrap = false;
            this.txtHits.ZoomFactor = 2F;
            // 
            // btnLoadDorks
            // 
            this.btnLoadDorks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadDorks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLoadDorks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnLoadDorks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadDorks.ForeColor = System.Drawing.Color.White;
            this.btnLoadDorks.Location = new System.Drawing.Point(12, 12);
            this.btnLoadDorks.Name = "btnLoadDorks";
            this.btnLoadDorks.Size = new System.Drawing.Size(133, 23);
            this.btnLoadDorks.TabIndex = 1;
            this.btnLoadDorks.Text = "Load Dorks";
            this.btnLoadDorks.UseVisualStyleBackColor = false;
            this.btnLoadDorks.Click += new System.EventHandler(this.btnLoadDorks_Click);
            // 
            // btnLoadProxies
            // 
            this.btnLoadProxies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadProxies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLoadProxies.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnLoadProxies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadProxies.ForeColor = System.Drawing.Color.White;
            this.btnLoadProxies.Location = new System.Drawing.Point(12, 93);
            this.btnLoadProxies.Name = "btnLoadProxies";
            this.btnLoadProxies.Size = new System.Drawing.Size(133, 23);
            this.btnLoadProxies.TabIndex = 2;
            this.btnLoadProxies.Text = "Load Proxies";
            this.btnLoadProxies.UseVisualStyleBackColor = false;
            this.btnLoadProxies.Click += new System.EventHandler(this.btnLoadProxies_Click);
            // 
            // SplitContainer
            // 
            this.SplitContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.SplitContainer.Panel1.Controls.Add(this.cbLogFullURL);
            this.SplitContainer.Panel1.Controls.Add(this.cbAllowDuplicates);
            this.SplitContainer.Panel1.Controls.Add(this.cbRegexMatches);
            this.SplitContainer.Panel1.Controls.Add(this.lblRetries);
            this.SplitContainer.Panel1.Controls.Add(this.lblBad);
            this.SplitContainer.Panel1.Controls.Add(this.lblHits);
            this.SplitContainer.Panel1.Controls.Add(this.btnLoadMatches);
            this.SplitContainer.Panel1.Controls.Add(this.lblThreads);
            this.SplitContainer.Panel1.Controls.Add(this.numThreads);
            this.SplitContainer.Panel1.Controls.Add(this.cbProxyless);
            this.SplitContainer.Panel1.Controls.Add(this.btnStart);
            this.SplitContainer.Panel1.Controls.Add(this.btnLoadDorks);
            this.SplitContainer.Panel1.Controls.Add(this.btnLoadProxies);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.txtHits);
            this.SplitContainer.Size = new System.Drawing.Size(644, 311);
            this.SplitContainer.SplitterDistance = 157;
            this.SplitContainer.TabIndex = 3;
            // 
            // cbRegexMatches
            // 
            this.cbRegexMatches.AutoSize = true;
            this.cbRegexMatches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cbRegexMatches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRegexMatches.ForeColor = System.Drawing.Color.White;
            this.cbRegexMatches.Location = new System.Drawing.Point(11, 70);
            this.cbRegexMatches.Name = "cbRegexMatches";
            this.cbRegexMatches.Size = new System.Drawing.Size(103, 17);
            this.cbRegexMatches.TabIndex = 11;
            this.cbRegexMatches.Text = "Matches is regex";
            this.cbRegexMatches.UseVisualStyleBackColor = false;
            // 
            // lblRetries
            // 
            this.lblRetries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRetries.AutoSize = true;
            this.lblRetries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblRetries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblRetries.Location = new System.Drawing.Point(11, 253);
            this.lblRetries.Name = "lblRetries";
            this.lblRetries.Size = new System.Drawing.Size(52, 13);
            this.lblRetries.TabIndex = 10;
            this.lblRetries.Text = "Retries: 0";
            // 
            // lblBad
            // 
            this.lblBad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBad.AutoSize = true;
            this.lblBad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblBad.ForeColor = System.Drawing.Color.Red;
            this.lblBad.Location = new System.Drawing.Point(11, 237);
            this.lblBad.Name = "lblBad";
            this.lblBad.Size = new System.Drawing.Size(38, 13);
            this.lblBad.TabIndex = 9;
            this.lblBad.Text = "Bad: 0";
            // 
            // lblHits
            // 
            this.lblHits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHits.AutoSize = true;
            this.lblHits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblHits.ForeColor = System.Drawing.Color.Lime;
            this.lblHits.Location = new System.Drawing.Point(11, 220);
            this.lblHits.Name = "lblHits";
            this.lblHits.Size = new System.Drawing.Size(37, 13);
            this.lblHits.TabIndex = 8;
            this.lblHits.Text = "Hits: 0";
            // 
            // btnLoadMatches
            // 
            this.btnLoadMatches.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadMatches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLoadMatches.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnLoadMatches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadMatches.ForeColor = System.Drawing.Color.White;
            this.btnLoadMatches.Location = new System.Drawing.Point(12, 41);
            this.btnLoadMatches.Name = "btnLoadMatches";
            this.btnLoadMatches.Size = new System.Drawing.Size(133, 23);
            this.btnLoadMatches.TabIndex = 7;
            this.btnLoadMatches.Text = "Load Matches";
            this.btnLoadMatches.UseVisualStyleBackColor = false;
            this.btnLoadMatches.Click += new System.EventHandler(this.btnLoadMatches_Click);
            // 
            // lblThreads
            // 
            this.lblThreads.AutoSize = true;
            this.lblThreads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblThreads.ForeColor = System.Drawing.Color.White;
            this.lblThreads.Location = new System.Drawing.Point(9, 148);
            this.lblThreads.Name = "lblThreads";
            this.lblThreads.Size = new System.Drawing.Size(49, 13);
            this.lblThreads.TabIndex = 6;
            this.lblThreads.Text = "Threads:";
            // 
            // numThreads
            // 
            this.numThreads.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numThreads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numThreads.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numThreads.ForeColor = System.Drawing.Color.White;
            this.numThreads.Location = new System.Drawing.Point(59, 145);
            this.numThreads.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numThreads.Name = "numThreads";
            this.numThreads.Size = new System.Drawing.Size(86, 20);
            this.numThreads.TabIndex = 5;
            this.numThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbProxyless
            // 
            this.cbProxyless.AutoSize = true;
            this.cbProxyless.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cbProxyless.Checked = true;
            this.cbProxyless.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbProxyless.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProxyless.ForeColor = System.Drawing.Color.White;
            this.cbProxyless.Location = new System.Drawing.Point(11, 122);
            this.cbProxyless.Name = "cbProxyless";
            this.cbProxyless.Size = new System.Drawing.Size(67, 17);
            this.cbProxyless.TabIndex = 4;
            this.cbProxyless.Text = "Proxyless";
            this.cbProxyless.UseVisualStyleBackColor = false;
            this.cbProxyless.CheckedChanged += new System.EventHandler(this.cbProxyless_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(12, 276);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(133, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbAllowDuplicates
            // 
            this.cbAllowDuplicates.AutoSize = true;
            this.cbAllowDuplicates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cbAllowDuplicates.Checked = true;
            this.cbAllowDuplicates.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAllowDuplicates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAllowDuplicates.ForeColor = System.Drawing.Color.White;
            this.cbAllowDuplicates.Location = new System.Drawing.Point(11, 171);
            this.cbAllowDuplicates.Name = "cbAllowDuplicates";
            this.cbAllowDuplicates.Size = new System.Drawing.Size(101, 17);
            this.cbAllowDuplicates.TabIndex = 12;
            this.cbAllowDuplicates.Text = "Allow Duplicates";
            this.cbAllowDuplicates.UseVisualStyleBackColor = false;
            // 
            // cbLogFullURL
            // 
            this.cbLogFullURL.AutoSize = true;
            this.cbLogFullURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cbLogFullURL.Checked = true;
            this.cbLogFullURL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLogFullURL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLogFullURL.ForeColor = System.Drawing.Color.White;
            this.cbLogFullURL.Location = new System.Drawing.Point(11, 194);
            this.cbLogFullURL.Name = "cbLogFullURL";
            this.cbLogFullURL.Size = new System.Drawing.Size(85, 17);
            this.cbLogFullURL.TabIndex = 13;
            this.cbLogFullURL.Text = "Log Full URL";
            this.cbLogFullURL.UseVisualStyleBackColor = false;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 311);
            this.Controls.Add(this.SplitContainer);
            this.MinimumSize = new System.Drawing.Size(660, 350);
            this.Name = "GUI";
            this.Text = "C0bW3b";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUI_FormClosing);
            this.Load += new System.EventHandler(this.GUI_Load);
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel1.PerformLayout();
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numThreads)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtHits;
        private System.Windows.Forms.Button btnLoadDorks;
        private System.Windows.Forms.Button btnLoadProxies;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox cbProxyless;
        private System.Windows.Forms.Label lblThreads;
        private System.Windows.Forms.NumericUpDown numThreads;
        private System.Windows.Forms.Button btnLoadMatches;
        private System.Windows.Forms.Label lblRetries;
        private System.Windows.Forms.Label lblBad;
        private System.Windows.Forms.Label lblHits;
        private System.Windows.Forms.CheckBox cbRegexMatches;
        private System.Windows.Forms.CheckBox cbAllowDuplicates;
        private System.Windows.Forms.CheckBox cbLogFullURL;
    }
}

