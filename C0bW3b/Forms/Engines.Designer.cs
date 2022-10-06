namespace C0bW3b.Forms
{
    partial class Engines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Engines));
            this.cbSearchEngines = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.gbEngine = new System.Windows.Forms.GroupBox();
            this.lblURLRegex = new System.Windows.Forms.Label();
            this.txtURLRegex = new System.Windows.Forms.TextBox();
            this.lblRString = new System.Windows.Forms.Label();
            this.txtRString = new System.Windows.Forms.TextBox();
            this.lblLString = new System.Windows.Forms.Label();
            this.txtLString = new System.Windows.Forms.TextBox();
            this.lblSearchURL = new System.Windows.Forms.Label();
            this.txtSearchURL = new System.Windows.Forms.TextBox();
            this.numTimeout = new System.Windows.Forms.NumericUpDown();
            this.lblTimeout = new System.Windows.Forms.Label();
            this.lblTimeout2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbEngine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSearchEngines
            // 
            this.cbSearchEngines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSearchEngines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbSearchEngines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchEngines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSearchEngines.ForeColor = System.Drawing.Color.White;
            this.cbSearchEngines.FormattingEnabled = true;
            this.cbSearchEngines.Location = new System.Drawing.Point(12, 12);
            this.cbSearchEngines.Name = "cbSearchEngines";
            this.cbSearchEngines.Size = new System.Drawing.Size(665, 21);
            this.cbSearchEngines.TabIndex = 0;
            this.cbSearchEngines.SelectedIndexChanged += new System.EventHandler(this.cbSearchEngines_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(825, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(136, 21);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAddNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(683, 12);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(136, 21);
            this.btnAddNew.TabIndex = 5;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // gbEngine
            // 
            this.gbEngine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEngine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.gbEngine.Controls.Add(this.lblTimeout2);
            this.gbEngine.Controls.Add(this.lblTimeout);
            this.gbEngine.Controls.Add(this.numTimeout);
            this.gbEngine.Controls.Add(this.lblURLRegex);
            this.gbEngine.Controls.Add(this.txtURLRegex);
            this.gbEngine.Controls.Add(this.lblRString);
            this.gbEngine.Controls.Add(this.txtRString);
            this.gbEngine.Controls.Add(this.lblLString);
            this.gbEngine.Controls.Add(this.txtLString);
            this.gbEngine.Controls.Add(this.lblSearchURL);
            this.gbEngine.Controls.Add(this.txtSearchURL);
            this.gbEngine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbEngine.ForeColor = System.Drawing.Color.White;
            this.gbEngine.Location = new System.Drawing.Point(12, 39);
            this.gbEngine.Name = "gbEngine";
            this.gbEngine.Size = new System.Drawing.Size(949, 461);
            this.gbEngine.TabIndex = 6;
            this.gbEngine.TabStop = false;
            this.gbEngine.Text = "Search Engine";
            // 
            // lblURLRegex
            // 
            this.lblURLRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblURLRegex.AutoSize = true;
            this.lblURLRegex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblURLRegex.ForeColor = System.Drawing.Color.White;
            this.lblURLRegex.Location = new System.Drawing.Point(6, 55);
            this.lblURLRegex.Name = "lblURLRegex";
            this.lblURLRegex.Size = new System.Drawing.Size(66, 13);
            this.lblURLRegex.TabIndex = 35;
            this.lblURLRegex.Text = "URL Regex:";
            // 
            // txtURLRegex
            // 
            this.txtURLRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURLRegex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtURLRegex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtURLRegex.ForeColor = System.Drawing.Color.White;
            this.txtURLRegex.Location = new System.Drawing.Point(9, 71);
            this.txtURLRegex.Name = "txtURLRegex";
            this.txtURLRegex.Size = new System.Drawing.Size(934, 20);
            this.txtURLRegex.TabIndex = 34;
            // 
            // lblRString
            // 
            this.lblRString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRString.AutoSize = true;
            this.lblRString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblRString.ForeColor = System.Drawing.Color.White;
            this.lblRString.Location = new System.Drawing.Point(6, 133);
            this.lblRString.Name = "lblRString";
            this.lblRString.Size = new System.Drawing.Size(65, 13);
            this.lblRString.TabIndex = 33;
            this.lblRString.Text = "Right String:";
            // 
            // txtRString
            // 
            this.txtRString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtRString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRString.ForeColor = System.Drawing.Color.White;
            this.txtRString.Location = new System.Drawing.Point(9, 149);
            this.txtRString.Name = "txtRString";
            this.txtRString.Size = new System.Drawing.Size(934, 20);
            this.txtRString.TabIndex = 32;
            // 
            // lblLString
            // 
            this.lblLString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLString.AutoSize = true;
            this.lblLString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblLString.ForeColor = System.Drawing.Color.White;
            this.lblLString.Location = new System.Drawing.Point(6, 94);
            this.lblLString.Name = "lblLString";
            this.lblLString.Size = new System.Drawing.Size(58, 13);
            this.lblLString.TabIndex = 31;
            this.lblLString.Text = "Left String:";
            // 
            // txtLString
            // 
            this.txtLString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtLString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLString.ForeColor = System.Drawing.Color.White;
            this.txtLString.Location = new System.Drawing.Point(9, 110);
            this.txtLString.Name = "txtLString";
            this.txtLString.Size = new System.Drawing.Size(934, 20);
            this.txtLString.TabIndex = 30;
            // 
            // lblSearchURL
            // 
            this.lblSearchURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchURL.AutoSize = true;
            this.lblSearchURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblSearchURL.ForeColor = System.Drawing.Color.White;
            this.lblSearchURL.Location = new System.Drawing.Point(6, 16);
            this.lblSearchURL.Name = "lblSearchURL";
            this.lblSearchURL.Size = new System.Drawing.Size(69, 13);
            this.lblSearchURL.TabIndex = 29;
            this.lblSearchURL.Text = "Search URL:";
            // 
            // txtSearchURL
            // 
            this.txtSearchURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtSearchURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchURL.ForeColor = System.Drawing.Color.White;
            this.txtSearchURL.Location = new System.Drawing.Point(9, 32);
            this.txtSearchURL.Name = "txtSearchURL";
            this.txtSearchURL.Size = new System.Drawing.Size(934, 20);
            this.txtSearchURL.TabIndex = 28;
            // 
            // numTimeout
            // 
            this.numTimeout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numTimeout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numTimeout.ForeColor = System.Drawing.Color.White;
            this.numTimeout.Location = new System.Drawing.Point(9, 188);
            this.numTimeout.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTimeout.Name = "numTimeout";
            this.numTimeout.Size = new System.Drawing.Size(144, 20);
            this.numTimeout.TabIndex = 37;
            this.numTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTimeout.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTimeout
            // 
            this.lblTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeout.AutoSize = true;
            this.lblTimeout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblTimeout.ForeColor = System.Drawing.Color.White;
            this.lblTimeout.Location = new System.Drawing.Point(6, 172);
            this.lblTimeout.Name = "lblTimeout";
            this.lblTimeout.Size = new System.Drawing.Size(85, 13);
            this.lblTimeout.TabIndex = 38;
            this.lblTimeout.Text = "Search Timeout:";
            // 
            // lblTimeout2
            // 
            this.lblTimeout2.AutoSize = true;
            this.lblTimeout2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblTimeout2.ForeColor = System.Drawing.Color.White;
            this.lblTimeout2.Location = new System.Drawing.Point(156, 192);
            this.lblTimeout2.Name = "lblTimeout2";
            this.lblTimeout2.Size = new System.Drawing.Size(63, 13);
            this.lblTimeout2.TabIndex = 39;
            this.lblTimeout2.Text = "milliseconds";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(12, 506);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(949, 21);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Engines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(973, 539);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbEngine);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.cbSearchEngines);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(613, 482);
            this.Name = "Engines";
            this.Text = "C0bW3b";
            this.gbEngine.ResumeLayout(false);
            this.gbEngine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSearchEngines;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.GroupBox gbEngine;
        private System.Windows.Forms.Label lblSearchURL;
        private System.Windows.Forms.TextBox txtSearchURL;
        private System.Windows.Forms.Label lblRString;
        private System.Windows.Forms.TextBox txtRString;
        private System.Windows.Forms.Label lblLString;
        private System.Windows.Forms.TextBox txtLString;
        private System.Windows.Forms.Label lblURLRegex;
        private System.Windows.Forms.TextBox txtURLRegex;
        private System.Windows.Forms.Label lblTimeout;
        private System.Windows.Forms.NumericUpDown numTimeout;
        private System.Windows.Forms.Label lblTimeout2;
        private System.Windows.Forms.Button btnSave;
    }
}

