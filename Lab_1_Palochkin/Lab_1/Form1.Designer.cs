namespace Lab_1
{
    partial class Lab_1_Palochkin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lab_1_UserControl = new Lab_1_ControlLibrary.Lab_1_UserControl();
            lbl_inf = new Label();
            SuspendLayout();
            // 
            // lab_1_UserControl
            // 
            lab_1_UserControl.BackColor = SystemColors.Control;
            lab_1_UserControl.crushValue = 7;
            lab_1_UserControl.currentValue = 0;
            lab_1_UserControl.firstColor = Color.LightBlue;
            lab_1_UserControl.Location = new Point(27, 34);
            lab_1_UserControl.Name = "lab_1_UserControl";
            lab_1_UserControl.secondColor = Color.LightPink;
            lab_1_UserControl.Size = new Size(393, 187);
            lab_1_UserControl.TabIndex = 0;
            lab_1_UserControl.ValueChanged += lab_1_UserControl1_ValueChanged;
            lab_1_UserControl.Crush += lab_1_UserControl_Crush;
            // 
            // lbl_inf
            // 
            lbl_inf.AutoSize = true;
            lbl_inf.Location = new Point(213, 250);
            lbl_inf.Name = "lbl_inf";
            lbl_inf.Size = new Size(0, 15);
            lbl_inf.TabIndex = 1;
            // 
            // Lab_1_Palochkin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 361);
            Controls.Add(lbl_inf);
            Controls.Add(lab_1_UserControl);
            Name = "Lab_1_Palochkin";
            Text = "ProgressBarRemake";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Lab_1_ControlLibrary.Lab_1_UserControl lab_1_UserControl;
        private Label lbl_inf;
    }
}