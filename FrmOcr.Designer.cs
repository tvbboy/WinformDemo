namespace myproject
{
    partial class FrmOcr
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
            txtResult = new TextBox();
            label1 = new Label();
            pictureBox = new PictureBox();
            txtLog = new TextBox();
            btnLoadImage = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.Location = new Point(151, 162);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(319, 38);
            txtResult.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 165);
            label1.Name = "label1";
            label1.Size = new Size(110, 31);
            label1.TabIndex = 1;
            label1.Text = "识别结果";
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(521, 48);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(303, 167);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(12, 267);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(812, 258);
            txtLog.TabIndex = 3;
            // 
            // btnLoadImage
            // 
            btnLoadImage.Location = new Point(12, 48);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new Size(458, 48);
            btnLoadImage.TabIndex = 4;
            btnLoadImage.Text = "选择车牌";
            btnLoadImage.UseVisualStyleBackColor = true;
            btnLoadImage.Click += btnLoadImage_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 222);
            label2.Name = "label2";
            label2.Size = new Size(110, 31);
            label2.TabIndex = 5;
            label2.Text = "识别日志";
            // 
            // FrmOcr
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 537);
            Controls.Add(label2);
            Controls.Add(btnLoadImage);
            Controls.Add(txtLog);
            Controls.Add(pictureBox);
            Controls.Add(label1);
            Controls.Add(txtResult);
            Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Margin = new Padding(4);
            Name = "FrmOcr";
            Text = "FrmOcr";
            Load += FrmOcr_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResult;
        private Label label1;
        private PictureBox pictureBox;
        private TextBox txtLog;
        private Button btnLoadImage;
        private Label label2;
    }
}