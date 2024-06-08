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
                MessageBox.Show("�iĵ�i!!!!!�j\n\n�q���ȿ�J���~�Υ���J!!!!!\n\n" +
                    "~���C���|�N�ثe�q���Ȫ� ������ �@���w�]�����a�q����~\n\n" +
                    "���֪��a�C�����Q!!!");
                iPlayerGuessValue = (iMiniValue + iMaxValue) / 2;
                textBox_PlayerGuess.Text = iPlayerGuessValue.ToString();
            }

            if (iPlayerGuessValue > iMiniValue && iPlayerGuessValue < iMaxValue)
            {
                if (iPlayerGuessValue == iPcAnswerValue)
                {
                    MessageBox.Show("���߿�a�X�{!!!!!\n\n�}�l�i���g�@�C��!!!!!");
                    vGameInitialize();
                }
                else if (iPlayerGuessValue > iPcAnswerValue)
                {
                    MessageBox.Show("�ӴΰաA�S���q��!!!\n\n�z��J���q���Ȥj�󵪮�!!!");
                    label_Max.Text = textBox_PlayerGuess.Text;
                    textBox_PlayerGuess.Text = "";
                }
                else
                {
                    MessageBox.Show("�ӴΰաA�S���q��!!!\n\n�z��J���q���Ȥp�󵪮�!!!");
                    label_Mini.Text = textBox_PlayerGuess.Text;
                    textBox_PlayerGuess.Text = "";
                }
            }
            else
            {
                MessageBox.Show("�q���ȿ�J���~!!!!!\n\n�z��J���q���ȥ����j�� " + label_Mini.Text +
                    " �B�p�� " + label_Max.Text + " ����!!!!!\n\n�Э��s��J�z���q���ȡC");
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
            if (MessageBox.Show("�T�w�n�t�ҷs���@���C���ܡH", "�t�ҷs��", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            { vGameInitialize(); }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("�O�_�n�������C���H", "�����C��", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            { Application.Exit(); }
        }
    }
}
