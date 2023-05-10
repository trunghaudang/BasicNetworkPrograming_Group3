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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void btnServerB4_Click(object sender, EventArgs e)
        {
            Server serverB4 = new Server();
            serverB4.Show();
        }

        private void btnClientB4_Click(object sender, EventArgs e)
        {
            Client clientB4 = new Client();
            clientB4.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
