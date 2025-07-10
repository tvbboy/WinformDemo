namespace myproject
{
    partial class frmSQL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnLink = new Button();
            btnInsert = new Button();
            dataGridView1 = new DataGridView();
            cboMajor = new ComboBox();
            txtStuName = new TextBox();
            btnSearch = new Button();
            label1 = new Label();
            label2 = new Label();
            lblCount = new Label();
            btnAlert = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            listView1 = new ListView();
            listView2 = new ListView();
            txtStudentname = new TextBox();
            label3 = new Label();
            lblStudentNo = new Label();
            txtStudentNo = new TextBox();
            label4 = new Label();
            txtMajor = new TextBox();
            pictureBox1 = new PictureBox();
            btnUpdate = new Button();
            label5 = new Label();
            txtPwd = new TextBox();
            label6 = new Label();
            txtConfirmPwd = new TextBox();
            btnUpdatePwd = new Button();
            btnResetPwd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLink
            // 
            btnLink.Location = new Point(12, 12);
            btnLink.Name = "btnLink";
            btnLink.Size = new Size(122, 23);
            btnLink.TabIndex = 0;
            btnLink.Text = "测试数据库链接";
            btnLink.UseVisualStyleBackColor = true;
            btnLink.Click += btnLink_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(156, 12);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(122, 23);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "一键打卡";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(377, 437);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // cboMajor
            // 
            cboMajor.FormattingEnabled = true;
            cboMajor.Location = new Point(50, 47);
            cboMajor.Name = "cboMajor";
            cboMajor.Size = new Size(159, 25);
            cboMajor.TabIndex = 3;
            // 
            // txtStuName
            // 
            txtStuName.Location = new Point(260, 46);
            txtStuName.Name = "txtStuName";
            txtStuName.Size = new Size(159, 23);
            txtStuName.TabIndex = 4;
            txtStuName.TextChanged += txtStuName_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(425, 43);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 28);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "查找";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 49);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 6;
            label1.Text = "姓名";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 7;
            label2.Text = "专业";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(12, 75);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(43, 17);
            lblCount.TabIndex = 9;
            lblCount.Text = "label3";
            // 
            // btnAlert
            // 
            btnAlert.Location = new Point(683, 134);
            btnAlert.Name = "btnAlert";
            btnAlert.Size = new Size(256, 23);
            btnAlert.TabIndex = 10;
            btnAlert.Text = "开始报警";
            btnAlert.UseVisualStyleBackColor = true;
            btnAlert.Click += button1_Click_1;
            // 
            // timer1
            // 
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // listView1
            // 
            listView1.Location = new Point(667, 180);
            listView1.Name = "listView1";
            listView1.Size = new Size(153, 388);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // listView2
            // 
            listView2.Location = new Point(826, 180);
            listView2.Name = "listView2";
            listView2.Size = new Size(360, 388);
            listView2.TabIndex = 12;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.List;
            // 
            // txtStudentname
            // 
            txtStudentname.Location = new Point(459, 273);
            txtStudentname.Name = "txtStudentname";
            txtStudentname.Size = new Size(138, 23);
            txtStudentname.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(404, 276);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 14;
            label3.Text = "姓名";
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Location = new Point(404, 310);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(32, 17);
            lblStudentNo.TabIndex = 16;
            lblStudentNo.Text = "学号";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(459, 307);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.ReadOnly = true;
            txtStudentNo.Size = new Size(138, 23);
            txtStudentNo.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(404, 347);
            label4.Name = "label4";
            label4.Size = new Size(32, 17);
            label4.TabIndex = 18;
            label4.Text = "专业";
            // 
            // txtMajor
            // 
            txtMajor.Location = new Point(459, 344);
            txtMajor.Name = "txtMajor";
            txtMajor.Size = new Size(138, 23);
            txtMajor.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(395, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(459, 384);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 23);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "更新";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(404, 442);
            label5.Name = "label5";
            label5.Size = new Size(32, 17);
            label5.TabIndex = 22;
            label5.Text = "密码";
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(459, 439);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.Size = new Size(138, 23);
            txtPwd.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(404, 471);
            label6.Name = "label6";
            label6.Size = new Size(56, 17);
            label6.TabIndex = 24;
            label6.Text = "重复密码";
            // 
            // txtConfirmPwd
            // 
            txtConfirmPwd.Location = new Point(459, 468);
            txtConfirmPwd.Name = "txtConfirmPwd";
            txtConfirmPwd.PasswordChar = '*';
            txtConfirmPwd.Size = new Size(138, 23);
            txtConfirmPwd.TabIndex = 23;
            // 
            // btnUpdatePwd
            // 
            btnUpdatePwd.Location = new Point(916, 66);
            btnUpdatePwd.Name = "btnUpdatePwd";
            btnUpdatePwd.Size = new Size(82, 23);
            btnUpdatePwd.TabIndex = 25;
            btnUpdatePwd.Text = "更新密码";
            btnUpdatePwd.UseVisualStyleBackColor = true;
            // 
            // btnResetPwd
            // 
            btnResetPwd.Location = new Point(459, 511);
            btnResetPwd.Name = "btnResetPwd";
            btnResetPwd.Size = new Size(82, 23);
            btnResetPwd.TabIndex = 26;
            btnResetPwd.Text = "重置密码";
            btnResetPwd.UseVisualStyleBackColor = true;
            btnResetPwd.Click += btnResetPwd_Click;
            // 
            // frmSQL
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1534, 626);
            Controls.Add(btnResetPwd);
            Controls.Add(btnUpdatePwd);
            Controls.Add(label6);
            Controls.Add(txtConfirmPwd);
            Controls.Add(label5);
            Controls.Add(txtPwd);
            Controls.Add(btnUpdate);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(txtMajor);
            Controls.Add(lblStudentNo);
            Controls.Add(txtStudentNo);
            Controls.Add(label3);
            Controls.Add(txtStudentname);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(btnAlert);
            Controls.Add(lblCount);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(txtStuName);
            Controls.Add(cboMajor);
            Controls.Add(dataGridView1);
            Controls.Add(btnInsert);
            Controls.Add(btnLink);
            Name = "frmSQL";
            Text = "SQL练习";
            Load += frmSQL_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLink;
        private Button btnInsert;
        private DataGridView dataGridView1;
        private ComboBox cboMajor;
        private TextBox txtStuName;
        private Button btnSearch;
        private Label label1;
        private Label label2;
        private Label lblCount;
        private Button btnAlert;
        private System.Windows.Forms.Timer timer1;
        private ListView listView1;
        private ListView listView2;
        private TextBox txtStudentname;
        private Label label3;
        private Label lblStudentNo;
        private TextBox txtStudentNo;
        private Label label4;
        private TextBox txtMajor;
        private PictureBox pictureBox1;
        private Button btnUpdate;
        private Label label5;
        private TextBox txtPwd;
        private Label label6;
        private TextBox txtConfirmPwd;
        private Button btnUpdatePwd;
        private Button btnResetPwd;
    }
}