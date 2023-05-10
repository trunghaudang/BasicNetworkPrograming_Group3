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
    public partial class PrivateChat : Form
    {
        public PrivateChat()
        {
            InitializeComponent();
        }

        List<string> listFiles = new List<string>();

        private void btnFile_Click(object sender, EventArgs e)
        {
            listFiles.Clear();
            lvMessage.Items.Clear();

            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    tbMessage.Text = fbd.SelectedPath;
                    LoadFiles(fbd.SelectedPath);
                }
            }
        }

        private void LoadFiles(string directoryPath)
        {
            try
            {
                lvMessage.Items.Clear();

                string[] files = Directory.GetFiles(directoryPath);

                foreach (string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    ListViewItem item = new ListViewItem(fileInfo.Name);
                    item.SubItems.Add(fileInfo.Extension);
                    item.SubItems.Add(fileInfo.Length.ToString());
                    item.SubItems.Add(fileInfo.LastWriteTime.ToString());
                    lvMessage.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        List<Image> Img_Collection = new List<Image>();

        private void btnPhoto_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (tbMessage.Text == "")
            {
                MessageBox.Show("Please type your message!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
