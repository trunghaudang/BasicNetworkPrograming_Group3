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
using HtmlAgilityPack;
using System.Text.RegularExpressions;
using Microsoft.Web.WebView2.Core;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }
        
        private async void btnGet_Click(object sender, EventArgs e)
        {
            // Mô phỏng quá trình trích xuất thông tin
            for (int i = 0; i <= progressBar1.Maximum; i++)
            {
                // Cập nhật giá trị của ProgressBar
                progressBar1.Value = i;

                // Giữ cho giao diện đáp ứng bằng cách cho đợi một lúc
                Application.DoEvents();

                // Mô phỏng thời gian trích xuất thông tin
                Thread.Sleep(100);
            }
            MessageBox.Show("Complete information extraction!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string url = txtURL.Text.Trim();

            // Kiểm tra xem URL có hợp lệ hay không
            if (!IsValidURL(url))
            {
                MessageBox.Show("Invalid URL!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tiến hành download file html từ URL
            string filePath = await DownloadHTML(url);

            // Trích xuất thông tin từ file html
            ExtractDataFromFile(filePath);
        }

        // Kiểm tra xem một chuỗi địa chỉ URL có hợp lệ hay không
        private bool IsValidURL(string url)
        {
            // Lưu trữ kết quả chuyển đổi chuỗi URL thành đối tượng Uri
            Uri uriResult; 
            return Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            // Kiểm tra tiền tố giao thức của địa chỉ URL là HTTP hoặc HTTPS
        }

        // Tải về nội dung HTML từ địa chỉ URL và lưu nó vào một tệp tin trên đĩa cứng
        private async Task<string> DownloadHTML(string url)
        {
            string filePath = @"D:\UIT\Lab4\Bai6\Web.html";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Gửi một yêu cầu HTTP GET đến địa chỉ URL để yêu cầu trả về một đối tượng đại diện cho phản hồi từ máy chủ
                    HttpResponseMessage response = await client.GetAsync(url);
                    // Kiểm tra xem phản hồi từ máy chủ có thành công hay không
                    response.EnsureSuccessStatusCode();
                    // Đọc nội dung HTML từ phản hồi HTTP
                    string htmlContent = await response.Content.ReadAsStringAsync();

                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        // Ghi nội dung HTML vào tệp tin
                        await writer.WriteAsync(htmlContent);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while downloading the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return filePath;
        }

        // Trích xuất thông tin từ tệp tin HTML đã được tải về
        private void ExtractDataFromFile(string filePath)
        {
            try
            {
                HtmlWeb web = new HtmlWeb();
                HtmlDocument doc = web.Load(filePath);
                // Lấy tất cả các phần tử <a> (liên kết) trong tài liệu HTML.
                // Mẫu XPath //a[@href] được sử dụng để chọn các phần tử <a> có thuộc tính href.
                HtmlNodeCollection linkNodes = doc.DocumentNode.SelectNodes("//a[@href]");

                if (linkNodes != null)
                {
                    listViewWeb.Items.Clear();

                    foreach (HtmlNode linkNode in linkNodes)
                    {
                        // Lấy giá trị của thuộc tính href của phần tử <a>. Nếu thuộc tính không tồn tại, giá trị mặc định là chuỗi rỗng.
                        string hrefValue = linkNode.GetAttributeValue("href", "");
                        Uri uriResult;
                        // Kiểm tra xem hrefValue có phải là một URL hợp lệ hay không
                        bool isUrl = Uri.TryCreate(hrefValue, UriKind.Absolute, out uriResult)
                            && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

                        if (isUrl)
                        {
                            ListViewItem listViewItem = new ListViewItem(hrefValue);
                            listViewWeb.Items.Add(listViewItem);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while extracting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bai6_Load(object sender, EventArgs e)
        {
            listViewWeb.View = View.SmallIcon;
            listViewWeb.MultiSelect = true;
            listViewWeb.Enabled = true; // Kích hoạt ListViewWeb
            listViewWeb.DoubleClick += listViewWeb_DoubleClick_1;
        }

        private void listViewWeb_DoubleClick_1(object sender, EventArgs e)
        {
            OpenSelectedWebItem();
        }
        private void OpenSelectedWebItem()
        {
            // Kiểm tra xem có ít nhất một mục được chọn trong listViewWeb hay không.
            // SelectedItems là một thuộc tính của listViewWeb trả về một collection chứa các mục đang được chọn.
            if (listViewWeb.SelectedItems.Count > 0)
            {
                // Lấy mục đầu tiên trong danh sách các mục được chọn và gán cho biến selectedItem.
                ListViewItem selectedItem = listViewWeb.SelectedItems[0];
                // Nội dung văn bản hiển thị cho mục được chọn
                string itemText = selectedItem.Text;
                OpenWebForm(itemText);
            }
        }

        private void OpenWebForm(string url)
        {
            ViewWebsite viewWebsite = new ViewWebsite();
            viewWebsite.DataFromBai6 = url;
            viewWebsite.ShowDialog();
        }
    }
}
