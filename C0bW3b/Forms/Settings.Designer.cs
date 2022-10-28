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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.lblOutputFormat = new System.Windows.Forms.Label();
            this.cblistVariables = new System.Windows.Forms.CheckedListBox();
            this.txtSeperator = new System.Windows.Forms.TextBox();
            this.lblSeperator = new System.Windows.Forms.Label();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.cbUpdateThreadStatus = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.numAutoSaveInterval = new System.Windows.Forms.NumericUpDown();
            this.lblMinMatch = new System.Windows.Forms.Label();
            this.cbAutoSave = new System.Windows.Forms.CheckBox();
            this.gbTheme = new System.Windows.Forms.GroupBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.gpBlacklist = new System.Windows.Forms.GroupBox();
            this.txtBlacklist = new System.Windows.Forms.RichTextBox();
            this.numGarbageCollectorInterval = new System.Windows.Forms.NumericUpDown();
            this.lblGarbageCollector = new System.Windows.Forms.Label();
            this.cbGarbageCollector = new System.Windows.Forms.CheckBox();
            this.cbLogCollection = new System.Windows.Forms.CheckBox();
            this.gbOutput.SuspendLayout();
            this.gbGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAutoSaveInterval)).BeginInit();
            this.gbTheme.SuspendLayout();
            this.gpBlacklist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGarbageCollectorInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOutputFormat
            // 
            this.lblOutputFormat.AutoSize = true;
            this.lblOutputFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblOutputFormat.ForeColor = System.Drawing.Color.White;
            this.lblOutputFormat.Location = new System.Drawing.Point(6, 16);
            this.lblOutputFormat.Name = "lblOutputFormat";
            this.lblOutputFormat.Size = new System.Drawing.Size(77, 13);
            this.lblOutputFormat.TabIndex = 20;
            this.lblOutputFormat.Text = "Output Format:";
            // 
            // cblistVariables
            // 
            this.cblistVariables.AllowDrop = true;
            this.cblistVariables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.cblistVariables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cblistVariables.ForeColor = System.Drawing.Color.White;
            this.cblistVariables.FormattingEnabled = true;
            this.cblistVariables.Items.AddRange(new object[] {
            "Url",
            "Dork",
            "Matches",
            "Match Count",
            "User Agent",
            "Proxy",
            "Engine"});
            this.cblistVariables.Location = new System.Drawing.Point(12, 32);
            this.cblistVariables.Name = "cblistVariables";
            this.cblistVariables.Size = new System.Drawing.Size(89, 105);
            this.cblistVariables.TabIndex = 22;
            this.cblistVariables.ThreeDCheckBoxes = true;
            this.cblistVariables.DragDrop += new System.Windows.Forms.DragEventHandler(this.cblistVariables_DragDrop);
            this.cblistVariables.DragOver += new System.Windows.Forms.DragEventHandler(this.cblistVariables_DragOver);
            this.cblistVariables.Leave += new System.EventHandler(this.cblistVariables_Leave);
            this.cblistVariables.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cblistVariables_MouseDown);
            // 
            // txtSeperator
            // 
            this.txtSeperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtSeperator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSeperator.ForeColor = System.Drawing.Color.White;
            this.txtSeperator.Location = new System.Drawing.Point(12, 165);
            this.txtSeperator.Name = "txtSeperator";
            this.txtSeperator.Size = new System.Drawing.Size(55, 20);
            this.txtSeperator.TabIndex = 23;
            this.txtSeperator.Text = "|";
            this.txtSeperator.TextChanged += new System.EventHandler(this.txtSeperator_TextChanged);
            // 
            // lblSeperator
            // 
            this.lblSeperator.AutoSize = true;
            this.lblSeperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblSeperator.ForeColor = System.Drawing.Color.White;
            this.lblSeperator.Location = new System.Drawing.Point(9, 149);
            this.lblSeperator.Name = "lblSeperator";
            this.lblSeperator.Size = new System.Drawing.Size(56, 13);
            this.lblSeperator.TabIndex = 24;
            this.lblSeperator.Text = "Seperator:";
            // 
            // gbOutput
            // 
            this.gbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.gbOutput.Controls.Add(this.lblOutputFormat);
            this.gbOutput.Controls.Add(this.lblSeperator);
            this.gbOutput.Controls.Add(this.cblistVariables);
            this.gbOutput.Controls.Add(this.txtSeperator);
            this.gbOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbOutput.ForeColor = System.Drawing.Color.White;
            this.gbOutput.Location = new System.Drawing.Point(12, 12);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(217, 253);
            this.gbOutput.TabIndex = 25;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Output";
            // 
            // cbUpdateThreadStatus
            // 
            this.cbUpdateThreadStatus.AutoSize = true;
            this.cbUpdateThreadStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cbUpdateThreadStatus.Checked = true;
            this.cbUpdateThreadStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUpdateThreadStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUpdateThreadStatus.ForeColor = System.Drawing.Color.White;
            this.cbUpdateThreadStatus.Location = new System.Drawing.Point(6, 14);
            this.cbUpdateThreadStatus.Name = "cbUpdateThreadStatus";
            this.cbUpdateThreadStatus.Size = new System.Drawing.Size(128, 17);
            this.cbUpdateThreadStatus.TabIndex = 25;
            this.cbUpdateThreadStatus.Text = "Update Thread Status";
            this.cbUpdateThreadStatus.UseVisualStyleBackColor = false;
            this.cbUpdateThreadStatus.CheckedChanged += new System.EventHandler(this.cbUpdateThreadStatus_CheckedChanged);
            // 
            // gbGeneral
            // 
            this.gbGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.gbGeneral.Controls.Add(this.numGarbageCollectorInterval);
            this.gbGeneral.Controls.Add(this.cbLogCollection);
            this.gbGeneral.Controls.Add(this.lblGarbageCollector);
            this.gbGeneral.Controls.Add(this.numAutoSaveInterval);
            this.gbGeneral.Controls.Add(this.lblMinMatch);
            this.gbGeneral.Controls.Add(this.cbUpdateThreadStatus);
            this.gbGeneral.Controls.Add(this.cbAutoSave);
            this.gbGeneral.Controls.Add(this.cbGarbageCollector);
            this.gbGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbGeneral.ForeColor = System.Drawing.Color.White;
            this.gbGeneral.Location = new System.Drawing.Point(235, 12);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Size = new System.Drawing.Size(329, 253);
            this.gbGeneral.TabIndex = 26;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Text = "General";
            // 
            // numAutoSaveInterval
            // 
            this.numAutoSaveInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numAutoSaveInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numAutoSaveInterval.ForeColor = System.Drawing.Color.White;
            this.numAutoSaveInterval.Location = new System.Drawing.Point(109, 59);
            this.numAutoSaveInterval.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.numAutoSaveInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAutoSaveInterval.Name = "numAutoSaveInterval";
            this.numAutoSaveInterval.Size = new System.Drawing.Size(64, 20);
            this.numAutoSaveInterval.TabIndex = 26;
            this.numAutoSaveInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numAutoSaveInterval.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numAutoSaveInterval.ValueChanged += new System.EventHandler(this.numAutoSaveInterval_ValueChanged);
            // 
            // lblMinMatch
            // 
            this.lblMinMatch.AutoSize = true;
            this.lblMinMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblMinMatch.ForeColor = System.Drawing.Color.White;
            this.lblMinMatch.Location = new System.Drawing.Point(3, 61);
            this.lblMinMatch.Name = "lblMinMatch";
            this.lblMinMatch.Size = new System.Drawing.Size(222, 13);
            this.lblMinMatch.TabIndex = 27;
            this.lblMinMatch.Text = "Auto Save Interval:                           seconds.";
            // 
            // cbAutoSave
            // 
            this.cbAutoSave.AutoSize = true;
            this.cbAutoSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cbAutoSave.Checked = true;
            this.cbAutoSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAutoSave.ForeColor = System.Drawing.Color.White;
            this.cbAutoSave.Location = new System.Drawing.Point(6, 41);
            this.cbAutoSave.Name = "cbAutoSave";
            this.cbAutoSave.Size = new System.Drawing.Size(73, 17);
            this.cbAutoSave.TabIndex = 25;
            this.cbAutoSave.Text = "Auto Save";
            this.cbAutoSave.UseVisualStyleBackColor = false;
            this.cbAutoSave.CheckedChanged += new System.EventHandler(this.cbAutoSave_CheckedChanged);
            // 
            // gbTheme
            // 
            this.gbTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.gbTheme.Controls.Add(this.lblWarning);
            this.gbTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbTheme.ForeColor = System.Drawing.Color.White;
            this.gbTheme.Location = new System.Drawing.Point(570, 12);
            this.gbTheme.Name = "gbTheme";
            this.gbTheme.Size = new System.Drawing.Size(391, 515);
            this.gbTheme.TabIndex = 28;
            this.gbTheme.TabStop = false;
            this.gbTheme.Text = "Theme";
            // 
            // lblWarning
            // 
            this.lblWarning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblWarning.Location = new System.Drawing.Point(3, 16);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(385, 496);
            this.lblWarning.TabIndex = 2;
            this.lblWarning.Text = "⚠️ Theming is not done yet ⚠️";
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpBlacklist
            // 
            this.gpBlacklist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gpBlacklist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.gpBlacklist.Controls.Add(this.txtBlacklist);
            this.gpBlacklist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpBlacklist.ForeColor = System.Drawing.Color.White;
            this.gpBlacklist.Location = new System.Drawing.Point(12, 268);
            this.gpBlacklist.Name = "gpBlacklist";
            this.gpBlacklist.Size = new System.Drawing.Size(552, 259);
            this.gpBlacklist.TabIndex = 28;
            this.gpBlacklist.TabStop = false;
            this.gpBlacklist.Text = "Blacklisted Url\'s";
            // 
            // txtBlacklist
            // 
            this.txtBlacklist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.txtBlacklist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBlacklist.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBlacklist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBlacklist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlacklist.ForeColor = System.Drawing.Color.White;
            this.txtBlacklist.Location = new System.Drawing.Point(3, 16);
            this.txtBlacklist.Name = "txtBlacklist";
            this.txtBlacklist.Size = new System.Drawing.Size(546, 240);
            this.txtBlacklist.TabIndex = 1;
            this.txtBlacklist.Text = "";
            this.txtBlacklist.WordWrap = false;
            this.txtBlacklist.TextChanged += new System.EventHandler(this.txtBlacklist_TextChanged);
            // 
            // numGarbageCollectorInterval
            // 
            this.numGarbageCollectorInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numGarbageCollectorInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numGarbageCollectorInterval.ForeColor = System.Drawing.Color.White;
            this.numGarbageCollectorInterval.Location = new System.Drawing.Point(109, 122);
            this.numGarbageCollectorInterval.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.numGarbageCollectorInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGarbageCollectorInterval.Name = "numGarbageCollectorInterval";
            this.numGarbageCollectorInterval.Size = new System.Drawing.Size(64, 20);
            this.numGarbageCollectorInterval.TabIndex = 28;
            this.numGarbageCollectorInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numGarbageCollectorInterval.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numGarbageCollectorInterval.ValueChanged += new System.EventHandler(this.numGarbageCollectorInterval_ValueChanged);
            // 
            // lblGarbageCollector
            // 
            this.lblGarbageCollector.AutoSize = true;
            this.lblGarbageCollector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblGarbageCollector.ForeColor = System.Drawing.Color.White;
            this.lblGarbageCollector.Location = new System.Drawing.Point(3, 124);
            this.lblGarbageCollector.Name = "lblGarbageCollector";
            this.lblGarbageCollector.Size = new System.Drawing.Size(221, 13);
            this.lblGarbageCollector.TabIndex = 29;
            this.lblGarbageCollector.Text = "Collection Interval:                            seconds.";
            // 
            // cbGarbageCollector
            // 
            this.cbGarbageCollector.AutoSize = true;
            this.cbGarbageCollector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cbGarbageCollector.Checked = true;
            this.cbGarbageCollector.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGarbageCollector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGarbageCollector.ForeColor = System.Drawing.Color.White;
            this.cbGarbageCollector.Location = new System.Drawing.Point(6, 104);
            this.cbGarbageCollector.Name = "cbGarbageCollector";
            this.cbGarbageCollector.Size = new System.Drawing.Size(108, 17);
            this.cbGarbageCollector.TabIndex = 30;
            this.cbGarbageCollector.Text = "Garbage Collector";
            this.cbGarbageCollector.UseVisualStyleBackColor = false;
            this.cbGarbageCollector.CheckedChanged += new System.EventHandler(this.cbGarbageCollector_CheckedChanged);
            // 
            // cbLogCollection
            // 
            this.cbLogCollection.AutoSize = true;
            this.cbLogCollection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cbLogCollection.Checked = true;
            this.cbLogCollection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLogCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLogCollection.ForeColor = System.Drawing.Color.White;
            this.cbLogCollection.Location = new System.Drawing.Point(6, 140);
            this.cbLogCollection.Name = "cbLogCollection";
            this.cbLogCollection.Size = new System.Drawing.Size(90, 17);
            this.cbLogCollection.TabIndex = 31;
            this.cbLogCollection.Text = "Log Collection";
            this.cbLogCollection.UseVisualStyleBackColor = false;
            this.cbLogCollection.CheckedChanged += new System.EventHandler(this.cbLogCollection_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(973, 539);
            this.Controls.Add(this.gpBlacklist);
            this.Controls.Add(this.gbTheme);
            this.Controls.Add(this.gbGeneral);
            this.Controls.Add(this.gbOutput);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(613, 482);
            this.Name = "Settings";
            this.Text = "C0bW3b";
            this.gbOutput.ResumeLayout(false);
            this.gbOutput.PerformLayout();
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAutoSaveInterval)).EndInit();
            this.gbTheme.ResumeLayout(false);
            this.gpBlacklist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numGarbageCollectorInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOutputFormat;
        private System.Windows.Forms.CheckedListBox cblistVariables;
        private System.Windows.Forms.TextBox txtSeperator;
        private System.Windows.Forms.Label lblSeperator;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox cbUpdateThreadStatus;
        private System.Windows.Forms.GroupBox gbGeneral;
        private System.Windows.Forms.CheckBox cbAutoSave;
        private System.Windows.Forms.NumericUpDown numAutoSaveInterval;
        private System.Windows.Forms.Label lblMinMatch;
        private System.Windows.Forms.GroupBox gbTheme;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.GroupBox gpBlacklist;
        private System.Windows.Forms.RichTextBox txtBlacklist;
        private System.Windows.Forms.CheckBox cbGarbageCollector;
        private System.Windows.Forms.NumericUpDown numGarbageCollectorInterval;
        private System.Windows.Forms.Label lblGarbageCollector;
        private System.Windows.Forms.CheckBox cbLogCollection;
    }
}

