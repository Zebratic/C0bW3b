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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.lblOutputFormat = new System.Windows.Forms.Label();
            this.cblistVariables = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lblOutputFormat
            // 
            this.lblOutputFormat.AutoSize = true;
            this.lblOutputFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblOutputFormat.ForeColor = System.Drawing.Color.White;
            this.lblOutputFormat.Location = new System.Drawing.Point(6, 15);
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
            "Dork",
            "Matches",
            "Proxy",
            "Url",
            "User Agent"});
            this.cblistVariables.Location = new System.Drawing.Point(12, 31);
            this.cblistVariables.Name = "cblistVariables";
            this.cblistVariables.Size = new System.Drawing.Size(78, 75);
            this.cblistVariables.TabIndex = 22;
            this.cblistVariables.ThreeDCheckBoxes = true;
            this.cblistVariables.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cblistVariables_ItemCheck);
            this.cblistVariables.DragDrop += new System.Windows.Forms.DragEventHandler(this.cblistVariables_DragDrop);
            this.cblistVariables.DragOver += new System.Windows.Forms.DragEventHandler(this.cblistVariables_DragOver);
            this.cblistVariables.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cblistVariables_MouseDown);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(973, 539);
            this.Controls.Add(this.cblistVariables);
            this.Controls.Add(this.lblOutputFormat);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(613, 482);
            this.Name = "Settings";
            this.Text = "C0bW3b";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutputFormat;
        private System.Windows.Forms.CheckedListBox cblistVariables;
    }
}

