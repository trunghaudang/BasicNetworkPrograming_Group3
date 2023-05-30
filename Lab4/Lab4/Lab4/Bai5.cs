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
using System.Net.Http.Json;
using Newtonsoft.Json;

namespace Lab4
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Hiển thị ký tự ẩn (*) trong TextBox khi nhập Password
            txtPassword.PasswordChar = '*';
            txtPassword.UseSystemPasswordChar = true;
        }

        private async void btnPOST_Click(object sender, EventArgs e) 
        {
            if (txtURL.Text != "") {
                if ((txtUsername.Text != "") && (txtPassword.Text != "")) {
                    string szURL = txtURL.Text;
                    // Chuyển đổi dữ liệu thành chuỗi JSON
                    string postData = JsonConvert.SerializeObject(new
                    {
                        username = txtUsername.Text,
                        password = txtPassword.Text
                    });
                    // Tạo yêu cầu WebRequest với phương thức POST
                    WebRequest request = WebRequest.Create(szURL);
                    request.Method = "POST";
                    // Chuyển đổi chuỗi JSON thành mảng byte
                    byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                    // Định dạng nội dung 
                    request.ContentType = "application/json";
                    // Độ dài nội dung là độ dài của mảng byte của chuỗi JSON
                    request.ContentLength = byteArray.Length;
                    // Ghi dữ liệu vào request stream
                    using (Stream dataStream = request.GetRequestStream()) 
                    {
                        dataStream.Write(byteArray, 0, byteArray.Length);
                        // Gửi yêu cầu POST bất đồng bộ và nhận phản hồi từ máy chủ
                        using (WebResponse response = await request.GetResponseAsync()) 
                        {
                            // Nhận stream phản hồi từ máy chủ
                            using (Stream responseStream = response.GetResponseStream()) 
                            {
                                // Đọc nội dung phản hồi từ response stream và chuyển đổi thành chuỗi
                                using (StreamReader reader = new StreamReader(responseStream)) 
                                {
                                    string responseFromServer = reader.ReadToEnd();
                                    // Chuyển đổi chuỗi phản hồi thành một đối tượng động
                                    dynamic jsonObject = JsonConvert.DeserializeObject<dynamic>(responseFromServer);
                                    // Gán giá trị của thuộc tính "token" từ đối tượng động
                                    rtbToken.Text = jsonObject.token;
                                }
                            }
                        }
                    }
                }
                else {
                    MessageBox.Show("Please enter the Username and Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }    
            }
            else {
                MessageBox.Show("Please enter the URL!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
