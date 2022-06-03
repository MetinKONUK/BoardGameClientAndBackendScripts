
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGameForm));
            this.mainGameWindow_UpPanel = new System.Windows.Forms.Panel();
            this.MainGameForm_BestScoreTextLabel = new System.Windows.Forms.Label();
            this.AboutButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.MainGameWindow_ProfileButton = new System.Windows.Forms.Button();
            this.mainGameWindow_SettingsButton = new System.Windows.Forms.Button();
            this.MainGameWindow_ExitButton = new System.Windows.Forms.Button();
            this.mainGameWindow_UpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainGameWindow_UpPanel
            // 
            this.mainGameWindow_UpPanel.Controls.Add(this.MainGameWindow_ExitButton);
            this.mainGameWindow_UpPanel.Controls.Add(this.MainGameForm_BestScoreTextLabel);
            this.mainGameWindow_UpPanel.Controls.Add(this.AboutButton);
            this.mainGameWindow_UpPanel.Controls.Add(this.HelpButton);
            this.mainGameWindow_UpPanel.Controls.Add(this.MainGameWindow_ProfileButton);
            this.mainGameWindow_UpPanel.Controls.Add(this.mainGameWindow_SettingsButton);
            this.mainGameWindow_UpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainGameWindow_UpPanel.Location = new System.Drawing.Point(0, 0);
            this.mainGameWindow_UpPanel.Name = "mainGameWindow_UpPanel";
            this.mainGameWindow_UpPanel.Size = new System.Drawing.Size(984, 50);
            this.mainGameWindow_UpPanel.TabIndex = 0;
            // 
            // MainGameForm_BestScoreTextLabel
            // 
            this.MainGameForm_BestScoreTextLabel.AutoSize = true;
            this.MainGameForm_BestScoreTextLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainGameForm_BestScoreTextLabel.Location = new System.Drawing.Point(3, 14);
            this.MainGameForm_BestScoreTextLabel.Name = "MainGameForm_BestScoreTextLabel";
            this.MainGameForm_BestScoreTextLabel.Size = new System.Drawing.Size(97, 22);
            this.MainGameForm_BestScoreTextLabel.TabIndex = 1;
            this.MainGameForm_BestScoreTextLabel.Text = "Best Score:";
            // 
            // AboutButton
            // 
            this.AboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.AboutButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.Location = new System.Drawing.Point(586, 0);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(99, 50);
            this.AboutButton.TabIndex = 1;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.HelpButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton.Location = new System.Drawing.Point(685, 0);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(101, 50);
            this.HelpButton.TabIndex = 2;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // MainGameWindow_ProfileButton
            // 
            this.MainGameWindow_ProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainGameWindow_ProfileButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainGameWindow_ProfileButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainGameWindow_ProfileButton.Location = new System.Drawing.Point(786, 0);
            this.MainGameWindow_ProfileButton.Name = "MainGameWindow_ProfileButton";
            this.MainGameWindow_ProfileButton.Size = new System.Drawing.Size(99, 50);
            this.MainGameWindow_ProfileButton.TabIndex = 3;
            this.MainGameWindow_ProfileButton.Text = "Profile";
            this.MainGameWindow_ProfileButton.UseVisualStyleBackColor = true;
            this.MainGameWindow_ProfileButton.Click += new System.EventHandler(this.MainGameWindow_ProfileButton_Click);
            // 
            // mainGameWindow_SettingsButton
            // 
            this.mainGameWindow_SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainGameWindow_SettingsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainGameWindow_SettingsButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainGameWindow_SettingsButton.Location = new System.Drawing.Point(885, 0);
            this.mainGameWindow_SettingsButton.Name = "mainGameWindow_SettingsButton";
            this.mainGameWindow_SettingsButton.Size = new System.Drawing.Size(99, 50);
            this.mainGameWindow_SettingsButton.TabIndex = 4;
            this.mainGameWindow_SettingsButton.Text = "Settings";
            this.mainGameWindow_SettingsButton.UseVisualStyleBackColor = true;
            this.mainGameWindow_SettingsButton.Click += new System.EventHandler(this.mainGameWindow_SettingsButton_Click);
            // 
            // MainGameWindow_ExitButton
            // 
            this.MainGameWindow_ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainGameWindow_ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainGameWindow_ExitButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainGameWindow_ExitButton.Location = new System.Drawing.Point(487, 0);
            this.MainGameWindow_ExitButton.Name = "MainGameWindow_ExitButton";
            this.MainGameWindow_ExitButton.Size = new System.Drawing.Size(99, 50);
            this.MainGameWindow_ExitButton.TabIndex = 0;
            this.MainGameWindow_ExitButton.Text = "Exit";
            this.MainGameWindow_ExitButton.UseVisualStyleBackColor = true;
            this.MainGameWindow_ExitButton.Click += new System.EventHandler(this.MainGameWindow_ExitButton_Click);
            // 
            // MainGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.mainGameWindow_UpPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Board Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainGameForm_FormClosed);
            this.Load += new System.EventHandler(this.MainGameForm_Load);
            this.mainGameWindow_UpPanel.ResumeLayout(false);
            this.mainGameWindow_UpPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainGameWindow_UpPanel;
        private System.Windows.Forms.Button mainGameWindow_SettingsButton;
        private System.Windows.Forms.Button MainGameWindow_ProfileButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Label MainGameForm_BestScoreTextLabel;
        private System.Windows.Forms.Button MainGameWindow_ExitButton;
    }
}