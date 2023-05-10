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

namespace Lab3
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private bool isListening = false; // Biến để đại diện cho trạng thái của nút Listen
        private Socket listenerSocket;
        private IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
        private List<Socket> ListClient;

        private void btnListen_Click(object sender, EventArgs e)
        {
            if (!isListening)
            {
                isListening = true;
                btnListen.Text = "Stop";
                lvMessage.Items.Add(new ListViewItem("Server running on 127.0.0.1:8080. Currently listening for connections...\r\n"));
                CheckForIllegalCrossThreadCalls = false;
                StartUnsafeThread();
            }
            else
            {
                isListening = false;
                btnListen.Text = "Listen";
                lvMessage.Items.Add(new ListViewItem("Stop listening for connections and close Server!\r\n"));
                foreach (Socket socket in ListClient)
                {
                    socket.Send(UTF32Encoding.UTF32.GetBytes("Server disconnect!"));
                }
                MessageBox.Show("The connection has been closed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listenerSocket.Close();
            }
        }

        void StartUnsafeThread()
        {
            ListClient = new List<Socket>();
            listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            listenerSocket.Bind(ipepServer);
            Thread listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        listenerSocket.Listen(100);
                        Socket client1 = listenerSocket.Accept();
                        ListClient.Add(client1);
                        string str = "New client connected from: " + client1.RemoteEndPoint.ToString() + "\n";
                        lvMessage.Items.Add(new ListViewItem(str));
                        Thread recei = new Thread(receive);
                        recei.IsBackground = true;
                        recei.Start(client1);
                    }
                }
                catch
                {
                    ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
                    listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                }
            });
            listen.IsBackground = true;
            listen.Start();
        }
        void receive(object obj)
        {
            Socket client = obj as Socket;
            Byte[] data = new byte[1024 * 5000];
            while (true)
            {
                if (isListening)
                {
                    int receivedBytes = client.Receive(data);
                    if (receivedBytes == 0)
                    {
                        // Kết nối đã đóng
                        break;
                    }
                    string str = Encoding.UTF32.GetString(data, 0, receivedBytes);
                    string content = client.RemoteEndPoint.ToString() + ": " + str + "\n";
                    lvMessage.Items.Add(new ListViewItem(content));

                    foreach (Socket socket in ListClient)
                    {
                        if (socket != client)
                        {
                            socket.Send(data, receivedBytes, SocketFlags.None);
                        }
                    }
                    // Reset lại buffer
                    Array.Clear(data, 0, data.Length);
                }
                else
                {
                    // Kết nối đã đóng
                    break;
                }
            }
        }
    }
}
