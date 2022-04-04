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
using Newtonsoft.Json;
using System.IO;




namespace main
{
    public partial class LoginForm : Form
    {

        private lastSuccess lastSuccess= new lastSuccess
                                   {
                                    username = "placeholder"
                                   };
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
                MessageBox.Show(Users.users[username]);

                lastSuccess.username = Users.users[username];
                var settingJson = JsonConvert.SerializeObject(lastSuccess);
                File.WriteAllText(@"../../user.json", settingJson);


                var mainGameWindow = new MainGameForm();
                this.Hide();
                mainGameWindow.ShowDialog();

            }

            
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            login_usernameTextBox.Focus();
        }

        private void login_usernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            var lastSuccessJson = File.ReadAllText(@"../../user.json");
            var lastSuccess = JsonConvert.DeserializeObject<lastSuccess>(lastSuccessJson);
            login_usernameTextBox.Text = lastSuccess.username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login_passwordTextBox.PasswordChar != '\0')
            {
            login_passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                login_passwordTextBox.PasswordChar = '*';
            }
        }
    }
}
