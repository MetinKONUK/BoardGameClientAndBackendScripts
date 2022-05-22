using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace main
{
    public partial class MainGameForm : Form
    {
        public static MainGameForm MainGameFormInstance;
        public        Panel        MainGameWindowGamePanel;

        public MainGameForm()
        {
            InitializeComponent();
            MainGameFormInstance = this;
            UserBase.SetSettings();
            //FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            MainGameWindowGamePanel = new Panel
                                      {
                                          Dock = DockStyle.Fill
                                      };
            Controls.Add(MainGameWindowGamePanel);
        }

        private void MainGameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var loginWindow = new LoginForm();
            this.Hide();
            loginWindow.ShowDialog();
            Board.ClearPanel(MainGameWindowGamePanel);
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
            Board.SetRowCol();
            Board.SetBoard();
            Board.ShowBoard();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            var helpWindow = new HelpForm();
            helpWindow.ShowDialog();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}
