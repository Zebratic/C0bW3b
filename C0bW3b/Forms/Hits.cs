using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;

namespace C0bW3b.Forms
{
    public partial class Hits : Form
    {
        public static Hits instance;

        public Hits()
        {
            InitializeComponent();
            instance = this;

            UpdateColumns();

            // load /Hits folder
            LoadHits();
        }

        public void UpdateColumns()
        {
            // load columns
            listHits.Columns.Clear();
            int columncount = 0;
            foreach (KeyValuePair<string, bool> variable in ConfigSystem.config.OutputFormat)
            {
                if (variable.Value)
                {
                    ColumnHeader column = new ColumnHeader();
                    column.Name = variable.Key.ToUpper();
                    column.Text = variable.Key.ToUpper();
                    listHits.Columns.Add(column);
                    columncount++;
                }
            }

            foreach (ColumnHeader column in listHits.Columns)
            {
                column.Width = listHits.Width / listHits.Columns.Count;
            }
        }

        public void LoadHits()
        {
            foreach (string file in System.IO.Directory.GetFiles("Hits"))
            {
                cbHits.Items.Add(file.Replace(@"Hits\", ""));
            }
        }

        private void cbHits_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // load data into columns
            listHits.Items.Clear();
            string[] lines = System.IO.File.ReadAllLines(@"Hits\" + cbHits.SelectedItem.ToString());
            foreach (string line in lines)
            {
                List<ListViewItem> items = new List<ListViewItem>();
                string[] data = line.Split(new string[] { " | " }, System.StringSplitOptions.None);
                foreach (ColumnHeader column in listHits.Columns)
                {
                    foreach (string variable in data)
                    {
                        string fixedvariable = variable.Split(new string[] { " =" }, System.StringSplitOptions.None)[0].ToUpper();
                        if (fixedvariable == column.Text.ToUpper())
                        {
                            items.Add(new ListViewItem(variable));
                        }
                    }
                }

                listHits.Items.AddRange(items.ToArray());
            }
        }
    }
}