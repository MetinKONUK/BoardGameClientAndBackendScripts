
namespace main
{
    partial class SettingsForm
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
            this.settings_LeftPanel = new System.Windows.Forms.Panel();
            this.settings_difficultyLevelButton = new System.Windows.Forms.Button();
            this.settings_ShapeButton = new System.Windows.Forms.Button();
            this.settings_ShapesUserControl1 = new main.settings_ShapesUserControl();
            this.settings_DifficultyLevelUserControl1 = new main.settings_DifficultyLevelUserControl();
            this.settings_LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // settings_LeftPanel
            // 
            this.settings_LeftPanel.Controls.Add(this.settings_ShapeButton);
            this.settings_LeftPanel.Controls.Add(this.settings_difficultyLevelButton);
            this.settings_LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.settings_LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.settings_LeftPanel.Name = "settings_LeftPanel";
            this.settings_LeftPanel.Size = new System.Drawing.Size(109, 450);
            this.settings_LeftPanel.TabIndex = 0;
            // 
            // settings_difficultyLevelButton
            // 
            this.settings_difficultyLevelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settings_difficultyLevelButton.Location = new System.Drawing.Point(0, 0);
            this.settings_difficultyLevelButton.Name = "settings_difficultyLevelButton";
            this.settings_difficultyLevelButton.Size = new System.Drawing.Size(109, 31);
            this.settings_difficultyLevelButton.TabIndex = 0;
            this.settings_difficultyLevelButton.Text = "Difficulty Level";
            this.settings_difficultyLevelButton.UseVisualStyleBackColor = true;
            this.settings_difficultyLevelButton.Click += new System.EventHandler(this.settings_difficultyLevelButton_Click);
            // 
            // settings_ShapeButton
            // 
            this.settings_ShapeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settings_ShapeButton.Location = new System.Drawing.Point(0, 31);
            this.settings_ShapeButton.Name = "settings_ShapeButton";
            this.settings_ShapeButton.Size = new System.Drawing.Size(109, 31);
            this.settings_ShapeButton.TabIndex = 1;
            this.settings_ShapeButton.Text = "Shapes";
            this.settings_ShapeButton.UseVisualStyleBackColor = true;
            this.settings_ShapeButton.Click += new System.EventHandler(this.settings_ShapeButton_Click);
            // 
            // settings_ShapesUserControl1
            // 
            this.settings_ShapesUserControl1.Location = new System.Drawing.Point(115, 0);
            this.settings_ShapesUserControl1.Name = "settings_ShapesUserControl1";
            this.settings_ShapesUserControl1.Size = new System.Drawing.Size(226, 161);
            this.settings_ShapesUserControl1.TabIndex = 2;
            // 
            // settings_DifficultyLevelUserControl1
            // 
            this.settings_DifficultyLevelUserControl1.Location = new System.Drawing.Point(115, 0);
            this.settings_DifficultyLevelUserControl1.Name = "settings_DifficultyLevelUserControl1";
            this.settings_DifficultyLevelUserControl1.Size = new System.Drawing.Size(349, 227);
            this.settings_DifficultyLevelUserControl1.TabIndex = 1;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.settings_ShapesUserControl1);
            this.Controls.Add(this.settings_DifficultyLevelUserControl1);
            this.Controls.Add(this.settings_LeftPanel);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.settings_LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel settings_LeftPanel;
        private System.Windows.Forms.Button settings_ShapeButton;
        private System.Windows.Forms.Button settings_difficultyLevelButton;
        private settings_DifficultyLevelUserControl settings_DifficultyLevelUserControl1;
        private settings_ShapesUserControl settings_ShapesUserControl1;
    }
}