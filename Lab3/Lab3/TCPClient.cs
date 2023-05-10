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
    public partial class TCPClient : Form
    {
        public TCPClient()
        {
            InitializeComponent();
        }

        NetworkStream ns;
        TcpClient tcpClient = new TcpClient();
        private bool isConnected = false;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            IPAddress iPAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipepClient = new IPEndPoint(iPAddress, 8080);
            tcpClient.Connect(ipepClient);
            ns = tcpClient.GetStream();
            isConnected = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                string message = rtbMessage.Text;
                Byte[] data = Encoding.UTF8.GetBytes(message);
                ns.Write(data, 0, data.Length);
                rtbMessage.Clear();
            }
            else
            {
                MessageBox.Show("The connection has been closed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                Byte[] data = Encoding.UTF8.GetBytes("\nDisconnect...\n");
                ns.Write(data, 0, data.Length);
                ns.Close();
                tcpClient.Close();
                isConnected = false;
            }
            btnConnect.Enabled = true;
        }
    }
}
