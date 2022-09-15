using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace C0bW3b.Forms
{
    public partial class Settings : Form
    {
        public List<string> OutputFormat = new List<string>();

        public Settings()
        {
            InitializeComponent();
        }

        #region Output Format Reorder system
        private void cblistVariables_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.cblistVariables.SelectedItem == null) return;
            this.cblistVariables.DoDragDrop(this.cblistVariables.SelectedItem, DragDropEffects.Move);
        }

        private void cblistVariables_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

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
        #endregion

        private void cblistVariables_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            OutputFormat.Clear();
            foreach (string item in cblistVariables.CheckedItems)
                OutputFormat.Add(item);
        }
    }
}