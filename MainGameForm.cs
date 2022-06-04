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
        public Label BestScoreLabel;
        Rectangle screen = Screen.PrimaryScreen.WorkingArea;
        public MainGameForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            MainGameFormInstance = this;
            this.Size = new Size(screen.Width * 7 / 10, screen.Height * 3 / 4);
            
            UserBase.SetSettings();
            MainGameWindowGamePanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Location = new Point(0, mainGameWindow_UpPanel.Height),
                Size = new Size(this.Width, this.Height - mainGameWindow_UpPanel.Height),
                                      };
            Controls.Add(MainGameWindowGamePanel);

            //Add bestscore label
            BestScoreLabel = new Label
            {
                Text = "0",
                Font = new Font("Times New Roman; 14,25pt; style=Bold, Italic", 14),
                Location = new Point(106, 13),
                AutoSize = true
            };
            mainGameWindow_UpPanel.Controls.Add(BestScoreLabel);
            Board.UpdateBestScore();
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

        private void MainGameForm_RefreshBestScoreButton_Click(object sender, EventArgs e)
        {
            Board.UpdateBestScore();
        }

        private void MainGameWindow_ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
