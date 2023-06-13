namespace Lab5
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
            lbRecent = new Label();
            lbTotal = new Label();
            listViewMail = new ListView();
            Subject = new ColumnHeader();
            From = new ColumnHeader();
            Date = new ColumnHeader();
            label5 = new Label();
            label4 = new Label();
            btnLogin = new Button();
            txtPass = new TextBox();
            txtEmail = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbRecent
            // 
            lbRecent.AutoSize = true;
            lbRecent.Location = new Point(316, 173);
            lbRecent.Name = "lbRecent";
            lbRecent.Size = new Size(17, 20);
            lbRecent.TabIndex = 21;
            lbRecent.Text = "0";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(68, 173);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(17, 20);
            lbTotal.TabIndex = 20;
            lbTotal.Text = "0";
            // 
            // listViewMail
            // 
            listViewMail.Columns.AddRange(new ColumnHeader[] { Subject, From, Date });
            listViewMail.Location = new Point(17, 197);
            listViewMail.Margin = new Padding(3, 4, 3, 4);
            listViewMail.Name = "listViewMail";
            listViewMail.Size = new Size(732, 348);
            listViewMail.TabIndex = 19;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(257, 173);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 18;
            label5.Text = "Recent:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 173);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 17;
            label4.Text = "Total:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightCyan;
            btnLogin.Location = new Point(590, 70);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(159, 67);
            btnLogin.TabIndex = 16;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(102, 106);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(457, 27);
            txtPass.TabIndex = 15;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(102, 66);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(457, 27);
            txtEmail.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(257, 18);
            label3.Name = "label3";
            label3.Size = new Size(264, 28);
            label3.TabIndex = 13;
            label3.Text = "ỨNG DỤNG ĐỌC MAIL POP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 110);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 12;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 70);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 11;
            label1.Text = "Email:";
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 562);
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
            Name = "Bai3";
            Text = "Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbRecent;
        private Label lbTotal;
        private ListView listViewMail;
        private ColumnHeader Subject;
        private ColumnHeader From;
        private ColumnHeader Date;
        private Label label5;
        private Label label4;
        private Button btnLogin;
        private TextBox txtPass;
        private TextBox txtEmail;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}