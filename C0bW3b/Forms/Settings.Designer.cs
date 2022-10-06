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
            this.gbOutput.SuspendLayout();
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
            "Proxy"});
            this.cblistVariables.Location = new System.Drawing.Point(12, 32);
            this.cblistVariables.Name = "cblistVariables";
            this.cblistVariables.Size = new System.Drawing.Size(89, 90);
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
            this.txtSeperator.Location = new System.Drawing.Point(110, 32);
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
            this.lblSeperator.Location = new System.Drawing.Point(107, 16);
            this.lblSeperator.Name = "lblSeperator";
            this.lblSeperator.Size = new System.Drawing.Size(56, 13);
            this.lblSeperator.TabIndex = 24;
            this.lblSeperator.Text = "Seperator:";
            // 
            // gbOutput
            // 
            this.gbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.gbOutput.Controls.Add(this.cbUpdateThreadStatus);
            this.gbOutput.Controls.Add(this.lblOutputFormat);
            this.gbOutput.Controls.Add(this.lblSeperator);
            this.gbOutput.Controls.Add(this.cblistVariables);
            this.gbOutput.Controls.Add(this.txtSeperator);
            this.gbOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbOutput.ForeColor = System.Drawing.Color.White;
            this.gbOutput.Location = new System.Drawing.Point(12, 12);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(244, 131);
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
            this.cbUpdateThreadStatus.Location = new System.Drawing.Point(110, 67);
            this.cbUpdateThreadStatus.Name = "cbUpdateThreadStatus";
            this.cbUpdateThreadStatus.Size = new System.Drawing.Size(128, 17);
            this.cbUpdateThreadStatus.TabIndex = 25;
            this.cbUpdateThreadStatus.Text = "Update Thread Status";
            this.cbUpdateThreadStatus.UseVisualStyleBackColor = false;
            this.cbUpdateThreadStatus.CheckedChanged += new System.EventHandler(this.cbUpdateThreadStatus_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(973, 539);
            this.Controls.Add(this.gbOutput);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(613, 482);
            this.Name = "Settings";
            this.Text = "C0bW3b";
            this.gbOutput.ResumeLayout(false);
            this.gbOutput.PerformLayout();
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
    }
}

