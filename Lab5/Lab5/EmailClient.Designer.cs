namespace Lab5
{
    partial class EmailClient
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
            lvEmail = new ListView();
            Num = new ColumnHeader();
            Subject = new ColumnHeader();
            From = new ColumnHeader();
            time = new ColumnHeader();
            panel2 = new Panel();
            txtPortS = new TextBox();
            txtPortI = new TextBox();
            txtSMTP = new TextBox();
            txtIMAP = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            btnLogOut = new Button();
            btnSend = new Button();
            btnRefresh = new Button();
            lbRecent = new Label();
            lbTotal = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lvEmail
            // 
            lvEmail.Columns.AddRange(new ColumnHeader[] { Num, Subject, From, time });
            lvEmail.Location = new Point(11, 157);
            lvEmail.Margin = new Padding(2);
            lvEmail.Name = "lvEmail";
            lvEmail.Size = new Size(904, 522);
            lvEmail.TabIndex = 28;
            lvEmail.UseCompatibleStateImageBehavior = false;
            lvEmail.View = View.Details;
            lvEmail.SelectedIndexChanged += lvEmail_SelectedIndexChanged;
            // 
            // Num
            // 
            Num.Text = "#";
            Num.Width = 42;
            // 
            // Subject
            // 
            Subject.Text = "Email";
            Subject.Width = 490;
            // 
            // From
            // 
            From.Text = "From";
            From.Width = 280;
            // 
            // time
            // 
            time.Text = "Date-Time";
            time.Width = 240;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtPortS);
            panel2.Controls.Add(txtPortI);
            panel2.Controls.Add(txtSMTP);
            panel2.Controls.Add(txtIMAP);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(451, 11);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(464, 108);
            panel2.TabIndex = 27;
            // 
            // txtPortS
            // 
            txtPortS.Location = new Point(376, 70);
            txtPortS.Margin = new Padding(2);
            txtPortS.Name = "txtPortS";
            txtPortS.ReadOnly = true;
            txtPortS.Size = new Size(79, 27);
            txtPortS.TabIndex = 30;
            // 
            // txtPortI
            // 
            txtPortI.Location = new Point(376, 22);
            txtPortI.Margin = new Padding(2);
            txtPortI.Name = "txtPortI";
            txtPortI.ReadOnly = true;
            txtPortI.Size = new Size(77, 27);
            txtPortI.TabIndex = 29;
            // 
            // txtSMTP
            // 
            txtSMTP.Location = new Point(55, 70);
            txtSMTP.Margin = new Padding(2);
            txtSMTP.Name = "txtSMTP";
            txtSMTP.ReadOnly = true;
            txtSMTP.Size = new Size(270, 27);
            txtSMTP.TabIndex = 28;
            // 
            // txtIMAP
            // 
            txtIMAP.Location = new Point(55, 24);
            txtIMAP.Margin = new Padding(2);
            txtIMAP.Name = "txtIMAP";
            txtIMAP.ReadOnly = true;
            txtIMAP.Size = new Size(270, 27);
            txtIMAP.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(338, 73);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(38, 20);
            label7.TabIndex = 26;
            label7.Text = "Port:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(338, 27);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 25;
            label6.Text = "Port:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 71);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 24;
            label5.Text = "SMTP:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 26);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 23;
            label4.Text = "IMAP:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, -6);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 23;
            label3.Text = "Setting";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(btnSend);
            panel1.Controls.Add(btnRefresh);
            panel1.Location = new Point(11, 11);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 108);
            panel1.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, -6);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 22;
            label2.Text = "Account";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(51, 22);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(375, 27);
            txtEmail.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 10;
            label1.Text = "User:";
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.LightSteelBlue;
            btnLogOut.Location = new Point(318, 66);
            btnLogOut.Margin = new Padding(2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(90, 27);
            btnLogOut.TabIndex = 19;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.LightSteelBlue;
            btnSend.Location = new Point(25, 66);
            btnSend.Margin = new Padding(2);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(90, 27);
            btnSend.TabIndex = 17;
            btnSend.Text = "Send Mail";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightSteelBlue;
            btnRefresh.Location = new Point(170, 66);
            btnRefresh.Margin = new Padding(2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 27);
            btnRefresh.TabIndex = 18;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lbRecent
            // 
            lbRecent.AutoSize = true;
            lbRecent.Location = new Point(307, 134);
            lbRecent.Margin = new Padding(2, 0, 2, 0);
            lbRecent.Name = "lbRecent";
            lbRecent.Size = new Size(57, 20);
            lbRecent.TabIndex = 25;
            lbRecent.Text = "Recent:";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(13, 134);
            lbTotal.Margin = new Padding(2, 0, 2, 0);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(45, 20);
            lbTotal.TabIndex = 24;
            lbTotal.Text = "Total:";
            // 
            // EmailClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 690);
            Controls.Add(lvEmail);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lbRecent);
            Controls.Add(lbTotal);
            Name = "EmailClient";
            Text = "EmailClient";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvEmail;
        private ColumnHeader Num;
        private ColumnHeader Subject;
        private ColumnHeader From;
        private ColumnHeader time;
        private Panel panel2;
        private TextBox txtPortS;
        private TextBox txtPortI;
        private TextBox txtSMTP;
        private TextBox txtIMAP;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private Label label2;
        private TextBox txtEmail;
        private Label label1;
        private Button btnLogOut;
        private Button btnSend;
        private Button btnRefresh;
        private Label lbRecent;
        private Label lbTotal;
    }
}