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
            grpBox.SuspendLayout();
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
            grpBox.Location = new Point(62, 194);
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
            // frm24grade
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 496);
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
    }
}
