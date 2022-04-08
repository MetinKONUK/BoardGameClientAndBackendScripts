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
    }
}
