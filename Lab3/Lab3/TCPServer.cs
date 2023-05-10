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
    public partial class TCPServer : Form
    {
        public TCPServer()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            if (btnListen.Text == "Listen")
            {
                MessageBox.Show("Server start listening!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnListen.Text = "Stop";

                CheckForIllegalCrossThreadCalls = false;
                Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
                serverThread.Start();
            }
            else
            {
                btnListen.Text = "Listen";
                lvMessage.Items.Clear();
            }
        }

        void StartUnsafeThread()
        {
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            TcpListener tcpListener = new TcpListener(ipepServer);
            tcpListener.Start();
            lvMessage.Items.Add("Server started!");
            while (true)
            {
                Socket clientSocket = tcpListener.AcceptSocket();
                lvMessage.Items.Add("Connection accepted from " + clientSocket.RemoteEndPoint.ToString());
                byte[] recv = new byte[1024 * 5000];
                while (clientSocket.Connected)
                {
                    int bytesReceived = clientSocket.Receive(recv, recv.Length, SocketFlags.None);
                    if (bytesReceived == 0)
                    {
                        lvMessage.Items.Add("The connection has been closed!");
                        clientSocket.Close();
                        break;
                    }
                    string text = Encoding.UTF8.GetString(recv, 0, bytesReceived);
                    string mess = "From client: " + text;
                    lvMessage.Items.Add(mess);
                    Array.Clear(recv, 0, recv.Length);
                }
                clientSocket.Close();
            }
            tcpListener.Stop();
        }
    }
}
