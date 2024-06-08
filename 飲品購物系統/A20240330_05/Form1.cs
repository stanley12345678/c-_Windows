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
            string[,] stringDrink = { { "¯Â³ð¯ù", "25" } , { "¥i¤f¥i¼Ö", "35" } , { "°¶®¦©@°Ø", "25" } ,
                                                       { "ÆZ¤û", "20" } , { "³Á­»¬õ¯ù", "15" } , { "¥ú¬u¤û¥¤", "38" } ,
                                                       { "¦BÂí¬õ¯ù", "30" } , { "¶ÂªQ¨F¤h", "28" } };

            for(int i = 0; i < stringDrink.GetLength(0); i++) 
            { dataGridView_Menu.Rows.Add( new object[] { stringDrink[i,0] , stringDrink[i,1] } ); }
        }
    }
}
