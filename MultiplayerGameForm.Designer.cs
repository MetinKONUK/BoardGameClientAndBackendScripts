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
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(344, 6);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 23);
            this.PlayButton.TabIndex = 5;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // OpponentUsernameLabel
            // 
            this.OpponentUsernameLabel.AutoSize = true;
            this.OpponentUsernameLabel.Location = new System.Drawing.Point(12, 9);
            this.OpponentUsernameLabel.Name = "OpponentUsernameLabel";
            this.OpponentUsernameLabel.Size = new System.Drawing.Size(136, 13);
            this.OpponentUsernameLabel.TabIndex = 3;
            this.OpponentUsernameLabel.Text = "Enter Opponent Username:";
            // 
            // OpponentUsernameTextBox
            // 
            this.OpponentUsernameTextBox.Location = new System.Drawing.Point(151, 6);
            this.OpponentUsernameTextBox.Name = "OpponentUsernameTextBox";
            this.OpponentUsernameTextBox.Size = new System.Drawing.Size(187, 20);
            this.OpponentUsernameTextBox.TabIndex = 4;
            // 
            // MultiplayerGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.OpponentUsernameLabel);
            this.Controls.Add(this.OpponentUsernameTextBox);
            this.Name = "MultiplayerGameForm";
            this.Text = "MultiplayerGameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label OpponentUsernameLabel;
        private System.Windows.Forms.TextBox OpponentUsernameTextBox;
    }
}