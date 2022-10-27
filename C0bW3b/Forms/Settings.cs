using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

            // setup tooltips
            toolTip.SetToolTip(lblOutputFormat, "You can change the formats order by dragging them around.");
            toolTip.SetToolTip(lblSeperator, "Add a new format.");
            toolTip.ShowAlways = true;


            // OUTPUT SETTINGS
            string[] outputs = { "Url", "Dork", "Matches", "Match Count", "User Agent", "Proxy", "Engine" };
            cblistVariables.Items.Clear();
            foreach (var item in ConfigSystem.config.OutputFormat)
                if (outputs.Contains(item.Key))
                    cblistVariables.Items.Add(item.Key, item.Value);

            // loop all added outputs, and add if the list dont contain all outputs, add the missing
            foreach (var item in outputs)
                if (!ConfigSystem.config.OutputFormat.ContainsKey(item))
                    ConfigSystem.config.OutputFormat.Add(item, false);

            txtSeperator.Text = ConfigSystem.config.Seperator;


            // GENERAL SETTINGS
            cbUpdateThreadStatus.Checked = ConfigSystem.config.UpdateThreadStatus;
            cbAutoSave.Checked = ConfigSystem.config.AutoSave;
            numAutoSaveInterval.Value = ConfigSystem.config.AutoSaveInterval;
            try { Main.instance.AutoSaveTimer.Interval = (int)numAutoSaveInterval.Value * 1000; } catch { }

            // THEME SETTINGS

            // BLACKLIST SETTINGS
            txtBlacklist.Text = ConfigSystem.config.Blacklist;
        }

        #region Output Format Reorder system
        private void cblistVariables_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.cblistVariables.SelectedItem == null) return;
            this.cblistVariables.DoDragDrop(this.cblistVariables.SelectedItem, DragDropEffects.Move);
            ConfigSystem.SaveConfig();
        }

        private void cblistVariables_DragOver(object sender, DragEventArgs e) => e.Effect = DragDropEffects.Move;

        private void cblistVariables_DragDrop(object sender, DragEventArgs e)
        {
            Point point = cblistVariables.PointToClient(new Point(e.X, e.Y));
            int index = this.cblistVariables.IndexFromPoint(point);
            if (index < 0) index = this.cblistVariables.Items.Count - 1;
            object data = cblistVariables.SelectedItem;
            if (cblistVariables.SelectedIndex != index)
            {
                // check if item is checked
                bool isChecked = cblistVariables.GetItemChecked(cblistVariables.SelectedIndex);
                this.cblistVariables.Items.Remove(data);
                this.cblistVariables.Items.Insert(index, data);
                this.cblistVariables.SetItemChecked(index, isChecked);
            }
            ConfigSystem.SaveConfig();
        }

        private void cblistVariables_Leave(object sender, System.EventArgs e)
        {
            ConfigSystem.config.OutputFormat.Clear();
            for (int i = 0; i < cblistVariables.Items.Count; i++)
                ConfigSystem.config.OutputFormat.Add(cblistVariables.Items[i].ToString(), cblistVariables.GetItemCheckState(i) == CheckState.Checked ? true : false);

            ConfigSystem.SaveConfig();
        }
        #endregion

        private void cbUpdateThreadStatus_CheckedChanged(object sender, System.EventArgs e)
        {
            ConfigSystem.config.UpdateThreadStatus = cbUpdateThreadStatus.Checked;
            ConfigSystem.SaveConfig();
        }

        private void txtSeperator_TextChanged(object sender, System.EventArgs e)
        {
            ConfigSystem.config.Seperator = txtSeperator.Text;
            ConfigSystem.SaveConfig();
        }

        private void cbAutoSave_CheckedChanged(object sender, System.EventArgs e)
        {
            ConfigSystem.config.AutoSave = cbAutoSave.Checked;
            ConfigSystem.SaveConfig();
        }

        private void numAutoSaveInterval_ValueChanged(object sender, System.EventArgs e)
        {
            try { Main.instance.AutoSaveTimer.Interval = (int)numAutoSaveInterval.Value * 1000; } catch { }
            ConfigSystem.config.AutoSaveInterval = (int)numAutoSaveInterval.Value;
            ConfigSystem.SaveConfig();
        }

        private void txtBlacklist_TextChanged(object sender, System.EventArgs e)
        {
            ConfigSystem.config.Blacklist = txtBlacklist.Text;
            ConfigSystem.SaveConfig();
        }
    }
}