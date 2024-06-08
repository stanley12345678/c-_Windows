namespace A20240330_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] stringElectiveSubjects = { "�L�n��", "�u�ʥN��", "���έ^��", "�q�u�ƾ�", "�Ʀ��޿�P�q�l�q��", "����ɦV����",
                                                                          "�q�l��", "�򥻹q��", "���v�P�έp", "C#�������ε{���]�p", "C�PC++�{���]�p",
                                                                          "�K�X��", "�����ƾ�", "��Ƶ��c�P�t��k", "Java�{���]�p", "Python�PAI�ɽ�",
                                                                          "�ͦ���AI�P��ܺ���", "�����g����", "VHDL�]�p��@", "PLC�i�{���޿豱����",
                                                                          "Swift�}�oiOS App", "Kotlin�{���]�p" };
            /*
                for (int i = 0; i < stringElectiveSubjects.Length; i++) 
                { cklstbx_EltvSubs.Items.Add(stringElectiveSubjects[i]); }
            */
            cklstbx_EltvSubs.Items.AddRange(stringElectiveSubjects);

            //�U����� �w�� / �`�q
            label_Count.Text = 0 + " / " + cklstbx_EltvSubs.Items.Count;
        }

        private void cklstbx_EltvSubs_SelectedIndexChanged(object sender, EventArgs e)
        { label_Count.Text = cklstbx_EltvSubs.CheckedItems.Count + " / " + cklstbx_EltvSubs.Items.Count; }

        private void button_Add_Click(object sender, EventArgs e)
        {
            lstbx_AddEltvSubs.Items.Clear();
            if (cklstbx_EltvSubs.CheckedItems.Count >0) 
            { 
                for (int i = 0; i < cklstbx_EltvSubs.CheckedItems.Count; i++) 
                { lstbx_AddEltvSubs.Items.Add(cklstbx_EltvSubs.CheckedItems[i]); }
            }
        }
    }
}
