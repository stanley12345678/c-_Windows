using System;

namespace _20240316_01
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelTitle.Text = "基本資料";
            labelTitle.BorderStyle = BorderStyle.Fixed3D;
            labelTitle.BackColor = Color.AliceBlue;
            labelTitle.ForeColor = Color.Yellow;




            //下方產生月下拉清單項目
            for (int month = 1; month <= 12; month++)
            {comboBoxBDM.Items.Add(month);} 
            comboBoxBDM.Text = DateTime.Today.Month.ToString();

            //下方產生年下拉清單項目
            
            for (int year = DateTime.Today.Year - 130; year <= DateTime.Today.Year; year++)
            {comboBoxBDY.Items.Add(year);}
            comboBoxBDY.Text = (DateTime.Today.Year - 18).ToString();

            vSetDays();

            

          

        }




        private void buttonOutput_Click(object sender, EventArgs e)
        {
            string strOutputData = "";

            if (textBoxFullname.Text != "")
            {
                strOutputData = "姓名 :  " + textBoxFullname.Text + "\n";
            }

            if (radioButtonGenderMale.Checked)
            { strOutputData += "性別 : " + radioButtonGenderMale.Text + "\n"; }
            else
            { strOutputData += "性別 : " + radioButtonGenderFemale.Text + "\n"; }

            if (radioButtoBloodTypeA.Checked)
            { strOutputData += "血型 : " + radioButtoBloodTypeA.Text + "\n"; }
            else if (radioButtonBloodTypeB.Checked)
            { strOutputData += "血型 : " + radioButtonBloodTypeB.Text + "\n"; }
            else if (radioButtonBloodTypeAB.Checked)
            { strOutputData += "血型 : " + radioButtonBloodTypeAB.Text + "\n"; }
            else
            { strOutputData += "血型 : " + radioButtonBloodTypeO.Text + "\n"; }
            labelOutput.Text = strOutputData;

            if (checkBoxinterest1.Checked || checkBoxinterest2.Checked
                || checkBoxinterest3.Checked || checkBoxinterest4.Checked)
            {
                strOutputData += "興趣 : ";
                if (checkBoxinterest1.Checked) { strOutputData += checkBoxinterest1.Text + " "; }
                if (checkBoxinterest2.Checked) { strOutputData += checkBoxinterest2.Text + " "; }
                if (checkBoxinterest3.Checked) { strOutputData += checkBoxinterest3.Text + " "; }
                if (checkBoxinterest4.Checked) { strOutputData += checkBoxinterest4.Text + " "; }
                strOutputData += "\n";
            }
            strOutputData += "出生日期:" + comboBoxBDY.Text + "/" 
                + comboBoxBDM.Text + "/" + comboBoxBDD.Text + "\n";

            labelOutput.Text = strOutputData;
        }

        private void comboBoxBDY_SelectedIndexChanged(object sender, EventArgs e)
        { vSetDays();}

        private void comboBoxBDM_SelectedIndexChanged(object sender, EventArgs e)
        { vSetDays(); }
             
        
        private void vSetDays()
        {
            //下方產生日下拉清單項目
            comboBoxBDD.Items.Clear();
            int idays = 0;
            int icbxMthitem = int.Parse(comboBoxBDM.Text);
            if (icbxMthitem == 2)
            {
                int icbxYearitem = int.Parse(comboBoxBDY.Text); //
                if (icbxYearitem % 400 == 0 || icbxYearitem % 4 == 0 && icbxYearitem % 100 != 0)
                { idays = 29; }
                else
                { idays = 28; }

            }
            else if (icbxMthitem == 4 || icbxMthitem == 6 || icbxMthitem == 9 || icbxMthitem == 11)
            { idays = 30; }
            else
            { idays = 31; }

            int iday = 1;
            do
            {
                comboBoxBDD.Items.Add(iday++); ;
            } while (iday <= idays);
            comboBoxBDD.Text = DateTime.Today.Day.ToString();
        }
    }
}
