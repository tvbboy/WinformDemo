using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using HtmlAgilityPack;
namespace myproject
{
    public partial class frmSpider : Form
    {
        private readonly HttpClient _httpClient;
        public frmSpider()
        {
            InitializeComponent();
            _httpClient = new HttpClient();  
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
        }
        private async void btnCrawl_Click(object sender, EventArgs e)
        {
            string tiebaName = txtTiebaName.Text.Trim();
            if (string.IsNullOrEmpty(tiebaName))
            {
                MessageBox.Show("请输入贴吧名称");
                return;
            }

            int pages = (int)numPages.Value;
            if (pages <= 0)
            {
                MessageBox.Show("请设置有效的页数");
                return;
            }

            btnCrawl.Enabled = false;
            progressBar1.Maximum = pages;
            progressBar1.Value = 0;

            try
            {
                List<PostInfo> posts = new List<PostInfo>();

                for (int i = 0; i < pages; i++)
                {
                    int pn = i * 50; // 贴吧每页50条帖子
                    string url = $"https://tieba.baidu.com/f?kw={tiebaName}&pn={pn}";

                    var pagePosts = await CrawlPageAsync(url);
                    posts.AddRange(pagePosts);

                    progressBar1.Value = i + 1;
                    await Task.Delay(1000); // 延迟防止被封
                }

                DisplayResults(posts);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"爬取失败: {ex.Message}");
            }
            finally
            {
                btnCrawl.Enabled = true;
            }
        }
        private async Task<List<PostInfo>> CrawlPageAsync(string url)
        {
            List<PostInfo> posts = new List<PostInfo>();

            try
            {
                string html = await _httpClient.GetStringAsync(url);
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);

                var threadItems = doc.DocumentNode.SelectNodes("//li[contains(@class, 'j_thread_list')]");
                if (threadItems == null) return posts;

                foreach (var item in threadItems)
                {
                    var titleNode = item.SelectSingleNode(".//a[contains(@class, 'j_th_tit')]");
                    var authorNode = item.SelectSingleNode(".//span[contains(@class, 'tb_icon_author')]");
                    var replyNode = item.SelectSingleNode(".//span[contains(@class, 'threadlist_rep_num')]");

                    if (titleNode != null && authorNode != null)
                    {
                        string title = titleNode.InnerText.Trim();
                        string author = authorNode.Attributes["title"]?.Value.Replace("主题作者: ", "");
                        string replyCount = replyNode?.InnerText.Trim() ?? "0";
                        string href = "https://tieba.baidu.com" + titleNode.Attributes["href"]?.Value;

                        posts.Add(new PostInfo
                        {
                            Title = title,
                            Author = author,
                            ReplyCount = replyCount,
                            Url = href
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"解析页面出错: {ex.Message}");
            }

            return posts;
        }
        private void DisplayResults(List<PostInfo> posts)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = posts;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // 添加点击打开链接的功能
            dataGridView1.CellContentClick += (s, e) =>
            {
                if (e.ColumnIndex == dataGridView1.Columns["Url"].Index && e.RowIndex >= 0)
                {
                    string url = dataGridView1.Rows[e.RowIndex].Cells["Url"].Value.ToString();
                    System.Diagnostics.Process.Start(url);
                }
            };
        }
    }
}
