namespace C0bW3b.Forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Runner));
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numRecursiveLimit = new System.Windows.Forms.NumericUpDown();
            this.lblRecursiveLimit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinMatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRecursiveLimit)).BeginInit();
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
            this.txtHits.Location = new System.Drawing.Point(154, 12);
            this.txtHits.Name = "txtHits";
            this.txtHits.ReadOnly = true;
            this.txtHits.Size = new System.Drawing.Size(366, 396);
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
            this.btnLoadDorks.Location = new System.Drawing.Point(12, 51);
            this.btnLoadDorks.Name = "btnLoadDorks";
            this.btnLoadDorks.Size = new System.Drawing.Size(136, 23);
            this.btnLoadDorks.TabIndex = 1;
            this.btnLoadDorks.Text = "Load Dorks";
            this.btnLoadDorks.UseVisualStyleBackColor = false;
            // 
            // btnLoadProxies
            // 
            this.btnLoadProxies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLoadProxies.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnLoadProxies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadProxies.ForeColor = System.Drawing.Color.White;
            this.btnLoadProxies.Location = new System.Drawing.Point(12, 132);
            this.btnLoadProxies.Name = "btnLoadProxies";
            this.btnLoadProxies.Size = new System.Drawing.Size(136, 23);
            this.btnLoadProxies.TabIndex = 2;
            this.btnLoadProxies.Text = "Load Proxies";
            this.btnLoadProxies.UseVisualStyleBackColor = false;
            // 
            // cbRegexMatches
            // 
            this.cbRegexMatches.AutoSize = true;
            this.cbRegexMatches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cbRegexMatches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRegexMatches.ForeColor = System.Drawing.Color.White;
            this.cbRegexMatches.Location = new System.Drawing.Point(12, 109);
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
            this.lblRetries.Location = new System.Drawing.Point(9, 369);
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
            this.lblBad.Location = new System.Drawing.Point(9, 352);
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
            this.lblHits.Location = new System.Drawing.Point(9, 335);
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
            this.btnLoadMatches.Location = new System.Drawing.Point(12, 80);
            this.btnLoadMatches.Name = "btnLoadMatches";
            this.btnLoadMatches.Size = new System.Drawing.Size(136, 23);
            this.btnLoadMatches.TabIndex = 7;
            this.btnLoadMatches.Text = "Load Matches";
            this.btnLoadMatches.UseVisualStyleBackColor = false;
            // 
            // lblThreads
            // 
            this.lblThreads.AutoSize = true;
            this.lblThreads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblThreads.ForeColor = System.Drawing.Color.White;
            this.lblThreads.Location = new System.Drawing.Point(9, 187);
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
            this.numThreads.Location = new System.Drawing.Point(59, 184);
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
            this.numThreads.Size = new System.Drawing.Size(89, 20);
            this.numThreads.TabIndex = 5;
            this.numThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numThreads.Value = new decimal(new int[] {
            10,
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
            this.cbProxyless.Location = new System.Drawing.Point(12, 161);
            this.cbProxyless.Name = "cbProxyless";
            this.cbProxyless.Size = new System.Drawing.Size(67, 17);
            this.cbProxyless.TabIndex = 4;
            this.cbProxyless.Text = "Proxyless";
            this.cbProxyless.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(12, 385);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(136, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // cbAllowDuplicates
            // 
            this.cbAllowDuplicates.AutoSize = true;
            this.cbAllowDuplicates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cbAllowDuplicates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAllowDuplicates.ForeColor = System.Drawing.Color.White;
            this.cbAllowDuplicates.Location = new System.Drawing.Point(12, 210);
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
            this.cbLogFullURL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLogFullURL.ForeColor = System.Drawing.Color.White;
            this.cbLogFullURL.Location = new System.Drawing.Point(12, 233);
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
            this.numMinMatch.Location = new System.Drawing.Point(87, 256);
            this.numMinMatch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinMatch.Name = "numMinMatch";
            this.numMinMatch.Size = new System.Drawing.Size(61, 20);
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
            this.lblMinMatch.Location = new System.Drawing.Point(9, 259);
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
            this.txtTarget.Location = new System.Drawing.Point(50, 25);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(98, 20);
            this.txtTarget.TabIndex = 16;
            this.txtTarget.Text = "%ITEM%";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblTarget.ForeColor = System.Drawing.Color.White;
            this.lblTarget.Location = new System.Drawing.Point(9, 28);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(41, 13);
            this.lblTarget.TabIndex = 17;
            this.lblTarget.Text = "Target:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(12, 282);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Recursive Search";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // numRecursiveLimit
            // 
            this.numRecursiveLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numRecursiveLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numRecursiveLimit.ForeColor = System.Drawing.Color.White;
            this.numRecursiveLimit.Location = new System.Drawing.Point(87, 305);
            this.numRecursiveLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRecursiveLimit.Name = "numRecursiveLimit";
            this.numRecursiveLimit.Size = new System.Drawing.Size(61, 20);
            this.numRecursiveLimit.TabIndex = 19;
            this.numRecursiveLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numRecursiveLimit.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblRecursiveLimit
            // 
            this.lblRecursiveLimit.AutoSize = true;
            this.lblRecursiveLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblRecursiveLimit.ForeColor = System.Drawing.Color.White;
            this.lblRecursiveLimit.Location = new System.Drawing.Point(9, 308);
            this.lblRecursiveLimit.Name = "lblRecursiveLimit";
            this.lblRecursiveLimit.Size = new System.Drawing.Size(79, 13);
            this.lblRecursiveLimit.TabIndex = 20;
            this.lblRecursiveLimit.Text = "Recusive Limit:";
            // 
            // Runner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(532, 420);
            this.Controls.Add(this.numRecursiveLimit);
            this.Controls.Add(this.lblRecursiveLimit);
            this.Controls.Add(this.checkBox1);
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
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 420);
            this.Name = "Settings";
            this.Text = "C0bW3b";
            ((System.ComponentModel.ISupportInitialize)(this.numThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinMatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRecursiveLimit)).EndInit();
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numRecursiveLimit;
        private System.Windows.Forms.Label lblRecursiveLimit;
    }
}

