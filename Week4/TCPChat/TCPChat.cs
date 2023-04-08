namespace TCPChat
{
    public partial class TCPChat : Form
    {
        public TCPChat()
        {
            InitializeComponent();
        }

        private void btnOpenClient_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }

        private void btnOpenServer_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
        }
    }
}