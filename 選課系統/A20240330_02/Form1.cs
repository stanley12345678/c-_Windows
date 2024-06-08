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
            string[] stringElectiveSubjects = { "微積分", "線性代數", "應用英文", "電工數學", "數位邏輯與電子電路", "物件導向概論",
                                                                          "電子學", "基本電學", "機率與統計", "C#視窗應用程式設計", "C與C++程式設計",
                                                                          "密碼學", "離散數學", "資料結構與演算法", "Java程式設計", "Python與AI導論",
                                                                          "生成式AI與對抗網路", "類神經網路", "VHDL設計實作", "PLC可程式邏輯控制器實務",
                                                                          "Swift開發iOS App", "Kotlin程式設計" };
            /*
                for (int i = 0; i < stringElectiveSubjects.Length; i++) 
                { cklstbx_EltvSubs.Items.Add(stringElectiveSubjects[i]); }
            */
            cklstbx_EltvSubs.Items.AddRange(stringElectiveSubjects);

            //下方顯示 已勾 / 總量
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
