using Microsoft.VisualBasic;
using SQL;
using System.Data;
using System.Formats.Asn1;
using System.Text;
using System.Xml.Linq;
using SecurityUtils;
namespace myproject
{
    public partial class frmSQL : Form
    {
        string msg = string.Empty;
        SQLHelper sh;
        string base_sql = @"select studentNo as 学号, studentname as 姓名,CASE gender WHEN 1 THEN '男' 
                      WHEN 0 THEN '女' 
                      ELSE '其他' 
         END as 性别,Major as 专业 from tblTopStudents where 1=1";
        /// <summary>
        /// 构造函数往往放置一些初始化的工作
        /// </summary>
        public frmSQL()
        {
            InitializeComponent();
            sh = new SQLHelper(); //数据库链接对象初始化
        }

        private void btnLink_Click(object sender, EventArgs e)
        {

            string sql = "select count(*) from tblTopStudents"; //该SQL意思是，获取tblstudents的行数
            try
            {
                string? num = sh.RunSelectSQLToScalar(sql);  //一般运行查询语句
                msg = string.Format("我们班共有{0}个同学!", num);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            finally
            {
                sh.Close();
            }
            MessageBox.Show(msg);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string studentnumber = Interaction.InputBox("打卡", "请输入打卡的学号，默认是自己", "10130212110");
            try
            {
                //string studentnumber = "10130212110";
                string sql = string.Format("insert into tblStudentAbsent(studentNumber)values('{0}')", studentnumber);
                int ret = sh.RunSQL(sql); //一般运行 查询之外的删、改、增
                msg = string.Format("打卡成功");
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            finally
            {
                sh.Close();
            }
            MessageBox.Show(msg);
        }

        /// <summary>
        /// 在初始化之后，内存中加载窗体的时候触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSQL_Load(object sender, EventArgs e)
        {

            bindData(base_sql);  //把数据绑定到datagridview
            initCombox(); //初始化combobox
            // 初始化 ImageList
            ImageList imgList = new ImageList();
            imgList.ColorDepth = ColorDepth.Depth32Bit;
            imgList.ImageSize = new Size(32, 32); // 图片大小

            // 加载图片到 ImageList
            imgList.Images.Add(Image.FromFile(@"..\..\..\faces\boy.jpg"));
            imgList.Images.Add(Image.FromFile(@"..\..\..\faces\girl.jpg"));

            // 关联 ImageList 到 ListView
            listView2.SmallImageList = imgList;
            listView2.LargeImageList = imgList;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = base_sql;
            string major = cboMajor.Text;
            string name = txtStuName.Text;
            if (name.Length > 0)
            {
                sql += string.Format(" and studentname like '%{0}%'", name);
            }
            if (cboMajor.Text != "全部显示")
            {
                sql += string.Format(" and major='{0}'", major);
            }
            bindData(sql);
        }
        /// <summary>
        /// 给我传递一个SQL命令，我来绑定数据到datagridview
        /// </summary>
        /// <param name="sql">传递过来的SQL命令</param>
        private void bindData(string sql)
        {
            //数据集 mini的database
            DataSet ds = new DataSet();

            try
            {
                // 函数名一样，参数不一样，这在OO里面叫重载 overload
                sh.RunSQL(sql, ref ds);
                //1个dataset包含落干个datatable
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                lblCount.Text = string.Format("共有{0}个同学", dt.Rows.Count);
                //dataGridView1.DataSource = ds.Tables[0];
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
        /// <summary>
        /// 用tbltopstudents里面的major来初始化这个combox
        /// </summary>
        private void initCombox()
        {
            string sql = "SELECT DISTINCT major FROM tblTopStudents";
            DataSet ds = new DataSet();

            try
            {
                sh.RunSQL(sql, ref ds);
                DataTable dt = ds.Tables[0];
                dt.Rows.Add("全部显示");
                // 绑定DataTable到ComboBox
                cboMajor.DataSource = dt;
                cboMajor.DisplayMember = "major";
                // 如果你想将某个列作为值成员，可以这样设置：
                cboMajor.ValueMember = "major";
                cboMajor.Text = "全部显示";
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

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {

            bindData(base_sql);  //把数据绑定到datagridview

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled)
                btnAlert.Text = "停止报警";
            else
                btnAlert.Text = "开始报警";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SearchStu();
        }
        private void SearchStu()
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            string sql = "SELECT studentno,STUDENTNAME,gender FROM tblTopStudents\r\nWHERE studentNo NOT IN\r\n(\r\nselect STUDENTNUMBER from tblStudentAbsent where DATEDIFF(DAY,dtedate,GETDATE())=0\r\n)\r\n";
            DataSet ds = new DataSet();
            try
            {

                sh.RunSQL(sql, ref ds);
                DataTable dt = ds.Tables[0];
                bindImgTolist(dt);
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
        /// <summary>
        /// 根据dt的信息更新两个listview 一个是更新文本名字，一个是更新图片
        /// </summary>
        /// <param name="dt"></param>
        private void bindImgTolist(DataTable dt)
        {

            foreach (DataRow stu in dt.Rows)
            {
                ListViewItem item1 = new ListViewItem(stu[1].ToString());
                if (stu[2].ToString() == "True")
                    item1.ImageIndex = 0; // 设置为 ImageList 中第一张图片
                else
                    item1.ImageIndex = 1; // 设置为 ImageList 中第一张图片
                listView2.Items.Add(item1);
                StringBuilder tmp = new StringBuilder();
                tmp.Append(string.Format("学号:{0},姓名:{1}", stu[0], stu[1]));
                listView1.Items.Add(tmp.ToString());

            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 确保点击的是数据行（行索引>=0）且不是标题行
            if (e.RowIndex >= 0)
            {
                // 获取被点击的行
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                // 将行中的单元格值赋给文本框
                // 注意：使用Cells[列索引]或Cells["列名"]来访问单元格
                txtStudentname.Text = row.Cells["姓名"].Value.ToString();
                txtStudentNo.Text = row.Cells["学号"].Value.ToString();
                txtMajor.Text = row.Cells["专业"].Value.ToString();
                if (row.Cells["性别"].Value.ToString() == "男")
                    pictureBox1.Image = Image.FromFile(@"..\..\..\faces\boy.jpg");
                else
                    pictureBox1.Image = Image.FromFile(@"..\..\..\faces\girl.jpg");

                // 如果某些列可能为null，可以使用安全转换
                // 例如：txtAge.Text = row.Cells["Age"].Value?.ToString() ?? string.Empty;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                //string studentnumber = "10130212110";
                string sql = string.Format(@"update tblTopStudents
                set Major='{0}',
                LoginTimes=LoginTimes+1
                where studentNo='{1}'", txtMajor.Text, txtStudentNo.Text);
                int ret = sh.RunSQL(sql); //一般运行 查询之外的删、改、增
                msg = string.Format("修改成功");
                bindData(base_sql); //重新绑定数据
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            finally
            {
                sh.Close();
            }
            MessageBox.Show(msg);
        }

        private void txtStuName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnResetPwd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtStudentNo.Text))
            {
                MessageBox.Show("请先选择一个学生");
                return;
            }
            if(txtPwd.Text.Length < 6)  //检测密码强度，大模型求助
            {
                MessageBox.Show("密码长度不能小于6位");
                return;
            }
            if(txtPwd.Text != txtConfirmPwd.Text)
            {
                MessageBox.Show("两次输入的密码不一致");
                return;
            }
            // 创建哈希密码
            string password = txtPwd.Text;
            string salt;
            string hash = PasswordHelper.CreateHash(password, out salt); //不可逆哈希
            try
            {
              
                string sql = string.Format(@"update tblTopStudents
set pwd='{0}', salt='{1}' 
where studentNo='{2}'", hash, salt, txtStudentNo.Text);
                int ret = sh.RunSQL(sql); //一般运行 查询之外的删、改、增
                msg = string.Format("重置密码成功！");
              
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            finally
            {
                sh.Close();
            }
            MessageBox.Show(msg);

        }
    }
}
