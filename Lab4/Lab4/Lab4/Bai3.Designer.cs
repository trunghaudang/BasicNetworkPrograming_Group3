namespace Lab4
{
    partial class Bai3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnShowWebsite = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnShowSource = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(53, 10);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(846, 27);
            this.txtURL.TabIndex = 1;
            // 
            // btnShowWebsite
            // 
            this.btnShowWebsite.BackColor = System.Drawing.Color.LightCyan;
            this.btnShowWebsite.Location = new System.Drawing.Point(905, 10);
            this.btnShowWebsite.Name = "btnShowWebsite";
            this.btnShowWebsite.Size = new System.Drawing.Size(116, 29);
            this.btnShowWebsite.TabIndex = 3;
            this.btnShowWebsite.Text = "Show Website";
            this.btnShowWebsite.UseVisualStyleBackColor = false;
            this.btnShowWebsite.Click += new System.EventHandler(this.btnShowWebsite_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.LightCyan;
            this.btnDownload.Location = new System.Drawing.Point(905, 45);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(116, 29);
            this.btnDownload.TabIndex = 6;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnShowSource
            // 
            this.btnShowSource.BackColor = System.Drawing.Color.LightCyan;
            this.btnShowSource.Location = new System.Drawing.Point(1027, 9);
            this.btnShowSource.Name = "btnShowSource";
            this.btnShowSource.Size = new System.Drawing.Size(116, 65);
            this.btnShowSource.TabIndex = 7;
            this.btnShowSource.Text = "Show Source";
            this.btnShowSource.UseVisualStyleBackColor = false;
            this.btnShowSource.Click += new System.EventHandler(this.btnShowSource_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Path";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(53, 47);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(846, 27);
            this.txtPath.TabIndex = 9;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(12, 80);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1131, 600);
            this.webView21.TabIndex = 10;
            this.webView21.ZoomFactor = 1D;
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 692);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShowSource);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnShowWebsite);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label1);
            this.Name = "Bai3";
            this.Text = "Bai3";
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtURL;
        private Button btnShowWebsite;
        private Button btnDownload;
        private Button btnShowSource;
        private Label label2;
        private TextBox txtPath;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}