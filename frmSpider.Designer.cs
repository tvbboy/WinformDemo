namespace myproject
{
    partial class frmSpider
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
            btnCrawl = new Button();
            txtTiebaName = new TextBox();
            numPages = new NumericUpDown();
            progressBar1 = new ProgressBar();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numPages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCrawl
            // 
            btnCrawl.Location = new Point(531, 46);
            btnCrawl.Name = "btnCrawl";
            btnCrawl.Size = new Size(118, 37);
            btnCrawl.TabIndex = 0;
            btnCrawl.Text = "开始爬取";
            btnCrawl.UseVisualStyleBackColor = true;
            btnCrawl.Click += btnCrawl_Click;
            // 
            // txtTiebaName
            // 
            txtTiebaName.Location = new Point(27, 50);
            txtTiebaName.Name = "txtTiebaName";
            txtTiebaName.Size = new Size(321, 28);
            txtTiebaName.TabIndex = 1;
            // 
            // numPages
            // 
            numPages.Location = new Point(370, 51);
            numPages.Name = "numPages";
            numPages.Size = new Size(120, 28);
            numPages.TabIndex = 3;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(27, 84);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(463, 23);
            progressBar1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(707, 264);
            dataGridView1.TabIndex = 5;
            // 
            // frmSpider
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 399);
            Controls.Add(dataGridView1);
            Controls.Add(progressBar1);
            Controls.Add(numPages);
            Controls.Add(txtTiebaName);
            Controls.Add(btnCrawl);
            Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            Margin = new Padding(4);
            Name = "frmSpider";
            Text = "frmSpider";
            ((System.ComponentModel.ISupportInitialize)numPages).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCrawl;
        private TextBox txtTiebaName;
        private NumericUpDown numPages;
        private ProgressBar progressBar1;
        private DataGridView dataGridView1;
    }
}