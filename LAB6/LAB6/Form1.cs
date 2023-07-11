using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FtpWebRequest request = null; 
        FtpWebResponse response = null; 
        Stream ftpstream = null;
        int lenght = 2048; 


        private List<string> ListFiles()
        {
            try
            {
                request = (FtpWebRequest)WebRequest.Create(txtIPFTPserver.Text);
                request.Method = WebRequestMethods.Ftp.ListDirectory;

                request.Credentials = new NetworkCredential(txtuser.Text, txtpassword.Text);
                response = (FtpWebResponse)request.GetResponse(); 
                ftpstream = response.GetResponseStream();
                StreamReader reader = new StreamReader(ftpstream);
                string names = reader.ReadToEnd(); 

                reader.Close();
                response.Close();
                request = null; 

                return names.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            catch (Exception)
            {
               throw; 
            }
        }
        private void btnconnect_Click(object sender, EventArgs e)
        {
            List<string> listFile = ListFiles(); 
            for( int i= 0; i< listFile.Count; i++ )
            {
                listView1.Items.Add(listFile[i]); 
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            Download(); 
        }


        private void Download()
        {
            try
            {
                string str = listView1.SelectedItems[0].Text;
                request = (FtpWebRequest)WebRequest.Create(txtIPFTPserver.Text + "/" + str);
                request.Credentials = new NetworkCredential(txtuser.Text, txtpassword.Text);
               // MessageBox.Show("B1");
                request.UseBinary = true;
                request.UsePassive = true;
                request.KeepAlive = true;
                request.Method = WebRequestMethods.Ftp.DownloadFile;
               // MessageBox.Show("B2");
                response = (FtpWebResponse)request.GetResponse();
                ftpstream = response.GetResponseStream();
               // MessageBox.Show("B3");
                saveFileDialog1.FileName = str;
                DialogResult result = saveFileDialog1.ShowDialog();
                byte[] bytebuffer = new byte[lenght];
                int byteRead = ftpstream.Read(bytebuffer, 0, lenght); 
                if( result == DialogResult.OK)
                {
                    FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);

                    try
                    {
                        while (byteRead > 0 )
                        {
                            fs.Write(bytebuffer, 0, byteRead);
                            byteRead = ftpstream.Read(bytebuffer, 0, lenght); 

                        }
                        MessageBox.Show("Dowload file successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fs.Close(); 
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                ftpstream.Close();
                response.Close();
                request = null;
            }
            catch
            {
                MessageBox.Show("Select a file before downloading!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void btnupload_Click(object sender, EventArgs e)
        {

                lblwrong.Text = "";

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Text Files (*.txt)|*.txt";
                DialogResult result = openFileDialog.ShowDialog();

                string filePath = openFileDialog.FileName;

                FileInfo fi = new FileInfo(filePath); 
                request = (FtpWebRequest)WebRequest.Create(txtIPFTPserver.Text + "/"+ fi.Name);

                request.Method = WebRequestMethods.Ftp.UploadFile; 
                request.Credentials = new NetworkCredential(txtuser.Text, txtpassword.Text); 

                ftpstream = request.GetRequestStream();
                FileStream file = File.OpenRead(filePath); 
                byte[] buffer = new byte[lenght];

                int byteRead = 0;

                do
                {
                    byteRead = file.Read(buffer, 0, lenght); 
                    ftpstream.Write(buffer, 0, byteRead); 
                } while (byteRead != 0);
                
                file.Close(); 
                ftpstream.Close();
                request = null;
                MessageBox.Show("Upload Successfull!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        private void btnDowload_Click(object sender, EventArgs e)
        {
            Download();
        }

        private void btnPickfile_Click(object sender, EventArgs e)
        {

        }
    }
}
