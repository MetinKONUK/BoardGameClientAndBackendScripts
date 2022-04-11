
namespace main
{
    partial class MainGameForm
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
            this.mainGameWindow_UpPanel = new System.Windows.Forms.Panel();
            this.MainGameWindow_ProfileButton = new System.Windows.Forms.Button();
            this.mainGameWindow_SettingsButton = new System.Windows.Forms.Button();
            this.MainGame_AboutButton = new System.Windows.Forms.Button();
            this.mainGameWindow_UpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainGameWindow_UpPanel
            // 
            this.mainGameWindow_UpPanel.Controls.Add(this.MainGame_AboutButton);
            this.mainGameWindow_UpPanel.Controls.Add(this.MainGameWindow_ProfileButton);
            this.mainGameWindow_UpPanel.Controls.Add(this.mainGameWindow_SettingsButton);
            this.mainGameWindow_UpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainGameWindow_UpPanel.Location = new System.Drawing.Point(0, 0);
            this.mainGameWindow_UpPanel.Name = "mainGameWindow_UpPanel";
            this.mainGameWindow_UpPanel.Size = new System.Drawing.Size(800, 40);
            this.mainGameWindow_UpPanel.TabIndex = 0;
            // 
            // MainGameWindow_ProfileButton
            // 
            this.MainGameWindow_ProfileButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainGameWindow_ProfileButton.Location = new System.Drawing.Point(602, 0);
            this.MainGameWindow_ProfileButton.Name = "MainGameWindow_ProfileButton";
            this.MainGameWindow_ProfileButton.Size = new System.Drawing.Size(99, 40);
            this.MainGameWindow_ProfileButton.TabIndex = 1;
            this.MainGameWindow_ProfileButton.Text = "Profile";
            this.MainGameWindow_ProfileButton.UseVisualStyleBackColor = true;
            this.MainGameWindow_ProfileButton.Click += new System.EventHandler(this.MainGameWindow_ProfileButton_Click);
            // 
            // mainGameWindow_SettingsButton
            // 
            this.mainGameWindow_SettingsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainGameWindow_SettingsButton.Location = new System.Drawing.Point(701, 0);
            this.mainGameWindow_SettingsButton.Name = "mainGameWindow_SettingsButton";
            this.mainGameWindow_SettingsButton.Size = new System.Drawing.Size(99, 40);
            this.mainGameWindow_SettingsButton.TabIndex = 0;
            this.mainGameWindow_SettingsButton.Text = "Settings";
            this.mainGameWindow_SettingsButton.UseVisualStyleBackColor = true;
            this.mainGameWindow_SettingsButton.Click += new System.EventHandler(this.mainGameWindow_SettingsButton_Click);
            // 
            // MainGame_AboutButton
            // 
            this.MainGame_AboutButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainGame_AboutButton.Location = new System.Drawing.Point(503, 0);
            this.MainGame_AboutButton.Name = "MainGame_AboutButton";
            this.MainGame_AboutButton.Size = new System.Drawing.Size(99, 40);
            this.MainGame_AboutButton.TabIndex = 2;
            this.MainGame_AboutButton.Text = "About";
            this.MainGame_AboutButton.UseVisualStyleBackColor = true;
            this.MainGame_AboutButton.Click += new System.EventHandler(this.MainGame_AboutButton_Click);
            // 
            // MainGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainGameWindow_UpPanel);
            this.Name = "MainGameForm";
            this.Text = "Board Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainGameForm_FormClosed);
            this.mainGameWindow_UpPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainGameWindow_UpPanel;
        private System.Windows.Forms.Button mainGameWindow_SettingsButton;
        private System.Windows.Forms.Button MainGameWindow_ProfileButton;
        private System.Windows.Forms.Button MainGame_AboutButton;
    }
}