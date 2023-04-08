using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TCPChat
{
    public partial class Client : Form
    {
        IPEndPoint IP;
        Socket clientSocket;

        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;//tránh việc đụng độ khi sử dụng tài nguyên giữa các thread
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //IP là địa chỉ của server.Khởi tạo địa chỉ IP và socket để kết nối
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1997);
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            //bắt đầu kết nôi. Nếu ko kết nối được thì hiện thông báo
            try
            {
                clientSocket.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //tạo luồng lắng nghe server khi vừa kết nối tới
            Thread listen = new Thread(Receive);  //Nhận đối số là Receive để luôn lắng nghe dưới nền
            listen.IsBackground = true;
            listen.Start();

            if (btnConnect.Text == "Connect")
            {
                btnConnect.Text = "Disconnected";
                txtIP.Enabled = txtName.Enabled = false;
                lsvShowMessage.Items.Add(new ListViewItem() { Text = txtName.Text + " " + "connected to: " + IP.ToString() }); // += txtName.Text + " " + "connected to: " + IP.ToString() + "\r\n";

            }
            else
            {
                btnConnect.Text = "Connect";
                txtIP.Enabled = txtName.Enabled = true;
                lsvShowMessage.Text = "";
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //nếu textbox khác rỗng thì mới gửi tin
            if (txtMessage.Text != string.Empty)
            {
                clientSocket.Send(Serialize(txtMessage.Text));  //Gửi thì phân mảnh 
            }
            ShowMessage(txtMessage.Text);
        
        }

        //đóng kết nối đến server
        void Close()
        {
            clientSocket.Close();
        }

        //nhận dữ liệu
        void Receive()
        {
            try
            {
                while (true)
                {
                    //khai báo mảng byte để nhận dữ liệu dưới mảng byte
                    byte[] data = new byte[1024 * 5000];  
                    clientSocket.Receive(data);
                    //chuyển data từ dạng byte sang dạng string
                    string message = (string)Deseriliaze(data);  //Nhận thì gom mảnh
                    ShowMessage(message);
                }
            }
            catch
            {
                Close();
            }
        }

        //Show message vào khung chat
        void ShowMessage(string s)
        {
            lsvShowMessage.Items.Add(new ListViewItem() { Text = txtName.Text + ": " + s });
            txtMessage.Clear();
        }

        //Hàm phân mảnh dữ liệu cần gửi từ dạng string sang dạng byte để gửi đi
        byte[] Serialize(object obj) 
        {
            //khởi tạo stream để lưu các byte phân mảnh
            MemoryStream stream = new MemoryStream();
            //khởi tạo đối tượng BinaryFormatter để phân mảnh dữ liệu sang kiểu byte
            BinaryFormatter formatter = new BinaryFormatter();
            //phân mảnh rồi ghi vào stream
            formatter.Serialize(stream, obj);
            //từ stream chuyển các các byte thành dãy rồi cbi gửi đi
            return stream.ToArray();  //Kết quả trả về là kiểu dữ liệu byte
        }

        //Hàm gom mảnh các byte nhận được rồi chuyển sang kiểu string để hiện thị lên màn hình
        object Deseriliaze(byte[] data)
        {
            //khởi tạo stream đọc kết quả của quá trình phân mảnh 
            MemoryStream stream = new MemoryStream(data); //Bên trên chưa có dữ liệu nên chưa truyền vào
                                                          //bên dưới có dữ liệu truyền vào là data
            //khởi tạo đối tượng chuyển đổi
            BinaryFormatter formatter = new BinaryFormatter();
            //chuyển đổi dữ liệu và lưu lại kết quả 
            return formatter.Deserialize(stream);  //Kết quả trả về không phải là byte mà là object
        }
    }
}
