using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class settings_DifficultyLevelUserControl : UserControl
    {
        public settings_DifficultyLevelUserControl()
        {
            InitializeComponent();
        }

        private void settings_SaveDifficultyLevelSelectionButton_Click(object sender, EventArgs e)
        {

        }

        private void settings_DifficultyLevelCustomRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            settings_CustomDifficultyPanel.Visible = settings_DifficultyLevelCustomRadioButton.Checked ? true : false;
        }
    }
}
