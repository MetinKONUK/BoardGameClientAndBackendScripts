
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
            this.mainGameWindow_SettingsButton = new System.Windows.Forms.Button();
            this.mainGameWindow_UpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainGameWindow_UpPanel
            // 
            this.mainGameWindow_UpPanel.Controls.Add(this.mainGameWindow_SettingsButton);
            this.mainGameWindow_UpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainGameWindow_UpPanel.Location = new System.Drawing.Point(0, 0);
            this.mainGameWindow_UpPanel.Name = "mainGameWindow_UpPanel";
            this.mainGameWindow_UpPanel.Size = new System.Drawing.Size(800, 40);
            this.mainGameWindow_UpPanel.TabIndex = 0;
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
    }
}