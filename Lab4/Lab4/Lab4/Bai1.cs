using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        // Hàm lấy dữ liệu sử dụng WebRequest
        private string getHTML(string szURL)
        {
            // Tạo một yêu cầu cho URL
            WebRequest request = WebRequest.Create(szURL);
            // Nhận phản hồi
            WebResponse response = request.GetResponse();
            // Lấy luồng dữ liệu chứa nội dung trả về từ máy chủ
            Stream dataStream = response.GetResponseStream();
            // Mở luồng bằng StreamReader để dễ dàng truy cập 
            StreamReader reader = new StreamReader(dataStream);
            // Đọc nội dung 
            string responseFromServer = reader.ReadToEnd();
            // Đóng phản hồi 
            response.Close();
            return responseFromServer;
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                rtbContent.Text = getHTML(txtURL.Text);
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
