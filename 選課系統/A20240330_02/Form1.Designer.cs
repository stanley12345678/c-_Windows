namespace A20240330_02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstbx_AddEltvSubs = new ListBox();
            cklstbx_EltvSubs = new CheckedListBox();
            label1 = new Label();
            label2 = new Label();
            button_Add = new Button();
            label3 = new Label();
            label_Count = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // lstbx_AddEltvSubs
            // 
            lstbx_AddEltvSubs.ColumnWidth = 40;
            lstbx_AddEltvSubs.FormattingEnabled = true;
            lstbx_AddEltvSubs.ItemHeight = 15;
            lstbx_AddEltvSubs.Location = new Point(26, 258);
            lstbx_AddEltvSubs.Name = "lstbx_AddEltvSubs";
            lstbx_AddEltvSubs.SelectionMode = SelectionMode.MultiExtended;
            lstbx_AddEltvSubs.Size = new Size(183, 124);
            lstbx_AddEltvSubs.TabIndex = 0;
            // 
            // cklstbx_EltvSubs
            // 
            cklstbx_EltvSubs.CheckOnClick = true;
            cklstbx_EltvSubs.FormattingEnabled = true;
            cklstbx_EltvSubs.Location = new Point(26, 39);
            cklstbx_EltvSubs.Name = "cklstbx_EltvSubs";
            cklstbx_EltvSubs.Size = new Size(183, 112);
            cklstbx_EltvSubs.TabIndex = 1;
            cklstbx_EltvSubs.SelectedIndexChanged += cklstbx_EltvSubs_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 2;
            label1.Text = "可供選修科目清單：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 240);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 3;
            label2.Text = "已加入：";
            // 
            // button_Add
            // 
            button_Add.Location = new Point(26, 194);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(183, 30);
            button_Add.TabIndex = 4;
            button_Add.Text = "加入勾選科目";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 157);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 5;
            label3.Text = "打勾項目數量：";
            // 
            // label_Count
            // 
            label_Count.BorderStyle = BorderStyle.FixedSingle;
            label_Count.Location = new Point(128, 153);
            label_Count.Name = "label_Count";
            label_Count.Size = new Size(68, 23);
            label_Count.TabIndex = 6;
            label_Count.Text = "已勾 / 總量";
            label_Count.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(154, 218);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 7;
            label5.Text = "button_Add";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(128, 172);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 7;
            label6.Text = "label_Count";
            label6.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 410);
            ControlBox = false;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label_Count);
            Controls.Add(label3);
            Controls.Add(button_Add);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cklstbx_EltvSubs);
            Controls.Add(lstbx_AddEltvSubs);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "學生選修課程系統";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstbx_AddEltvSubs;
        private CheckedListBox cklstbx_EltvSubs;
        private Label label1;
        private Label label2;
        private Button button_Add;
        private Label label3;
        private Label label_Count;
        private Label label5;
        private Label label6;
    }
}
