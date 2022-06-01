
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.AboutForm_InfoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AboutForm_InfoTextBoxSecond = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AboutForm_InfoTextBox
            // 
            this.AboutForm_InfoTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.AboutForm_InfoTextBox.Font = new System.Drawing.Font("Times New Roman", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutForm_InfoTextBox.Location = new System.Drawing.Point(0, 0);
            this.AboutForm_InfoTextBox.Multiline = true;
            this.AboutForm_InfoTextBox.Name = "AboutForm_InfoTextBox";
            this.AboutForm_InfoTextBox.ReadOnly = true;
            this.AboutForm_InfoTextBox.Size = new System.Drawing.Size(800, 217);
            this.AboutForm_InfoTextBox.TabIndex = 1;
            this.AboutForm_InfoTextBox.TabStop = false;
            this.AboutForm_InfoTextBox.Text = resources.GetString("AboutForm_InfoTextBox.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // AboutForm_InfoTextBoxSecond
            // 
            this.AboutForm_InfoTextBoxSecond.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AboutForm_InfoTextBoxSecond.Font = new System.Drawing.Font("Times New Roman", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutForm_InfoTextBoxSecond.Location = new System.Drawing.Point(0, 223);
            this.AboutForm_InfoTextBoxSecond.Multiline = true;
            this.AboutForm_InfoTextBoxSecond.Name = "AboutForm_InfoTextBoxSecond";
            this.AboutForm_InfoTextBoxSecond.ReadOnly = true;
            this.AboutForm_InfoTextBoxSecond.Size = new System.Drawing.Size(800, 227);
            this.AboutForm_InfoTextBoxSecond.TabIndex = 3;
            this.AboutForm_InfoTextBoxSecond.TabStop = false;
            this.AboutForm_InfoTextBoxSecond.Text = resources.GetString("AboutForm_InfoTextBoxSecond.Text");
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AboutForm_InfoTextBoxSecond);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AboutForm_InfoTextBox);
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AboutForm_InfoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AboutForm_InfoTextBoxSecond;
    }
}