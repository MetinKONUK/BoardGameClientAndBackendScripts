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
            this.login_leftPanel = new System.Windows.Forms.Panel();
            this.login_passwordLabel = new System.Windows.Forms.Label();
            this.login_usernameLabel = new System.Windows.Forms.Label();
            this.login_loginButton = new System.Windows.Forms.Button();
            this.login_passwordTextBox = new System.Windows.Forms.TextBox();
            this.login_usernameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.login_leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_leftPanel
            // 
            this.login_leftPanel.Controls.Add(this.button1);
            this.login_leftPanel.Controls.Add(this.login_passwordLabel);
            this.login_leftPanel.Controls.Add(this.login_usernameLabel);
            this.login_leftPanel.Controls.Add(this.login_loginButton);
            this.login_leftPanel.Controls.Add(this.login_passwordTextBox);
            this.login_leftPanel.Controls.Add(this.login_usernameTextBox);
            this.login_leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.login_leftPanel.Location = new System.Drawing.Point(0, 0);
            this.login_leftPanel.Name = "login_leftPanel";
            this.login_leftPanel.Size = new System.Drawing.Size(170, 450);
            this.login_leftPanel.TabIndex = 0;
            // 
            // login_passwordLabel
            // 
            this.login_passwordLabel.AutoSize = true;
            this.login_passwordLabel.Location = new System.Drawing.Point(12, 176);
            this.login_passwordLabel.Name = "login_passwordLabel";
            this.login_passwordLabel.Size = new System.Drawing.Size(52, 13);
            this.login_passwordLabel.TabIndex = 5;
            this.login_passwordLabel.Text = "password";
            // 
            // login_usernameLabel
            // 
            this.login_usernameLabel.AutoSize = true;
            this.login_usernameLabel.Location = new System.Drawing.Point(12, 137);
            this.login_usernameLabel.Name = "login_usernameLabel";
            this.login_usernameLabel.Size = new System.Drawing.Size(53, 13);
            this.login_usernameLabel.TabIndex = 4;
            this.login_usernameLabel.Text = "username";
            // 
            // login_loginButton
            // 
            this.login_loginButton.Location = new System.Drawing.Point(0, 239);
            this.login_loginButton.Name = "login_loginButton";
            this.login_loginButton.Size = new System.Drawing.Size(170, 35);
            this.login_loginButton.TabIndex = 3;
            this.login_loginButton.Text = "Log In";
            this.login_loginButton.UseVisualStyleBackColor = true;
            this.login_loginButton.Click += new System.EventHandler(this.login_loginButton_Click);
            // 
            // login_passwordTextBox
            // 
            this.login_passwordTextBox.Location = new System.Drawing.Point(0, 192);
            this.login_passwordTextBox.Name = "login_passwordTextBox";
            this.login_passwordTextBox.PasswordChar = '*';
            this.login_passwordTextBox.Size = new System.Drawing.Size(170, 20);
            this.login_passwordTextBox.TabIndex = 2;
            // 
            // login_usernameTextBox
            // 
            this.login_usernameTextBox.Location = new System.Drawing.Point(0, 153);
            this.login_usernameTextBox.Name = "login_usernameTextBox";
            this.login_usernameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.login_usernameTextBox.Size = new System.Drawing.Size(170, 20);
            this.login_usernameTextBox.TabIndex = 1;
            this.login_usernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_usernameTextBox_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.login_loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login_leftPanel);
            this.Name = "LoginForm";
            this.Text = "Log In";
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
        private System.Windows.Forms.Button button1;
    }
}

