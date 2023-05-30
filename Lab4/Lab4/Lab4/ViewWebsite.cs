using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace Lab4
{
    public partial class ViewWebsite : Form
    {
        public ViewWebsite()
        {
            InitializeComponent();
            Load += ViewWebsite_Load;
        }

        // Lưu trữ URL truyền từ form Bai6
        public string DataFromBai6 { get; set; }

        private void ViewWebsite_Load(object sender, EventArgs e)
        {
            // Khởi tạo WebView2
            InitializeWebView2();
        }

        // Thiết lập URL cho WebView2
        private async void InitializeWebView2()
        {
            await webView21.EnsureCoreWebView2Async(null); // CoreWebView2 đã được khởi tạo và sẵn sàng sử dụng
            webView21.CoreWebView2.Navigate(DataFromBai6); // Thiết lập URL cho WebView2
        }

    }
}
