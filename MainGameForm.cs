﻿using System;
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
            //MainGameWindowGamePanel.Location = new Point(
            //this.ClientSize.Width / 2 - MainGameWindowGamePanel.Size.Width / 2,
            //this.ClientSize.Height / 2 - MainGameWindowGamePanel.Size.Height / 2);
            //MainGameWindowGamePanel.Anchor = AnchorStyles.None;


            Controls.Add(MainGameWindowGamePanel);
            MainGameForm_BestScoreDynamicLabel.Text = UserBase.GetUsers()[UserBase.GetCurrentUser()].BestScore.ToString();
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
            MainGameForm_BestScoreDynamicLabel.Text = UserBase.GetUsers()[UserBase.GetCurrentUser()].BestScore.ToString();
        }
    }
}
