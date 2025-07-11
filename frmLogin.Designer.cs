namespace myproject
{
    partial class frmLogin
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
            txtUserNo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPwd = new TextBox();
            btnLogin = new Button();
            chkAutoLogin = new CheckBox();
            chkRememberMe = new CheckBox();
            btnForgetPwd = new Button();
            SuspendLayout();
            // 
            // txtUserNo
            // 
            txtUserNo.Location = new Point(211, 63);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.Size = new Size(173, 28);
            txtUserNo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 63);
            label1.Name = "label1";
            label1.Size = new Size(42, 22);
            label1.TabIndex = 1;
            label1.Text = "学号";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 122);
            label2.Name = "label2";
            label2.Size = new Size(42, 22);
            label2.TabIndex = 3;
            label2.Text = "密码";
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(211, 122);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.Size = new Size(173, 28);
            txtPwd.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(154, 183);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(95, 40);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "登录";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // chkAutoLogin
            // 
            chkAutoLogin.AutoSize = true;
            chkAutoLogin.Location = new Point(284, 191);
            chkAutoLogin.Name = "chkAutoLogin";
            chkAutoLogin.Size = new Size(125, 26);
            chkAutoLogin.TabIndex = 5;
            chkAutoLogin.Text = "下次自动登录";
            chkAutoLogin.UseVisualStyleBackColor = true;
            chkAutoLogin.CheckedChanged += chkAutoLogin_CheckedChanged;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.Location = new Point(415, 191);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(125, 26);
            chkRememberMe.TabIndex = 6;
            chkRememberMe.Text = "记住我的信息";
            chkRememberMe.UseVisualStyleBackColor = true;
            chkRememberMe.CheckedChanged += chkRememberMe_CheckedChanged;
            // 
            // btnForgetPwd
            // 
            btnForgetPwd.Location = new Point(154, 229);
            btnForgetPwd.Name = "btnForgetPwd";
            btnForgetPwd.Size = new Size(95, 33);
            btnForgetPwd.TabIndex = 7;
            btnForgetPwd.Text = "忘记密码";
            btnForgetPwd.UseVisualStyleBackColor = true;
            btnForgetPwd.Click += btnForgetPwd_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 274);
            Controls.Add(btnForgetPwd);
            Controls.Add(chkRememberMe);
            Controls.Add(chkAutoLogin);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(txtPwd);
            Controls.Add(label1);
            Controls.Add(txtUserNo);
            Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            Margin = new Padding(4);
            Name = "frmLogin";
            Text = "登录窗体";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserNo;
        private Label label1;
        private Label label2;
        private TextBox txtPwd;
        private Button btnLogin;
        private CheckBox chkAutoLogin;
        private CheckBox chkRememberMe;
        private Button btnForgetPwd;
    }
}