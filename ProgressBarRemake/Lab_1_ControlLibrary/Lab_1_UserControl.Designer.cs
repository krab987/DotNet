namespace Lab_1_ControlLibrary
{
    [ToolboxBitmap(@"drive:\W:\projects\C#\.Net\DotNet\Lab_1_ControlLibrary\Lab_1_UserControl.ico")]
    partial class Lab_1_UserControl
    {
        #region properties
        public int currentValue { get; set; } = 0;

        #endregion

        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.);





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
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
        }

        #endregion
    }
}