using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Web;

namespace Lab4
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
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
                    // Download nội dung trang web thành file HTML
                    WebClient myClient = new WebClient();
                    Stream response = myClient.OpenRead(txtURL.Text);
                    myClient.DownloadFile(txtURL.Text, txtPath.Text);
                    // Ghi nội dung file HTML lên form
                    StreamReader sr = new StreamReader(response);
                    rtbContent.Text = sr.ReadToEnd();
                    response.Close();
                }
                catch
                {
                    MessageBox.Show("Invalid URL! Please enter again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rtbContent.Text = "";
                    txtURL.Text = "";
                }
            }
        }
    }
}
