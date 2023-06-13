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
using System.Net;
using MailKit;
using MailKit.Net.Imap;
using MimeKit;
using MailKit.Net.Pop3;

namespace Lab5
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }
        Pop3Client client = new Pop3Client();
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

                    // Khởi tạo một đối tượng Pop3Client 
                    var client = new Pop3Client();
                    client.Connect("pop.gmail.com", 995, true);
                    client.Authenticate(txtEmail.Text, txtPass.Text);

                    // Đọc thông tin
                    int Count = client.GetMessageCount();
                    int Recent = 0;
                    lbTotal.Text = Count.ToString();
                    lbRecent.Text = Recent.ToString();

                    for (int i = 0; i < limit; i++)
                    {
                        var message = client.GetMessage(i);
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
