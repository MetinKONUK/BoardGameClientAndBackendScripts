﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Newtonsoft.Json;

namespace main
{
    public partial class LoginForm : Form
    {
        private readonly SucceededLoginLogs _succeededLoginLogs = new SucceededLoginLogs
                                                  {
                                                      Username = "",
                                                  };


        Rectangle screen = Screen.PrimaryScreen.WorkingArea;
        public LoginForm()
        {
            InitializeComponent();
            this.Size = new Size(screen.Width* 7 / 10, screen.Height* 3 / 4);
            Login_ImagePanel.BackgroundImage = Image.FromFile(@"../../LoginPageImage.jpg");
            Login_ImagePanel.BackgroundImageLayout = ImageLayout.Stretch;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Login_loginButton_Click(object sender, EventArgs e)
        {
            const string userDoesNotExistErrorMessage = "User does not exist!";
            const string passwordInvalidErrorMessage = "Invalid Password!";

            var username = login_usernameTextBox.Text;
            var password = login_passwordTextBox.Text;
            password = Sha2.Sha256Hash(password);
            UserBase.SetAdmins();
            UserBase.SetCurrentUser(username);
            var admins = UserBase.GetAdmins();

            if (admins.ContainsKey(username))
            {
                //MessageBox.Show(@"Admin type user");
                if (admins[username].Password != password)
                {
                    MessageBox.Show(passwordInvalidErrorMessage);
                }
                else
                {
                    //MessageBox.Show(accessGranted);
                    UserBase.SetCurrentUser(username);
                    UserBase.IsCurrentUserAdmin = true;
                    _succeededLoginLogs.Username = username;
                    var succeededLoginLogs = JsonConvert.SerializeObject(_succeededLoginLogs);
                    File.WriteAllText(@"../../succeededLoginLogs.json", succeededLoginLogs);
                    var adminPanelWindow = new AdminPanelForm();
                    this.Hide();
                    adminPanelWindow.ShowDialog();
                }
            }
            else
            {
                UserBase.SetUsers();
                var users = UserBase.GetUsers();
                if (users.ContainsKey(username))
                {
                    //MessageBox.Show(@"User type user");
                    if (users[username].Password != password)
                    {
                        MessageBox.Show(passwordInvalidErrorMessage);
                    }
                    else
                    {
                        //MessageBox.Show(accessGranted);
                        UserBase.SetCurrentUser(username);
                        _succeededLoginLogs.Username = username;
                        var succeededLoginLogs = JsonConvert.SerializeObject(_succeededLoginLogs);
                        File.WriteAllText(@"../../succeededLoginLogs.json", succeededLoginLogs);
                        if(LoginForm_MultiplayerModeCheckBox.Checked == true)
                        {
                            try
                            {
                                var multiplayerGameForm = new MultiplayerGameForm();
                                MultiplayerBoard.Connect();
                                this.Hide();
                                multiplayerGameForm.ShowDialog();
                            }
                            catch
                            {
                                MessageBox.Show("An error occured while connecting to server...");
                            }
                        } 
                        else
                        {
                            var mainGameWindow = new MainGameForm();
                            this.Hide();
                            mainGameWindow.ShowDialog();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(userDoesNotExistErrorMessage);
                }
            }
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            login_usernameTextBox.Focus();
        }

        private void Login_usernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var isLetter = char.IsLetter(e.KeyChar);
            var isControl = char.IsControl(e.KeyChar);

            if (!isLetter && !isControl)
            {
                e.Handled = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            var succeededLoginLogJson = File.ReadAllText(@"../../succeededLoginLogs.json");
            var succeededLoginLog = JsonConvert.DeserializeObject<SucceededLoginLogs>(succeededLoginLogJson);
            if (succeededLoginLog != null)
            {
                var lastUsername = succeededLoginLog.Username;
                login_usernameTextBox.Text = lastUsername;
            }
        }

        private void Login_TogglePasswordVisibilityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Login_TogglePasswordVisibilityCheckBox.Text = Login_TogglePasswordVisibilityCheckBox.Checked ? "Hide" : "Show";

            login_passwordTextBox.PasswordChar = Login_TogglePasswordVisibilityCheckBox.Checked ? '\0' : '*';
        }

        private void Login_RegisterLabel_Click(object sender, EventArgs e)
        {
            var registerWindow = new RegisterForm();
            this.Hide();
            registerWindow.ShowDialog();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
