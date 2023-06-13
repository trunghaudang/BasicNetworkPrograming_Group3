using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MimeKit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Org.BouncyCastle.Crypto;

namespace Lab5
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }
        ImapClient client = new ImapClient();
        public readonly int limit = 20;

        // Email: datmathew@gmail.com
        // Pass: nixefjhelupqvcqs

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtEmail.Text != "") && (txtPass.Text != ""))
            {
                try
                {
                    listViewMail.Items.Clear();

                    // Khởi tạo một đối tượng ImapClient 
                    var client = new ImapClient();
                    client.Connect("imap.gmail.com", 993, true);
                    client.Authenticate(txtEmail.Text, txtPass.Text);

                    // Đọc
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);
                    lbTotal.Text = inbox.Count.ToString();
                    lbRecent.Text = inbox.Recent.ToString();

                    for (int i = 0; i < limit; i++)
                    {
                        var message = inbox.GetMessage(i);
                        ListViewItem item = new ListViewItem(message.Subject.ToString());
                        item.SubItems.Add(message.From.ToString());
                        item.SubItems.Add(message.Date.ToString());
                        listViewMail.Items.Add(item);
                    }

                    MessageBox.Show("Login successfully!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Login failed! The Email or password is incorrect. \nError: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter the Email and Pass fields to login email!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
            txtPass.UseSystemPasswordChar = true;
        }
    }
}
