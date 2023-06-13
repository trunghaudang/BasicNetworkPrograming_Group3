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

namespace Lab5
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if ((txtFrom.Text != "") && (txtTo.Text != ""))
            {
                // Khởi tạo một đối tượng SmtpClient 
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("datmathew@gmail.com", "nixefjhelupqvcqs");
                client.EnableSsl = true;

                // Khởi tạo một đối tượng MailMessage
                MailAddress from = new MailAddress(txtFrom.Text, "Dat Ho Manh");
                MailMessage message = new MailMessage();
                message.From = from;
                message.To.Add(txtTo.Text);
                message.Subject = txtSubject.Text;
                message.Body = rtbBody.Text;

                try
                {
                    client.Send(message);
                    MessageBox.Show("Email sent successfully!", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Email sending failed! \nError: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter the 'From' and 'To' fields to send email!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }              
        }
    }
}
