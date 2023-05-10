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
    public partial class UDPServer : Form
    {
        public UDPServer()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            if (btnListen.Text == "Listen")
            {
                MessageBox.Show("Server start listening!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnListen.Text = "Stop";
                txtPort.Enabled = false;
                
                CheckForIllegalCrossThreadCalls = false;
                Thread thread = new Thread(new ThreadStart(serverThread));
                thread.Start();
            }
            else
            {
                btnListen.Text = "Listen";
                txtPort.Enabled = true;
                lvReceiveMessage.Items.Clear();
            }
        }

        private void serverThread()
        {
            int port = int.Parse(txtPort.Text);
            UdpClient server = new UdpClient(port);
            while (true)
            {
                IPEndPoint ipEP = new IPEndPoint(IPAddress.Any, 0);
                Byte[] rev = server.Receive(ref ipEP);
                string data = Encoding.UTF8.GetString(rev);
                string mess = ipEP.Address.ToString() + ": " + data + Environment.NewLine;
                lvReceiveMessage.Items.Add(mess);
            }
        }
    }
    
}
