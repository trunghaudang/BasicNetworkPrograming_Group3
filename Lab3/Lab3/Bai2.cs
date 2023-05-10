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

namespace Lab3
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private bool isListening = false; // Trạng thái của nút lắng nghe
        private Socket listenerSocket; 
        private string receivedData = ""; 
        private Socket clientSocket;

        private void btnListen_Click(object sender, EventArgs e)
        {
            if (!isListening)
            {
                isListening = true;
                btnListen.Text = "Stop and Close";
                lvMessage.Items.Add(new ListViewItem("Telnet running on 127.0.0.1:8080. Currently listening for connections...\r\n"));

                CheckForIllegalCrossThreadCalls = false;
                Thread severthread = new Thread(new ThreadStart(StartUnsafeThread));
                severthread.Start();
            }
            else
            {
                listenerSocket.Close();
                btnListen.Text = "Listen";
                lvMessage.Items.Add(new ListViewItem("Stop listening for connections and close Telnet!\r\n"));
            }
        }
        void StartUnsafeThread()
        {
            int bytesRecv = 0;
            // Khởi tạo mảng bytes nhận dữ liệu
            byte[] recv = new byte[1];

            listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenerSocket.Bind(ipepServer);
            listenerSocket.Listen(-1);
            clientSocket = listenerSocket.Accept();

            lvMessage.Items.Add(new ListViewItem("New client connected!\r\n"));

            while (clientSocket.Connected)
            {
                bytesRecv = clientSocket.Receive(recv);
                receivedData += Encoding.ASCII.GetString(recv, 0, bytesRecv);

                if (receivedData.EndsWith("\r\n"))
                {
                    if (isListening) // Kiểm tra trạng thái của nút Listen trước khi nhập dữ liệu vào ListView
                    {
                        lvMessage.Items.Add(new ListViewItem("Client: " + receivedData));
                    }
                    receivedData = "";
                }
            }
            listenerSocket.Close(); 
        }
    }
}
