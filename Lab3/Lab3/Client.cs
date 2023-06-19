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
using System.Net.Sockets;
using System.Xml.Linq;
using System.IO;
using System.Drawing;

namespace Lab3
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        public Socket clientSocket;
        private IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
        private bool isConnect = false; // Biến để đại diện cho trạng thái của nút Connect     

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!isConnect)
            {
                if (txtName.Text != "")
                {
                    isConnect = true;
                    btnConnect.Text = "Stop and Exit";
                    CheckForIllegalCrossThreadCalls = false;
                    Connect();
                    string participant = txtName.Text + "\n";
                    BroadcastData(participant, clientSocket);
                    lbParticipants.Items.Add(participant);
                }
                else
                {
                    MessageBox.Show("Please type your name!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                btnConnect.Text = "Connect";
                this.Close();
            }
        }

        private void Connect()
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                clientSocket.Connect(ipepServer);
            }
            catch
            {
                MessageBox.Show("Can not connect to Server!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            Thread thread = new Thread(ReceiveData);
            thread.IsBackground = true;
            thread.Start();
        }

        private void ReceiveData()
        {
            while (true)
            {
                try
                {
                    byte[] data = new byte[1024 * 5000];
                    int receivedBytes = clientSocket.Receive(data);
                    string str = UTF32Encoding.UTF32.GetString(data, 0, receivedBytes);

                    if (str == "Server disconnected!")
                    {
                        lvMessage.Items.Add(new ListViewItem(str));
                        clientSocket.Shutdown(SocketShutdown.Both);
                        clientSocket.Close();
                        break;
                    }
                    else
                        lvMessage.Items.Add(new ListViewItem(str));
                }

                catch (SocketException ex)
                {
                    // Xử lý lỗi khi kết nối đã đóng
                    Console.WriteLine(ex.ToString());
                    break;
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please type your name!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtMess.Text == "")
            {
                MessageBox.Show("Please type your message!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (clientSocket == null || !clientSocket.Connected)
                {
                    MessageBox.Show("No connection to server!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Gửi tin nhắn của người dùng đến server
                string content = txtName.Text + ": " + txtMess.Text + "\n";
                clientSocket.Send(UTF32Encoding.UTF32.GetBytes(content));
                lvMessage.Items.Add(content);
                txtMess.Clear();
            }
        }

        private void lbParticipants_Click(object sender, EventArgs e)
        {
            PrivateChat privateChat = new PrivateChat();
            privateChat.Show();    
        }

        static void BroadcastData(string data, Socket senderSocket)
        {
            List<Socket> clientSockets = new List<Socket>();
            // Lặp qua danh sách các client đã kết nối tới server và gửi dữ liệu đến từng client
            foreach (Socket clientSocket in clientSockets)
            {
                if (clientSocket != senderSocket)
                {
                    byte[] buffer = Encoding.ASCII.GetBytes(data);
                    clientSocket.Send(buffer);
                    Console.WriteLine($"Đã gửi dữ liệu tới client {clientSocket.RemoteEndPoint}");
                }
            }
        }
    }
}
