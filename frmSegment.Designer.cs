namespace myproject
{
    partial class frmSegment
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
            txtInput = new TextBox();
            btnRecognize = new Button();
            label1 = new Label();
            lstNames = new ListBox();
            label2 = new Label();
            label3 = new Label();
            cboPosTags = new ComboBox();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(12, 77);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.ScrollBars = ScrollBars.Both;
            txtInput.Size = new Size(542, 375);
            txtInput.TabIndex = 0;
            // 
            // btnRecognize
            // 
            btnRecognize.Location = new Point(763, 36);
            btnRecognize.Name = "btnRecognize";
            btnRecognize.Size = new Size(93, 30);
            btnRecognize.TabIndex = 1;
            btnRecognize.Text = "分词";
            btnRecognize.UseVisualStyleBackColor = true;
            btnRecognize.Click += btnRecognize_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(581, 91);
            label1.Name = "label1";
            label1.Size = new Size(42, 22);
            label1.TabIndex = 2;
            label1.Text = "结果";
            // 
            // lstNames
            // 
            lstNames.FormattingEnabled = true;
            lstNames.Location = new Point(571, 140);
            lstNames.Name = "lstNames";
            lstNames.Size = new Size(422, 312);
            lstNames.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(74, 22);
            label2.TabIndex = 4;
            label2.Text = "输入文本";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(571, 37);
            label3.Name = "label3";
            label3.Size = new Size(42, 22);
            label3.TabIndex = 5;
            label3.Text = "词性";
            // 
            // cboPosTags
            // 
            cboPosTags.FormattingEnabled = true;
            cboPosTags.Location = new Point(619, 34);
            cboPosTags.Name = "cboPosTags";
            cboPosTags.Size = new Size(121, 30);
            cboPosTags.TabIndex = 6;
            // 
            // frmSegment
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 464);
            Controls.Add(cboPosTags);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstNames);
            Controls.Add(label1);
            Controls.Add(btnRecognize);
            Controls.Add(txtInput);
            Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            Margin = new Padding(4);
            Name = "frmSegment";
            Text = "frmSegment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnRecognize;
        private Label label1;
        private ListBox lstNames;
        private Label label2;
        private Label label3;
        private ComboBox cboPosTags;
    }
}