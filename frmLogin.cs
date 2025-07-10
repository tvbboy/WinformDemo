using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL;
using SecurityUtils;
namespace myproject
{
    public partial class frmLogin : Form
    {
        string stuNo, stuPwd;
        SQLHelper sh;
        public frmLogin()
        {
            InitializeComponent();
            sh = new SQLHelper(); //数据库链接对象初始化
            this.StartPosition=FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            stuNo = txtUserNo.Text;
            stuPwd = txtPwd.Text;//明文
          
          
            string sql = string.Format("select pwd,salt from tblTopstudents where studentNo='{0}'", stuNo);

            try
            {
                // 函数名一样，参数不一样，这在OO里面叫重载 overload
                DataSet ds=new DataSet();
                sh.RunSQL(sql,ref ds);
                DataTable dt= ds.Tables[0];
                //1个dataset包含落干个datatable
                if (dt.Rows.Count>0)
                {
                    string pwd = dt.Rows[0]["pwd"].ToString();
                    string salt = dt.Rows[0]["salt"].ToString();
                    if(PasswordHelper.VerifyHash(stuPwd, salt, pwd))
                    {
                      
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
    }
}
