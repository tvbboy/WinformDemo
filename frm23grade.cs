using JiebaNet.Segmenter;
using System.Diagnostics.Eventing.Reader;

namespace myproject
{
    public partial class frm23grade : Form
    {
        int count = 10; //该变量的作用域是所有的类内部，包括类内的各个函数（方法）
        /// <summary>
        /// 窗体初始化要做的事情
        /// </summary>
        public frm23grade()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体第一次加载到内存要做的事情，此时窗体还没有呈现在用户面前，只是加载到了内存中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            cboType.DropDownStyle = ComboBoxStyle.DropDownList; // 对于 DropDownList 风格
            cboProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            cboType.Text = "年";
            txtNum1.Text = "35";
            txtNum2.Text = "26";
            txtNum3.Text = "44";
            int num1 = 35, num2 = 26, num3 = 44;
            lblResult.Text =CommFunction.getMax(num1, num2, num3).ToString();
            string[] provinces = { "山东省", "广东省", "上海市" };
            foreach (string province in provinces)
                cboProvince.Items.Add(province); //动态创建combobox的items
            cboProvince.Text = cboProvince.Items[2].ToString();//初始化combobox
            cboType.Text = cboType.Items[0].ToString();//初始化combobox
        }

        private void btnGetmax_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int num3 = int.Parse(txtNum3.Text);
            lblResult.Text = CommFunction.getMax(num1, num2, num3).ToString();
        }
      

        private void btnGetday_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;

            int year = int.Parse(txtYear.Text);
            int month = int.Parse(txtMonth.Text);
            int day = int.Parse(txtDay.Text);
            int[] days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30 };
            for (int i = 0; i < month; i++)
            {
                day += days[i];
            }
            if (CommFunction.isLeap(year) && month > 2)
                day += 1;
            MessageBox.Show(string.Format("是该年的第{0}天,来自控件的答案{1}", day, dt.DayOfYear));
        }
     

        private void btnGetDays_Click(object sender, EventArgs e)
        {
            //搜索两个日期之间天数计算的系统级方法
            DateTime dtStart = dtpStart.Value;
            DateTime dtEnd = dtpEnd.Value;

            int result = 0;
            if (cboType.Text == "年")
                result = dtEnd.Year - dtStart.Year;
            else if (cboType.Text == "月")
                result = dtEnd.Month - dtStart.Month + 12 * (dtEnd.Year - dtStart.Year);
            else if (cboType.Text == "日")
            {
                // 计算两个日期之间的天数差
                TimeSpan difference = dtEnd - dtStart;
                result = difference.Days;
            }

            MessageBox.Show(string.Format("两个日期差是:{0}{1}", result, cboType.Text));
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            //搜索两个日期之间天数计算的系统级方法
            DateTime dtStart = dtpStart.Value;
            DateTime dtEnd = dtpEnd.Value;
            if (dtEnd <= dtStart)
                MessageBox.Show("起始日期必须小于开始日期");
        }

        private void cboProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCity.Items.Clear(); //清空列表
            //TODO 根据省份调整城市的下拉列表
            if (cboProvince.Text == "广东省")
            {
                string[] citys = { "广州市", "深圳市", "汕头市" };
                foreach (string province in citys)
                    cboCity.Items.Add(province);
                cboCity.Text = cboCity.Items[0].ToString();//初始化
            }
            else if (cboProvince.Text == "山东省")
            {
                string[] citys = { "济南市", "青岛市", "淄博市" };
                foreach (string province in citys)
                    cboCity.Items.Add(province);
                cboCity.Text = cboCity.Items[0].ToString();//初始化
            }
            else if (cboProvince.Text == "上海市")
            {
                string[] citys = { "黄埔区", "闵行区", "普陀区" };
                foreach (string province in citys)
                    cboCity.Items.Add(province);
                cboCity.Text = cboCity.Items[0].ToString();//初始化
            }

        }

        private void btnSubmitBlank_Click(object sender, EventArgs e)
        {
            string[] blankKeys = { "大宋", "北宋", "宋朝", "song" };
            string stuKey = txtKey.Text.Trim();
            stuKey = stuKey.Replace(" ", "");//去除半角空格
            stuKey = stuKey.Replace("　", "");//去除中文空格
            stuKey = stuKey.ToLower();//配合标注答案转小写

            var segmenter = new JiebaSegmenter();
            var segments = segmenter.Cut(stuKey);  // 默认为精确模式
            //Console.WriteLine("【精确模式】：{0}", string.Join("/ ", segments));
            if (blankKeys.Contains(stuKey))
            {
                MessageBox.Show(string.Format("回答正确"));
            }
            else
            {
                bool findanswer = false;
                foreach (var item in segments)
                {
                    if (blankKeys.Contains(item.ToString()))
                    {
                        findanswer = true;
                        break;
                    }
                }

                if (findanswer)
                    MessageBox.Show(string.Format("回答正确"));
                else
                    MessageBox.Show(string.Format("回答不正确,标准答案是:{0}", String.Join(" ", blankKeys)));
            }
        }

        private void btnSubmitChoice_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked) //用户选择了b
            {
                MessageBox.Show(string.Format("回答正确"));
            }
            else
            {
                MessageBox.Show(string.Format("回答不正确,标准答案是:B"));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            lblSeconds.Text = count--.ToString();
            if (count == -1)
            {
                timer1.Enabled = false;
                btnSubmitChoice.Enabled = false;
                btnSubmitBlank.Enabled = false;
                btnSubmitChoice_Click(sender, e);

            }
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"pics\pic1.jpg");
            
        }
    }
}
