namespace myproject
{
    partial class frmTiebaSpider
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
            btnCrawlInfo = new Button();
            txtTiebaName = new TextBox();
            numPages = new NumericUpDown();
            progressBar1 = new ProgressBar();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btnCrawlImage = new Button();
            label3 = new Label();
            txtSavePath = new TextBox();
            btnSavePath = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            lstLog = new ListBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numPages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCrawlInfo
            // 
            btnCrawlInfo.Location = new Point(477, 38);
            btnCrawlInfo.Name = "btnCrawlInfo";
            btnCrawlInfo.Size = new Size(118, 37);
            btnCrawlInfo.TabIndex = 0;
            btnCrawlInfo.Text = "开始爬取信息";
            btnCrawlInfo.UseVisualStyleBackColor = true;
            btnCrawlInfo.Click += btnCrawl_Click;
            // 
            // txtTiebaName
            // 
            txtTiebaName.Location = new Point(107, 43);
            txtTiebaName.Name = "txtTiebaName";
            txtTiebaName.Size = new Size(213, 28);
            txtTiebaName.TabIndex = 1;
            // 
            // numPages
            // 
            numPages.Location = new Point(397, 43);
            numPages.Name = "numPages";
            numPages.Size = new Size(61, 28);
            numPages.TabIndex = 3;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(27, 133);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(707, 23);
            progressBar1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 162);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(707, 375);
            dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(339, 46);
            label1.Name = "label1";
            label1.Size = new Size(42, 22);
            label1.TabIndex = 6;
            label1.Text = "页数";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 45);
            label2.Name = "label2";
            label2.Size = new Size(74, 22);
            label2.TabIndex = 7;
            label2.Text = "贴吧名称";
            // 
            // btnCrawlImage
            // 
            btnCrawlImage.Location = new Point(477, 81);
            btnCrawlImage.Name = "btnCrawlImage";
            btnCrawlImage.Size = new Size(118, 37);
            btnCrawlImage.TabIndex = 8;
            btnCrawlImage.Text = "开始爬取图片";
            btnCrawlImage.UseVisualStyleBackColor = true;
            btnCrawlImage.Click += btnCrawlImage_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 88);
            label3.Name = "label3";
            label3.Size = new Size(74, 22);
            label3.TabIndex = 10;
            label3.Text = "图片存放";
            // 
            // txtSavePath
            // 
            txtSavePath.Location = new Point(107, 86);
            txtSavePath.Name = "txtSavePath";
            txtSavePath.Size = new Size(213, 28);
            txtSavePath.TabIndex = 9;
            // 
            // btnSavePath
            // 
            btnSavePath.Location = new Point(326, 81);
            btnSavePath.Name = "btnSavePath";
            btnSavePath.Size = new Size(36, 37);
            btnSavePath.TabIndex = 11;
            btnSavePath.Text = "...";
            btnSavePath.UseVisualStyleBackColor = true;
            btnSavePath.Click += btnSavePath_Click;
            // 
            // lstLog
            // 
            lstLog.FormattingEnabled = true;
            lstLog.Location = new Point(764, 137);
            lstLog.Name = "lstLog";
            lstLog.Size = new Size(645, 400);
            lstLog.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(764, 112);
            label4.Name = "label4";
            label4.Size = new Size(74, 22);
            label4.TabIndex = 13;
            label4.Text = "爬取日志";
            // 
            // frmTiebaSpider
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1441, 600);
            Controls.Add(label4);
            Controls.Add(lstLog);
            Controls.Add(btnSavePath);
            Controls.Add(label3);
            Controls.Add(txtSavePath);
            Controls.Add(btnCrawlImage);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(progressBar1);
            Controls.Add(numPages);
            Controls.Add(txtTiebaName);
            Controls.Add(btnCrawlInfo);
            Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            Margin = new Padding(4);
            Name = "frmTiebaSpider";
            Text = "frmSpider";
            ((System.ComponentModel.ISupportInitialize)numPages).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCrawlInfo;
        private TextBox txtTiebaName;
        private NumericUpDown numPages;
        private ProgressBar progressBar1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Button btnCrawlImage;
        private Label label3;
        private TextBox txtSavePath;
        private Button btnSavePath;
        private FolderBrowserDialog folderBrowserDialog1;
        private ListBox lstLog;
        private Label label4;
    }
}