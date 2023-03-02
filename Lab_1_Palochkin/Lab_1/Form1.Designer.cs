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
            this.lab_1_UserControl = new Lab_1_ControlLibrary.Lab_1_UserControl();
            this.lbl_inf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_1_UserControl
            // 
            this.lab_1_UserControl.BackColor = System.Drawing.SystemColors.Control;
            this.lab_1_UserControl.crushValue = 7;
            this.lab_1_UserControl.currentValue = 0;
            this.lab_1_UserControl.firstColor = System.Drawing.Color.LightBlue;
            this.lab_1_UserControl.Location = new System.Drawing.Point(27, 34);
            this.lab_1_UserControl.Name = "lab_1_UserControl";
            this.lab_1_UserControl.secondColor = System.Drawing.Color.LightPink;
            this.lab_1_UserControl.Size = new System.Drawing.Size(393, 187);
            this.lab_1_UserControl.TabIndex = 0;
            this.lab_1_UserControl.ValueChanged += new System.EventHandler(this.lab_1_UserControl1_ValueChanged);
            this.lab_1_UserControl.Crush += new System.EventHandler(this.lab_1_UserControl_Crush);
            // 
            // lbl_inf
            // 
            this.lbl_inf.AutoSize = true;
            this.lbl_inf.Location = new System.Drawing.Point(213, 250);
            this.lbl_inf.Name = "lbl_inf";
            this.lbl_inf.Size = new System.Drawing.Size(0, 15);
            this.lbl_inf.TabIndex = 1;
            // 
            // Lab_1_Palochkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 361);
            this.Controls.Add(this.lbl_inf);
            this.Controls.Add(this.lab_1_UserControl);
            this.Name = "Lab_1_Palochkin";
            this.Text = "Lab_1_Palochkin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lab_1_ControlLibrary.Lab_1_UserControl lab_1_UserControl;
        private Label lbl_inf;
    }
}