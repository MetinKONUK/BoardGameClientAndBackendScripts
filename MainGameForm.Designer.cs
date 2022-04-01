
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
            this.mainGameWindow_indicatorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainGameWindow_indicatorLabel
            // 
            this.mainGameWindow_indicatorLabel.AutoSize = true;
            this.mainGameWindow_indicatorLabel.Location = new System.Drawing.Point(86, 81);
            this.mainGameWindow_indicatorLabel.Name = "mainGameWindow_indicatorLabel";
            this.mainGameWindow_indicatorLabel.Size = new System.Drawing.Size(103, 13);
            this.mainGameWindow_indicatorLabel.TabIndex = 0;
            this.mainGameWindow_indicatorLabel.Text = "Main Game Window";
            // 
            // MainGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainGameWindow_indicatorLabel);
            this.Name = "MainGameForm";
            this.Text = "MainGameWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainGameForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainGameWindow_indicatorLabel;
    }
}