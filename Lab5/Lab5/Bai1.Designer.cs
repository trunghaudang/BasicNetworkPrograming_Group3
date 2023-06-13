namespace Lab5
{
    partial class Bai1
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
            label4 = new Label();
            txtFrom = new TextBox();
            txtTo = new TextBox();
            rtbBody = new RichTextBox();
            txtSubject = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 1;
            label2.Text = "To:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 125);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Subject:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 156);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 3;
            label4.Text = "Body:";
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(73, 11);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(259, 23);
            txtFrom.TabIndex = 4;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(73, 54);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(259, 23);
            txtTo.TabIndex = 5;
            // 
            // rtbBody
            // 
            rtbBody.Location = new Point(73, 156);
            rtbBody.Name = "rtbBody";
            rtbBody.Size = new Size(512, 247);
            rtbBody.TabIndex = 6;
            rtbBody.Text = "";
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(73, 122);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(512, 23);
            txtSubject.TabIndex = 7;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.LightCyan;
            btnSend.ForeColor = SystemColors.ControlText;
            btnSend.Location = new Point(434, 14);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(151, 63);
            btnSend.TabIndex = 8;
            btnSend.Text = "SEND";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 420);
            Controls.Add(btnSend);
            Controls.Add(txtSubject);
            Controls.Add(rtbBody);
            Controls.Add(txtTo);
            Controls.Add(txtFrom);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai1";
            Text = "Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtFrom;
        private TextBox txtTo;
        private RichTextBox rtbBody;
        private TextBox txtSubject;
        private Button btnSend;
    }
}