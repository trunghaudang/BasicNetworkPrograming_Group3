using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit.Net.Pop3;
using MailKit.Search;
using MailKit;
using MimeKit;

namespace Lab5
{
    public partial class EmailClient : Form
    {
        public EmailClient()
        {
            InitializeComponent();
        }
        string Emailuser = "";
        string Pass = "";
        public EmailClient(string email, string pass)
        {
            InitializeComponent();
            txtEmail.Text = email;
            txtIMAP.Text = "imap.gmail.com";
            txtPortI.Text = "993";
            txtSMTP.Text = "smtp.gmail.com";
            txtPortS.Text = "465";
            Emailuser = email;
            Pass = pass;

            ViewMail();
        }

        private bool _isHtml = false;
        private ImapClient imapClient;
        private void ViewMail()
        {
            lvEmail.Items.Clear();
            try
            {
                imapClient = new ImapClient();
                imapClient.Connect("imap.gmail.com", 993, true);
                imapClient.Authenticate(Emailuser, Pass);
                // Đọc
                var inbox = imapClient.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                lbTotal.Text = "Total: " + inbox.Count.ToString();
                lbRecent.Text = "Recent: " + inbox.Recent.ToString();
                // Tạo một danh sách tạm thời để lưu các email
                var messages = new List<MimeMessage>();
                for (int i = 0; i < inbox.Count; i++) {
                    var message = inbox.GetMessage(i);
                    messages.Add(message);
                }

                int Num = 1;
                // Thêm các email vào ListView theo thứ tự từ trên xuống dưới
                for (int i = messages.Count - 1; i >= 0; i--) {
                    var message = messages[i];
                    ListViewItem item = new ListViewItem(Num.ToString());
                    //Thiết lập giá trị cột #
                    item.Text = Num.ToString();
                    // Thiết lập giá trị cột "Tiêu đề"
                    item.SubItems.Add(new ListViewItem.ListViewSubItem()
                    {
                        Text = message.Subject
                    });
                    // Thiết lập giá trị cột "Người gửi"
                    item.SubItems.Add(new ListViewItem.ListViewSubItem()
                    {
                        Text = message.From.ToString()
                    });
                    // Chuyển đổi thời gian sang múi giờ máy
                    var timeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
                    var localDate = TimeZoneInfo.ConvertTimeFromUtc(message.Date.UtcDateTime, timeZone);
                    // Thiết lập giá trị cột "Ngày gửi"
                    item.SubItems.Add(new ListViewItem.ListViewSubItem()
                    {
                        Text = localDate.ToString("dd/MM/yyyy HH:mm:ss")
                    });

                    // Lưu trữ thông tin nội dung email
                    if (message.HtmlBody != null)
                    {
                        item.SubItems.Add(new ListViewItem.ListViewSubItem()
                        {
                            Text = message.HtmlBody
                        });
                        _isHtml = true;
                    }
                    else if (message.TextBody != null)
                    {
                        item.SubItems.Add(new ListViewItem.ListViewSubItem()
                        {
                            Text = message.TextBody
                        });
                    }
                    else
                    {
                        item.SubItems.Add(new ListViewItem.ListViewSubItem()
                        {
                            Text = ""
                        });
                    }
                    // Thêm đối tượng ListViewItem vào ListView
                    lvEmail.Items.Add(item);
                    Num++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private MimeMessage GetMessageFromServer(string subject)
        {
            // Đăng nhập với IMAP
            var imapClient = new ImapClient();
            imapClient.Connect("imap.gmail.com", 993, true);
            imapClient.Authenticate(Emailuser, Pass);

            // Đọc
            var inbox = imapClient.Inbox;
            inbox.Open(FolderAccess.ReadOnly);

            // Tìm email theo stt và tiêu đề
            ListViewItem item = lvEmail.SelectedItems[0];
            int num = Int32.Parse(item.SubItems[0].Text);

            // Lấy nội dung email tương ứng
            var mimeMessage = inbox.GetMessage(inbox.Count - num);
            var timeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
            var localDate = TimeZoneInfo.ConvertTimeFromUtc(mimeMessage.Date.UtcDateTime, timeZone);

            // Thiết lập lại thời gian của email
            mimeMessage.Date = localDate;

            return mimeMessage;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var Send = new SendMail(Emailuser, Pass);
            Send.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ViewMail();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            // Ngắt kết nối với server
            imapClient.Disconnect(true);

            // Tạo danh sách chứa tạm các form đang mở 
            List<Form> openForms = new List<Form>();
            foreach (Form form in Application.OpenForms)
            {
                if (form != this && form.Name != "Login")
                {
                    openForms.Add(form);
                }
            }

            // Đóng các form đang mở từ danh sách tạm thời
            foreach (Form form in openForms)
            {
                form.Close();
            }

            // Đóng form Login cũ nếu có
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "Login" && form != this)
                {
                    form.Close();
                }
            }

            this.Close();
        }

        private void lvEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEmail.SelectedItems.Count > 0)
            {
                try
                {
                    // Lấy đối tượng message tương ứng từ server
                    var message = GetMessageFromServer(lvEmail.SelectedItems[0].Text);

                    // Hiển thị nội dung email trong form mới
                    var emailForm = new ReadMail(Emailuser, Pass, message);
                    emailForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
