using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class AboutForm : Form
    {
        Rectangle screen = Screen.PrimaryScreen.WorkingArea;
        public AboutForm()
        {
            InitializeComponent();
            this.Size = new Size(screen.Width* 7 / 10, screen.Height* 3 / 4);
    }
    }
}
