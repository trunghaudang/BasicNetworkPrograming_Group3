namespace Lab5
{
    partial class SendMail
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
            checkHtml = new CheckBox();
            btnAttach = new Button();
            tbAttach = new TextBox();
            label5 = new Label();
            txtFrom = new TextBox();
            label1 = new Label();
            btnSend = new Button();
            txtSub = new TextBox();
            txtTo = new TextBox();
            rtbBody = new RichTextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // checkHtml
            // 
            checkHtml.AutoSize = true;
            checkHtml.Location = new Point(75, 93);
            checkHtml.Margin = new Padding(2);
            checkHtml.Name = "checkHtml";
            checkHtml.Size = new Size(70, 24);
            checkHtml.TabIndex = 34;
            checkHtml.Text = "HTML";
            checkHtml.UseVisualStyleBackColor = true;
            // 
            // btnAttach
            // 
            btnAttach.Location = new Point(673, 633);
            btnAttach.Margin = new Padding(2);
            btnAttach.Name = "btnAttach";
            btnAttach.Size = new Size(103, 27);
            btnAttach.TabIndex = 33;
            btnAttach.Text = "Browse...";
            btnAttach.UseVisualStyleBackColor = true;
            btnAttach.Click += btnAttach_Click;
            // 
            // tbAttach
            // 
            tbAttach.Location = new Point(101, 633);
            tbAttach.Margin = new Padding(2);
            tbAttach.Name = "tbAttach";
            tbAttach.Size = new Size(565, 27);
            tbAttach.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 636);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 31;
            label5.Text = "Attachment:";
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(66, 7);
            txtFrom.Margin = new Padding(2);
            txtFrom.Name = "txtFrom";
            txtFrom.ReadOnly = true;
            txtFrom.Size = new Size(330, 27);
            txtFrom.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 29;
            label1.Text = "From:";
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.LightSteelBlue;
            btnSend.Location = new Point(656, 667);
            btnSend.Margin = new Padding(2);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(120, 40);
            btnSend.TabIndex = 28;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // txtSub
            // 
            txtSub.Location = new Point(66, 51);
            txtSub.Margin = new Padding(2);
            txtSub.Name = "txtSub";
            txtSub.Size = new Size(710, 27);
            txtSub.TabIndex = 27;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(448, 7);
            txtTo.Margin = new Padding(2);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(328, 27);
            txtTo.TabIndex = 26;
            // 
            // rtbBody
            // 
            rtbBody.Location = new Point(16, 117);
            rtbBody.Margin = new Padding(2);
            rtbBody.Name = "rtbBody";
            rtbBody.Size = new Size(760, 502);
            rtbBody.TabIndex = 25;
            rtbBody.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 94);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 24;
            label4.Text = "Body:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 53);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 23;
            label3.Text = "Subject:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(423, 9);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 22;
            label2.Text = "To:";
            // 
            // SendMail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 718);
            Controls.Add(checkHtml);
            Controls.Add(btnAttach);
            Controls.Add(tbAttach);
            Controls.Add(label5);
            Controls.Add(txtFrom);
            Controls.Add(label1);
            Controls.Add(btnSend);
            Controls.Add(txtSub);
            Controls.Add(txtTo);
            Controls.Add(rtbBody);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "SendMail";
            Text = "SendMail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkHtml;
        private Button btnAttach;
        private TextBox tbAttach;
        private Label label5;
        private TextBox txtFrom;
        private Label label1;
        private Button btnSend;
        private TextBox txtSub;
        private TextBox txtTo;
        private RichTextBox rtbBody;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}