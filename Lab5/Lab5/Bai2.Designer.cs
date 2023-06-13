namespace Lab5
{
    partial class Bai2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            label4 = new Label();
            label5 = new Label();
            listViewMail = new ListView();
            Subject = new ColumnHeader();
            From = new ColumnHeader();
            Date = new ColumnHeader();
            lbTotal = new Label();
            lbRecent = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 78);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(222, 9);
            label3.Name = "label3";
            label3.Size = new Size(218, 21);
            label3.TabIndex = 2;
            label3.Text = "ỨNG DỤNG ĐỌC MAIL IMAP";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(87, 45);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(400, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(87, 75);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(400, 23);
            txtPass.TabIndex = 4;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightCyan;
            btnLogin.Location = new Point(514, 48);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(139, 50);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 125);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 6;
            label4.Text = "Total:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(222, 125);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 7;
            label5.Text = "Recent:";
            // 
            // listViewMail
            // 
            listViewMail.Columns.AddRange(new ColumnHeader[] { Subject, From, Date });
            listViewMail.Location = new Point(12, 143);
            listViewMail.Name = "listViewMail";
            listViewMail.Size = new Size(641, 262);
            listViewMail.TabIndex = 8;
            listViewMail.UseCompatibleStateImageBehavior = false;
            listViewMail.View = View.Details;
            // 
            // Subject
            // 
            Subject.Text = "Email";
            Subject.Width = 290;
            // 
            // From
            // 
            From.Text = "From";
            From.Width = 200;
            // 
            // Date
            // 
            Date.Text = "Thời gian";
            Date.Width = 140;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(57, 125);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(13, 15);
            lbTotal.TabIndex = 9;
            lbTotal.Text = "0";
            // 
            // lbRecent
            // 
            lbRecent.AutoSize = true;
            lbRecent.Location = new Point(274, 125);
            lbRecent.Name = "lbRecent";
            lbRecent.Size = new Size(13, 15);
            lbRecent.TabIndex = 10;
            lbRecent.Text = "0";
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 417);
            Controls.Add(lbRecent);
            Controls.Add(lbTotal);
            Controls.Add(listViewMail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai2";
            Text = "Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtPass;
        private Button btnLogin;
        private Label label4;
        private Label label5;
        private ListView listViewMail;
        private Label lbTotal;
        private Label lbRecent;
        private ColumnHeader Subject;
        private ColumnHeader From;
        private ColumnHeader Date;
    }
}