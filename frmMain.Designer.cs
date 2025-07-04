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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            btnSegment = new Button();
            button1 = new Button();
            btnControls = new Button();
            btnCrawer = new Button();
            btnSearchFile = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // btnHomework1
            // 
            btnHomework1.Location = new Point(20, 40);
            btnHomework1.Name = "btnHomework1";
            btnHomework1.Size = new Size(152, 37);
            btnHomework1.TabIndex = 0;
            btnHomework1.Text = "作业1 选择题";
            btnHomework1.UseVisualStyleBackColor = true;
            btnHomework1.Click += btnHomework1_Click;
            // 
            // btnHomework2
            // 
            btnHomework2.Location = new Point(20, 83);
            btnHomework2.Name = "btnHomework2";
            btnHomework2.Size = new Size(152, 37);
            btnHomework2.TabIndex = 1;
            btnHomework2.Text = "作业2 相册";
            btnHomework2.UseVisualStyleBackColor = true;
            btnHomework2.Click += btnHomework2_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(64, 59);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(871, 434);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnHomework2);
            tabPage1.Controls.Add(btnHomework1);
            tabPage1.Location = new Point(4, 35);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(863, 395);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "作业区";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnSegment);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(btnControls);
            tabPage2.Controls.Add(btnCrawer);
            tabPage2.Controls.Add(btnSearchFile);
            tabPage2.Location = new Point(4, 35);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(863, 395);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "示例区";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSegment
            // 
            btnSegment.Location = new Point(112, 223);
            btnSegment.Name = "btnSegment";
            btnSegment.Size = new Size(152, 47);
            btnSegment.TabIndex = 8;
            btnSegment.Text = "示例人名识别";
            btnSegment.UseVisualStyleBackColor = true;
            btnSegment.Click += btnSegment_Click;
            // 
            // button1
            // 
            button1.Location = new Point(112, 291);
            button1.Name = "button1";
            button1.Size = new Size(152, 47);
            button1.TabIndex = 7;
            button1.Text = "示例 车牌识别";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnControls
            // 
            btnControls.Location = new Point(112, 31);
            btnControls.Name = "btnControls";
            btnControls.Size = new Size(152, 52);
            btnControls.TabIndex = 6;
            btnControls.Text = "示例 常用控件";
            btnControls.UseVisualStyleBackColor = true;
            btnControls.Click += btnControls_Click;
            // 
            // btnCrawer
            // 
            btnCrawer.Location = new Point(112, 161);
            btnCrawer.Name = "btnCrawer";
            btnCrawer.Size = new Size(152, 47);
            btnCrawer.TabIndex = 5;
            btnCrawer.Text = "示例 贴吧爬虫";
            btnCrawer.UseVisualStyleBackColor = true;
            btnCrawer.Click += btnCrawer_Click;
            // 
            // btnSearchFile
            // 
            btnSearchFile.Location = new Point(112, 98);
            btnSearchFile.Name = "btnSearchFile";
            btnSearchFile.Size = new Size(152, 49);
            btnSearchFile.TabIndex = 4;
            btnSearchFile.Text = "示例 搜索文件";
            btnSearchFile.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(12F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 513);
            Controls.Add(tabControl1);
            Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            Margin = new Padding(5);
            Name = "frmMain";
            Text = "主窗体";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnHomework1;
        private Button btnHomework2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnCrawer;
        private Button btnSearchFile;
        private Button btnControls;
        private Button button1;
        private Button btnSegment;
    }
}