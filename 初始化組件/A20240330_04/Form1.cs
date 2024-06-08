namespace A20240330_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int iNumber = 9999;
        private void button1_Click(object sender, EventArgs e)
        {
            int iValue = 168;
            label1.Text = "Value = " + iValue + "\n";       //1. Value = 168
            vTest1();
            label1.Text += "Value = " + iValue + "\n\n\n";    //3. Value = 168
            /*=====================================*/
            label1.Text += "Number = " + iNumber + "\n";    //1. Number = 9999
            iNumber = 520;
            label1.Text += "Number = " + iNumber + "\n";    //2. Number = 520
            vTest2();
            label1.Text += "Number = " + iNumber + "\n";    //4. Number = 555
            vTest3();
            label1.Text += "Number = " + iNumber + "\n";    //6. Number = 555
        }

        private void vTest1()
        {
            int iValue = 500;
            label1.Text += "Value = " + iValue + "\n";      //2. Value = 500
        }

        private void vTest2()
        {
            iNumber = 555;
            label1.Text += "Number = " + iNumber + "\n";    //3. Number = 555
        }

        private void vTest3()
        {
            int iNumber = 888;
            label1.Text += "Number = " + iNumber + "\n";    //5. Number = 888
        }
    }
}
