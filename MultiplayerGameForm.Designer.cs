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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiplayerGameForm));
            this.PlayButton = new System.Windows.Forms.Button();
            this.OpponentUsernameLabel = new System.Windows.Forms.Label();
            this.OpponentUsernameTextBox = new System.Windows.Forms.TextBox();
            this.UpPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.UpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.OpponentUsernameLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpponentUsernameLabel.Location = new System.Drawing.Point(3, 12);
            this.OpponentUsernameLabel.Name = "OpponentUsernameLabel";
            this.OpponentUsernameLabel.Size = new System.Drawing.Size(140, 15);
            this.OpponentUsernameLabel.TabIndex = 0;
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
            this.UpPanel.Controls.Add(this.button1);
            this.UpPanel.Controls.Add(this.OpponentUsernameLabel);
            this.UpPanel.Controls.Add(this.PlayButton);
            this.UpPanel.Controls.Add(this.OpponentUsernameTextBox);
            this.UpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpPanel.Location = new System.Drawing.Point(0, 0);
            this.UpPanel.Name = "UpPanel";
            this.UpPanel.Size = new System.Drawing.Size(899, 44);
            this.UpPanel.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(425, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MultiplayerGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 472);
            this.Controls.Add(this.UpPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button button1;
    }
}