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
    public partial class MainGameForm : Form
    {
        public MainGameForm()
        {
            InitializeComponent();
            UserBase.SetSettings();
        }

        private void MainGameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var loginWindow = new LoginForm();
            this.Hide();
            loginWindow.ShowDialog();
        }

        private void mainGameWindow_SettingsButton_Click(object sender, EventArgs e)
        {
            var settingsWindow = new SettingsForm();

            settingsWindow.ShowDialog();
        }

        private void MainGameWindow_ProfileButton_Click(object sender, EventArgs e)
        {
            var profileWindow = new ProfileForm();

            profileWindow.ShowDialog();
        }

        private void MainGameForm_Load(object sender, EventArgs e)
        {
            var n         = 0;
            var m         = 0;
            var diffLevel = UserBase.GetSettings()[UserBase.GetCurrentUser()].DifficultyLevel;
            MessageBox.Show(diffLevel.ToString());
            if (diffLevel == 0)
            {
                n = 6;
                m = 6;
            }
            else if (diffLevel == 1)
            {
                n = 9;
                m = 9;
            }
            else
            {
                n = 12;
                m = 12;
            }

            Board.SetBoard(n, m);
            Board.ShowBoard(MainGameWindow_GamePanel, n, m);
            Board.SetCellShape(0, 0, 2);

        }
    }
}
