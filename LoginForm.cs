using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace main
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public Users Users = new Users();
        private void login_loginButton_Click(object sender, EventArgs e)
        {
            const string userDoesNotExistErrorMessage = "User does not exist!";
            const string passwordInvalidErrorMessage = "Invalid Password!";
            const string accessGranted = "Access Granted!";

            var username = login_usernameTextBox.Text;
            var password = login_passwordTextBox.Text;
            
            if (!Users.users.ContainsKey(username))
            {
                MessageBox.Show(userDoesNotExistErrorMessage);
            }
            else if(Users.users[username] != password)
            {
                MessageBox.Show(passwordInvalidErrorMessage);
            }
            else
            {
                MessageBox.Show(accessGranted);
                var mainGameWindow = new MainGameForm();
                this.Hide();
                mainGameWindow.ShowDialog();
            }

            
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            login_usernameTextBox.Focus();
        }
    }
}
