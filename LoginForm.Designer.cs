namespace main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.login_leftPanel = new System.Windows.Forms.Panel();
            this.Login_TogglePasswordVisibilityCheckBox = new System.Windows.Forms.CheckBox();
            this.LoginForm_MultiplayerModeCheckBox = new System.Windows.Forms.CheckBox();
            this.Login_RegisterLabel = new System.Windows.Forms.Label();
            this.Login_HaveAnAccountLabel = new System.Windows.Forms.Label();
            this.login_passwordLabel = new System.Windows.Forms.Label();
            this.login_usernameLabel = new System.Windows.Forms.Label();
            this.login_loginButton = new System.Windows.Forms.Button();
            this.login_passwordTextBox = new System.Windows.Forms.TextBox();
            this.login_usernameTextBox = new System.Windows.Forms.TextBox();
            this.Login_ImagePanel = new System.Windows.Forms.Panel();
            this.LoginForm_ExitButton = new System.Windows.Forms.Button();
            this.login_leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_leftPanel
            // 
            this.login_leftPanel.Controls.Add(this.LoginForm_ExitButton);
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
            this.login_leftPanel.Size = new System.Drawing.Size(256, 505);
            this.login_leftPanel.TabIndex = 0;
            // 
            // Login_TogglePasswordVisibilityCheckBox
            // 
            this.Login_TogglePasswordVisibilityCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Login_TogglePasswordVisibilityCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.Login_TogglePasswordVisibilityCheckBox.AutoSize = true;
            this.Login_TogglePasswordVisibilityCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_TogglePasswordVisibilityCheckBox.Font = new System.Drawing.Font("Times New Roman", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Login_TogglePasswordVisibilityCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Login_TogglePasswordVisibilityCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Login_TogglePasswordVisibilityCheckBox.Location = new System.Drawing.Point(183, 199);
            this.Login_TogglePasswordVisibilityCheckBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.Login_TogglePasswordVisibilityCheckBox.Name = "Login_TogglePasswordVisibilityCheckBox";
            this.Login_TogglePasswordVisibilityCheckBox.Size = new System.Drawing.Size(40, 24);
            this.Login_TogglePasswordVisibilityCheckBox.TabIndex = 0;
            this.Login_TogglePasswordVisibilityCheckBox.TabStop = false;
            this.Login_TogglePasswordVisibilityCheckBox.Text = "show";
            this.Login_TogglePasswordVisibilityCheckBox.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Login_TogglePasswordVisibilityCheckBox.UseVisualStyleBackColor = true;
            this.Login_TogglePasswordVisibilityCheckBox.CheckedChanged += new System.EventHandler(this.Login_TogglePasswordVisibilityCheckBox_CheckedChanged);
            // 
            // LoginForm_MultiplayerModeCheckBox
            // 
            this.LoginForm_MultiplayerModeCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginForm_MultiplayerModeCheckBox.AutoSize = true;
            this.LoginForm_MultiplayerModeCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginForm_MultiplayerModeCheckBox.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginForm_MultiplayerModeCheckBox.Location = new System.Drawing.Point(28, 255);
            this.LoginForm_MultiplayerModeCheckBox.Name = "LoginForm_MultiplayerModeCheckBox";
            this.LoginForm_MultiplayerModeCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LoginForm_MultiplayerModeCheckBox.Size = new System.Drawing.Size(112, 18);
            this.LoginForm_MultiplayerModeCheckBox.TabIndex = 0;
            this.LoginForm_MultiplayerModeCheckBox.TabStop = false;
            this.LoginForm_MultiplayerModeCheckBox.Text = ":Multiplayer Mode";
            this.LoginForm_MultiplayerModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // Login_RegisterLabel
            // 
            this.Login_RegisterLabel.AutoSize = true;
            this.Login_RegisterLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_RegisterLabel.Font = new System.Drawing.Font("Times New Roman", 7F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_RegisterLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Login_RegisterLabel.Location = new System.Drawing.Point(170, 367);
            this.Login_RegisterLabel.Name = "Login_RegisterLabel";
            this.Login_RegisterLabel.Size = new System.Drawing.Size(39, 11);
            this.Login_RegisterLabel.TabIndex = 0;
            this.Login_RegisterLabel.Text = "Register";
            this.Login_RegisterLabel.Click += new System.EventHandler(this.Login_RegisterLabel_Click);
            // 
            // Login_HaveAnAccountLabel
            // 
            this.Login_HaveAnAccountLabel.AutoSize = true;
            this.Login_HaveAnAccountLabel.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Login_HaveAnAccountLabel.Location = new System.Drawing.Point(26, 368);
            this.Login_HaveAnAccountLabel.Name = "Login_HaveAnAccountLabel";
            this.Login_HaveAnAccountLabel.Size = new System.Drawing.Size(104, 12);
            this.Login_HaveAnAccountLabel.TabIndex = 0;
            this.Login_HaveAnAccountLabel.Text = "Don\'t Have An Account?";
            // 
            // login_passwordLabel
            // 
            this.login_passwordLabel.AutoSize = true;
            this.login_passwordLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login_passwordLabel.Location = new System.Drawing.Point(87, 182);
            this.login_passwordLabel.Name = "login_passwordLabel";
            this.login_passwordLabel.Size = new System.Drawing.Size(71, 15);
            this.login_passwordLabel.TabIndex = 0;
            this.login_passwordLabel.Text = "PASSWORD";
            // 
            // login_usernameLabel
            // 
            this.login_usernameLabel.AutoSize = true;
            this.login_usernameLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_usernameLabel.Location = new System.Drawing.Point(86, 96);
            this.login_usernameLabel.Name = "login_usernameLabel";
            this.login_usernameLabel.Size = new System.Drawing.Size(74, 15);
            this.login_usernameLabel.TabIndex = 0;
            this.login_usernameLabel.Text = "USERNAME";
            // 
            // login_loginButton
            // 
            this.login_loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login_loginButton.AutoSize = true;
            this.login_loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_loginButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login_loginButton.Location = new System.Drawing.Point(28, 307);
            this.login_loginButton.Name = "login_loginButton";
            this.login_loginButton.Size = new System.Drawing.Size(181, 26);
            this.login_loginButton.TabIndex = 5;
            this.login_loginButton.Text = "Log In";
            this.login_loginButton.UseVisualStyleBackColor = true;
            this.login_loginButton.Click += new System.EventHandler(this.Login_loginButton_Click);
            // 
            // login_passwordTextBox
            // 
            this.login_passwordTextBox.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.login_passwordTextBox.Location = new System.Drawing.Point(28, 200);
            this.login_passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.login_passwordTextBox.Name = "login_passwordTextBox";
            this.login_passwordTextBox.PasswordChar = '*';
            this.login_passwordTextBox.Size = new System.Drawing.Size(155, 20);
            this.login_passwordTextBox.TabIndex = 2;
            // 
            // login_usernameTextBox
            // 
            this.login_usernameTextBox.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.login_usernameTextBox.Location = new System.Drawing.Point(28, 114);
            this.login_usernameTextBox.Name = "login_usernameTextBox";
            this.login_usernameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.login_usernameTextBox.Size = new System.Drawing.Size(197, 20);
            this.login_usernameTextBox.TabIndex = 1;
            this.login_usernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_usernameTextBox_KeyPress);
            // 
            // Login_ImagePanel
            // 
            this.Login_ImagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login_ImagePanel.Location = new System.Drawing.Point(256, 0);
            this.Login_ImagePanel.Name = "Login_ImagePanel";
            this.Login_ImagePanel.Size = new System.Drawing.Size(685, 505);
            this.Login_ImagePanel.TabIndex = 1;
            // 
            // LoginForm_ExitButton
            // 
            this.LoginForm_ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginForm_ExitButton.AutoSize = true;
            this.LoginForm_ExitButton.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.LoginForm_ExitButton.Location = new System.Drawing.Point(0, 481);
            this.LoginForm_ExitButton.Name = "LoginForm_ExitButton";
            this.LoginForm_ExitButton.Size = new System.Drawing.Size(256, 24);
            this.LoginForm_ExitButton.TabIndex = 6;
            this.LoginForm_ExitButton.Text = "Exit";
            this.LoginForm_ExitButton.UseVisualStyleBackColor = true;
            this.LoginForm_ExitButton.Click += new System.EventHandler(this.LoginForm_ExitButton_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.login_loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 505);
            this.Controls.Add(this.Login_ImagePanel);
            this.Controls.Add(this.login_leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button LoginForm_ExitButton;
    }
}

