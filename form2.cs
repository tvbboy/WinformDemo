using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace myproject
{
    public partial class form2 : Form
    {
        int currImg = 0;
        string[] picPath = { "pics/pic1.jpg", "pics/pic2.jpg", "pics/pic3.jpg", "pics/pic4.jpg", "pics/pic5.jpg", "pics/pic6.jpg", "pics/pic7.jpg" };
        Image[] imgs = new Image[7];
        public form2()
        {
            InitializeComponent();
        }

        private void form2_Load(object sender, EventArgs e)
        {
            Image img;
            for (int i = 0; i < picPath.Length; i++)
            {
                img = Image.FromFile(@picPath[i]);
                imgs[i] = img;
            }
            progressBar1.Maximum = picPath.Length;
            progressBar1.Minimum = 0;
            showImg();


            //pictureBox1.Image = imageList1.Images[0];
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currImg++;
            showImg();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            currImg--;
            showImg();
        }
        private void showImg()
        {
            pictureBox1.Image = imgs[currImg];
            progressBar1.Value = currImg;
        }
    }
}
