using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myproject
{
    public partial class frmSearchFile : Form
    {
        public frmSearchFile()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // 显示文件夹浏览对话框
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDirectory.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 清空列表框
            lstPythonFiles.Items.Clear();

            // 检查目录是否存在
            if (string.IsNullOrWhiteSpace(txtDirectory.Text) || !Directory.Exists(txtDirectory.Text))
            {
                MessageBox.Show("请选择有效的目录", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 开始递归搜索
                SearchPythonFiles(txtDirectory.Text);
                MessageBox.Show($"找到 {lstPythonFiles.Items.Count} 个 .py 文件", "完成",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"搜索时出错: {ex.Message}", "错误",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // 递归搜索 Python 文件
        private void SearchPythonFiles(string directory)
        {
            try
            {
                // 搜索当前目录中的 .py 文件
                foreach (string file in Directory.GetFiles(directory, "*.py"))
                {
                    lstPythonFiles.Items.Add(file);
                }

                // 递归搜索子目录
                foreach (string subDir in Directory.GetDirectories(directory))
                {
                    SearchPythonFiles(subDir);
                }
            }
            catch (UnauthorizedAccessException)
            {
                // 跳过无权限访问的目录
            }
        }

        // 双击列表项打开文件所在目录
        private void lstPythonFiles_DoubleClick(object sender, EventArgs e)
        {
            if (lstPythonFiles.SelectedItem != null)
            {
                string filePath = lstPythonFiles.SelectedItem.ToString();
                if (File.Exists(filePath))
                {
                    // 在资源管理器中打开并选中文件
                    System.Diagnostics.Process.Start("explorer.exe", $"/select,\"{filePath}\"");
                }
            }
        }
    }
}
