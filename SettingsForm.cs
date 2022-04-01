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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void settings_difficultyLevelButton_Click(object sender, EventArgs e)
        {
            settings_DifficultyLevelUserControl1.BringToFront();
        }

        private void settings_ShapeButton_Click(object sender, EventArgs e)
        {
            settings_ShapesUserControl1.BringToFront();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            settings_DifficultyLevelUserControl1.BringToFront();
        }

        private void settings_backToGameWindowButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
