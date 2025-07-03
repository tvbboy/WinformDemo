using JiebaNet.Segmenter;
using System.Diagnostics.Eventing.Reader;

namespace myproject
{
    public partial class frm23grade : Form
    {
        int count = 10; //�ñ����������������е����ڲ����������ڵĸ���������������
        /// <summary>
        /// �����ʼ��Ҫ��������
        /// </summary>
        public frm23grade()
        {
            InitializeComponent();
        }
        /// <summary>
        /// �����һ�μ��ص��ڴ�Ҫ�������飬��ʱ���廹û�г������û���ǰ��ֻ�Ǽ��ص����ڴ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            cboType.DropDownStyle = ComboBoxStyle.DropDownList; // ���� DropDownList ���
            cboProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            cboType.Text = "��";
            txtNum1.Text = "35";
            txtNum2.Text = "26";
            txtNum3.Text = "44";
            int num1 = 35, num2 = 26, num3 = 44;
            lblResult.Text =CommFunction.getMax(num1, num2, num3).ToString();
            string[] provinces = { "ɽ��ʡ", "�㶫ʡ", "�Ϻ���" };
            foreach (string province in provinces)
                cboProvince.Items.Add(province); //��̬����combobox��items
            cboProvince.Text = cboProvince.Items[2].ToString();//��ʼ��combobox
            cboType.Text = cboType.Items[0].ToString();//��ʼ��combobox
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
            MessageBox.Show(string.Format("�Ǹ���ĵ�{0}��,���Կؼ��Ĵ�{1}", day, dt.DayOfYear));
        }
     

        private void btnGetDays_Click(object sender, EventArgs e)
        {
            //������������֮�����������ϵͳ������
            DateTime dtStart = dtpStart.Value;
            DateTime dtEnd = dtpEnd.Value;

            int result = 0;
            if (cboType.Text == "��")
                result = dtEnd.Year - dtStart.Year;
            else if (cboType.Text == "��")
                result = dtEnd.Month - dtStart.Month + 12 * (dtEnd.Year - dtStart.Year);
            else if (cboType.Text == "��")
            {
                // ������������֮���������
                TimeSpan difference = dtEnd - dtStart;
                result = difference.Days;
            }

            MessageBox.Show(string.Format("�������ڲ���:{0}{1}", result, cboType.Text));
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            //������������֮�����������ϵͳ������
            DateTime dtStart = dtpStart.Value;
            DateTime dtEnd = dtpEnd.Value;
            if (dtEnd <= dtStart)
                MessageBox.Show("��ʼ���ڱ���С�ڿ�ʼ����");
        }

        private void cboProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCity.Items.Clear(); //����б�
            //TODO ����ʡ�ݵ������е������б�
            if (cboProvince.Text == "�㶫ʡ")
            {
                string[] citys = { "������", "������", "��ͷ��" };
                foreach (string province in citys)
                    cboCity.Items.Add(province);
                cboCity.Text = cboCity.Items[0].ToString();//��ʼ��
            }
            else if (cboProvince.Text == "ɽ��ʡ")
            {
                string[] citys = { "������", "�ൺ��", "�Ͳ���" };
                foreach (string province in citys)
                    cboCity.Items.Add(province);
                cboCity.Text = cboCity.Items[0].ToString();//��ʼ��
            }
            else if (cboProvince.Text == "�Ϻ���")
            {
                string[] citys = { "������", "������", "������" };
                foreach (string province in citys)
                    cboCity.Items.Add(province);
                cboCity.Text = cboCity.Items[0].ToString();//��ʼ��
            }

        }

        private void btnSubmitBlank_Click(object sender, EventArgs e)
        {
            string[] blankKeys = { "����", "����", "�γ�", "song" };
            string stuKey = txtKey.Text.Trim();
            stuKey = stuKey.Replace(" ", "");//ȥ����ǿո�
            stuKey = stuKey.Replace("��", "");//ȥ�����Ŀո�
            stuKey = stuKey.ToLower();//��ϱ�ע��תСд

            var segmenter = new JiebaSegmenter();
            var segments = segmenter.Cut(stuKey);  // Ĭ��Ϊ��ȷģʽ
            //Console.WriteLine("����ȷģʽ����{0}", string.Join("/ ", segments));
            if (blankKeys.Contains(stuKey))
            {
                MessageBox.Show(string.Format("�ش���ȷ"));
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
                    MessageBox.Show(string.Format("�ش���ȷ"));
                else
                    MessageBox.Show(string.Format("�ش���ȷ,��׼����:{0}", String.Join(" ", blankKeys)));
            }
        }

        private void btnSubmitChoice_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked) //�û�ѡ����b
            {
                MessageBox.Show(string.Format("�ش���ȷ"));
            }
            else
            {
                MessageBox.Show(string.Format("�ش���ȷ,��׼����:B"));
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
