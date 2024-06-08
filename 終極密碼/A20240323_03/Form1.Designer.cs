namespace A20240323_03
{
    partial class MainForm
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
            label_Mini = new Label();
            label_Max = new Label();
            textBox_PlayerGuess = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button_Replay = new Button();
            button_Exit = new Button();
            button_Guess = new Button();
            label8 = new Label();
            label1 = new Label();
            label2 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label_PcAns = new Label();
            SuspendLayout();
            // 
            // label_Mini
            // 
            label_Mini.BorderStyle = BorderStyle.FixedSingle;
            label_Mini.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label_Mini.Location = new Point(12, 44);
            label_Mini.Name = "label_Mini";
            label_Mini.Size = new Size(95, 36);
            label_Mini.TabIndex = 0;
            label_Mini.Text = "100000";
            label_Mini.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Max
            // 
            label_Max.BorderStyle = BorderStyle.FixedSingle;
            label_Max.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label_Max.Location = new Point(306, 44);
            label_Max.Name = "label_Max";
            label_Max.Size = new Size(95, 36);
            label_Max.TabIndex = 0;
            label_Max.Text = "100000";
            label_Max.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_PlayerGuess
            // 
            textBox_PlayerGuess.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 136);
            textBox_PlayerGuess.Location = new Point(148, 38);
            textBox_PlayerGuess.Name = "textBox_PlayerGuess";
            textBox_PlayerGuess.Size = new Size(117, 48);
            textBox_PlayerGuess.TabIndex = 1;
            textBox_PlayerGuess.Text = "99999";
            textBox_PlayerGuess.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Bold);
            label3.Location = new Point(111, 49);
            label3.Name = "label3";
            label3.Size = new Size(33, 26);
            label3.TabIndex = 2;
            label3.Text = "＜";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Bold);
            label4.Location = new Point(269, 49);
            label4.Name = "label4";
            label4.Size = new Size(33, 26);
            label4.TabIndex = 2;
            label4.Text = "＜";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label5.Location = new Point(31, 24);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 3;
            label5.Text = "最小值";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label6.Location = new Point(325, 24);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 3;
            label6.Text = "最大值";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label7.Location = new Point(162, 15);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 3;
            label7.Text = "玩家猜測值";
            // 
            // button_Replay
            // 
            button_Replay.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            button_Replay.Location = new Point(12, 120);
            button_Replay.Name = "button_Replay";
            button_Replay.Size = new Size(95, 33);
            button_Replay.TabIndex = 4;
            button_Replay.Text = "另啟新局";
            button_Replay.UseVisualStyleBackColor = true;
            button_Replay.Click += button_Replay_Click;
            // 
            // button_Exit
            // 
            button_Exit.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            button_Exit.Location = new Point(306, 120);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(95, 33);
            button_Exit.TabIndex = 4;
            button_Exit.Text = "結束遊戲";
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // button_Guess
            // 
            button_Guess.Font = new Font("Microsoft JhengHei UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            button_Guess.Location = new Point(113, 111);
            button_Guess.Name = "button_Guess";
            button_Guess.Size = new Size(187, 51);
            button_Guess.TabIndex = 4;
            button_Guess.Text = "猜數字";
            button_Guess.UseVisualStyleBackColor = true;
            button_Guess.Click += button_Guess_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(31, 74);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 5;
            label8.Text = "label_Mini";
            label8.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(325, 74);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 5;
            label1.Text = "label_Max";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(148, 74);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 5;
            label2.Text = "textBox_PlayerGuess";
            label2.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(14, 152);
            label9.Name = "label9";
            label9.Size = new Size(89, 15);
            label9.TabIndex = 5;
            label9.Text = "button_Replay";
            label9.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(318, 152);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 5;
            label10.Text = "button_Exit";
            label10.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(166, 154);
            label11.Name = "label11";
            label11.Size = new Size(83, 15);
            label11.TabIndex = 5;
            label11.Text = "button_Guess";
            label11.Visible = false;
            // 
            // label_PcAns
            // 
            label_PcAns.AutoSize = true;
            label_PcAns.ForeColor = Color.Blue;
            label_PcAns.Location = new Point(0, 0);
            label_PcAns.Name = "label_PcAns";
            label_PcAns.Size = new Size(73, 15);
            label_PcAns.TabIndex = 6;
            label_PcAns.Text = "label_PcAns";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 183);
            ControlBox = false;
            Controls.Add(label_PcAns);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button_Exit);
            Controls.Add(button_Guess);
            Controls.Add(button_Replay);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox_PlayerGuess);
            Controls.Add(label_Max);
            Controls.Add(label_Mini);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "終極密碼 (猜數字遊戲)";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Mini;
        private Label label_Max;
        private TextBox textBox_PlayerGuess;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button_Replay;
        private Button button_Exit;
        private Button button_Guess;
        private Label label8;
        private Label label1;
        private Label label2;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label_PcAns;
    }
}
