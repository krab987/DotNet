using Lab_1_ControlLibrary;
using static Lab_1_ControlLibrary.Lab_1_UserControl;

namespace Lab_1
{
    public partial class Lab_1_Palochkin : Form
    {
        public Lab_1_Palochkin()
        {
            InitializeComponent();
        }

        private void lab_1_UserControl1_ValueChanged(object sender, EventArgs e)
        {
            lbl_inf.Text = lab_1_UserControl.currentValue.ToString();
        }

        private void lab_1_UserControl_Crush(object sender, EventArgs e)
        {
            lbl_inf.Text = "Color is crushed";        
        }
    }
}