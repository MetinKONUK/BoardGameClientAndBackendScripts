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
            var setting = new Setting
                          {
                            Row = -1,
                            Col = -1,
                            DifficultyLevel = 0,
                            Shapes = new List<int>(){1, 0, 1}
                          };
        }
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            settings_ShapesPanel.Visible = false;
            settings_DifficultyLevelPanel.Visible = false;
        }

        private void Settings_difficultyLevelButton_Click(object sender, EventArgs e)
        {
            settings_DifficultyLevelPanel.Show();
            settings_ShapesPanel.Hide();
            settings_DifficultyLevelPanel.BringToFront();
        }

        private void Settings_ShapeButton_Click(object sender, EventArgs e)
        {
            settings_ShapesPanel.Show();
            settings_DifficultyLevelPanel.Hide();
            settings_ShapesPanel.BringToFront();
        }


        private void Settings_backToGameWindowButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settings_DifficultyLevelCustomRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            settings_CustomDifficultyPanel.Visible = settings_DifficultyLevelCustomRadioButton.Checked ? true : false;
        }

    }
}
