namespace myproject
{
    partial class frmMain
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
            btnHomework1 = new Button();
            btnHomework2 = new Button();
            btnSearchFile = new Button();
            btnCrawer = new Button();
            SuspendLayout();
            // 
            // btnHomework1
            // 
            btnHomework1.Location = new Point(112, 300);
            btnHomework1.Name = "btnHomework1";
            btnHomework1.Size = new Size(152, 37);
            btnHomework1.TabIndex = 0;
            btnHomework1.Text = "作业1 选择题";
            btnHomework1.UseVisualStyleBackColor = true;
            btnHomework1.Click += btnHomework1_Click;
            // 
            // btnHomework2
            // 
            btnHomework2.Location = new Point(112, 343);
            btnHomework2.Name = "btnHomework2";
            btnHomework2.Size = new Size(152, 37);
            btnHomework2.TabIndex = 1;
            btnHomework2.Text = "作业2 相册";
            btnHomework2.UseVisualStyleBackColor = true;
            btnHomework2.Click += button2_Click;
            // 
            // btnSearchFile
            // 
            btnSearchFile.Location = new Point(387, 300);
            btnSearchFile.Name = "btnSearchFile";
            btnSearchFile.Size = new Size(152, 37);
            btnSearchFile.TabIndex = 2;
            btnSearchFile.Text = "示例 搜索文件";
            btnSearchFile.UseVisualStyleBackColor = true;
            btnSearchFile.Click += button1_Click;
            // 
            // btnCrawer
            // 
            btnCrawer.Location = new Point(387, 343);
            btnCrawer.Name = "btnCrawer";
            btnCrawer.Size = new Size(152, 37);
            btnCrawer.TabIndex = 3;
            btnCrawer.Text = "示例 爬虫";
            btnCrawer.UseVisualStyleBackColor = true;
            btnCrawer.Click += btnCrawer_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(12F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 513);
            Controls.Add(btnCrawer);
            Controls.Add(btnSearchFile);
            Controls.Add(btnHomework2);
            Controls.Add(btnHomework1);
            Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            Margin = new Padding(5);
            Name = "frmMain";
            Text = "主窗体";
            ResumeLayout(false);
        }

        #endregion

        private Button btnHomework1;
        private Button btnHomework2;
        private Button btnSearchFile;
        private Button btnCrawer;
    }
}