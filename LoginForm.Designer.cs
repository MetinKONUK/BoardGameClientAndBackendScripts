﻿namespace main
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_leftPanel = new System.Windows.Forms.Panel();
            this.LoginForm_MultiplayerModeCheckBox = new System.Windows.Forms.CheckBox();
            this.Login_RegisterLabel = new System.Windows.Forms.Label();
            this.Login_HaveAnAccountLabel = new System.Windows.Forms.Label();
            this.Login_TogglePasswordVisibilityCheckBox = new System.Windows.Forms.CheckBox();
            this.login_passwordLabel = new System.Windows.Forms.Label();
            this.login_usernameLabel = new System.Windows.Forms.Label();
            this.login_loginButton = new System.Windows.Forms.Button();
            this.login_passwordTextBox = new System.Windows.Forms.TextBox();
            this.login_usernameTextBox = new System.Windows.Forms.TextBox();
            this.Login_ImagePanel = new System.Windows.Forms.Panel();
            this.login_leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_leftPanel
            // 
            this.login_leftPanel.Controls.Add(this.Login_TogglePasswordVisibilityCheckBox);
            this.login_leftPanel.Controls.Add(this.LoginForm_MultiplayerModeCheckBox);
            this.login_leftPanel.Controls.Add(this.Login_RegisterLabel);
            this.login_leftPanel.Controls.Add(this.Login_HaveAnAccountLabel);
            this.login_leftPanel.Controls.Add(this.login_passwordLabel);
            this.login_leftPanel.Controls.Add(this.login_usernameLabel);
            this.login_leftPanel.Controls.Add(this.login_loginButton);
            this.login_leftPanel.Controls.Add(this.login_passwordTextBox);
            this.login_leftPanel.Controls.Add(this.login_usernameTextBox);
            this.login_leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.login_leftPanel.Location = new System.Drawing.Point(0, 0);
            this.login_leftPanel.Name = "login_leftPanel";
            this.login_leftPanel.Size = new System.Drawing.Size(231, 374);
            this.login_leftPanel.TabIndex = 0;
            // 
            // LoginForm_MultiplayerModeCheckBox
            // 
            this.LoginForm_MultiplayerModeCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginForm_MultiplayerModeCheckBox.AutoSize = true;
            this.LoginForm_MultiplayerModeCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginForm_MultiplayerModeCheckBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginForm_MultiplayerModeCheckBox.Location = new System.Drawing.Point(-3, 146);
            this.LoginForm_MultiplayerModeCheckBox.Name = "LoginForm_MultiplayerModeCheckBox";
            this.LoginForm_MultiplayerModeCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LoginForm_MultiplayerModeCheckBox.Size = new System.Drawing.Size(131, 20);
            this.LoginForm_MultiplayerModeCheckBox.TabIndex = 0;
            this.LoginForm_MultiplayerModeCheckBox.TabStop = false;
            this.LoginForm_MultiplayerModeCheckBox.Text = ":Multiplayer Mode";
            this.LoginForm_MultiplayerModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // Login_RegisterLabel
            // 
            this.Login_RegisterLabel.AutoSize = true;
            this.Login_RegisterLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_RegisterLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_RegisterLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Login_RegisterLabel.Location = new System.Drawing.Point(178, 261);
            this.Login_RegisterLabel.Name = "Login_RegisterLabel";
            this.Login_RegisterLabel.Size = new System.Drawing.Size(53, 16);
            this.Login_RegisterLabel.TabIndex = 0;
            this.Login_RegisterLabel.Text = "Register";
            this.Login_RegisterLabel.Click += new System.EventHandler(this.Login_RegisterLabel_Click);
            // 
            // Login_HaveAnAccountLabel
            // 
            this.Login_HaveAnAccountLabel.AutoSize = true;
            this.Login_HaveAnAccountLabel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Login_HaveAnAccountLabel.Location = new System.Drawing.Point(3, 258);
            this.Login_HaveAnAccountLabel.Name = "Login_HaveAnAccountLabel";
            this.Login_HaveAnAccountLabel.Size = new System.Drawing.Size(175, 19);
            this.Login_HaveAnAccountLabel.TabIndex = 0;
            this.Login_HaveAnAccountLabel.Text = "Don\'t Have An Account?";
            // 
            // Login_TogglePasswordVisibilityCheckBox
            // 
            this.Login_TogglePasswordVisibilityCheckBox.AutoSize = true;
            this.Login_TogglePasswordVisibilityCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_TogglePasswordVisibilityCheckBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Login_TogglePasswordVisibilityCheckBox.Location = new System.Drawing.Point(177, 107);
            this.Login_TogglePasswordVisibilityCheckBox.Name = "Login_TogglePasswordVisibilityCheckBox";
            this.Login_TogglePasswordVisibilityCheckBox.Size = new System.Drawing.Size(54, 20);
            this.Login_TogglePasswordVisibilityCheckBox.TabIndex = 0;
            this.Login_TogglePasswordVisibilityCheckBox.TabStop = false;
            this.Login_TogglePasswordVisibilityCheckBox.Text = "show";
            this.Login_TogglePasswordVisibilityCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Login_TogglePasswordVisibilityCheckBox.UseVisualStyleBackColor = true;
            this.Login_TogglePasswordVisibilityCheckBox.CheckedChanged += new System.EventHandler(this.Login_TogglePasswordVisibilityCheckBox_CheckedChanged);
            // 
            // login_passwordLabel
            // 
            this.login_passwordLabel.AutoSize = true;
            this.login_passwordLabel.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login_passwordLabel.Location = new System.Drawing.Point(3, 89);
            this.login_passwordLabel.Name = "login_passwordLabel";
            this.login_passwordLabel.Size = new System.Drawing.Size(72, 15);
            this.login_passwordLabel.TabIndex = 0;
            this.login_passwordLabel.Text = "PASSWORD";
            // 
            // login_usernameLabel
            // 
            this.login_usernameLabel.AutoSize = true;
            this.login_usernameLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_usernameLabel.Location = new System.Drawing.Point(2, 35);
            this.login_usernameLabel.Name = "login_usernameLabel";
            this.login_usernameLabel.Size = new System.Drawing.Size(73, 15);
            this.login_usernameLabel.TabIndex = 0;
            this.login_usernameLabel.Text = "USERNAME";
            // 
            // login_loginButton
            // 
            this.login_loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_loginButton.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_loginButton.Location = new System.Drawing.Point(0, 188);
            this.login_loginButton.Name = "login_loginButton";
            this.login_loginButton.Size = new System.Drawing.Size(231, 35);
            this.login_loginButton.TabIndex = 5;
            this.login_loginButton.Text = "Log In";
            this.login_loginButton.UseVisualStyleBackColor = true;
            this.login_loginButton.Click += new System.EventHandler(this.Login_loginButton_Click);
            // 
            // login_passwordTextBox
            // 
            this.login_passwordTextBox.Location = new System.Drawing.Point(-3, 107);
            this.login_passwordTextBox.Name = "login_passwordTextBox";
            this.login_passwordTextBox.PasswordChar = '*';
            this.login_passwordTextBox.Size = new System.Drawing.Size(231, 20);
            this.login_passwordTextBox.TabIndex = 2;
            // 
            // login_usernameTextBox
            // 
            this.login_usernameTextBox.Location = new System.Drawing.Point(-3, 53);
            this.login_usernameTextBox.Name = "login_usernameTextBox";
            this.login_usernameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.login_usernameTextBox.Size = new System.Drawing.Size(231, 20);
            this.login_usernameTextBox.TabIndex = 1;
            this.login_usernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_usernameTextBox_KeyPress);
            // 
            // Login_ImagePanel
            // 
            this.Login_ImagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login_ImagePanel.Location = new System.Drawing.Point(231, 0);
            this.Login_ImagePanel.Name = "Login_ImagePanel";
            this.Login_ImagePanel.Size = new System.Drawing.Size(514, 374);
            this.Login_ImagePanel.TabIndex = 1;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.login_loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 374);
            this.Controls.Add(this.Login_ImagePanel);
            this.Controls.Add(this.login_leftPanel);
            this.Name = "LoginForm";
            this.Text = "Log In";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Shown += new System.EventHandler(this.LoginForm_Shown);
            this.login_leftPanel.ResumeLayout(false);
            this.login_leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel login_leftPanel;
        private System.Windows.Forms.TextBox login_passwordTextBox;
        private System.Windows.Forms.TextBox login_usernameTextBox;
        private System.Windows.Forms.Button login_loginButton;
        private System.Windows.Forms.Label login_passwordLabel;
        private System.Windows.Forms.Label login_usernameLabel;
        private System.Windows.Forms.CheckBox Login_TogglePasswordVisibilityCheckBox;
        private System.Windows.Forms.Label Login_RegisterLabel;
        private System.Windows.Forms.Label Login_HaveAnAccountLabel;
        private System.Windows.Forms.Panel Login_ImagePanel;
        private System.Windows.Forms.CheckBox LoginForm_MultiplayerModeCheckBox;
    }
}

