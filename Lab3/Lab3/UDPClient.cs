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
    public partial class UDPClient : Form
    {
        public UDPClient()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if ((txtIP.Text != "") && (txtPort.Text != ""))
            {
                if (rtbMessage.Text != "")
                {
                    int portserver = int.Parse(txtPort.Text);
                    UdpClient client = new UdpClient();
                    string mess = rtbMessage.Text;
                    Byte[] sendmess = Encoding.UTF8.GetBytes(mess);
                    client.Send(sendmess, sendmess.Length, txtIP.Text, portserver);
                    client.Close();
                }
                else
                {
                    MessageBox.Show("Please type your message!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please type the IP Remote host and Port!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
