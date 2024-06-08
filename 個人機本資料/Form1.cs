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
            labelTitle.Text = "�򥻸��";
            labelTitle.BorderStyle = BorderStyle.Fixed3D;
            labelTitle.BackColor = Color.AliceBlue;
            labelTitle.ForeColor = Color.Yellow;




            //�U�貣�ͤ�U�ԲM�涵��
            for (int month = 1; month <= 12; month++)
            {comboBoxBDM.Items.Add(month);} 
            comboBoxBDM.Text = DateTime.Today.Month.ToString();

            //�U�貣�ͦ~�U�ԲM�涵��
            
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
                strOutputData = "�m�W :  " + textBoxFullname.Text + "\n";
            }

            if (radioButtonGenderMale.Checked)
            { strOutputData += "�ʧO : " + radioButtonGenderMale.Text + "\n"; }
            else
            { strOutputData += "�ʧO : " + radioButtonGenderFemale.Text + "\n"; }

            if (radioButtoBloodTypeA.Checked)
            { strOutputData += "�嫬 : " + radioButtoBloodTypeA.Text + "\n"; }
            else if (radioButtonBloodTypeB.Checked)
            { strOutputData += "�嫬 : " + radioButtonBloodTypeB.Text + "\n"; }
            else if (radioButtonBloodTypeAB.Checked)
            { strOutputData += "�嫬 : " + radioButtonBloodTypeAB.Text + "\n"; }
            else
            { strOutputData += "�嫬 : " + radioButtonBloodTypeO.Text + "\n"; }
            labelOutput.Text = strOutputData;

            if (checkBoxinterest1.Checked || checkBoxinterest2.Checked
                || checkBoxinterest3.Checked || checkBoxinterest4.Checked)
            {
                strOutputData += "���� : ";
                if (checkBoxinterest1.Checked) { strOutputData += checkBoxinterest1.Text + " "; }
                if (checkBoxinterest2.Checked) { strOutputData += checkBoxinterest2.Text + " "; }
                if (checkBoxinterest3.Checked) { strOutputData += checkBoxinterest3.Text + " "; }
                if (checkBoxinterest4.Checked) { strOutputData += checkBoxinterest4.Text + " "; }
                strOutputData += "\n";
            }
            strOutputData += "�X�ͤ��:" + comboBoxBDY.Text + "/" 
                + comboBoxBDM.Text + "/" + comboBoxBDD.Text + "\n";

            labelOutput.Text = strOutputData;
        }

        private void comboBoxBDY_SelectedIndexChanged(object sender, EventArgs e)
        { vSetDays();}

        private void comboBoxBDM_SelectedIndexChanged(object sender, EventArgs e)
        { vSetDays(); }
             
        
        private void vSetDays()
        {
            //�U�貣�ͤ�U�ԲM�涵��
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
