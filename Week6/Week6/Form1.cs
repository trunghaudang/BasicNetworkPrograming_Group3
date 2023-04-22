using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Week6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private async void btnCall_Click(object sender, EventArgs e)
        {
            if (txtUrl.Text != "")
            {
                using (var client = new HttpClient())
                {
                    var response = await Task.Run(() => client.GetAsync(txtUrl.Text));
                    // Testing API: https://jsonplaceholder.typicode.com/todos
                    // Try with another API: http://webcode.me/users.json

                    if (response.IsSuccessStatusCode)
                    {
                        // handle successful response
                        var responseBody = await Task.Run(() => response.Content.ReadAsStringAsync());
                        rtbShow.Text = responseBody;
                    }
                    else
                    {
                        // handle error response                    
                        if (response.StatusCode == HttpStatusCode.NotFound)
                        {
                            // handle 404 Not Found error
                            rtbShow.Text = "404 Not Found";
                        }
                        else if (response.StatusCode == HttpStatusCode.Unauthorized)
                        {
                            // handle 401 Unauthorized error
                            rtbShow.Text = "401 Unauthorized";
                        }
                        else
                        {
                            // handle other error
                            var responseBody = await response.Content.ReadAsStringAsync();
                            rtbShow.Text = $"Error: {response.StatusCode}\n{responseBody}";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("The URL is invalid, API cannot be called! Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to exit?", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}