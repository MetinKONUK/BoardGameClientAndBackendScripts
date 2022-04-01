
namespace main
{
    partial class settings_ShapesUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.settings_ShapesPanel = new System.Windows.Forms.Panel();
            this.settings_SaveShapeSelectionButton = new System.Windows.Forms.Button();
            this.settings_RoundCheckBox = new System.Windows.Forms.CheckBox();
            this.settings_TriangleCheckBox = new System.Windows.Forms.CheckBox();
            this.settings_SquareCheckBox = new System.Windows.Forms.CheckBox();
            this.settings_ShapesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // settings_ShapesPanel
            // 
            this.settings_ShapesPanel.Controls.Add(this.settings_SaveShapeSelectionButton);
            this.settings_ShapesPanel.Controls.Add(this.settings_RoundCheckBox);
            this.settings_ShapesPanel.Controls.Add(this.settings_TriangleCheckBox);
            this.settings_ShapesPanel.Controls.Add(this.settings_SquareCheckBox);
            this.settings_ShapesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings_ShapesPanel.Location = new System.Drawing.Point(0, 0);
            this.settings_ShapesPanel.Name = "settings_ShapesPanel";
            this.settings_ShapesPanel.Size = new System.Drawing.Size(499, 395);
            this.settings_ShapesPanel.TabIndex = 5;
            // 
            // settings_SaveShapeSelectionButton
            // 
            this.settings_SaveShapeSelectionButton.Location = new System.Drawing.Point(3, 72);
            this.settings_SaveShapeSelectionButton.Name = "settings_SaveShapeSelectionButton";
            this.settings_SaveShapeSelectionButton.Size = new System.Drawing.Size(75, 23);
            this.settings_SaveShapeSelectionButton.TabIndex = 3;
            this.settings_SaveShapeSelectionButton.Text = "Save";
            this.settings_SaveShapeSelectionButton.UseVisualStyleBackColor = true;
            // 
            // settings_RoundCheckBox
            // 
            this.settings_RoundCheckBox.AutoSize = true;
            this.settings_RoundCheckBox.Location = new System.Drawing.Point(3, 49);
            this.settings_RoundCheckBox.Name = "settings_RoundCheckBox";
            this.settings_RoundCheckBox.Size = new System.Drawing.Size(58, 17);
            this.settings_RoundCheckBox.TabIndex = 2;
            this.settings_RoundCheckBox.Text = "Round";
            this.settings_RoundCheckBox.UseVisualStyleBackColor = true;
            // 
            // settings_TriangleCheckBox
            // 
            this.settings_TriangleCheckBox.AutoSize = true;
            this.settings_TriangleCheckBox.Location = new System.Drawing.Point(3, 26);
            this.settings_TriangleCheckBox.Name = "settings_TriangleCheckBox";
            this.settings_TriangleCheckBox.Size = new System.Drawing.Size(64, 17);
            this.settings_TriangleCheckBox.TabIndex = 1;
            this.settings_TriangleCheckBox.Text = "Triangle";
            this.settings_TriangleCheckBox.UseVisualStyleBackColor = true;
            // 
            // settings_SquareCheckBox
            // 
            this.settings_SquareCheckBox.AutoSize = true;
            this.settings_SquareCheckBox.Location = new System.Drawing.Point(3, 3);
            this.settings_SquareCheckBox.Name = "settings_SquareCheckBox";
            this.settings_SquareCheckBox.Size = new System.Drawing.Size(60, 17);
            this.settings_SquareCheckBox.TabIndex = 0;
            this.settings_SquareCheckBox.Text = "Square";
            this.settings_SquareCheckBox.UseVisualStyleBackColor = true;
            // 
            // settings_ShapesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.settings_ShapesPanel);
            this.Name = "settings_ShapesUserControl";
            this.Size = new System.Drawing.Size(499, 395);
            this.settings_ShapesPanel.ResumeLayout(false);
            this.settings_ShapesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel settings_ShapesPanel;
        private System.Windows.Forms.Button settings_SaveShapeSelectionButton;
        private System.Windows.Forms.CheckBox settings_RoundCheckBox;
        private System.Windows.Forms.CheckBox settings_TriangleCheckBox;
        private System.Windows.Forms.CheckBox settings_SquareCheckBox;
    }
}
