namespace LAB6
{
    partial class Form1
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
            this.txtIPFTPserver = new System.Windows.Forms.TextBox();
            this.btnconnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnupload = new System.Windows.Forms.Button();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnDowload = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblwrong = new System.Windows.Forms.Label();
            this.btnPickfile = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP FTP Server";
            // 
            // txtIPFTPserver
            // 
            this.txtIPFTPserver.Location = new System.Drawing.Point(226, 88);
            this.txtIPFTPserver.Name = "txtIPFTPserver";
            this.txtIPFTPserver.Size = new System.Drawing.Size(236, 22);
            this.txtIPFTPserver.TabIndex = 1;
            this.txtIPFTPserver.Text = "ftp://127.0.0.1";
            // 
            // btnconnect
            // 
            this.btnconnect.BackColor = System.Drawing.Color.LightCyan;
            this.btnconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconnect.Location = new System.Drawing.Point(496, 140);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(145, 46);
            this.btnconnect.TabIndex = 2;
            this.btnconnect.Text = "Connect";
            this.btnconnect.UseVisualStyleBackColor = false;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // btnupload
            // 
            this.btnupload.BackColor = System.Drawing.Color.LightCyan;
            this.btnupload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupload.Location = new System.Drawing.Point(559, 250);
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(165, 83);
            this.btnupload.TabIndex = 5;
            this.btnupload.Text = "Upload";
            this.btnupload.UseVisualStyleBackColor = false;
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(226, 123);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(236, 22);
            this.txtuser.TabIndex = 6;
            this.txtuser.Text = "user";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(226, 164);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(236, 22);
            this.txtpassword.TabIndex = 7;
            this.txtpassword.Text = "k123";
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // btnDowload
            // 
            this.btnDowload.BackColor = System.Drawing.Color.LightCyan;
            this.btnDowload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDowload.Location = new System.Drawing.Point(559, 352);
            this.btnDowload.Name = "btnDowload";
            this.btnDowload.Size = new System.Drawing.Size(165, 86);
            this.btnDowload.TabIndex = 8;
            this.btnDowload.Text = "Download";
            this.btnDowload.UseVisualStyleBackColor = false;
            this.btnDowload.Click += new System.EventHandler(this.btnDowload_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Remote Site";
            // 
            // lblwrong
            // 
            this.lblwrong.AutoSize = true;
            this.lblwrong.Location = new System.Drawing.Point(503, 221);
            this.lblwrong.Name = "lblwrong";
            this.lblwrong.Size = new System.Drawing.Size(37, 16);
            this.lblwrong.TabIndex = 13;
            this.lblwrong.Text = "label";
            // 
            // btnPickfile
            // 
            this.btnPickfile.Location = new System.Drawing.Point(496, 88);
            this.btnPickfile.Name = "btnPickfile";
            this.btnPickfile.Size = new System.Drawing.Size(145, 46);
            this.btnPickfile.TabIndex = 14;
            this.btnPickfile.Text = ": :";
            this.btnPickfile.UseVisualStyleBackColor = true;
            this.btnPickfile.Click += new System.EventHandler(this.btnPickfile_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 250);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(513, 188);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(229, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ứng dụng FTP client";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPickfile);
            this.Controls.Add(this.lblwrong);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDowload);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.btnupload);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnconnect);
            this.Controls.Add(this.txtIPFTPserver);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIPFTPserver;
        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnupload;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnDowload;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblwrong;
        private System.Windows.Forms.Button btnPickfile;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
    }
}

