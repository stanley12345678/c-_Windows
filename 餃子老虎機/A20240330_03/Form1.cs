namespace A20240330_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool bRollState = false;

        private void button_Play_Click(object sender, EventArgs e)
        {
            if (!bRollState) 
            {
                timer1.Enabled = timer2.Enabled = timer3.Enabled = true;
                bRollState = true;
                button_Play.Text = "°±¤î";
            }
            else
            {
                timer1.Enabled = timer2.Enabled = timer3.Enabled = false;
                bRollState = false;
                button_Play.Text = "»ë°Ê";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer2.Interval = timer1.Interval / 2;
            timer3.Interval = timer2.Interval / 2;
        }

        Random rDice = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        { label_Value1.Text = rDice.Next(10).ToString(); }

        private void timer2_Tick(object sender, EventArgs e)
        { label_Value2.Text = rDice.Next(10).ToString(); }

        private void timer3_Tick(object sender, EventArgs e)
        {  label_Value3.Text = rDice.Next(10).ToString(); }
    }
}
