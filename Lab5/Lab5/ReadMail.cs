using Microsoft.VisualBasic.ApplicationServices;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class ReadMail : Form
    {
        MimeMessage _message;
        string user;
        string pass;
        public ReadMail(string email, string pw, MimeMessage message)
        {
            InitializeComponent();
            user = email;
            pass = pw;
            _message = message;
        }

        private async void ReadMail_Load(object sender, EventArgs e)
        {
            // Hiển thị nội dung email trên các điều khiển tương ứng
            txtFrom.Text = _message.From.ToString();
            txtSub.Text = _message.Subject;
            var localTime = _message.Date.ToLocalTime();
            txtDate.Text = localTime.ToString("dd/MM/yyyy HH:mm:ss");

            // Khởi tạo trình duyệt WebView2
            await webView21.EnsureCoreWebView2Async();
            // Hiển thị nội dung email trên WebView2 hoặc rtb
            if (_message.HtmlBody != null)
            {
                webView21.NavigateToString(_message.HtmlBody);
                rtbBody.Visible = false;
            }
            else if (_message.TextBody != null)
            {
                webView21.Visible = false;
                rtbBody.Visible = true;
                rtbBody.Text = _message.TextBody;
            }
            else
            {
                webView21.Visible = false;
                rtbBody.Visible = true;
                rtbBody.Text = "Email content not found.";
            }
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            var Send = new SendMail(user, pass);
            Send.Show();
        }
    }
}
