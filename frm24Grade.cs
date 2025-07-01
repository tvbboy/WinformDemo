namespace myproject
{
    public partial class frm24grade : Form
    {
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
            WindowState = FormWindowState.Maximized;//��󻯴���

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a simple WinForms application demonstrating a greeting based on the time of day.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGetMax_Click(object sender, EventArgs e)
        {
            float num1,num2,num3;
            bool isValidInput1 = float.TryParse(txtNum1.Text.Trim(), out num1);
            bool isValidInput2 = float.TryParse(txtNum2.Text.Trim(), out num2);
            bool isValidInput3 = float.TryParse(txtNum3.Text.Trim(), out num3);
         
            if (!(isValidInput1 && isValidInput2 && isValidInput3))
            {
                MessageBox.Show("��������Ч�����֣�", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(chkMaxMin.Checked)
                MessageBox.Show($"The min value is: {getMin(num1, num2, num3)}", "Min Value", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show($"The maximum value is: {getMax(num1, num2, num3)}", "Maximum Value", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private float getMax(float n1, float n2, float n3)
        {
            return Math.Max(n1, Math.Max(n2, n3));
        }
        private float getMin(float n1, float n2, float n3)
        {
            return Math.Min(n1, Math.Max(n2, n3));
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
    }
}
