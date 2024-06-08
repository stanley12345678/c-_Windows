namespace A20240330_05
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
            dataGridView_Menu = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Menu).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_Menu
            // 
            dataGridView_Menu.AllowUserToAddRows = false;
            dataGridView_Menu.AllowUserToDeleteRows = false;
            dataGridView_Menu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Menu.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView_Menu.Location = new Point(32, 34);
            dataGridView_Menu.Name = "dataGridView_Menu";
            dataGridView_Menu.ReadOnly = true;
            dataGridView_Menu.RowHeadersWidth = 20;
            dataGridView_Menu.Size = new Size(240, 150);
            dataGridView_Menu.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "飲品名稱";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "建議售價";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 16);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 1;
            label1.Text = "可供選購飲料：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(164, 16);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 2;
            label2.Text = "dataGridView_Menu";
            label2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 222);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView_Menu);
            Name = "Form1";
            Text = "【飲品購物系統】";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Menu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_Menu;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Label label1;
        private Label label2;
    }
}
