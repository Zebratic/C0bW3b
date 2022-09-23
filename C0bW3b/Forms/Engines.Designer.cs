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
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbSearchEngines
            // 
            this.cbSearchEngines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbSearchEngines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSearchEngines.ForeColor = System.Drawing.Color.White;
            this.cbSearchEngines.FormattingEnabled = true;
            this.cbSearchEngines.Location = new System.Drawing.Point(12, 12);
            this.cbSearchEngines.Name = "cbSearchEngines";
            this.cbSearchEngines.Size = new System.Drawing.Size(290, 21);
            this.cbSearchEngines.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(308, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(136, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // Engines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(973, 539);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbSearchEngines);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(613, 482);
            this.Name = "Engines";
            this.Text = "C0bW3b";
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
        private System.Windows.Forms.ComboBox cbSearchEngines;
        private System.Windows.Forms.Button btnStart;
    }
}

