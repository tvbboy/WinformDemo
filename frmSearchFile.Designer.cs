namespace myproject
{
    partial class frmSearchFile
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
            folderBrowserDialog1 = new FolderBrowserDialog();
            txtDirectory = new TextBox();
            label1 = new Label();
            btnBrowse = new Button();
            btnSearch = new Button();
            lstPythonFiles = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtDirectory
            // 
            txtDirectory.Location = new Point(60, 15);
            txtDirectory.Name = "txtDirectory";
            txtDirectory.Size = new Size(197, 28);
            txtDirectory.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(42, 22);
            label1.TabIndex = 1;
            label1.Text = "路径";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(274, 12);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(95, 33);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "浏览";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(12, 62);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(346, 33);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "搜索";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lstPythonFiles
            // 
            lstPythonFiles.FormattingEnabled = true;
            lstPythonFiles.Location = new Point(12, 135);
            lstPythonFiles.Name = "lstPythonFiles";
            lstPythonFiles.Size = new Size(346, 180);
            lstPythonFiles.TabIndex = 4;
            lstPythonFiles.DoubleClick += lstPythonFiles_DoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 110);
            label2.Name = "label2";
            label2.Size = new Size(74, 22);
            label2.TabIndex = 5;
            label2.Text = "搜索结果";
            // 
            // frmSearchFile
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 327);
            Controls.Add(label2);
            Controls.Add(lstPythonFiles);
            Controls.Add(btnSearch);
            Controls.Add(btnBrowse);
            Controls.Add(label1);
            Controls.Add(txtDirectory);
            Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            Margin = new Padding(4);
            Name = "frmSearchFile";
            Text = "示例：搜索文件";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox txtDirectory;
        private Label label1;
        private Button btnBrowse;
        private Button btnSearch;
        private ListBox lstPythonFiles;
        private Label label2;
    }
}