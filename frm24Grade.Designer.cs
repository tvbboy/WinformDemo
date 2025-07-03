namespace myproject
{
    partial class frm24grade
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
            lblInfo = new Label();
            btnInfo2 = new Button();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtNum3 = new TextBox();
            btnGetMaxMin = new Button();
            chkMaxMin = new CheckBox();
            radA = new RadioButton();
            grpBox = new GroupBox();
            label1 = new Label();
            radC = new RadioButton();
            radB = new RadioButton();
            timer1 = new System.Windows.Forms.Timer(components);
            lblTimer = new Label();
            btnTimer = new Button();
            progressBar1 = new ProgressBar();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            btnDate = new Button();
            dateTimePickerEnd = new DateTimePicker();
            dateTimePickerStart = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            btnDateDiff = new Button();
            cboNative = new ComboBox();
            label5 = new Label();
            cmbProvince = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cmbCity = new ComboBox();
            cmbDistrict = new ComboBox();
            pbx = new PictureBox();
            btnShowImage = new Button();
            cboImageStyle = new ComboBox();
            label9 = new Label();
            numericUpDown1 = new NumericUpDown();
            listBox1 = new ListBox();
            listView1 = new ListView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            colorDialog1 = new ColorDialog();
            btnChangeColor = new Button();
            button1 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            grpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfo.Location = new Point(12, 9);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(113, 27);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "HelloWorld";
            // 
            // btnInfo2
            // 
            btnInfo2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnInfo2.Location = new Point(695, 12);
            btnInfo2.Name = "btnInfo2";
            btnInfo2.Size = new Size(93, 36);
            btnInfo2.TabIndex = 1;
            btnInfo2.Text = "关于";
            btnInfo2.UseVisualStyleBackColor = true;
            btnInfo2.Click += btnInfo_Click;
            // 
            // txtNum1
            // 
            txtNum1.BackColor = SystemColors.Info;
            txtNum1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNum1.ForeColor = Color.Red;
            txtNum1.Location = new Point(62, 138);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 30);
            txtNum1.TabIndex = 2;
            txtNum1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNum2
            // 
            txtNum2.BackColor = SystemColors.Info;
            txtNum2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNum2.ForeColor = Color.Red;
            txtNum2.Location = new Point(223, 138);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 30);
            txtNum2.TabIndex = 3;
            txtNum2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNum3
            // 
            txtNum3.BackColor = SystemColors.Info;
            txtNum3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNum3.ForeColor = Color.Red;
            txtNum3.Location = new Point(379, 138);
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(100, 30);
            txtNum3.TabIndex = 4;
            txtNum3.TextAlign = HorizontalAlignment.Center;
            // 
            // btnGetMaxMin
            // 
            btnGetMaxMin.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnGetMaxMin.Location = new Point(570, 135);
            btnGetMaxMin.Name = "btnGetMaxMin";
            btnGetMaxMin.Size = new Size(93, 36);
            btnGetMaxMin.TabIndex = 5;
            btnGetMaxMin.Text = "极值";
            btnGetMaxMin.UseVisualStyleBackColor = true;
            btnGetMaxMin.Click += btnGetMax_Click;
            // 
            // chkMaxMin
            // 
            chkMaxMin.AutoSize = true;
            chkMaxMin.Location = new Point(499, 145);
            chkMaxMin.Name = "chkMaxMin";
            chkMaxMin.Size = new Size(51, 21);
            chkMaxMin.TabIndex = 6;
            chkMaxMin.Text = "最小";
            chkMaxMin.UseVisualStyleBackColor = true;
            // 
            // radA
            // 
            radA.AutoSize = true;
            radA.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            radA.Location = new Point(24, 82);
            radA.Name = "radA";
            radA.Size = new Size(60, 26);
            radA.TabIndex = 7;
            radA.TabStop = true;
            radA.Text = "北京";
            radA.UseVisualStyleBackColor = true;
            radA.CheckedChanged += radioButton_CheckedChanged;
            // 
            // grpBox
            // 
            grpBox.Controls.Add(label1);
            grpBox.Controls.Add(radC);
            grpBox.Controls.Add(radB);
            grpBox.Controls.Add(radA);
            grpBox.Location = new Point(19, 183);
            grpBox.Name = "grpBox";
            grpBox.Size = new Size(304, 205);
            grpBox.TabIndex = 8;
            grpBox.TabStop = false;
            grpBox.Text = "做题区";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 36);
            label1.Name = "label1";
            label1.Size = new Size(188, 27);
            label1.TabIndex = 9;
            label1.Text = "请问中国的首都是:";
            // 
            // radC
            // 
            radC.AutoSize = true;
            radC.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            radC.Location = new Point(24, 154);
            radC.Name = "radC";
            radC.Size = new Size(60, 26);
            radC.TabIndex = 9;
            radC.TabStop = true;
            radC.Text = "杭州";
            radC.UseVisualStyleBackColor = true;
            radC.CheckedChanged += radioButton_CheckedChanged;
            // 
            // radB
            // 
            radB.AutoSize = true;
            radB.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            radB.Location = new Point(24, 118);
            radB.Name = "radB";
            radB.Size = new Size(60, 26);
            radB.TabIndex = 8;
            radB.TabStop = true;
            radB.Text = "上海";
            radB.UseVisualStyleBackColor = true;
            radB.CheckedChanged += radioButton_CheckedChanged;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Location = new Point(656, 320);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(32, 17);
            lblTimer.TabIndex = 9;
            lblTimer.Text = "时间";
            // 
            // btnTimer
            // 
            btnTimer.Location = new Point(741, 317);
            btnTimer.Name = "btnTimer";
            btnTimer.Size = new Size(98, 23);
            btnTimer.TabIndex = 10;
            btnTimer.Text = "倒计时开始";
            btnTimer.UseVisualStyleBackColor = true;
            btnTimer.Click += btnTimer_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(601, 375);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(409, 13);
            progressBar1.TabIndex = 11;
            progressBar1.Value = 50;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(628, 234);
            dateTimePicker1.MaxDate = new DateTime(2106, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2006, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(566, 234);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 13;
            label2.Text = "出生日期";
            // 
            // btnDate
            // 
            btnDate.Location = new Point(850, 234);
            btnDate.Name = "btnDate";
            btnDate.Size = new Size(75, 23);
            btnDate.TabIndex = 14;
            btnDate.Text = "日期解析";
            btnDate.UseVisualStyleBackColor = true;
            btnDate.Click += btnDate_Click;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(780, 276);
            dateTimePickerEnd.MaxDate = new DateTime(2106, 12, 31, 0, 0, 0, 0);
            dateTimePickerEnd.MinDate = new DateTime(2006, 1, 1, 0, 0, 0, 0);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 23);
            dateTimePickerEnd.TabIndex = 15;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(512, 276);
            dateTimePickerStart.MaxDate = new DateTime(2106, 12, 31, 0, 0, 0, 0);
            dateTimePickerStart.MinDate = new DateTime(2006, 1, 1, 0, 0, 0, 0);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(200, 23);
            dateTimePickerStart.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(450, 281);
            label3.Name = "label3";
            label3.Size = new Size(56, 17);
            label3.TabIndex = 17;
            label3.Text = "开始日期";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(718, 276);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 18;
            label4.Text = "结束日期";
            // 
            // btnDateDiff
            // 
            btnDateDiff.Location = new Point(1007, 276);
            btnDateDiff.Name = "btnDateDiff";
            btnDateDiff.Size = new Size(75, 23);
            btnDateDiff.TabIndex = 19;
            btnDateDiff.Text = "日期比较";
            btnDateDiff.UseVisualStyleBackColor = true;
            btnDateDiff.Click += btnDateDiff_Click;
            // 
            // cboNative
            // 
            cboNative.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNative.FormattingEnabled = true;
            cboNative.Items.AddRange(new object[] { "汉", "回", "维吾尔", "蒙古", "壮" });
            cboNative.Location = new Point(73, 74);
            cboNative.Name = "cboNative";
            cboNative.Size = new Size(121, 25);
            cboNative.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 77);
            label5.Name = "label5";
            label5.Size = new Size(32, 17);
            label5.TabIndex = 21;
            label5.Text = "民族";
            // 
            // cmbProvince
            // 
            cmbProvince.FormattingEnabled = true;
            cmbProvince.Location = new Point(334, 71);
            cmbProvince.Name = "cmbProvince";
            cmbProvince.Size = new Size(121, 25);
            cmbProvince.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(470, 77);
            label6.Name = "label6";
            label6.Size = new Size(20, 17);
            label6.TabIndex = 23;
            label6.Text = "市";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(274, 77);
            label7.Name = "label7";
            label7.Size = new Size(20, 17);
            label7.TabIndex = 24;
            label7.Text = "省";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(643, 79);
            label8.Name = "label8";
            label8.Size = new Size(20, 17);
            label8.TabIndex = 25;
            label8.Text = "区";
            // 
            // cmbCity
            // 
            cmbCity.FormattingEnabled = true;
            cmbCity.Location = new Point(512, 72);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(121, 25);
            cmbCity.TabIndex = 26;
            // 
            // cmbDistrict
            // 
            cmbDistrict.FormattingEnabled = true;
            cmbDistrict.Location = new Point(669, 70);
            cmbDistrict.Name = "cmbDistrict";
            cmbDistrict.Size = new Size(121, 25);
            cmbDistrict.TabIndex = 27;
            // 
            // pbx
            // 
            pbx.Location = new Point(440, 414);
            pbx.Name = "pbx";
            pbx.Size = new Size(182, 120);
            pbx.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx.TabIndex = 28;
            pbx.TabStop = false;
            // 
            // btnShowImage
            // 
            btnShowImage.Location = new Point(637, 511);
            btnShowImage.Name = "btnShowImage";
            btnShowImage.Size = new Size(75, 23);
            btnShowImage.TabIndex = 29;
            btnShowImage.Text = "加载图片";
            btnShowImage.UseVisualStyleBackColor = true;
            btnShowImage.Click += btnShowImage_Click;
            // 
            // cboImageStyle
            // 
            cboImageStyle.FormattingEnabled = true;
            cboImageStyle.Items.AddRange(new object[] { "Stretch", "autosize" });
            cboImageStyle.Location = new Point(705, 437);
            cboImageStyle.Name = "cboImageStyle";
            cboImageStyle.Size = new Size(121, 25);
            cboImageStyle.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(643, 440);
            label9.Name = "label9";
            label9.Size = new Size(56, 17);
            label9.TabIndex = 31;
            label9.Text = "显示方式";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(772, 133);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 32;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(911, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 89);
            listBox1.TabIndex = 33;
            // 
            // listView1
            // 
            listView1.Location = new Point(910, 107);
            listView1.Name = "listView1";
            listView1.Size = new Size(121, 97);
            listView1.TabIndex = 34;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(65, 420);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(200, 100);
            tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(192, 70);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 70);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnChangeColor
            // 
            btnChangeColor.Location = new Point(290, 482);
            btnChangeColor.Name = "btnChangeColor";
            btnChangeColor.Size = new Size(75, 23);
            btnChangeColor.TabIndex = 36;
            btnChangeColor.Text = "调背景色";
            btnChangeColor.UseVisualStyleBackColor = true;
            btnChangeColor.Click += btnChangeColor_Click;
            // 
            // button1
            // 
            button1.Location = new Point(291, 446);
            button1.Name = "button1";
            button1.Size = new Size(101, 30);
            button1.TabIndex = 37;
            button1.Text = "打开计算器";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frm24grade
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 573);
            Controls.Add(button1);
            Controls.Add(btnChangeColor);
            Controls.Add(tabControl1);
            Controls.Add(listView1);
            Controls.Add(listBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(label9);
            Controls.Add(cboImageStyle);
            Controls.Add(btnShowImage);
            Controls.Add(pbx);
            Controls.Add(cmbDistrict);
            Controls.Add(cmbCity);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cmbProvince);
            Controls.Add(label5);
            Controls.Add(cboNative);
            Controls.Add(btnDateDiff);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePickerStart);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(btnDate);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(progressBar1);
            Controls.Add(btnTimer);
            Controls.Add(lblTimer);
            Controls.Add(grpBox);
            Controls.Add(chkMaxMin);
            Controls.Add(btnGetMaxMin);
            Controls.Add(txtNum3);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(btnInfo2);
            Controls.Add(lblInfo);
            Name = "frm24grade";
            Text = "这是我第一个WINFORM";
            grpBox.ResumeLayout(false);
            grpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfo;
        private Button btnInfo2;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtNum3;
        private Button btnGetMaxMin;
        private CheckBox chkMaxMin;
        private RadioButton radA;
        private GroupBox grpBox;
        private RadioButton radC;
        private RadioButton radB;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label lblTimer;
        private Button btnTimer;
        private ProgressBar progressBar1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Button btnDate;
        private DateTimePicker dateTimePickerEnd;
        private DateTimePicker dateTimePickerStart;
        private Label label3;
        private Label label4;
        private Button btnDateDiff;
        private ComboBox cboNative;
        private Label label5;
        private ComboBox cmbProvince;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cmbCity;
        private ComboBox cmbDistrict;
        private PictureBox pbx;
        private Button btnShowImage;
        private ComboBox cboImageStyle;
        private Label label9;
        private NumericUpDown numericUpDown1;
        private ListBox listBox1;
        private ListView listView1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ColorDialog colorDialog1;
        private Button btnChangeColor;
        private Button button1;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}
