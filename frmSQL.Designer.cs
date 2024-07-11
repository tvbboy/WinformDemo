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
            chkAll = new CheckBox();
            lblCount = new Label();
            btnAlert = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            listView1 = new ListView();
            listView2 = new ListView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnLink
            // 
            btnLink.Location = new Point(39, 41);
            btnLink.Name = "btnLink";
            btnLink.Size = new Size(122, 23);
            btnLink.TabIndex = 0;
            btnLink.Text = "测试数据库链接";
            btnLink.UseVisualStyleBackColor = true;
            btnLink.Click += btnLink_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(202, 41);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(122, 23);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "一键打卡";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 177);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(285, 437);
            dataGridView1.TabIndex = 2;
            // 
            // cboMajor
            // 
            cboMajor.FormattingEnabled = true;
            cboMajor.Location = new Point(77, 84);
            cboMajor.Name = "cboMajor";
            cboMajor.Size = new Size(159, 25);
            cboMajor.TabIndex = 3;
            // 
            // txtStuName
            // 
            txtStuName.Location = new Point(77, 115);
            txtStuName.Name = "txtStuName";
            txtStuName.Size = new Size(159, 23);
            txtStuName.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(242, 115);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "查找";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 118);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 6;
            label1.Text = "姓名";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 84);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 7;
            label2.Text = "专业";
            // 
            // chkAll
            // 
            chkAll.AutoSize = true;
            chkAll.Location = new Point(273, 86);
            chkAll.Name = "chkAll";
            chkAll.Size = new Size(51, 21);
            chkAll.TabIndex = 8;
            chkAll.Text = "全部";
            chkAll.UseVisualStyleBackColor = true;
            chkAll.CheckedChanged += chkAll_CheckedChanged;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(39, 157);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(43, 17);
            lblCount.TabIndex = 9;
            lblCount.Text = "label3";
            // 
            // btnAlert
            // 
            btnAlert.Location = new Point(385, 151);
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
            listView1.Location = new Point(385, 180);
            listView1.Name = "listView1";
            listView1.Size = new Size(227, 388);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // listView2
            // 
            listView2.Location = new Point(683, 180);
            listView2.Name = "listView2";
            listView2.Size = new Size(503, 388);
            listView2.TabIndex = 12;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.List;
            // 
            // frmSQL
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1534, 626);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(btnAlert);
            Controls.Add(lblCount);
            Controls.Add(chkAll);
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
        private CheckBox chkAll;
        private Label lblCount;
        private Button btnAlert;
        private System.Windows.Forms.Timer timer1;
        private ListView listView1;
        private ListView listView2;
    }
}