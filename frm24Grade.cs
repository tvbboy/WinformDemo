namespace myproject
{
    public partial class frm24grade : Form
    {
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
            WindowState = FormWindowState.Maximized;//最大化窗口

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
                MessageBox.Show("请输入有效的数字！", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("回答正确！", "结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("回答错误！", "结果", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
