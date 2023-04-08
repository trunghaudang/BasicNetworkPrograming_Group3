namespace TCPChat
{
    partial class TCPChat
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenClient = new System.Windows.Forms.Button();
            this.btnOpenServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenClient
            // 
            this.btnOpenClient.Location = new System.Drawing.Point(110, 126);
            this.btnOpenClient.Name = "btnOpenClient";
            this.btnOpenClient.Size = new System.Drawing.Size(265, 125);
            this.btnOpenClient.TabIndex = 0;
            this.btnOpenClient.Text = "Open Client";
            this.btnOpenClient.UseVisualStyleBackColor = true;
            this.btnOpenClient.Click += new System.EventHandler(this.btnOpenClient_Click);
            // 
            // btnOpenServer
            // 
            this.btnOpenServer.Location = new System.Drawing.Point(440, 126);
            this.btnOpenServer.Name = "btnOpenServer";
            this.btnOpenServer.Size = new System.Drawing.Size(265, 125);
            this.btnOpenServer.TabIndex = 1;
            this.btnOpenServer.Text = "Open Server";
            this.btnOpenServer.UseVisualStyleBackColor = true;
            this.btnOpenServer.Click += new System.EventHandler(this.btnOpenServer_Click);
            // 
            // TCPChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenServer);
            this.Controls.Add(this.btnOpenClient);
            this.Name = "TCPChat";
            this.Text = "TCP Chat";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnOpenClient;
        private Button btnOpenServer;
    }
}