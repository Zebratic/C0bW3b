using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace C0bW3b.Forms
{
    public partial class Engines : Form
    {
        public static Engines instance;

        public Engines()
        {
            InitializeComponent();
            instance = this;
        }
    }
}