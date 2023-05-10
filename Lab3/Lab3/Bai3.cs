using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnServerB3_Click(object sender, EventArgs e)
        {
            TCPServer serverB3 = new TCPServer();
            serverB3.Show();
        }

        private void btnClientB3_Click(object sender, EventArgs e)
        {
            TCPClient clientB3 = new TCPClient();
            clientB3.Show();
        }
    }
}
