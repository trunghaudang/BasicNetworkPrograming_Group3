using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Web;
using HtmlAgilityPack;

namespace Lab4
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private string getHTML(string strURL)
        {
            // Tạo một yêu cầu đến URL
            WebRequest request = WebRequest.Create(strURL);
            // Lấy phản hồi
            WebResponse response = request.GetResponse();
            // Lấy luồng chứa nội dung được trả về bởi máy chủ
            Stream dataStream = response.GetResponseStream();
            // Mở luồng bằng StreamReader để dễ dàng truy cập
            StreamReader reader = new StreamReader(dataStream);
            // Đọc nội dung
            string responseFromServer = reader.ReadToEnd();
            // Đóng phản hồi
            response.Close();
            return responseFromServer;
        }

        private void btnShowWebsite_Click(object sender, EventArgs e)
        {
            if (txtURL.Text == "")
            {
                MessageBox.Show("Please enter the URL of the Website!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    webView21.Source = new Uri(txtURL.Text);
                }
                catch
                {
                    MessageBox.Show("Invalid URL! Please enter the URL of the Website!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void DownloadFile(string address, string filename)
        {
            // Download các file từ address và lưu trong filename
            WebClient myWebClient = new WebClient();
            myWebClient.DownloadFile(address, filename);
        }
        private void DownloadHTML(string szURL, string path)
        {
            // Download nội dung HTML từ URL và lưu vào tệp trong đường dẫn chỉ định
            WebClient client = new WebClient();
            client.DownloadFile(szURL, path);
        }
        private bool check_link(string link)
        {
            // Lấy các link có extension là ".jpg", ".png",".jpeg", ".webm", ".mp4", ".mp3", ".js", ".css", ".ico" 
            string ext = System.IO.Path.GetExtension(link); // Lấy phần mở rộng của link và lưu vào biến ext 
            if (ext == ".jpg" || ext == ".png" || ext == ".jpeg" || ext == ".webm" 
                || ext == ".mp4" || ext == ".mp3" || ext == ".js" || ext == ".css" || ext == ".ico") 
                return true;
            else
            {
                return false;
            }
        }
        private string getFilename(string hyper_link)
        {
            // Lấy tên file từ URL
            string filename = "";
            Uri uri = new Uri(hyper_link);
            filename = System.IO.Path.GetFileName(uri.LocalPath); // Lấy tên file từ đường dẫn
            return filename;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            // Tạo điều kiện yêu cầu nhập URL, không được để trống
            if (txtURL.Text == "")
            {
                MessageBox.Show("Please enter the URL!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Tạo điều kiện yêu cầu nhập đường dẫn lưu file, không được để trống
            if (txtPath.Text == "")
            {
                MessageBox.Show("Please enter the file saving path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if ((txtURL.Text != "") && (txtPath.Text != ""))
            {
                try
                {
                    //Download HTMl
                    DownloadHTML(txtURL.Text, txtPath.Text + "\\" + "content" + ".html");
                    // Download các image và file
                    WebClient web = new WebClient();
                    HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
                    htmlDoc.Load(web.OpenRead(txtURL.Text), Encoding.UTF8);
                    foreach (HtmlNode link in htmlDoc.DocumentNode.SelectNodes("//*"))
                    {
                        string hyper_link = "";
                        if (link.Attributes["href"] != null)
                        {
                            hyper_link = link.Attributes["href"].Value;
                        }
                        if (link.Attributes["src"] != null)
                        {
                            hyper_link = link.Attributes["src"].Value;
                        }
                        if (check_link(hyper_link))
                        {
                            if (!hyper_link.Contains("http") || !hyper_link.Contains("https"))
                            {
                                hyper_link = txtURL.Text + hyper_link;
                            }
                            string filename = Path.GetFileName(new Uri(hyper_link).AbsolutePath);
                            DownloadFile(hyper_link, txtPath.Text + "\\" + getFilename(hyper_link));
                        }
                    }
                    MessageBox.Show("Download successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Invalid URL! Please enter again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnShowSource_Click(object sender, EventArgs e)
        {
            if (txtURL.Text == "")
            {
                MessageBox.Show("Please enter the URL of the Website!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    // Xử lý tạo form mới để xem source website
                    var url = getHTML(txtURL.Text);
                    Source showSource = new Source(url);
                    showSource.Show();
                }
                catch
                {
                    MessageBox.Show("Invalid URL! Please enter the URL of the Website!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
