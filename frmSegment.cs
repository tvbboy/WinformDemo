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
            SetupPosComboBox();
            // 初始化分词器（首次加载较慢）
            // 在构造函数中添加
            var segmenter = new JiebaSegmenter();
            //segmenter.LoadUserDict(@"../../../Resources/user_dict.txt");  // 自定义词典路径
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
            var selectedTag = ((KeyValuePair<string, string>)cboPosTags.SelectedItem).Key;
            foreach (var segment in segments)
            {
                //    // 筛选人名（nr=人名，nr1=姓氏，nr2=名字）
                if (segment.Flag==selectedTag)
                {
                    if(segment.Word.Length>1) //有时候一个单字也会识别为人名
                        result.Add(segment.Word + "--" + segment.Flag);
                }
                if (selectedTag=="")
                    result.Add(segment.Word + "--" + segment.Flag);

            }
            return result;
        }
        // 初始化词性选择器
        private void SetupPosComboBox()
        {
            cboPosTags.DisplayMember = "Value";
            cboPosTags.ValueMember = "Key";

            // 添加过滤选项
            var items = new List<KeyValuePair<string, string>>();
            items.Add(new KeyValuePair<string, string>("", "所有词性"));

            // 添加常用词性（精简版）
            items.Add(new KeyValuePair<string, string>("n", "名词"));
            items.Add(new KeyValuePair<string, string>("v", "动词"));
            items.Add(new KeyValuePair<string, string>("a", "形容词"));
            items.Add(new KeyValuePair<string, string>("d", "副词"));
            items.Add(new KeyValuePair<string, string>("nr", "人名"));
            items.Add(new KeyValuePair<string, string>("ns", "地名"));
            items.Add(new KeyValuePair<string, string>("nt", "机构名"));
            items.Add(new KeyValuePair<string, string>("t", "时间词"));

            // 添加分隔线
            items.Add(new KeyValuePair<string, string>("-", "─────────"));

            // 添加完整词性
            foreach (var tag in CommData.PosTags)
            {
                if (!string.IsNullOrEmpty(tag.Value) && !items.Exists(i => i.Key == tag.Key))
                {
                    items.Add(tag);
                }
            }

            cboPosTags.DataSource = items;
            cboPosTags.SelectedIndex = 0;
        }
    }
}
