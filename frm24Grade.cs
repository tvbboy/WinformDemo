using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace myproject
{
    public partial class frm24grade : Form
    {
        //关于private的解释，如果这个变量是private的，
        //那么它只能在这个类内部访问，不能在其他类中访问。
        private int _counter = 60; // Timer countdown starting from 60 seconds
                                   // Fix for CS8602: 解引用可能出现空引用  
                                   // Ensure that cboNative.Items is not null or empty before accessing its first element.  
        private List<Province> provinces = new List<Province>();
        public frm24grade()
        {
            InitializeComponent();
            string s = string.Empty;
            int currentHour = DateTime.Now.Hour;
            // 返回0(午夜)到23(晚上11点)之间的整数  
            if (currentHour < 12)
            {
                s = "Good Morning!";
            }
            else if (currentHour < 18)
            {
                s = "Good Afternoon!";
            }
            else
            {
                s = "Good Evening!";
            }
            lblInfo.Text = s + " hello world!";

            StartPosition = FormStartPosition.CenterScreen; //居中显示  
            WindowState = FormWindowState.Maximized; //最大化窗口  

            // Check if cboNative.Items is not null and has at least one item before accessing its first element.  
            if (cboNative.Items != null && cboNative.Items.Count > 0)
            {
                cboNative.Text = cboNative.Items[0].ToString();
            }
            else
            {
                cboNative.Text = string.Empty; // Provide a default value if the list is empty.  
            }
            // 初始化ComboBox样式（只允许选择）
            cmbProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCity.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDistrict.DropDownStyle = ComboBoxStyle.DropDownList;
            // 初始化模拟数据
            InitializeData();

            // 绑定省份数据
            BindProvinces();

            // 注册事件
            cmbProvince.SelectedIndexChanged += CmbProvince_SelectedIndexChanged;
            cmbCity.SelectedIndexChanged += CmbCity_SelectedIndexChanged;
        }
        private void BindProvinces()
        {
            cmbProvince.DataSource = null;
            cmbProvince.DisplayMember = "Name";
            cmbProvince.ValueMember = "Id";
            cmbProvince.DataSource = provinces;

            // 清空城市和区县
            cmbCity.DataSource = null;
            cmbCity.Text = "";
            cmbDistrict.DataSource = null;
            cmbDistrict.Text = "";
        }

        private void CmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProvince.SelectedItem is Province selectedProvince)
            {
                cmbCity.DataSource = null;
                cmbCity.DisplayMember = "Name";
                cmbCity.ValueMember = "Id";
                cmbCity.DataSource = selectedProvince.Cities;

                // 清空区县
                cmbDistrict.DataSource = null;
                cmbDistrict.Text = "";
            }
        }

        private void CmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCity.SelectedItem is City selectedCity)
            {
                cmbDistrict.DataSource = null;
                cmbDistrict.DisplayMember = "Name";
                cmbDistrict.ValueMember = "Id";
                cmbDistrict.DataSource = selectedCity.Districts;
            }
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a simple WinForms application demonstrating a greeting based on the time of day.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGetMax_Click(object sender, EventArgs e)
        {
            float num1, num2, num3;
            bool isValidInput1 = float.TryParse(txtNum1.Text.Trim(), out num1);
            bool isValidInput2 = float.TryParse(txtNum2.Text.Trim(), out num2);
            bool isValidInput3 = float.TryParse(txtNum3.Text.Trim(), out num3);

            if (!(isValidInput1 && isValidInput2 && isValidInput3))
            {
                MessageBox.Show("请输入有效的数字！", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (chkMaxMin.Checked)
                MessageBox.Show($"The min value is: {CommFunction.getMax(num1, num2, num3)}", "Min Value", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show($"The maximum value is: {CommFunction.getMax(num1, num2, num3)}", "Maximum Value", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked) // Fixes IDE0019: Use pattern matching
            {
                if (rb == radA)
                {
                    MessageBox.Show("回答正确！", "结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("回答错误！", "结果", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            _counter--;
            lblTimer.Text = _counter.ToString();
            progressBar1.Value = (int)(_counter * (100.0 / 60)); // Ensure proper type conversion to avoid CS1503  
            // lblInfo.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");  
        }
        private void btnTimer_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                btnTimer.Text = "Start Timer";
            }
            else
            {
                timer1.Start();
                btnTimer.Text = "Stop Timer";
            }
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            // 获取选中的日期
            DateTime selectedDate = dateTimePicker1.Value;

            // 解析年月日
            int year = selectedDate.Year;
            int month = selectedDate.Month;
            int day = selectedDate.Day;

            // 使用解析出的值
            MessageBox.Show($"选中的日期是: {year}年\n{month}月\n{day}日");
        }

        private void btnDateDiff_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;
            TimeSpan difference = endDate - startDate;
            double days = difference.TotalDays;
            double hours = difference.TotalHours;
            double minutes = difference.TotalMinutes;
            if (days < 0)
            {
                MessageBox.Show("结束日期不能早于开始日期！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show($"两个日期相差\n {days} 天\n{hours}小时\n{minutes}分钟");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void InitializeData()
        {
            // 模拟数据 - 实际项目中可以从数据库或API获取
            var beijing = new Province { Id = 1, Name = "北京市" };
            beijing.Cities.Add(new City { Id = 101, Name = "北京市" });
            beijing.Cities[0].Districts.AddRange(new[]
            {
            new District { Id = 10101, Name = "东城区" },
            new District { Id = 10102, Name = "西城区" },
            new District { Id = 10103, Name = "朝阳区" }
        });

            var shanghai = new Province { Id = 2, Name = "上海市" };
            shanghai.Cities.Add(new City { Id = 201, Name = "上海市" });
            shanghai.Cities[0].Districts.AddRange(new[]
            {
            new District { Id = 20101, Name = "黄浦区" },
            new District { Id = 20102, Name = "徐汇区" },
            new District { Id = 20103, Name = "长宁区" },
            new District { Id = 20104, Name = "普陀区" }
        });

            var zhejiang = new Province { Id = 3, Name = "浙江省" };
            zhejiang.Cities.AddRange(new[]
            {
            new City { Id = 301, Name = "杭州市" },
            new City { Id = 302, Name = "宁波市" },
            new City { Id = 303, Name = "温州市" }
        });
            zhejiang.Cities[0].Districts.AddRange(new[]
            {
            new District { Id = 30101, Name = "上城区" },
            new District { Id = 30102, Name = "下城区" },
            new District { Id = 30103, Name = "江干区" }
        });
            zhejiang.Cities[1].Districts.AddRange(new[]
            {
            new District { Id = 30201, Name = "海曙区" },
            new District { Id = 30202, Name = "江北区" },
            new District { Id = 30203, Name = "镇海区" }
        });

            provinces.AddRange(new[] { beijing, shanghai, zhejiang });
        }

        private void btnShowImage_Click(object sender, EventArgs e)
        {
            // 方法1：使用Image.FromFile直接加载图片文件
            // pbx.Image = Image.FromFile(@"C:\24application\WinformDemo\images\pic1.jpg");
            //补充下绝对路径和相对路径的概念
            if (cboImageStyle.Text == "Stretch")
                pbx.SizeMode = PictureBoxSizeMode.StretchImage; // 设置图片显示模式
            else
                pbx.SizeMode = PictureBoxSizeMode.AutoSize; // 设置图片显示模式
            pbx.Image = Image.FromFile(@"..\..\..\images\pic1.jpg");

            // 方法2：使用Bitmap类加载图片
            // pbx.Image = new Bitmap(@"C:\path\to\your\image.png");
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            // colorDialog1.Color = Color.Red; // 设置默认颜色为红色
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }
    }


}
