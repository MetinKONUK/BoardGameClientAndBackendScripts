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
    public partial class MultiplayerGameForm : Form
    {
        public static MultiplayerGameForm GameFormInstance;
        public Panel GameFormLowerPanel;
        public MultiplayerGameForm()
        {
            InitializeComponent();
            //FormBorderStyle = FormBorderStyle.None;
            Control.CheckForIllegalCrossThreadCalls = false;
            GameFormInstance = this;
            WindowState = FormWindowState.Maximized;
            GameFormLowerPanel = new Panel
            {
                Dock = DockStyle.Fill
            };
            Controls.Add(GameFormLowerPanel);

        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            UserBase.GetUsers()[UserBase.CurrentUser].OpponentUsername = OpponentUsernameTextBox.Text;
            var OpponentUsername = OpponentUsernameTextBox.Text;
            MultiplayerBoard.SetOpponent(OpponentUsername);
        }

        private void MultiplayerGameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MultiplayerBoard.Disconnect();
            var loginWindow = new LoginForm();
            this.Hide();
            loginWindow.ShowDialog();
        }
    }
}
