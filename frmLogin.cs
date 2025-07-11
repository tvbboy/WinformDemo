using JiebaNet.Segmenter;
using Microsoft.VisualBasic;
using SecurityUtils;
using SQL;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace myproject
{
    public partial class frmLogin : Form
    {
        private const string SectionName = "autoLoginSettings";
        string stuNo, stuPwd;
        SQLHelper sh;
        public frmLogin()
        {
            InitializeComponent();
            sh = new SQLHelper(); //数据库链接对象初始化
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadAutoLoginSettings();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadAutoLoginSettings();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            stuNo = txtUserNo.Text;
            stuPwd = txtPwd.Text;//明文          
            string sql = string.Format("select pwd,salt from tblTopstudents where studentNo='{0}'", stuNo);
            try
            {
                DataSet ds = new DataSet();
                sh.RunSQL(sql, ref ds);
                DataTable dt = ds.Tables[0];
                //1个dataset包含落干个datatable
                if (dt.Rows.Count > 0)
                {
                    string pwd = dt.Rows[0]["pwd"].ToString();
                    string salt = dt.Rows[0]["salt"].ToString();
                    if (PasswordHelper.VerifyHash(stuPwd, salt, pwd))//登录成功的逻辑
                    {
                        SaveAutoLoginSettings(stuNo, stuPwd);

                        frmMain fm = new frmMain();
                        fm.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("密码不匹配！");
                }
                else
                {
                    MessageBox.Show("用户名不存在！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sh.Close();
            }
        }
        /// <summary>
        /// 保存自动登录设置
        /// </summary>
        private void SaveAutoLoginSettings(string username, string password)
        {
            // 创建配置集合
            NameValueCollection settings = new NameValueCollection();
            settings["RememberCredentials"] = chkRememberMe.Checked.ToString();
            settings["AutoLogin"] = chkAutoLogin.Checked.ToString();
            settings["Username"] = chkRememberMe.Checked ? username : "";

            // 安全存储密码
            settings["EncryptedPassword"] = chkRememberMe.Checked ?
                APPConfigManager.EncryptString(password) : "";

            // 更新配置文件
            APPConfigManager.UpdateCustomSection(SectionName, settings);
        }
        /// <summary>
        /// 加载自动登录设置
        /// </summary>
        private void LoadAutoLoginSettings()
        {
            // 获取配置节
            NameValueCollection settings = APPConfigManager.GetCustomSection(SectionName);

            if (settings != null)
            {
                // 解析设置
                bool.TryParse(settings["RememberCredentials"], out bool rememberCredentials);
                bool.TryParse(settings["AutoLogin"], out bool autoLogin);
                string username = settings["Username"] ?? "";
                string encryptedPassword = settings["EncryptedPassword"] ?? "";
                string password = APPConfigManager.DecryptString(encryptedPassword);

                // 更新UI
                chkRememberMe.Checked = rememberCredentials;
                chkAutoLogin.Checked = autoLogin;
                txtUserNo.Text = username;
                txtPwd.Text = password;

                // 自动登录处理
                if (autoLogin && !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                {
                    // this.BeginInvoke(new Action(AttemptAutoLogin));
                    btnLogin.PerformClick();
                }
            }
        }
        /// <summary>
        /// 尝试自动登录
        /// </summary>
        private void AttemptAutoLogin()
        {
            // 防止窗体还未完全显示
            if (!this.IsHandleCreated) return;

            // 模拟登录按钮点击
            btnLogin.PerformClick();
        }
        private void chkAutoLogin_CheckedChanged(object sender, EventArgs e)
        {
            // 如果启用"自动登录"，则自动启用"记住密码"
            if (chkAutoLogin.Checked)
            {
                chkRememberMe.Checked = true;
            }

        }

        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            // 如果取消"记住密码"，则自动取消"自动登录"
            if (!chkRememberMe.Checked)
            {
                chkAutoLogin.Checked = false;
            }
        }

        private void btnForgetPwd_Click(object sender, EventArgs e)
        {
            string mail = Interaction.InputBox("找回密码", "请输入注册时的EMAIL");
            string msg = "验证码已发送，请注意查收";
            try
            {
                string sql = string.Format("select count(*) from tbltopstudents where email='{0}'", mail);
                string ret = sh.RunSelectSQLToScalar(sql); //一般运行 查询之外的删、改、增
                if(ret == "0")
                {
                    MessageBox.Show("邮箱不存在，请检查后重试");
                    return;
                }
             
                string code = CommFunction.GenerateSafeCode();

                if (!CommFunction.SendVerificationEmail(mail, code))
                {
                    MessageBox.Show("验证码发送失败，请检查网络连接或联系管理员", "发送错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }
                    
                string inputcode = Interaction.InputBox("输入验证码", "验证码已经发送至你的邮箱");
                if (inputcode != code)
                {
                    MessageBox.Show("验证码错误，请重试");
                    return;
                }
                frmMain fm = new frmMain();
                fm.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                msg = ex.Message;
                MessageBox.Show(msg);
            }
            finally
            {
                sh.Close();
            }
           
        }
    }
}
