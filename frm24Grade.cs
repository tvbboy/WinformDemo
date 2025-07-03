using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace myproject
{
    public partial class frm24grade : Form
    {
        //����private�Ľ��ͣ�������������private�ģ�
        //��ô��ֻ����������ڲ����ʣ��������������з��ʡ�
        private int _counter = 60; // Timer countdown starting from 60 seconds
                                   // Fix for CS8602: �����ÿ��ܳ��ֿ�����  
                                   // Ensure that cboNative.Items is not null or empty before accessing its first element.  
        private List<Province> provinces = new List<Province>();
        public frm24grade()
        {
            InitializeComponent();
            string s = string.Empty;
            int currentHour = DateTime.Now.Hour;
            // ����0(��ҹ)��23(����11��)֮�������  
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

            StartPosition = FormStartPosition.CenterScreen; //������ʾ  
            WindowState = FormWindowState.Maximized; //��󻯴���  

            // Check if cboNative.Items is not null and has at least one item before accessing its first element.  
            if (cboNative.Items != null && cboNative.Items.Count > 0)
            {
                cboNative.Text = cboNative.Items[0].ToString();
            }
            else
            {
                cboNative.Text = string.Empty; // Provide a default value if the list is empty.  
            }
            // ��ʼ��ComboBox��ʽ��ֻ����ѡ��
            cmbProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCity.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDistrict.DropDownStyle = ComboBoxStyle.DropDownList;
            // ��ʼ��ģ������
            InitializeData();

            // ��ʡ������
            BindProvinces();

            // ע���¼�
            cmbProvince.SelectedIndexChanged += CmbProvince_SelectedIndexChanged;
            cmbCity.SelectedIndexChanged += CmbCity_SelectedIndexChanged;
        }
        private void BindProvinces()
        {
            cmbProvince.DataSource = null;
            cmbProvince.DisplayMember = "Name";
            cmbProvince.ValueMember = "Id";
            cmbProvince.DataSource = provinces;

            // ��ճ��к�����
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

                // �������
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
                MessageBox.Show("��������Ч�����֣�", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("�ش���ȷ��", "���", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("�ش����", "���", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // ��ȡѡ�е�����
            DateTime selectedDate = dateTimePicker1.Value;

            // ����������
            int year = selectedDate.Year;
            int month = selectedDate.Month;
            int day = selectedDate.Day;

            // ʹ�ý�������ֵ
            MessageBox.Show($"ѡ�е�������: {year}��\n{month}��\n{day}��");
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
                MessageBox.Show("�������ڲ������ڿ�ʼ���ڣ�", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show($"�����������\n {days} ��\n{hours}Сʱ\n{minutes}����");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void InitializeData()
        {
            // ģ������ - ʵ����Ŀ�п��Դ����ݿ��API��ȡ
            var beijing = new Province { Id = 1, Name = "������" };
            beijing.Cities.Add(new City { Id = 101, Name = "������" });
            beijing.Cities[0].Districts.AddRange(new[]
            {
            new District { Id = 10101, Name = "������" },
            new District { Id = 10102, Name = "������" },
            new District { Id = 10103, Name = "������" }
        });

            var shanghai = new Province { Id = 2, Name = "�Ϻ���" };
            shanghai.Cities.Add(new City { Id = 201, Name = "�Ϻ���" });
            shanghai.Cities[0].Districts.AddRange(new[]
            {
            new District { Id = 20101, Name = "������" },
            new District { Id = 20102, Name = "�����" },
            new District { Id = 20103, Name = "������" },
            new District { Id = 20104, Name = "������" }
        });

            var zhejiang = new Province { Id = 3, Name = "�㽭ʡ" };
            zhejiang.Cities.AddRange(new[]
            {
            new City { Id = 301, Name = "������" },
            new City { Id = 302, Name = "������" },
            new City { Id = 303, Name = "������" }
        });
            zhejiang.Cities[0].Districts.AddRange(new[]
            {
            new District { Id = 30101, Name = "�ϳ���" },
            new District { Id = 30102, Name = "�³���" },
            new District { Id = 30103, Name = "������" }
        });
            zhejiang.Cities[1].Districts.AddRange(new[]
            {
            new District { Id = 30201, Name = "������" },
            new District { Id = 30202, Name = "������" },
            new District { Id = 30203, Name = "����" }
        });

            provinces.AddRange(new[] { beijing, shanghai, zhejiang });
        }

        private void btnShowImage_Click(object sender, EventArgs e)
        {
            // ����1��ʹ��Image.FromFileֱ�Ӽ���ͼƬ�ļ�
            // pbx.Image = Image.FromFile(@"C:\24application\WinformDemo\images\pic1.jpg");
            //�����¾���·�������·���ĸ���
            if (cboImageStyle.Text == "Stretch")
                pbx.SizeMode = PictureBoxSizeMode.StretchImage; // ����ͼƬ��ʾģʽ
            else
                pbx.SizeMode = PictureBoxSizeMode.AutoSize; // ����ͼƬ��ʾģʽ
            pbx.Image = Image.FromFile(@"..\..\..\images\pic1.jpg");

            // ����2��ʹ��Bitmap�����ͼƬ
            // pbx.Image = new Bitmap(@"C:\path\to\your\image.png");
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            // colorDialog1.Color = Color.Red; // ����Ĭ����ɫΪ��ɫ
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }
    }


}
