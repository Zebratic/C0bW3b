using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace C0bW3b.Forms
{
    public partial class Plugins : Form
    {
        public static Plugins instance;

        public Plugins()
        {
            InitializeComponent();
            instance = this;
        }
    }
}