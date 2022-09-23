using System.Collections.Generic;
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
        }
    }
}