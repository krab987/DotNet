using System.ComponentModel;

namespace Lab_1_ControlLibrary
{
    //[DefaultEvent(ValueChanged)]
    [ToolboxBitmap(@"drive:\W:\projects\C#\.Net\DotNet\Lab_1_ControlLibrary\Lab_1_UserControl.ico")]
    public partial class Lab_1_UserControl : UserControl
    {
        public Lab_1_UserControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.myTrackBar = new System.Windows.Forms.TrackBar();
            this.myPannel = new System.Windows.Forms.Panel();
            this.myPannelSecond = new System.Windows.Forms.Panel();
            this.myTextBox = new System.Windows.Forms.TextBox();
            this.bnChange = new System.Windows.Forms.Button();
            this.myTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.myTrackBar)).BeginInit();
            this.myPannel.SuspendLayout();
            this.myTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // myTrackBar
            // 
            this.myTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myTrackBar.Location = new System.Drawing.Point(3, 103);
            this.myTrackBar.Name = "myTrackBar";
            this.myTrackBar.Size = new System.Drawing.Size(367, 44);
            this.myTrackBar.TabIndex = 1;
            this.myTrackBar.Scroll += new System.EventHandler(this.myTrackBar_Scroll);
            // 
            // myPannel
            // 
            this.myPannel.BackColor = System.Drawing.SystemColors.Control;
            this.myPannel.Controls.Add(this.myPannelSecond);
            this.myPannel.Location = new System.Drawing.Point(3, 53);
            this.myPannel.Name = "myPannel";
            this.myPannel.Size = new System.Drawing.Size(367, 44);
            this.myPannel.TabIndex = 0;
            // 
            // myPannelSecond
            // 
            this.myPannelSecond.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myPannelSecond.BackColor = System.Drawing.SystemColors.Control;
            this.myPannelSecond.Location = new System.Drawing.Point(243, 0);
            this.myPannelSecond.Name = "myPannelSecond";
            this.myPannelSecond.Size = new System.Drawing.Size(121, 44);
            this.myPannelSecond.TabIndex = 0;
            // 
            // myTextBox
            // 
            this.myTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myTextBox.Location = new System.Drawing.Point(3, 3);
            this.myTextBox.Name = "myTextBox";
            this.myTextBox.Size = new System.Drawing.Size(177, 23);
            this.myTextBox.TabIndex = 3;
            // 
            // bnChange
            // 
            this.bnChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bnChange.Location = new System.Drawing.Point(186, 3);
            this.bnChange.Name = "bnChange";
            this.bnChange.Size = new System.Drawing.Size(178, 23);
            this.bnChange.TabIndex = 4;
            this.bnChange.Text = "Change Critical Piont";
            this.bnChange.UseVisualStyleBackColor = true;
            this.bnChange.Click += new System.EventHandler(this.bnChange_Click);
            // 
            // myTableLayoutPanel
            // 
            this.myTableLayoutPanel.ColumnCount = 1;
            this.myTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.myTableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.myTableLayoutPanel.Controls.Add(this.myTrackBar, 0, 2);
            this.myTableLayoutPanel.Controls.Add(this.myPannel, 0, 1);
            this.myTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.myTableLayoutPanel.Name = "myTableLayoutPanel";
            this.myTableLayoutPanel.RowCount = 3;
            this.myTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.myTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.myTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.myTableLayoutPanel.Size = new System.Drawing.Size(373, 148);
            this.myTableLayoutPanel.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.myTextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bnChange, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(367, 44);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Lab_1_UserControl
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.myTableLayoutPanel);
            this.Name = "Lab_1_UserControl";
            this.Size = new System.Drawing.Size(562, 275);
            ((System.ComponentModel.ISupportInitialize)(this.myTrackBar)).EndInit();
            this.myPannel.ResumeLayout(false);
            this.myTableLayoutPanel.ResumeLayout(false);
            this.myTableLayoutPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }


        #region properties
        public Color firstColor { get; set; } = Color.LightBlue;
        public Color secondColor { get; set; } = Color.LightPink;
        public int crushValue { get; set; } = 7;
        public int currentValue { get; set; } = 0;
        #endregion


        private TrackBar myTrackBar;
        private Panel myPannelSecond;
        private TextBox myTextBox;
        private Button bnChange;
        private TableLayoutPanel myTableLayoutPanel;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel myPannel;


        public event EventHandler ValueChanged;
        public event EventHandler Crush;

        private void myTrackBar_Scroll(object sender, EventArgs e)
        {
            currentValue = myTrackBar.Value;
            this.ValueChanged?.Invoke(this, EventArgs.Empty);


            myPannel.BackColor = firstColor;
            myPannelSecond.BackColor = secondColor;

            myPannel.Width = myTrackBar.Width * (myTrackBar.Value * 10) / 100;
            myPannelSecond.Width = (crushValue < myTrackBar.Value) ? myTrackBar.Width - myPannel.Width * ((myTrackBar.Value - crushValue)  * 10) / 100 : myPannelSecond.Width;

            if(currentValue == crushValue)
                this.Crush?.Invoke(this, EventArgs.Empty);
            //myPannel.BackColor = Color.FromArgb(255,0,0, (int)(myTrackBar.Value/10.0*255));
        }

        private void bnChange_Click(object sender, EventArgs e)
        {
            crushValue = int.Parse(myTextBox.Text);
            myPannelSecond.Location = new Point(myTrackBar.Width / 10 * crushValue + 3, 0);
        }
    }
}