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
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Lab4
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
            LoadUsers(page);
        }

        private int page = 1;
        private string url = "https://reqres.in/api/users?page=1"; 

        // Định nghĩa lớp lưu trữ thông tin chi tiết về một người dùng từ dữ liệu được nhận về từ API
        class User
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("email")]
            public string Email { get; set; }

            [JsonPropertyName("first_name")]
            public string FirstName { get; set; }

            [JsonPropertyName("last_name")]
            public string LastName { get; set; }

            [JsonPropertyName("avatar")]
            public string Avatar { get; set; }
        }
        // Định nghĩa lớp lưu trữ thông tin về phân trang dữ liệu người dùng, bao gồm thông tin về trang hiện tại,
        // số lượng người dùng trên mỗi trang và danh sách các đối tượng người dùng trên trang
        class UserPagination
        {
            [JsonPropertyName("page")]
            public int Page { get; set; }

            [JsonPropertyName("per_page")]
            public int PerPage { get; set; }

            [JsonPropertyName("total")]
            public int Total { get; set; }

            [JsonPropertyName("total_pages")]
            public int TotalPages { get; set; }

            [JsonPropertyName("data")]
            public List<User> Data { get; set; }
        }

        UserPagination data;
        private void LoadUsers(int pageNum)
        {
            // Xây dựng URL của API để lấy dữ liệu trang pageNum
            string apiUrl = $"{url}?page={pageNum}";
            // Gửi yêu cầu HTTP và nhận dữ liệu dạng JSON từ API
            string json = getHTML(apiUrl);
            // Chuyển đổi dữ liệu JSON thành đối tượng UserPagination
            data = JsonSerializer.Deserialize<UserPagination>(json);

            // Cập nhật các label để hiển thị thông tin về trang, số người dùng trên trang, tổng số người dùng và tổng số trang
            lbPage.Text = $"{data.Page}";
            lbUsers.Text = $"{data.PerPage}";
            lbTotalUsers.Text = $"{data.Total}";
            lbTotalPage.Text = $"{data.TotalPages}";
            // Xóa các control hiện tại trong flowLayoutPanel1
            flowLayoutPanel1.Controls.Clear();

            // Lặp qua danh sách người dùng trong dữ liệu và tạo panel và controls tương ứng
            foreach (User user in data.Data)
            {
                // Tạo một panel để chứa thông tin về người dùng
                Panel panel = new Panel
                {
                    Width = flowLayoutPanel1.ClientSize.Width,
                    Height = 200,
                    BorderStyle = BorderStyle.Fixed3D
                };

                // Tạo một TableLayoutPanel để chứa các controls trong panel
                TableLayoutPanel tlp = new TableLayoutPanel
                {
                    Width = panel.ClientSize.Width,
                    Height = panel.ClientSize.Height,
                    ColumnCount = 2
                };
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70));
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));

                // Tạo label để hiển thị tên người dùng
                Label nameLabel = new Label
                {
                    Text = $"{user.FirstName} {user.LastName}",
                    Dock = DockStyle.Fill,
                    Font = new Font(Font, FontStyle.Bold)
                };
                tlp.Controls.Add(nameLabel, 0, 0);

                // Tạo label để hiển thị email người dùng
                Label emailLabel = new Label
                {
                    Text = user.Email,
                    Dock = DockStyle.Fill,
                    Font = new Font(Font, FontStyle.Italic)
                };
                tlp.Controls.Add(emailLabel, 0, 1);

                // Tạo PictureBox để hiển thị hình ảnh người dùng
                PictureBox avatarBox = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.AutoSize,
                    Anchor = AnchorStyles.Top | AnchorStyles.Right
                };
                avatarBox.Load(user.Avatar);
                tlp.Controls.Add(avatarBox, 1, 0);
                tlp.SetRowSpan(avatarBox, 2);
                tlp.Dock = DockStyle.Fill;

                // Điều chỉnh kích thước panel và TableLayoutPanel dựa trên kích thước hình ảnh người dùng
                panel.Height = avatarBox.Height;
                tlp.Height = panel.Height;
                // Đưa TableLayoutPanel vào panel và thêm panel vào flowLayoutPanel1
                panel.Controls.Add(tlp);
                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private string getHTML(string strURL)
        {
            // Tạo một yêu cầu đến URL
            WebRequest request = WebRequest.Create(strURL);
            // Lấy phản hồi
            WebResponse response = request.GetResponse();
            // Lấy luồng chứa nội dung được trả về bởi máy chủ
            Stream dataStream = response.GetResponseStream();
            // Mở luồng bằng StreamReader để dễ dàng truy cập
            StreamReader reader = new StreamReader(dataStream);
            // Đọc nội dung
            string responseFromServer = reader.ReadToEnd();
            // Đóng phản hồi
            response.Close();
            return responseFromServer;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
                LoadUsers(page);
            }
            else
                MessageBox.Show("Currently on the first page!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (page < data.TotalPages)
            {
                page++;
                LoadUsers(page);
            }
            else
                MessageBox.Show("Currently on the last page!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
