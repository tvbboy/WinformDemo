using Common.AITools.Tvbboy;
using System.Text.RegularExpressions;

namespace myproject
{
    public partial class frmCrawer : Form
    {
        public frmCrawer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var hrefList = new List<Myhref>();//定义泛型列表存放城市名称及对应的酒店URL   
            string initurl = "http://tieba.baidu.com/f?kw=%E5%8D%8E%E4%B8%9C%E5%B8%88%E8%8C%83%E5%A4%A7%E5%AD%A6&ie=utf-8";
            // cityCrawler.url = new Uri("http://hotels.ctrip.com/citylist");//定义爬虫入口URL
            for (int i = 0; i < 500; i = i + 50)
            {
                string result = string.Empty;
                var url = initurl;
                var hrefCrawler = new SimpleCrawler();//调用爬虫程序
                if (i >= 50)
                    url = initurl + "&pn=" + i;


                hrefCrawler.url = new Uri(url);//定义爬虫入口URL      
                Console.Write("爬虫开始抓取地址：" + hrefCrawler.url.ToString() + "</br>");
                hrefCrawler.OnError += (s, e) =>
                {
                    MessageBox.Show("爬虫抓取出现错误，异常消息：" + e.Exception.Message);
                };

                hrefCrawler.OnCompleted += (s, e) =>
                {
                    //使用正则表达式清洗网页源代码中的数据
                    var links = Regex.Matches(e.PageSource, @"<a[^>]+href=""*(?<href>[^>\s]+)""\s*[^>]*>(?<text>(?!.*img).*?)</a>", RegexOptions.IgnoreCase);
                    // var links = Regex.Matches(e.PageSource, @"<a[^>]*href=(""([^""]*)""|\'([^\']*)\'|([^\\s>]*)[^>]*>(?<text>(?!.*img).*?)</a>", RegexOptions.IgnoreCase);
                    //匹配http链接

                    foreach (Match match in links)
                    {
                        var h = new Myhref
                        {
                            hreftitle = match.Groups["text"].Value,
                            hrefsrc = match.Groups["href"].Value
                        };
                        if (!hrefList.Contains(h))
                        {
                            if (h.hreftitle.Contains("吐槽"))
                            {
                                hrefList.Add(h);//将数据加入到泛型列表
                                result += h.hreftitle + "|" + h.hrefsrc + "</br>";//将名称及URL显示到网页
                            }
                        }

                    }
                    listBox1.Items.Add("===============================================</br>");
                    listBox1.Items.Add("爬虫抓取任务完成！合计 " + links.Count + " 个超级链接。</br>");
                    listBox1.Items.Add("耗时：" + e.Milliseconds + "</br>毫秒");
                    listBox1.Items.Add("线程：" + e.ThreadId + "</br>");
                    listBox1.Items.Add(result);
                    listBox1.Items.Add("===============================================</br>");

                };

                hrefCrawler.start();
            }
        }
        public class Myhref
        {
            public string? hreftitle { get; set; }
            public string? hrefsrc { get; set; }
        }
    }
}
