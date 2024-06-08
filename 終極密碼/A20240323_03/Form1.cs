namespace A20240323_03
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_Guess_Click(object sender, EventArgs e)
        {
            int iPlayerGuessValue;
            int iPcAnswerValue = int.Parse(label_PcAns.Text);
            int iMiniValue = int.Parse(label_Mini.Text);
            int iMaxValue = int.Parse(label_Max.Text);

            try
            { iPlayerGuessValue = int.Parse(textBox_PlayerGuess.Text); }
            catch
            {
                MessageBox.Show("【警告!!!!!】\n\n猜測值輸入錯誤或未輸入!!!!!\n\n" +
                    "~本遊戲會將目前猜測值的 中間值 作為預設的玩家猜測值~\n\n" +
                    "祝福玩家遊戲順利!!!");
                iPlayerGuessValue = (iMiniValue + iMaxValue) / 2;
                textBox_PlayerGuess.Text = iPlayerGuessValue.ToString();
            }

            if (iPlayerGuessValue > iMiniValue && iPlayerGuessValue < iMaxValue)
            {
                if (iPlayerGuessValue == iPcAnswerValue)
                {
                    MessageBox.Show("恭喜輸家出現!!!!!\n\n開始進行懲罰遊戲!!!!!");
                    vGameInitialize();
                }
                else if (iPlayerGuessValue > iPcAnswerValue)
                {
                    MessageBox.Show("太棒啦，沒有猜中!!!\n\n您輸入的猜測值大於答案!!!");
                    label_Max.Text = textBox_PlayerGuess.Text;
                    textBox_PlayerGuess.Text = "";
                }
                else
                {
                    MessageBox.Show("太棒啦，沒有猜中!!!\n\n您輸入的猜測值小於答案!!!");
                    label_Mini.Text = textBox_PlayerGuess.Text;
                    textBox_PlayerGuess.Text = "";
                }
            }
            else
            {
                MessageBox.Show("猜測值輸入錯誤!!!!!\n\n您輸入的猜測值必須大於 " + label_Mini.Text +
                    " 且小於 " + label_Max.Text + " 之間!!!!!\n\n請重新輸入您的猜測值。");
                textBox_PlayerGuess.Text = "";
            }
        }

        private void vGameInitialize()
        {
            Random rDice = new Random();
            label_PcAns.Text = rDice.Next(1, 100000).ToString();
            label_Mini.Text = "0";
            label_Max.Text = "100000";
            textBox_PlayerGuess.Text = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            vGameInitialize();
        }

        private void button_Replay_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要另啟新的一局遊戲嗎？", "另啟新局", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            { vGameInitialize(); }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否要結束本遊戲？", "結束遊戲", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            { Application.Exit(); }
        }
    }
}
