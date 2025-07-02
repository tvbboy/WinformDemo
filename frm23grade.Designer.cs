namespace myproject
{
    partial class frm23grade
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
            lblResult = new Label();
            txtNum1 = new TextBox();
            btnGetmax = new Button();
            txtNum2 = new TextBox();
            txtNum3 = new TextBox();
            txtDay = new TextBox();
            txtMonth = new TextBox();
            txtYear = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnGetday = new Button();
            dateTimePicker1 = new DateTimePicker();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            btnGetDays = new Button();
            cboType = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            cboProvince = new ComboBox();
            label8 = new Label();
            cboCity = new ComboBox();
            label9 = new Label();
            txtKey = new TextBox();
            btnSubmitBlank = new Button();
            label10 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            btnSubmitChoice = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label11 = new Label();
            lblSeconds = new Label();
            btnAlbum = new Button();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Microsoft YaHei UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblResult.ForeColor = Color.IndianRed;
            lblResult.Location = new Point(263, 26);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(270, 39);
            lblResult.TabIndex = 0;
            lblResult.Text = "Hello World  驼峰";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(3, 132);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(160, 23);
            txtNum1.TabIndex = 1;
            // 
            // btnGetmax
            // 
            btnGetmax.Location = new Point(3, 281);
            btnGetmax.Name = "btnGetmax";
            btnGetmax.Size = new Size(106, 66);
            btnGetmax.TabIndex = 2;
            btnGetmax.Text = "求最大值";
            btnGetmax.UseVisualStyleBackColor = true;
            btnGetmax.Click += btnGetmax_Click;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(3, 176);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(160, 23);
            txtNum2.TabIndex = 3;
            // 
            // txtNum3
            // 
            txtNum3.Location = new Point(3, 225);
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(160, 23);
            txtNum3.TabIndex = 4;
            // 
            // txtDay
            // 
            txtDay.Location = new Point(215, 225);
            txtDay.Name = "txtDay";
            txtDay.Size = new Size(160, 23);
            txtDay.TabIndex = 7;
            // 
            // txtMonth
            // 
            txtMonth.Location = new Point(215, 176);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new Size(160, 23);
            txtMonth.TabIndex = 6;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(215, 132);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(160, 23);
            txtYear.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 135);
            label1.Name = "label1";
            label1.Size = new Size(20, 17);
            label1.TabIndex = 8;
            label1.Text = "年";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 176);
            label2.Name = "label2";
            label2.Size = new Size(20, 17);
            label2.TabIndex = 9;
            label2.Text = "月";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 228);
            label3.Name = "label3";
            label3.Size = new Size(20, 17);
            label3.TabIndex = 10;
            label3.Text = "日";
            // 
            // btnGetday
            // 
            btnGetday.Location = new Point(215, 281);
            btnGetday.Name = "btnGetday";
            btnGetday.Size = new Size(160, 66);
            btnGetday.TabIndex = 11;
            btnGetday.Text = "求日期是该年的第几天";
            btnGetday.UseVisualStyleBackColor = true;
            btnGetday.Click += btnGetday_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(271, 94);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(95, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(483, 135);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(200, 23);
            dtpStart.TabIndex = 13;
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(483, 179);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(200, 23);
            dtpEnd.TabIndex = 14;
            dtpEnd.ValueChanged += dtpEnd_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(409, 138);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 15;
            label4.Text = "起始日期";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(409, 179);
            label5.Name = "label5";
            label5.Size = new Size(56, 17);
            label5.TabIndex = 16;
            label5.Text = "结束日期";
            // 
            // btnGetDays
            // 
            btnGetDays.Location = new Point(409, 281);
            btnGetDays.Name = "btnGetDays";
            btnGetDays.Size = new Size(274, 66);
            btnGetDays.TabIndex = 17;
            btnGetDays.Text = "求日期之间的差";
            btnGetDays.UseVisualStyleBackColor = true;
            btnGetDays.Click += btnGetDays_Click;
            // 
            // cboType
            // 
            cboType.FormattingEnabled = true;
            cboType.Items.AddRange(new object[] { "年", "月", "日" });
            cboType.Location = new Point(483, 220);
            cboType.Name = "cboType";
            cboType.Size = new Size(49, 25);
            cboType.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(409, 223);
            label6.Name = "label6";
            label6.Size = new Size(68, 17);
            label6.TabIndex = 19;
            label6.Text = "日期差类型";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(707, 141);
            label7.Name = "label7";
            label7.Size = new Size(32, 17);
            label7.TabIndex = 21;
            label7.Text = "省份";
            // 
            // cboProvince
            // 
            cboProvince.FormattingEnabled = true;
            cboProvince.Location = new Point(745, 135);
            cboProvince.Name = "cboProvince";
            cboProvince.Size = new Size(114, 25);
            cboProvince.TabIndex = 20;
            cboProvince.SelectedIndexChanged += cboProvince_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(707, 179);
            label8.Name = "label8";
            label8.Size = new Size(32, 17);
            label8.TabIndex = 23;
            label8.Text = "城市";
            // 
            // cboCity
            // 
            cboCity.FormattingEnabled = true;
            cboCity.Location = new Point(745, 173);
            cboCity.Name = "cboCity";
            cboCity.Size = new Size(114, 25);
            cboCity.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(905, 138);
            label9.Name = "label9";
            label9.Size = new Size(140, 17);
            label9.TabIndex = 24;
            label9.Text = "王安石生活在哪个朝代？";
            // 
            // txtKey
            // 
            txtKey.Location = new Point(905, 173);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(106, 23);
            txtKey.TabIndex = 25;
            // 
            // btnSubmitBlank
            // 
            btnSubmitBlank.Location = new Point(905, 203);
            btnSubmitBlank.Name = "btnSubmitBlank";
            btnSubmitBlank.Size = new Size(106, 37);
            btnSubmitBlank.TabIndex = 26;
            btnSubmitBlank.Text = "提交答案";
            btnSubmitBlank.UseVisualStyleBackColor = true;
            btnSubmitBlank.Click += btnSubmitBlank_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1085, 138);
            label10.Name = "label10";
            label10.Size = new Size(140, 17);
            label10.TabIndex = 27;
            label10.Text = "王安石生活在哪个朝代？";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(1082, 179);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(50, 21);
            radioButton1.TabIndex = 28;
            radioButton1.TabStop = true;
            radioButton1.Text = "明朝";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(1082, 211);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(50, 21);
            radioButton2.TabIndex = 29;
            radioButton2.TabStop = true;
            radioButton2.Text = "宋朝";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(1082, 247);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(50, 21);
            radioButton3.TabIndex = 30;
            radioButton3.TabStop = true;
            radioButton3.Text = "清朝";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(1082, 281);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(50, 21);
            radioButton4.TabIndex = 31;
            radioButton4.TabStop = true;
            radioButton4.Text = "唐朝";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // btnSubmitChoice
            // 
            btnSubmitChoice.Location = new Point(1082, 310);
            btnSubmitChoice.Name = "btnSubmitChoice";
            btnSubmitChoice.Size = new Size(106, 37);
            btnSubmitChoice.TabIndex = 32;
            btnSubmitChoice.Text = "提交答案";
            btnSubmitChoice.UseVisualStyleBackColor = true;
            btnSubmitChoice.Click += btnSubmitChoice_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1085, 110);
            label11.Name = "label11";
            label11.Size = new Size(104, 17);
            label11.TabIndex = 33;
            label11.Text = "距离自动交卷还有";
            // 
            // lblSeconds
            // 
            lblSeconds.AutoSize = true;
            lblSeconds.Font = new Font("Microsoft YaHei UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblSeconds.ForeColor = Color.Coral;
            lblSeconds.Location = new Point(1195, 99);
            lblSeconds.Name = "lblSeconds";
            lblSeconds.Size = new Size(53, 39);
            lblSeconds.TabIndex = 34;
            lblSeconds.Text = "10";
            // 
            // btnAlbum
            // 
            btnAlbum.Location = new Point(525, 372);
            btnAlbum.Name = "btnAlbum";
            btnAlbum.Size = new Size(274, 66);
            btnAlbum.TabIndex = 35;
            btnAlbum.Text = "\u007f打开我的相册";
            btnAlbum.UseVisualStyleBackColor = true;
            btnAlbum.Click += btnAlbum_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1324, 450);
            Controls.Add(btnAlbum);
            Controls.Add(lblSeconds);
            Controls.Add(label11);
            Controls.Add(btnSubmitChoice);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label10);
            Controls.Add(btnSubmitBlank);
            Controls.Add(txtKey);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(cboCity);
            Controls.Add(label7);
            Controls.Add(cboProvince);
            Controls.Add(label6);
            Controls.Add(cboType);
            Controls.Add(btnGetDays);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnGetday);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDay);
            Controls.Add(txtMonth);
            Controls.Add(txtYear);
            Controls.Add(txtNum3);
            Controls.Add(txtNum2);
            Controls.Add(btnGetmax);
            Controls.Add(txtNum1);
            Controls.Add(lblResult);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult;
        private TextBox txtNum1;
        private Button btnGetmax;
        private TextBox txtNum2;
        private TextBox txtNum3;
        private TextBox txtDay;
        private TextBox txtMonth;
        private TextBox txtYear;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnGetday;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Label label4;
        private Label label5;
        private Button btnGetDays;
        private ComboBox cboType;
        private Label label6;
        private Label label7;
        private ComboBox cboProvince;
        private Label label8;
        private ComboBox cboCity;
        private Label label9;
        private TextBox txtKey;
        private Button btnSubmitBlank;
        private Label label10;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button btnSubmitChoice;
        private System.Windows.Forms.Timer timer1;
        private Label label11;
        private Label lblSeconds;
        private Button btnAlbum;
    }
}
