namespace Lab5
{
    partial class ReadMail
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
            btnReply = new Button();
            txtSub = new TextBox();
            txtDate = new TextBox();
            txtFrom = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            rtbBody = new RichTextBox();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // btnReply
            // 
            btnReply.BackColor = Color.LightSteelBlue;
            btnReply.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnReply.Location = new Point(615, 594);
            btnReply.Margin = new Padding(2);
            btnReply.Name = "btnReply";
            btnReply.Size = new Size(110, 36);
            btnReply.TabIndex = 18;
            btnReply.Text = "REPLY";
            btnReply.UseVisualStyleBackColor = false;
            btnReply.Click += btnReply_Click;
            // 
            // txtSub
            // 
            txtSub.Location = new Point(69, 55);
            txtSub.Margin = new Padding(2);
            txtSub.Name = "txtSub";
            txtSub.ReadOnly = true;
            txtSub.Size = new Size(659, 27);
            txtSub.TabIndex = 16;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(502, 6);
            txtDate.Margin = new Padding(2);
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = true;
            txtDate.Size = new Size(226, 27);
            txtDate.TabIndex = 15;
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(56, 6);
            txtFrom.Margin = new Padding(2);
            txtFrom.Name = "txtFrom";
            txtFrom.ReadOnly = true;
            txtFrom.Size = new Size(354, 27);
            txtFrom.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 99);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 13;
            label4.Text = "Content:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 58);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 12;
            label3.Text = "Subject:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(455, 8);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 11;
            label2.Text = "Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 10;
            label1.Text = "From:";
            // 
            // rtbBody
            // 
            rtbBody.Location = new Point(11, 99);
            rtbBody.Name = "rtbBody";
            rtbBody.Size = new Size(714, 490);
            rtbBody.TabIndex = 19;
            rtbBody.Text = "";
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(12, 99);
            webView21.Name = "webView21";
            webView21.Size = new Size(712, 489);
            webView21.TabIndex = 20;
            webView21.ZoomFactor = 1D;
            // 
            // ReadMail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 638);
            Controls.Add(webView21);
            Controls.Add(rtbBody);
            Controls.Add(btnReply);
            Controls.Add(txtSub);
            Controls.Add(txtDate);
            Controls.Add(txtFrom);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReadMail";
            Text = "ReadMail";
            Load += ReadMail_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReply;
        private TextBox txtSub;
        private TextBox txtDate;
        private TextBox txtFrom;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RichTextBox rtbBody;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}