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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.txtHits = new System.Windows.Forms.RichTextBox();
            this.btnLoadDorks = new System.Windows.Forms.Button();
            this.btnLoadProxies = new System.Windows.Forms.Button();
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
            this.numMinMatch = new System.Windows.Forms.NumericUpDown();
            this.lblMinMatch = new System.Windows.Forms.Label();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.lblTarget = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHits
            // 
            this.txtHits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.txtHits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHits.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtHits.ForeColor = System.Drawing.Color.White;
            this.txtHits.Location = new System.Drawing.Point(132, 0);
            this.txtHits.Name = "txtHits";
            this.txtHits.ReadOnly = true;
            this.txtHits.Size = new System.Drawing.Size(402, 370);
            this.txtHits.TabIndex = 0;
            this.txtHits.Text = "";
            this.txtHits.WordWrap = false;
            this.txtHits.ZoomFactor = 2F;
            // 
            // btnLoadDorks
            // 
            this.btnLoadDorks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLoadDorks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnLoadDorks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadDorks.ForeColor = System.Drawing.Color.White;
            this.btnLoadDorks.Location = new System.Drawing.Point(12, 38);
            this.btnLoadDorks.Name = "btnLoadDorks";
            this.btnLoadDorks.Size = new System.Drawing.Size(114, 23);
            this.btnLoadDorks.TabIndex = 1;
            this.btnLoadDorks.Text = "Load Dorks";
            this.btnLoadDorks.UseVisualStyleBackColor = false;
            this.btnLoadDorks.Click += new System.EventHandler(this.btnLoadDorks_Click);
            // 
            // btnLoadProxies
            // 
            this.btnLoadProxies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLoadProxies.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnLoadProxies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadProxies.ForeColor = System.Drawing.Color.White;
            this.btnLoadProxies.Location = new System.Drawing.Point(12, 119);
            this.btnLoadProxies.Name = "btnLoadProxies";
            this.btnLoadProxies.Size = new System.Drawing.Size(114, 23);
            this.btnLoadProxies.TabIndex = 2;
            this.btnLoadProxies.Text = "Load Proxies";
            this.btnLoadProxies.UseVisualStyleBackColor = false;
            this.btnLoadProxies.Click += new System.EventHandler(this.btnLoadProxies_Click);
            // 
            // cbRegexMatches
            // 
            this.cbRegexMatches.AutoSize = true;
            this.cbRegexMatches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cbRegexMatches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRegexMatches.ForeColor = System.Drawing.Color.White;
            this.cbRegexMatches.Location = new System.Drawing.Point(12, 96);
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
            this.lblRetries.Location = new System.Drawing.Point(11, 312);
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
            this.lblBad.Location = new System.Drawing.Point(11, 296);
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
            this.lblHits.Location = new System.Drawing.Point(11, 279);
            this.lblHits.Name = "lblHits";
            this.lblHits.Size = new System.Drawing.Size(37, 13);
            this.lblHits.TabIndex = 8;
            this.lblHits.Text = "Hits: 0";
            // 
            // btnLoadMatches
            // 
            this.btnLoadMatches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLoadMatches.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnLoadMatches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadMatches.ForeColor = System.Drawing.Color.White;
            this.btnLoadMatches.Location = new System.Drawing.Point(12, 67);
            this.btnLoadMatches.Name = "btnLoadMatches";
            this.btnLoadMatches.Size = new System.Drawing.Size(114, 23);
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
            this.lblThreads.Location = new System.Drawing.Point(9, 174);
            this.lblThreads.Name = "lblThreads";
            this.lblThreads.Size = new System.Drawing.Size(49, 13);
            this.lblThreads.TabIndex = 6;
            this.lblThreads.Text = "Threads:";
            // 
            // numThreads
            // 
            this.numThreads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numThreads.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numThreads.ForeColor = System.Drawing.Color.White;
            this.numThreads.Location = new System.Drawing.Point(59, 171);
            this.numThreads.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numThreads.Name = "numThreads";
            this.numThreads.Size = new System.Drawing.Size(67, 20);
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
            this.cbProxyless.Location = new System.Drawing.Point(12, 148);
            this.cbProxyless.Name = "cbProxyless";
            this.cbProxyless.Size = new System.Drawing.Size(67, 17);
            this.cbProxyless.TabIndex = 4;
            this.cbProxyless.Text = "Proxyless";
            this.cbProxyless.UseVisualStyleBackColor = false;
            this.cbProxyless.CheckedChanged += new System.EventHandler(this.cbProxyless_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(12, 335);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(114, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbAllowDuplicates
            // 
            this.cbAllowDuplicates.AutoSize = true;
            this.cbAllowDuplicates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cbAllowDuplicates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAllowDuplicates.ForeColor = System.Drawing.Color.White;
            this.cbAllowDuplicates.Location = new System.Drawing.Point(12, 197);
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
            this.cbLogFullURL.Location = new System.Drawing.Point(12, 220);
            this.cbLogFullURL.Name = "cbLogFullURL";
            this.cbLogFullURL.Size = new System.Drawing.Size(85, 17);
            this.cbLogFullURL.TabIndex = 13;
            this.cbLogFullURL.Text = "Log Full URL";
            this.cbLogFullURL.UseVisualStyleBackColor = false;
            // 
            // numMinMatch
            // 
            this.numMinMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numMinMatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numMinMatch.ForeColor = System.Drawing.Color.White;
            this.numMinMatch.Location = new System.Drawing.Point(81, 243);
            this.numMinMatch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinMatch.Name = "numMinMatch";
            this.numMinMatch.Size = new System.Drawing.Size(45, 20);
            this.numMinMatch.TabIndex = 14;
            this.numMinMatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMinMatch.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMinMatch
            // 
            this.lblMinMatch.AutoSize = true;
            this.lblMinMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblMinMatch.ForeColor = System.Drawing.Color.White;
            this.lblMinMatch.Location = new System.Drawing.Point(9, 246);
            this.lblMinMatch.Name = "lblMinMatch";
            this.lblMinMatch.Size = new System.Drawing.Size(71, 13);
            this.lblMinMatch.TabIndex = 15;
            this.lblMinMatch.Text = "Min Matches:";
            // 
            // txtTarget
            // 
            this.txtTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTarget.ForeColor = System.Drawing.Color.White;
            this.txtTarget.Location = new System.Drawing.Point(50, 12);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(76, 20);
            this.txtTarget.TabIndex = 16;
            this.txtTarget.Text = "%ITEM%";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblTarget.ForeColor = System.Drawing.Color.White;
            this.lblTarget.Location = new System.Drawing.Point(9, 15);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(41, 13);
            this.lblTarget.TabIndex = 17;
            this.lblTarget.Text = "Target:";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(534, 370);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.numMinMatch);
            this.Controls.Add(this.lblMinMatch);
            this.Controls.Add(this.txtHits);
            this.Controls.Add(this.cbLogFullURL);
            this.Controls.Add(this.cbAllowDuplicates);
            this.Controls.Add(this.btnLoadDorks);
            this.Controls.Add(this.cbRegexMatches);
            this.Controls.Add(this.btnLoadProxies);
            this.Controls.Add(this.lblRetries);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblBad);
            this.Controls.Add(this.cbProxyless);
            this.Controls.Add(this.lblHits);
            this.Controls.Add(this.numThreads);
            this.Controls.Add(this.btnLoadMatches);
            this.Controls.Add(this.lblThreads);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(550, 370);
            this.Name = "GUI";
            this.Text = "C0bW3b";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUI_FormClosing);
            this.Load += new System.EventHandler(this.GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinMatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtHits;
        private System.Windows.Forms.Button btnLoadDorks;
        private System.Windows.Forms.Button btnLoadProxies;
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
        private System.Windows.Forms.NumericUpDown numMinMatch;
        private System.Windows.Forms.Label lblMinMatch;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Label lblTarget;
    }
}

