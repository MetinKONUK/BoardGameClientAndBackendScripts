
namespace main
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.HelpForm_AboutButton = new System.Windows.Forms.Button();
            this.HelpForm_InfoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HelpForm_AboutButton
            // 
            this.HelpForm_AboutButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpForm_AboutButton.Location = new System.Drawing.Point(13, 261);
            this.HelpForm_AboutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HelpForm_AboutButton.Name = "HelpForm_AboutButton";
            this.HelpForm_AboutButton.Size = new System.Drawing.Size(100, 28);
            this.HelpForm_AboutButton.TabIndex = 0;
            this.HelpForm_AboutButton.Text = "About";
            this.HelpForm_AboutButton.UseVisualStyleBackColor = true;
            this.HelpForm_AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // HelpForm_InfoTextBox
            // 
            this.HelpForm_InfoTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.HelpForm_InfoTextBox.Font = new System.Drawing.Font("Times New Roman", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpForm_InfoTextBox.Location = new System.Drawing.Point(0, 0);
            this.HelpForm_InfoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HelpForm_InfoTextBox.Multiline = true;
            this.HelpForm_InfoTextBox.Name = "HelpForm_InfoTextBox";
            this.HelpForm_InfoTextBox.ReadOnly = true;
            this.HelpForm_InfoTextBox.Size = new System.Drawing.Size(1067, 253);
            this.HelpForm_InfoTextBox.TabIndex = 0;
            this.HelpForm_InfoTextBox.TabStop = false;
            this.HelpForm_InfoTextBox.Text = resources.GetString("HelpForm_InfoTextBox.Text");
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.HelpForm_InfoTextBox);
            this.Controls.Add(this.HelpForm_AboutButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HelpForm_AboutButton;
        private System.Windows.Forms.TextBox HelpForm_InfoTextBox;
    }
}