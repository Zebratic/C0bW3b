namespace C0bW3b.Forms
{
    partial class Hits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hits));
            this.cbHits = new System.Windows.Forms.ComboBox();
            this.listHits = new C0bW3b.UIControls.ListViewNF();
            this.SuspendLayout();
            // 
            // cbHits
            // 
            this.cbHits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbHits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbHits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbHits.ForeColor = System.Drawing.Color.White;
            this.cbHits.FormattingEnabled = true;
            this.cbHits.Location = new System.Drawing.Point(12, 12);
            this.cbHits.Name = "cbHits";
            this.cbHits.Size = new System.Drawing.Size(949, 21);
            this.cbHits.TabIndex = 4;
            this.cbHits.SelectedIndexChanged += new System.EventHandler(this.cbHits_SelectedIndexChanged);
            // 
            // listHits
            // 
            this.listHits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listHits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.listHits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listHits.ForeColor = System.Drawing.Color.White;
            this.listHits.FullRowSelect = true;
            this.listHits.HideSelection = false;
            this.listHits.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listHits.Location = new System.Drawing.Point(12, 39);
            this.listHits.Name = "listHits";
            this.listHits.Size = new System.Drawing.Size(949, 488);
            this.listHits.TabIndex = 2;
            this.listHits.UseCompatibleStateImageBehavior = false;
            this.listHits.View = System.Windows.Forms.View.Details;
            // 
            // Hits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(973, 539);
            this.Controls.Add(this.cbHits);
            this.Controls.Add(this.listHits);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(613, 482);
            this.Name = "Hits";
            this.Text = "C0bW3b";
            this.ResumeLayout(false);

        }

        #endregion

        private UIControls.ListViewNF listHits;
        private System.Windows.Forms.ComboBox cbHits;
    }
}

