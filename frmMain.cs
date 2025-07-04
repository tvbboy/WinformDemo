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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnHomework2_Click(object sender, EventArgs e)
        {
            frmAlbum fm2 = new frmAlbum();
            fm2.ShowDialog(); //显示模态窗体
        }

        private void btnHomework1_Click(object sender, EventArgs e)
        {
            //fm24就是frm24grade的实例
            frm24grade fm24 = new frm24grade();
            fm24.ShowDialog(); //显示模态窗体
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSearchFile frmSearch = new frmSearchFile();
            frmSearch.ShowDialog(); //显示模态窗体
        }

        private void btnCrawer_Click(object sender, EventArgs e)
        {
            frmTiebaSpider frmSpider = new frmTiebaSpider();
            frmSpider.ShowDialog();
        }

        private void btnControls_Click(object sender, EventArgs e)
        {
            frm24grade fm24 = new frm24grade();
            fm24.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmOcr frmOcr = new FrmOcr();
            frmOcr.ShowDialog();
        }

        private void btnSegment_Click(object sender, EventArgs e)
        {
            frmSegment frmSegment = new frmSegment();
            frmSegment.ShowDialog();
        }
    }
}
