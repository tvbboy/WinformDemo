using JiebaNet.Segmenter;
using JiebaNet.Segmenter.PosSeg;
using myproject.Properties;
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
    public partial class frmSegment : Form
    {
        private readonly PosSegmenter _segmenter;
        public frmSegment()
        {
            InitializeComponent();
            // 初始化分词器（首次加载较慢）
            // 在构造函数中添加
            var segmenter = new JiebaSegmenter();
            segmenter.LoadUserDict(@"../../../Resources/user_dict.txt");  // 自定义词典路径
            _segmenter = new PosSegmenter(segmenter);
           
        }

        private void btnRecognize_Click(object sender, EventArgs e)
        {
            lstNames.Items.Clear();
            var text = txtInput.Text.Trim();

            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("请输入文本");
                return;
            }

            // 执行分词和词性标注
            var names = ExtractChineseNames(text);

            // 显示结果
            foreach (var name in names)
            {
                lstNames.Items.Add(name);
            }
        }
        private List<string> ExtractChineseNames(string text)
        {
            var result = new List<string>();
            var segments = _segmenter.Cut(text);  // 词性标注分词

            foreach (var segment in segments)
            {
            //    // 筛选人名（nr=人名，nr1=姓氏，nr2=名字）
            //    if (segment.Flag == "nr" || segment.Flag == "nr1" || segment.Flag == "nr2")
            //    {
            //        result.Add(segment.Word);
            //    }
                result.Add(segment.Word+"--"+ segment.Flag);
            }
            return result;
        }
    }
}
