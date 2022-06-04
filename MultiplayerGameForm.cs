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
        Rectangle screen = Screen.PrimaryScreen.WorkingArea;
        public static MultiplayerGameForm GameFormInstance;
        public Panel GameFormLowerPanel;
        public MultiplayerGameForm()
        {
            InitializeComponent();
            this.Size = new Size(screen.Width * 7 / 10, screen.Height * 3 / 4);
            this.FormBorderStyle = FormBorderStyle.None;
            GameFormInstance = this;
            Control.CheckForIllegalCrossThreadCalls = false;
            GameFormLowerPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Location = new Point(0, UpPanel.Height),
                Size = new Size(this.Width, this.Height - UpPanel.Height),
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
            try
            {
                MultiplayerBoard.Disconnect();
            }
            catch
            {
                MessageBox.Show("An error occured while disconnecting from server...");
            }
            var loginWindow = new LoginForm();
            this.Hide();
            loginWindow.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
