namespace A20240330_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[,] stringDrink = { { "�³��", "25" } , { "�i�f�i��", "35" } , { "�����@��", "25" } ,
                                                       { "�Z��", "20" } , { "��������", "15" } , { "���u����", "38" } ,
                                                       { "�B�����", "30" } , { "�ªQ�F�h", "28" } };

            for(int i = 0; i < stringDrink.GetLength(0); i++) 
            { dataGridView_Menu.Rows.Add( new object[] { stringDrink[i,0] , stringDrink[i,1] } ); }
        }
    }
}
