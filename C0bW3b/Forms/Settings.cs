using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace C0bW3b.Forms
{
    public partial class Settings : Form
    {
        public static Settings instance;

        // settings
        

        public Settings()
        {
            InitializeComponent();
            instance = this;

            // SETTINGS //
            // check off the default output format
            //cblistVariables.SetItemChecked(0, true); // URL
            //cblistVariables.SetItemChecked(3, true); // MATCH COUNT

            /*
            Url
            Dork
            Matches
            Match Count
            User Agent
            Proxy
            */

            cblistVariables.Items.Clear();
            int i = 0;
            foreach (var item in ConfigSystem.config.OutputFormat)
            {
                MessageBox.Show(item.Key);
                if (item.Key == "Url" ||
                    item.Key == "Dork" ||
                    item.Key == "Matches" ||
                    item.Key == "Match Count" ||
                    item.Key == "User Agent" ||
                    item.Key == "Proxy")
                {
                    // get index
                    cblistVariables.Items.Add(item.Key, item.Value);
                }

                i++;
            }

            // setup tooltips
            toolTip.SetToolTip(lblOutputFormat, "You can change the formats order by dragging them around.");
            toolTip.SetToolTip(lblSeperator, "Add a new format.");
            toolTip.ShowAlways = true;
        }

        #region Output Format Reorder system
        private void cblistVariables_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.cblistVariables.SelectedItem == null) return;
            this.cblistVariables.DoDragDrop(this.cblistVariables.SelectedItem, DragDropEffects.Move);
        }

        private void cblistVariables_DragOver(object sender, DragEventArgs e) => e.Effect = DragDropEffects.Move;

        private void cblistVariables_DragDrop(object sender, DragEventArgs e)
        {
            Point point = cblistVariables.PointToClient(new Point(e.X, e.Y));
            int index = this.cblistVariables.IndexFromPoint(point);
            if (index < 0) index = this.cblistVariables.Items.Count - 1;
            object data = cblistVariables.SelectedItem;
            if (cblistVariables.SelectedIndex == index)
                cblistVariables.SetItemChecked(index, !cblistVariables.GetItemChecked(index));
            else
            {
                // check if item is checked
                bool isChecked = cblistVariables.GetItemChecked(cblistVariables.SelectedIndex);
                this.cblistVariables.Items.Remove(data);
                this.cblistVariables.Items.Insert(index, data);
                this.cblistVariables.SetItemChecked(index, isChecked);
            }
        }

        private void cblistVariables_Leave(object sender, System.EventArgs e)
        {
            ConfigSystem.config.OutputFormat.Clear();
            for (int i = 0; i < cblistVariables.Items.Count; i++)
                ConfigSystem.config.OutputFormat.Add(cblistVariables.Items[i].ToString(), cblistVariables.GetItemCheckState(i) == CheckState.Checked ? true : false);
        }
        #endregion

        private void cbUpdateThreadStatus_CheckedChanged(object sender, System.EventArgs e) => ConfigSystem.config.UpdateThreadStatus = cbUpdateThreadStatus.Checked;
        private void txtSeperator_TextChanged(object sender, System.EventArgs e) => ConfigSystem.config.Seperator = txtSeperator.Text;
    }
}