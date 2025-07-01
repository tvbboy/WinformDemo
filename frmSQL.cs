using Microsoft.VisualBasic;
using SQL;
using System.Data;
using System.Text;

namespace myproject
{
    public partial class frmSQL : Form
    {
        string msg = string.Empty;
        SQLHelper sh;
        string base_sql = "select studentname as 学生姓名,major as 专业 from tblTopStudents where 1=1";
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

            string sql = "select count(*) from tblstudents"; //该SQL意思是，获取tblstudents的行数
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

        private void button1_Click(object sender, EventArgs e)
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
            if (cboMajor.Text != "全部显示")
            {
                if (major.Length > 0)
                {
                    sql += string.Format(" and major='{0}'", major);
                }
                if (name.Length > 0)
                {
                    sql += string.Format(" and studentname like '%{0}%'", name);
                }
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
        private void  SearchStu()
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
                StringBuilder tmp = new StringBuilder();
                foreach (DataRow stu in dt.Rows)
                {
                    tmp.Append(string.Format("学号:{0},姓名:{1}",stu[0], stu[1]));
                    listView1.Items.Add(tmp.ToString());
                }                
                //MessageBox.Show(tmp.ToString());
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
        private void bindImgTolist(DataTable dt)
        {
            
            foreach (DataRow stu in dt.Rows)
            {
                ListViewItem item1 = new ListViewItem(stu[1].ToString());
                if (stu[2].ToString()=="True")
                    item1.ImageIndex = 0; // 设置为 ImageList 中第一张图片
                else
                    item1.ImageIndex = 1; // 设置为 ImageList 中第一张图片
                listView2.Items.Add(item1);
               
            }
          
        }
    }
}
