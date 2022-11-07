using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;

namespace C0bW3b.Forms
{
    public partial class Help : Form
    {
        public static Help instance;

        public Help()
        {
            InitializeComponent();
            instance = this;
        }

        private void Help_Load(object sender, System.EventArgs e)
        {
            // TODO: load all contributors and show on a listview
        }
    }
}