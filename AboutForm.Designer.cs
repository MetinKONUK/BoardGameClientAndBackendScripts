
namespace main
{
    partial class AboutForm
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
            this.About_GameNameLabel = new System.Windows.Forms.Label();
            this.About_DevelopersTextLabel = new System.Windows.Forms.Label();
            this.About_Developer1Label = new System.Windows.Forms.Label();
            this.About_Developer2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // About_GameNameLabel
            // 
            this.About_GameNameLabel.AutoSize = true;
            this.About_GameNameLabel.Location = new System.Drawing.Point(12, 9);
            this.About_GameNameLabel.Name = "About_GameNameLabel";
            this.About_GameNameLabel.Size = new System.Drawing.Size(66, 13);
            this.About_GameNameLabel.TabIndex = 0;
            this.About_GameNameLabel.Text = "Game Name";
            // 
            // About_DevelopersTextLabel
            // 
            this.About_DevelopersTextLabel.AutoSize = true;
            this.About_DevelopersTextLabel.Location = new System.Drawing.Point(12, 53);
            this.About_DevelopersTextLabel.Name = "About_DevelopersTextLabel";
            this.About_DevelopersTextLabel.Size = new System.Drawing.Size(79, 13);
            this.About_DevelopersTextLabel.TabIndex = 1;
            this.About_DevelopersTextLabel.Text = "DEVELOPERS";
            // 
            // About_Developer1Label
            // 
            this.About_Developer1Label.AutoSize = true;
            this.About_Developer1Label.Location = new System.Drawing.Point(12, 76);
            this.About_Developer1Label.Name = "About_Developer1Label";
            this.About_Developer1Label.Size = new System.Drawing.Size(67, 13);
            this.About_Developer1Label.TabIndex = 2;
            this.About_Developer1Label.Text = "Metin Konuk";
            // 
            // About_Developer2Label
            // 
            this.About_Developer2Label.AutoSize = true;
            this.About_Developer2Label.Location = new System.Drawing.Point(12, 89);
            this.About_Developer2Label.Name = "About_Developer2Label";
            this.About_Developer2Label.Size = new System.Drawing.Size(71, 13);
            this.About_Developer2Label.TabIndex = 3;
            this.About_Developer2Label.Text = "Hasan Yasen";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.About_Developer2Label);
            this.Controls.Add(this.About_Developer1Label);
            this.Controls.Add(this.About_DevelopersTextLabel);
            this.Controls.Add(this.About_GameNameLabel);
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label About_GameNameLabel;
        private System.Windows.Forms.Label About_DevelopersTextLabel;
        private System.Windows.Forms.Label About_Developer1Label;
        private System.Windows.Forms.Label About_Developer2Label;
    }
}