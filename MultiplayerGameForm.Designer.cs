namespace main
{
    partial class MultiplayerGameForm
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
            this.PlayButton = new System.Windows.Forms.Button();
            this.OpponentUsernameLabel = new System.Windows.Forms.Label();
            this.OpponentUsernameTextBox = new System.Windows.Forms.TextBox();
            this.UpPanel = new System.Windows.Forms.Panel();
            this.UpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.Location = new System.Drawing.Point(344, 8);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 23);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // OpponentUsernameLabel
            // 
            this.OpponentUsernameLabel.AutoSize = true;
            this.OpponentUsernameLabel.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpponentUsernameLabel.Location = new System.Drawing.Point(3, 12);
            this.OpponentUsernameLabel.Name = "OpponentUsernameLabel";
            this.OpponentUsernameLabel.Size = new System.Drawing.Size(142, 15);
            this.OpponentUsernameLabel.TabIndex = 3;
            this.OpponentUsernameLabel.Text = "Enter Opponent Username:";
            // 
            // OpponentUsernameTextBox
            // 
            this.OpponentUsernameTextBox.Location = new System.Drawing.Point(151, 10);
            this.OpponentUsernameTextBox.Name = "OpponentUsernameTextBox";
            this.OpponentUsernameTextBox.Size = new System.Drawing.Size(187, 20);
            this.OpponentUsernameTextBox.TabIndex = 0;
            // 
            // UpPanel
            // 
            this.UpPanel.Controls.Add(this.OpponentUsernameLabel);
            this.UpPanel.Controls.Add(this.PlayButton);
            this.UpPanel.Controls.Add(this.OpponentUsernameTextBox);
            this.UpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpPanel.Location = new System.Drawing.Point(0, 0);
            this.UpPanel.Name = "UpPanel";
            this.UpPanel.Size = new System.Drawing.Size(800, 42);
            this.UpPanel.TabIndex = 4;
            // 
            // MultiplayerGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MultiplayerGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiplayerGameForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MultiplayerGameForm_FormClosed);
            this.UpPanel.ResumeLayout(false);
            this.UpPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label OpponentUsernameLabel;
        private System.Windows.Forms.TextBox OpponentUsernameTextBox;
        private System.Windows.Forms.Panel UpPanel;
    }
}