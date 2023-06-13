using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using MailKit.Security;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Lab5
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }
        string email;
        string pass;

        // Email: datmathew@gmail.com
        // Pass: nixefjhelupqvcqs

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text == "")
                {
                    MessageBox.Show("Enter user!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtPass.Text == "")
                {
                    MessageBox.Show("Enter password!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if ((txtEmail.Text != "") && (txtPass.Text != ""))
                {
                    email = txtEmail.Text.Trim();
                    pass = txtPass.Text.Trim();
                    var imapClient = new ImapClient();
                    imapClient.Connect("imap.gmail.com", 993, true);
                    imapClient.Authenticate(email, pass);
                    var Read = new EmailClient(email, pass);

                    Read.Load += async (s, ea) =>
                    {
                        await Task.Delay(1000); // đợi 1 giây
                        this.Hide(); // ẩn form đăng nhập
                    };

                    Read.Show();
                }
            }
            catch (AuthenticationException ex)
            {
                MessageBox.Show("The Email or Password is incorrect. Please check again. \nError: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
            txtPass.UseSystemPasswordChar = true;
        }
    }
}
