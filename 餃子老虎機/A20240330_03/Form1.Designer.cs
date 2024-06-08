namespace A20240330_03
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
            components = new System.ComponentModel.Container();
            label_Value1 = new Label();
            label_Value2 = new Label();
            label_Value3 = new Label();
            button_Play = new Button();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label_Value1
            // 
            label_Value1.BorderStyle = BorderStyle.FixedSingle;
            label_Value1.Font = new Font("Microsoft JhengHei UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label_Value1.Location = new Point(12, 18);
            label_Value1.Name = "label_Value1";
            label_Value1.Size = new Size(77, 129);
            label_Value1.TabIndex = 0;
            label_Value1.Text = "9";
            label_Value1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Value2
            // 
            label_Value2.BorderStyle = BorderStyle.FixedSingle;
            label_Value2.Font = new Font("Microsoft JhengHei UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label_Value2.Location = new Point(95, 18);
            label_Value2.Name = "label_Value2";
            label_Value2.Size = new Size(77, 129);
            label_Value2.TabIndex = 0;
            label_Value2.Text = "9";
            label_Value2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Value3
            // 
            label_Value3.BorderStyle = BorderStyle.FixedSingle;
            label_Value3.Font = new Font("Microsoft JhengHei UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label_Value3.Location = new Point(178, 18);
            label_Value3.Name = "label_Value3";
            label_Value3.Size = new Size(77, 129);
            label_Value3.TabIndex = 0;
            label_Value3.Text = "9";
            label_Value3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_Play
            // 
            button_Play.Font = new Font("Microsoft JhengHei UI", 60F, FontStyle.Bold, GraphicsUnit.Point, 136);
            button_Play.Location = new Point(12, 159);
            button_Play.Name = "button_Play";
            button_Play.Size = new Size(243, 109);
            button_Play.TabIndex = 1;
            button_Play.Text = "骰動";
            button_Play.UseVisualStyleBackColor = true;
            button_Play.Click += button_Play_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(0, 9);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 2;
            label4.Text = "label_Value1";
            label4.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(95, 9);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 2;
            label1.Text = "label_Value2";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(185, 9);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 2;
            label2.Text = "label_Value3";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(144, 253);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "button_Play";
            label3.Visible = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Tick += timer3_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 285);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(button_Play);
            Controls.Add(label_Value3);
            Controls.Add(label_Value2);
            Controls.Add(label_Value1);
            Name = "Form1";
            Text = "電子骰子";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Value1;
        private Label label_Value2;
        private Label label_Value3;
        private Button button_Play;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}
