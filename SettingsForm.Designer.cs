
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
            this.settings_backToGameWindowButton = new System.Windows.Forms.Button();
            this.settings_ShapeButton = new System.Windows.Forms.Button();
            this.settings_difficultyLevelButton = new System.Windows.Forms.Button();
            this.settings_DifficultyLevelCustomRadioButton = new System.Windows.Forms.RadioButton();
            this.settings_CustomDifficultyPanel = new System.Windows.Forms.Panel();
            this.settings_CustomTextLabel = new System.Windows.Forms.Label();
            this.settings_DifficultyLevelCustomColTextBox = new System.Windows.Forms.TextBox();
            this.settings_DifficultyLevelCustomRowTextBox = new System.Windows.Forms.TextBox();
            this.settings_SaveDifficultyLevelSelectionButton = new System.Windows.Forms.Button();
            this.settings_DifficultyLevelNormalRadioButton = new System.Windows.Forms.RadioButton();
            this.settings_DifficultyLevelHardRadioButton = new System.Windows.Forms.RadioButton();
            this.settings_DifficultyLevelEasyRadioButton = new System.Windows.Forms.RadioButton();
            this.settings_DifficultyLevelPanel = new System.Windows.Forms.Panel();
            this.settings_SaveShapeSelectionButton = new System.Windows.Forms.Button();
            this.settings_RoundCheckBox = new System.Windows.Forms.CheckBox();
            this.settings_TriangleCheckBox = new System.Windows.Forms.CheckBox();
            this.settings_SquareCheckBox = new System.Windows.Forms.CheckBox();
            this.settings_ShapesPanel = new System.Windows.Forms.Panel();
            this.settings_ColorButton = new System.Windows.Forms.Button();
            this.Settings_ColorPanel = new System.Windows.Forms.Panel();
            this.settings_RedCheckBox = new System.Windows.Forms.CheckBox();
            this.Settings_SaveColorSelectionButton = new System.Windows.Forms.Button();
            this.settings_GreenCheckBox = new System.Windows.Forms.CheckBox();
            this.Settings_BlueCheckBox = new System.Windows.Forms.CheckBox();
            this.settings_LeftPanel.SuspendLayout();
            this.settings_CustomDifficultyPanel.SuspendLayout();
            this.settings_DifficultyLevelPanel.SuspendLayout();
            this.settings_ShapesPanel.SuspendLayout();
            this.Settings_ColorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // settings_LeftPanel
            // 
            this.settings_LeftPanel.Controls.Add(this.settings_ColorButton);
            this.settings_LeftPanel.Controls.Add(this.settings_backToGameWindowButton);
            this.settings_LeftPanel.Controls.Add(this.settings_ShapeButton);
            this.settings_LeftPanel.Controls.Add(this.settings_difficultyLevelButton);
            this.settings_LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.settings_LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.settings_LeftPanel.Name = "settings_LeftPanel";
            this.settings_LeftPanel.Size = new System.Drawing.Size(109, 450);
            this.settings_LeftPanel.TabIndex = 0;
            // 
            // settings_backToGameWindowButton
            // 
            this.settings_backToGameWindowButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settings_backToGameWindowButton.Location = new System.Drawing.Point(0, 427);
            this.settings_backToGameWindowButton.Name = "settings_backToGameWindowButton";
            this.settings_backToGameWindowButton.Size = new System.Drawing.Size(109, 23);
            this.settings_backToGameWindowButton.TabIndex = 3;
            this.settings_backToGameWindowButton.Text = "Main Menu";
            this.settings_backToGameWindowButton.UseVisualStyleBackColor = true;
            this.settings_backToGameWindowButton.Click += new System.EventHandler(this.Settings_backToGameWindowButton_Click);
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
            this.settings_ShapeButton.Click += new System.EventHandler(this.Settings_ShapeButton_Click);
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
            this.settings_difficultyLevelButton.Click += new System.EventHandler(this.Settings_difficultyLevelButton_Click);
            // 
            // settings_DifficultyLevelCustomRadioButton
            // 
            this.settings_DifficultyLevelCustomRadioButton.AutoSize = true;
            this.settings_DifficultyLevelCustomRadioButton.Location = new System.Drawing.Point(3, 72);
            this.settings_DifficultyLevelCustomRadioButton.Name = "settings_DifficultyLevelCustomRadioButton";
            this.settings_DifficultyLevelCustomRadioButton.Size = new System.Drawing.Size(60, 17);
            this.settings_DifficultyLevelCustomRadioButton.TabIndex = 19;
            this.settings_DifficultyLevelCustomRadioButton.TabStop = true;
            this.settings_DifficultyLevelCustomRadioButton.Text = "Custom";
            this.settings_DifficultyLevelCustomRadioButton.UseVisualStyleBackColor = true;
            this.settings_DifficultyLevelCustomRadioButton.CheckedChanged += new System.EventHandler(this.settings_DifficultyLevelCustomRadioButton_CheckedChanged);
            // 
            // settings_CustomDifficultyPanel
            // 
            this.settings_CustomDifficultyPanel.Controls.Add(this.settings_CustomTextLabel);
            this.settings_CustomDifficultyPanel.Controls.Add(this.settings_DifficultyLevelCustomColTextBox);
            this.settings_CustomDifficultyPanel.Controls.Add(this.settings_DifficultyLevelCustomRowTextBox);
            this.settings_CustomDifficultyPanel.Location = new System.Drawing.Point(3, 95);
            this.settings_CustomDifficultyPanel.Name = "settings_CustomDifficultyPanel";
            this.settings_CustomDifficultyPanel.Size = new System.Drawing.Size(123, 52);
            this.settings_CustomDifficultyPanel.TabIndex = 20;
            this.settings_CustomDifficultyPanel.Visible = false;
            // 
            // settings_CustomTextLabel
            // 
            this.settings_CustomTextLabel.AutoSize = true;
            this.settings_CustomTextLabel.Location = new System.Drawing.Point(3, 19);
            this.settings_CustomTextLabel.Name = "settings_CustomTextLabel";
            this.settings_CustomTextLabel.Size = new System.Drawing.Size(45, 13);
            this.settings_CustomTextLabel.TabIndex = 6;
            this.settings_CustomTextLabel.Text = "Custom:";
            // 
            // settings_DifficultyLevelCustomColTextBox
            // 
            this.settings_DifficultyLevelCustomColTextBox.Location = new System.Drawing.Point(84, 16);
            this.settings_DifficultyLevelCustomColTextBox.Name = "settings_DifficultyLevelCustomColTextBox";
            this.settings_DifficultyLevelCustomColTextBox.Size = new System.Drawing.Size(24, 20);
            this.settings_DifficultyLevelCustomColTextBox.TabIndex = 4;
            // 
            // settings_DifficultyLevelCustomRowTextBox
            // 
            this.settings_DifficultyLevelCustomRowTextBox.Location = new System.Drawing.Point(54, 16);
            this.settings_DifficultyLevelCustomRowTextBox.Name = "settings_DifficultyLevelCustomRowTextBox";
            this.settings_DifficultyLevelCustomRowTextBox.Size = new System.Drawing.Size(24, 20);
            this.settings_DifficultyLevelCustomRowTextBox.TabIndex = 5;
            // 
            // settings_SaveDifficultyLevelSelectionButton
            // 
            this.settings_SaveDifficultyLevelSelectionButton.Location = new System.Drawing.Point(3, 153);
            this.settings_SaveDifficultyLevelSelectionButton.Name = "settings_SaveDifficultyLevelSelectionButton";
            this.settings_SaveDifficultyLevelSelectionButton.Size = new System.Drawing.Size(75, 23);
            this.settings_SaveDifficultyLevelSelectionButton.TabIndex = 18;
            this.settings_SaveDifficultyLevelSelectionButton.Text = "Save";
            this.settings_SaveDifficultyLevelSelectionButton.UseVisualStyleBackColor = true;
            this.settings_SaveDifficultyLevelSelectionButton.Click += new System.EventHandler(this.settings_SaveDifficultyLevelSelectionButton_Click);
            // 
            // settings_DifficultyLevelNormalRadioButton
            // 
            this.settings_DifficultyLevelNormalRadioButton.AutoSize = true;
            this.settings_DifficultyLevelNormalRadioButton.Location = new System.Drawing.Point(3, 26);
            this.settings_DifficultyLevelNormalRadioButton.Name = "settings_DifficultyLevelNormalRadioButton";
            this.settings_DifficultyLevelNormalRadioButton.Size = new System.Drawing.Size(58, 17);
            this.settings_DifficultyLevelNormalRadioButton.TabIndex = 17;
            this.settings_DifficultyLevelNormalRadioButton.TabStop = true;
            this.settings_DifficultyLevelNormalRadioButton.Text = "Normal";
            this.settings_DifficultyLevelNormalRadioButton.UseVisualStyleBackColor = true;
            // 
            // settings_DifficultyLevelHardRadioButton
            // 
            this.settings_DifficultyLevelHardRadioButton.AutoSize = true;
            this.settings_DifficultyLevelHardRadioButton.Location = new System.Drawing.Point(3, 49);
            this.settings_DifficultyLevelHardRadioButton.Name = "settings_DifficultyLevelHardRadioButton";
            this.settings_DifficultyLevelHardRadioButton.Size = new System.Drawing.Size(48, 17);
            this.settings_DifficultyLevelHardRadioButton.TabIndex = 16;
            this.settings_DifficultyLevelHardRadioButton.TabStop = true;
            this.settings_DifficultyLevelHardRadioButton.Text = "Hard";
            this.settings_DifficultyLevelHardRadioButton.UseVisualStyleBackColor = true;
            // 
            // settings_DifficultyLevelEasyRadioButton
            // 
            this.settings_DifficultyLevelEasyRadioButton.AutoSize = true;
            this.settings_DifficultyLevelEasyRadioButton.Location = new System.Drawing.Point(3, 3);
            this.settings_DifficultyLevelEasyRadioButton.Name = "settings_DifficultyLevelEasyRadioButton";
            this.settings_DifficultyLevelEasyRadioButton.Size = new System.Drawing.Size(48, 17);
            this.settings_DifficultyLevelEasyRadioButton.TabIndex = 15;
            this.settings_DifficultyLevelEasyRadioButton.TabStop = true;
            this.settings_DifficultyLevelEasyRadioButton.Text = "Easy";
            this.settings_DifficultyLevelEasyRadioButton.UseVisualStyleBackColor = true;
            // 
            // settings_DifficultyLevelPanel
            // 
            this.settings_DifficultyLevelPanel.Controls.Add(this.settings_DifficultyLevelEasyRadioButton);
            this.settings_DifficultyLevelPanel.Controls.Add(this.settings_DifficultyLevelCustomRadioButton);
            this.settings_DifficultyLevelPanel.Controls.Add(this.settings_SaveDifficultyLevelSelectionButton);
            this.settings_DifficultyLevelPanel.Controls.Add(this.settings_DifficultyLevelHardRadioButton);
            this.settings_DifficultyLevelPanel.Controls.Add(this.settings_DifficultyLevelNormalRadioButton);
            this.settings_DifficultyLevelPanel.Controls.Add(this.settings_CustomDifficultyPanel);
            this.settings_DifficultyLevelPanel.Location = new System.Drawing.Point(115, 12);
            this.settings_DifficultyLevelPanel.Name = "settings_DifficultyLevelPanel";
            this.settings_DifficultyLevelPanel.Size = new System.Drawing.Size(308, 218);
            this.settings_DifficultyLevelPanel.TabIndex = 22;
            // 
            // settings_SaveShapeSelectionButton
            // 
            this.settings_SaveShapeSelectionButton.Location = new System.Drawing.Point(3, 72);
            this.settings_SaveShapeSelectionButton.Name = "settings_SaveShapeSelectionButton";
            this.settings_SaveShapeSelectionButton.Size = new System.Drawing.Size(75, 23);
            this.settings_SaveShapeSelectionButton.TabIndex = 26;
            this.settings_SaveShapeSelectionButton.Text = "Save";
            this.settings_SaveShapeSelectionButton.UseVisualStyleBackColor = true;
            this.settings_SaveShapeSelectionButton.Click += new System.EventHandler(this.settings_SaveShapeSelectionButton_Click);
            // 
            // settings_RoundCheckBox
            // 
            this.settings_RoundCheckBox.AutoSize = true;
            this.settings_RoundCheckBox.Location = new System.Drawing.Point(3, 49);
            this.settings_RoundCheckBox.Name = "settings_RoundCheckBox";
            this.settings_RoundCheckBox.Size = new System.Drawing.Size(58, 17);
            this.settings_RoundCheckBox.TabIndex = 25;
            this.settings_RoundCheckBox.Text = "Round";
            this.settings_RoundCheckBox.UseVisualStyleBackColor = true;
            // 
            // settings_TriangleCheckBox
            // 
            this.settings_TriangleCheckBox.AutoSize = true;
            this.settings_TriangleCheckBox.Location = new System.Drawing.Point(3, 26);
            this.settings_TriangleCheckBox.Name = "settings_TriangleCheckBox";
            this.settings_TriangleCheckBox.Size = new System.Drawing.Size(64, 17);
            this.settings_TriangleCheckBox.TabIndex = 24;
            this.settings_TriangleCheckBox.Text = "Triangle";
            this.settings_TriangleCheckBox.UseVisualStyleBackColor = true;
            // 
            // settings_SquareCheckBox
            // 
            this.settings_SquareCheckBox.AutoSize = true;
            this.settings_SquareCheckBox.Location = new System.Drawing.Point(3, 3);
            this.settings_SquareCheckBox.Name = "settings_SquareCheckBox";
            this.settings_SquareCheckBox.Size = new System.Drawing.Size(60, 17);
            this.settings_SquareCheckBox.TabIndex = 23;
            this.settings_SquareCheckBox.Text = "Square";
            this.settings_SquareCheckBox.UseVisualStyleBackColor = true;
            // 
            // settings_ShapesPanel
            // 
            this.settings_ShapesPanel.Controls.Add(this.settings_SquareCheckBox);
            this.settings_ShapesPanel.Controls.Add(this.settings_SaveShapeSelectionButton);
            this.settings_ShapesPanel.Controls.Add(this.settings_TriangleCheckBox);
            this.settings_ShapesPanel.Controls.Add(this.settings_RoundCheckBox);
            this.settings_ShapesPanel.Location = new System.Drawing.Point(115, 12);
            this.settings_ShapesPanel.Name = "settings_ShapesPanel";
            this.settings_ShapesPanel.Size = new System.Drawing.Size(308, 197);
            this.settings_ShapesPanel.TabIndex = 27;
            // 
            // settings_ColorButton
            // 
            this.settings_ColorButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settings_ColorButton.Location = new System.Drawing.Point(0, 62);
            this.settings_ColorButton.Name = "settings_ColorButton";
            this.settings_ColorButton.Size = new System.Drawing.Size(109, 31);
            this.settings_ColorButton.TabIndex = 4;
            this.settings_ColorButton.Text = "Colors";
            this.settings_ColorButton.UseVisualStyleBackColor = true;
            this.settings_ColorButton.Click += new System.EventHandler(this.settings_ColorButton_Click);
            // 
            // Settings_ColorPanel
            // 
            this.Settings_ColorPanel.Controls.Add(this.settings_RedCheckBox);
            this.Settings_ColorPanel.Controls.Add(this.Settings_SaveColorSelectionButton);
            this.Settings_ColorPanel.Controls.Add(this.settings_GreenCheckBox);
            this.Settings_ColorPanel.Controls.Add(this.Settings_BlueCheckBox);
            this.Settings_ColorPanel.Location = new System.Drawing.Point(115, 12);
            this.Settings_ColorPanel.Name = "Settings_ColorPanel";
            this.Settings_ColorPanel.Size = new System.Drawing.Size(308, 176);
            this.Settings_ColorPanel.TabIndex = 28;
            // 
            // settings_RedCheckBox
            // 
            this.settings_RedCheckBox.AutoSize = true;
            this.settings_RedCheckBox.ForeColor = System.Drawing.Color.Red;
            this.settings_RedCheckBox.Location = new System.Drawing.Point(3, 3);
            this.settings_RedCheckBox.Name = "settings_RedCheckBox";
            this.settings_RedCheckBox.Size = new System.Drawing.Size(46, 17);
            this.settings_RedCheckBox.TabIndex = 23;
            this.settings_RedCheckBox.Text = "Red";
            this.settings_RedCheckBox.UseVisualStyleBackColor = true;
            // 
            // Settings_SaveColorSelectionButton
            // 
            this.Settings_SaveColorSelectionButton.Location = new System.Drawing.Point(3, 72);
            this.Settings_SaveColorSelectionButton.Name = "Settings_SaveColorSelectionButton";
            this.Settings_SaveColorSelectionButton.Size = new System.Drawing.Size(75, 23);
            this.Settings_SaveColorSelectionButton.TabIndex = 26;
            this.Settings_SaveColorSelectionButton.Text = "Save";
            this.Settings_SaveColorSelectionButton.UseVisualStyleBackColor = true;
            this.Settings_SaveColorSelectionButton.Click += new System.EventHandler(this.Settings_SaveColorSelectionButton_Click);
            // 
            // settings_GreenCheckBox
            // 
            this.settings_GreenCheckBox.AutoSize = true;
            this.settings_GreenCheckBox.ForeColor = System.Drawing.Color.Lime;
            this.settings_GreenCheckBox.Location = new System.Drawing.Point(3, 26);
            this.settings_GreenCheckBox.Name = "settings_GreenCheckBox";
            this.settings_GreenCheckBox.Size = new System.Drawing.Size(55, 17);
            this.settings_GreenCheckBox.TabIndex = 24;
            this.settings_GreenCheckBox.Text = "Green";
            this.settings_GreenCheckBox.UseVisualStyleBackColor = true;
            // 
            // Settings_BlueCheckBox
            // 
            this.Settings_BlueCheckBox.AutoSize = true;
            this.Settings_BlueCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Settings_BlueCheckBox.Location = new System.Drawing.Point(3, 49);
            this.Settings_BlueCheckBox.Name = "Settings_BlueCheckBox";
            this.Settings_BlueCheckBox.Size = new System.Drawing.Size(47, 17);
            this.Settings_BlueCheckBox.TabIndex = 25;
            this.Settings_BlueCheckBox.Text = "Blue";
            this.Settings_BlueCheckBox.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.Settings_ColorPanel);
            this.Controls.Add(this.settings_ShapesPanel);
            this.Controls.Add(this.settings_DifficultyLevelPanel);
            this.Controls.Add(this.settings_LeftPanel);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.settings_LeftPanel.ResumeLayout(false);
            this.settings_CustomDifficultyPanel.ResumeLayout(false);
            this.settings_CustomDifficultyPanel.PerformLayout();
            this.settings_DifficultyLevelPanel.ResumeLayout(false);
            this.settings_DifficultyLevelPanel.PerformLayout();
            this.settings_ShapesPanel.ResumeLayout(false);
            this.settings_ShapesPanel.PerformLayout();
            this.Settings_ColorPanel.ResumeLayout(false);
            this.Settings_ColorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel settings_LeftPanel;
        private System.Windows.Forms.Button settings_ShapeButton;
        private System.Windows.Forms.Button settings_difficultyLevelButton;
        private System.Windows.Forms.Button settings_backToGameWindowButton;
        private System.Windows.Forms.RadioButton settings_DifficultyLevelEasyRadioButton;
        private System.Windows.Forms.RadioButton settings_DifficultyLevelCustomRadioButton;
        private System.Windows.Forms.RadioButton settings_DifficultyLevelHardRadioButton;
        private System.Windows.Forms.Panel settings_CustomDifficultyPanel;
        private System.Windows.Forms.Label settings_CustomTextLabel;
        private System.Windows.Forms.TextBox settings_DifficultyLevelCustomColTextBox;
        private System.Windows.Forms.TextBox settings_DifficultyLevelCustomRowTextBox;
        private System.Windows.Forms.RadioButton settings_DifficultyLevelNormalRadioButton;
        private System.Windows.Forms.Button settings_SaveDifficultyLevelSelectionButton;
        private System.Windows.Forms.Panel settings_DifficultyLevelPanel;
        private System.Windows.Forms.Button settings_SaveShapeSelectionButton;
        private System.Windows.Forms.CheckBox settings_RoundCheckBox;
        private System.Windows.Forms.CheckBox settings_TriangleCheckBox;
        private System.Windows.Forms.CheckBox settings_SquareCheckBox;
        private System.Windows.Forms.Panel settings_ShapesPanel;
        private System.Windows.Forms.Button settings_ColorButton;
        private System.Windows.Forms.Panel Settings_ColorPanel;
        private System.Windows.Forms.CheckBox settings_RedCheckBox;
        private System.Windows.Forms.Button Settings_SaveColorSelectionButton;
        private System.Windows.Forms.CheckBox settings_GreenCheckBox;
        private System.Windows.Forms.CheckBox Settings_BlueCheckBox;
    }
}