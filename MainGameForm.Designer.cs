
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
            this.MainGameForm_RefreshBestScoreButton = new System.Windows.Forms.Button();
            this.MainGameForm_BestScoreDynamicLabel = new System.Windows.Forms.Label();
            this.MainGameForm_BestScoreTextLabel = new System.Windows.Forms.Label();
            this.AboutButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.MainGameWindow_ProfileButton = new System.Windows.Forms.Button();
            this.mainGameWindow_SettingsButton = new System.Windows.Forms.Button();
            this.mainGameWindow_UpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainGameWindow_UpPanel
            // 
            this.mainGameWindow_UpPanel.Controls.Add(this.MainGameForm_RefreshBestScoreButton);
            this.mainGameWindow_UpPanel.Controls.Add(this.MainGameForm_BestScoreDynamicLabel);
            this.mainGameWindow_UpPanel.Controls.Add(this.MainGameForm_BestScoreTextLabel);
            this.mainGameWindow_UpPanel.Controls.Add(this.AboutButton);
            this.mainGameWindow_UpPanel.Controls.Add(this.HelpButton);
            this.mainGameWindow_UpPanel.Controls.Add(this.MainGameWindow_ProfileButton);
            this.mainGameWindow_UpPanel.Controls.Add(this.mainGameWindow_SettingsButton);
            this.mainGameWindow_UpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainGameWindow_UpPanel.Location = new System.Drawing.Point(0, 0);
            this.mainGameWindow_UpPanel.Name = "mainGameWindow_UpPanel";
            this.mainGameWindow_UpPanel.Size = new System.Drawing.Size(796, 50);
            this.mainGameWindow_UpPanel.TabIndex = 0;
            // 
            // MainGameForm_RefreshBestScoreButton
            // 
            this.MainGameForm_RefreshBestScoreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainGameForm_RefreshBestScoreButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainGameForm_RefreshBestScoreButton.Location = new System.Drawing.Point(147, 0);
            this.MainGameForm_RefreshBestScoreButton.Name = "MainGameForm_RefreshBestScoreButton";
            this.MainGameForm_RefreshBestScoreButton.Size = new System.Drawing.Size(101, 50);
            this.MainGameForm_RefreshBestScoreButton.TabIndex = 0;
            this.MainGameForm_RefreshBestScoreButton.Text = "Refresh";
            this.MainGameForm_RefreshBestScoreButton.UseVisualStyleBackColor = true;
            this.MainGameForm_RefreshBestScoreButton.Click += new System.EventHandler(this.MainGameForm_RefreshBestScoreButton_Click);
            // 
            // MainGameForm_BestScoreDynamicLabel
            // 
            this.MainGameForm_BestScoreDynamicLabel.AutoSize = true;
            this.MainGameForm_BestScoreDynamicLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainGameForm_BestScoreDynamicLabel.Location = new System.Drawing.Point(106, 14);
            this.MainGameForm_BestScoreDynamicLabel.Name = "MainGameForm_BestScoreDynamicLabel";
            this.MainGameForm_BestScoreDynamicLabel.Size = new System.Drawing.Size(20, 22);
            this.MainGameForm_BestScoreDynamicLabel.TabIndex = 4;
            this.MainGameForm_BestScoreDynamicLabel.Text = "0";
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
            this.AboutButton.Location = new System.Drawing.Point(398, 0);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(99, 50);
            this.AboutButton.TabIndex = 2;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.HelpButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton.Location = new System.Drawing.Point(497, 0);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(101, 50);
            this.HelpButton.TabIndex = 1;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // MainGameWindow_ProfileButton
            // 
            this.MainGameWindow_ProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainGameWindow_ProfileButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainGameWindow_ProfileButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainGameWindow_ProfileButton.Location = new System.Drawing.Point(598, 0);
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
            this.mainGameWindow_SettingsButton.Location = new System.Drawing.Point(697, 0);
            this.mainGameWindow_SettingsButton.Name = "mainGameWindow_SettingsButton";
            this.mainGameWindow_SettingsButton.Size = new System.Drawing.Size(99, 50);
            this.mainGameWindow_SettingsButton.TabIndex = 4;
            this.mainGameWindow_SettingsButton.Text = "Settings";
            this.mainGameWindow_SettingsButton.UseVisualStyleBackColor = true;
            this.mainGameWindow_SettingsButton.Click += new System.EventHandler(this.mainGameWindow_SettingsButton_Click);
            // 
            // MainGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.mainGameWindow_UpPanel);
            this.Name = "MainGameForm";
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
        private System.Windows.Forms.Label MainGameForm_BestScoreDynamicLabel;
        private System.Windows.Forms.Label MainGameForm_BestScoreTextLabel;
        private System.Windows.Forms.Button MainGameForm_RefreshBestScoreButton;
    }
}