using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Newtonsoft.Json;

namespace main
{
    public partial class SettingsForm : Form
    {
        Setting _setting =  new Setting
                      {
                          Row             = -1,
                          Col             = -1,
                          DifficultyLevel = 0,
                          Shapes          = new List<int>() { 1, 0, 1 }
                      };
        public SettingsForm()
        {
            InitializeComponent();
        }
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            settings_ShapesPanel.Visible          = false;
            settings_DifficultyLevelPanel.Visible = false;
            Settings_ColorPanel.Visible           = false;

            var settingJson = File.ReadAllText(@"../../settings.json");
            var setting = JsonConvert.DeserializeObject<Setting>(settingJson);
            
            _setting = setting;

            if (setting != null && setting.Shapes != null)
            {
                List<int> shapes = setting.Shapes;
                if (shapes[0] == 1)
                {
                    settings_SquareCheckBox.Checked = true;
                }
                if (shapes[1] == 1)
                {
                    settings_TriangleCheckBox.Checked = true;
                }
                if (shapes[2] == 1)
                {
                    settings_RoundCheckBox.Checked = true;
                }
            }

            if (setting != null && setting.Shapes != null)
            {
                var difficultyLevel = setting.DifficultyLevel;
                switch (difficultyLevel)
                {
                    case 0:
                        settings_DifficultyLevelEasyRadioButton.Checked = true;
                        break;
                    case 1:
                        settings_DifficultyLevelNormalRadioButton.Checked = true;
                        break;
                    case 2:
                        settings_DifficultyLevelHardRadioButton.Checked = true;
                        break;
                    default:
                        settings_DifficultyLevelCustomRadioButton.Checked = true;
                        settings_DifficultyLevelCustomRowTextBox.Text = setting.Row.ToString();
                        settings_DifficultyLevelCustomColTextBox.Text = setting.Col.ToString();
                        break;
                }
            }
        }

        private void Settings_difficultyLevelButton_Click(object sender, EventArgs e)
        {
            settings_DifficultyLevelPanel.Show();
            settings_ShapesPanel.Hide();
            Settings_ColorPanel.Hide();
            settings_DifficultyLevelPanel.BringToFront();
        }

        private void Settings_ShapeButton_Click(object sender, EventArgs e)
        {
            settings_ShapesPanel.Show();
            settings_DifficultyLevelPanel.Hide();
            Settings_ColorPanel.Hide();
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

        private void settings_SaveShapeSelectionButton_Click(object sender, EventArgs e)
        {
            var square = settings_SquareCheckBox.Checked ? 1 : 0;
            var triangle = settings_TriangleCheckBox.Checked ? 1 : 0;
            var round = settings_RoundCheckBox.Checked ? 1 : 0;
            _setting.Shapes = new List<int>() { square, triangle, round};
        }

        private void settings_SaveDifficultyLevelSelectionButton_Click(object sender, EventArgs e)
        {
            if (settings_DifficultyLevelEasyRadioButton.Checked)
            {
                _setting.DifficultyLevel = 0;
            } 
            else if (settings_DifficultyLevelNormalRadioButton.Checked)
            {
                _setting.DifficultyLevel = 1;
            }
            else if (settings_DifficultyLevelHardRadioButton.Checked)
            {
                _setting.DifficultyLevel = 2;
            }
            else
            {
                const string rowValueInvalidError = "Row value invalid!";
                const string colValueInvalidError = "Col value invalid!";

                _setting.DifficultyLevel = 3;
                int row;
                int col;
                try
                {
                    row = int.Parse(settings_DifficultyLevelCustomColTextBox.Text);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    MessageBox.Show(rowValueInvalidError);
                    return;
                }
                try
                {
                    col = int.Parse(settings_DifficultyLevelCustomRowTextBox.Text);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    MessageBox.Show(colValueInvalidError);
                    return;
                }

                _setting.Col = col;
                _setting.Row = row;

            }
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var settingJson = JsonConvert.SerializeObject(_setting);
            File.WriteAllText(@"../../settings.json", settingJson);
        }

        private void settings_ColorButton_Click(object sender, EventArgs e)
        {
            Settings_ColorPanel.Show();
            settings_ShapesPanel.Hide();
            settings_DifficultyLevelPanel.Hide();
            Settings_ColorPanel.BringToFront();
        }
    }
}
