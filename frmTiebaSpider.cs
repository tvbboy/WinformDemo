using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace myproject
{
    public partial class frmTiebaSpider : Form
    {
        private readonly HttpClient _httpClient;
        private string _savePath = "";
        private int _totalImages = 0;
        private int _downloadedImages = 0;
        public frmTiebaSpider()
        {
            InitializeComponent();
            //_httpClient = new HttpClient();  
            //_httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            // 初始化HttpClient
            _httpClient = new HttpClient(new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            });
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            _httpClient.Timeout = TimeSpan.FromSeconds(30);
        }

        private async void btnCrawl_Click(object sender, EventArgs e)
        {
            string tiebaName = txtTiebaName.Text.Trim();
            if (string.IsNullOrEmpty(tiebaName))
            {
                Log("请输入贴吧名称");
                return;
            }

            int pages = (int)numPages.Value;
            if (pages <= 0)
            {
                Log("请设置有效的页数");
                return;
            }

            btnCrawlInfo.Enabled = false;
            progressBar1.Maximum = pages;
            progressBar1.Value = 0;

            try
            {
                List<PostInfo> posts = new List<PostInfo>();
                //贴吧按页循环
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
                Log($"爬取失败: {ex.Message}");
            }
            finally
            {
                btnCrawlInfo.Enabled = true;
            }
        }
        /// <summary>
        /// 以异步的方式爬取网页，这是专门针对贴吧的爬取代码，不太好独立解耦
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
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
                    // 使用XPath选择器获取帖子标题、作者和回复数
                    var titleNode = item.SelectSingleNode(".//a[contains(@class, 'j_th_tit')]");
                    var authorNode = item.SelectSingleNode(".//span[contains(@class, 'tb_icon_author')]");
                    var replyNode = item.SelectSingleNode(".//span[contains(@class, 'threadlist_rep_num')]");

                    if (titleNode != null && authorNode != null)
                    {
                        string title = titleNode.InnerText.Trim();
                        string author = authorNode.Attributes["title"]?.Value?.Replace("主题作者: ", "") ?? string.Empty;
                        string replyCount = replyNode?.InnerText?.Trim() ?? "0";
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
                Log($"解析页面出错: {ex.Message}");
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
                var urlColumn = dataGridView1.Columns["Url"];
                if (urlColumn != null && e.ColumnIndex == urlColumn.Index && e.RowIndex >= 0)
                {
                    var cellValue = dataGridView1.Rows[e.RowIndex].Cells["Url"].Value;
                    if (cellValue is string url && !string.IsNullOrEmpty(url))
                    {
                        System.Diagnostics.Process.Start(url);
                    }
                }
            };
        }

        private async void btnCrawlImage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTiebaName.Text))
            {
                Log("请输入贴吧名称");
                return;
            }

            if (string.IsNullOrWhiteSpace(_savePath))
            {
                Log("请选择保存路径");
                return;
            }           
            if ((int)numPages.Value <= 0)
            {
                Log("请设置有效的页数");
                return;
            }
            // 创建贴吧专属文件夹
            string tiebaFolder = Path.Combine(_savePath, txtTiebaName.Text.Trim());
            Directory.CreateDirectory(tiebaFolder);

            btnCrawlImage.Enabled = false;
            _totalImages = 0;
            _downloadedImages = 0;
            lstLog.Items.Clear();
            try
            {
                int pages = (int)numPages.Value;
                progressBar1.Maximum = pages;
                progressBar1.Value = 0;

                for (int i = 0; i < pages; i++)
                {
                    int pn = i * 50; // 贴吧每页50条帖子
                    string url = $"https://tieba.baidu.com/f?kw={WebUtility.UrlEncode(txtTiebaName.Text.Trim())}&pn={pn}";

                   // Log($"正在处理第 {i + 1} 页: {url}");
                    await CrawlImageAsync(url, tiebaFolder);
                    progressBar1.Value = i + 1;
                    await Task.Delay(2000); // 延迟防止被封
                }

                Log($"任务完成! 共找到 {_totalImages} 张图片，成功下载 {_downloadedImages} 张");
            }
            catch (Exception ex)
            {
                Log($"发生错误: {ex.Message}");
            }
            finally
            {
                btnCrawlImage.Enabled = true;
            }
        }
        private async Task CrawlImageAsync(string pageUrl, string saveFolder)
        {
            try
            {
                string html = await _httpClient.GetStringAsync(pageUrl);
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);

                // 获取当前页所有帖子链接
                var threadLinks = doc.DocumentNode.SelectNodes("//a[contains(@class, 'j_th_tit')]");
                if (threadLinks == null) return;

                foreach (var link in threadLinks)
                {
                    string threadUrl = "https://tieba.baidu.com" + link.Attributes["href"].Value;
                    await ProcessThreadAsync(threadUrl, saveFolder);
                }
            }
            catch (Exception ex)
            {
                Log($"处理页面时出错: {ex.Message}");
            }
        }
        private void btnSavePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                _savePath = folderBrowserDialog1.SelectedPath;
                txtSavePath.Text = _savePath;

                // 在保存路径下创建以贴吧名命名的子文件夹
                if (!string.IsNullOrEmpty(txtTiebaName.Text))
                {
                    txtSavePath.Text = Path.Combine(_savePath, txtTiebaName.Text.Trim());
                }
            }
        }
        private async Task ProcessThreadAsync(string threadUrl, string saveFolder)
        {
            try
            {
                string html = await _httpClient.GetStringAsync(threadUrl);
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);

                // 获取帖子中所有图片
                var imgNodes = doc.DocumentNode.SelectNodes("//img[@class='BDE_Image']");
                if (imgNodes == null) return;

                _totalImages += imgNodes.Count;
                Log($"在帖子 {threadUrl} 中找到 {imgNodes.Count} 张图片");

                // 为当前帖子创建单独文件夹
                string threadFolder = Path.Combine(saveFolder, Path.GetFileName(threadUrl));
                Directory.CreateDirectory(threadFolder);

                // 下载图片
                foreach (var imgNode in imgNodes)
                {
                    string imgUrl = imgNode.Attributes["src"].Value;
                    await DownloadImageAsync(imgUrl, threadFolder);
                }
            }
            catch (Exception ex)
            {
                Log($"处理帖子时出错: {ex.Message}");
            }
        }
        private void Log(string message)
        {
            if (lstLog.InvokeRequired)
            {
                lstLog.Invoke(new Action<string>(Log), message);
                return;
            }

            string logEntry = $"[{DateTime.Now:HH:mm:ss}] {message}";
            lstLog.Items.Add(logEntry);
            lstLog.TopIndex = lstLog.Items.Count - 1;
        }
        private async Task DownloadImageAsync(string imageUrl, string saveFolder)
        {
            try
            {
                string fileName = string.Empty;
                if (imageUrl.Contains('?'))
                {
                    string[] temp = imageUrl.Split('?');
                    fileName = Path.GetFileName(temp[0]);
                }                  
                else
                    fileName = Path.GetFileName(imageUrl);
                string savePath = Path.Combine(saveFolder, fileName);

                // 如果文件已存在则跳过
                if (File.Exists(savePath))
                {
                    Log($"文件已存在，跳过: {fileName}");
                    _downloadedImages++;
                    return;
                }

                Log($"正在下载: {fileName}");
                byte[] imageData = await _httpClient.GetByteArrayAsync(imageUrl);
                await File.WriteAllBytesAsync(savePath, imageData);
                _downloadedImages++;
                Log($"下载完成: {fileName}");
            }
            catch (Exception ex)
            {
              Log($"下载图片失败: {imageUrl} \n - {ex.Message}");
            }
        }

    }
}
