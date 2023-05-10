namespace Lab3
{
    partial class Client
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.lvMessage = new System.Windows.Forms.ListView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbParticipants = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Azure;
            this.btnConnect.Location = new System.Drawing.Point(532, 341);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(197, 29);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lvMessage
            // 
            this.lvMessage.Location = new System.Drawing.Point(28, 27);
            this.lvMessage.Name = "lvMessage";
            this.lvMessage.Size = new System.Drawing.Size(701, 308);
            this.lvMessage.TabIndex = 1;
            this.lvMessage.UseCompatibleStateImageBehavior = false;
            this.lvMessage.View = System.Windows.Forms.View.List;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(113, 341);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(413, 27);
            this.txtName.TabIndex = 2;
            // 
            // txtMess
            // 
            this.txtMess.Location = new System.Drawing.Point(113, 376);
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(413, 27);
            this.txtMess.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Message";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Azure;
            this.btnSend.Location = new System.Drawing.Point(532, 376);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(197, 29);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(748, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Participants";
            // 
            // lbParticipants
            // 
            this.lbParticipants.FormattingEnabled = true;
            this.lbParticipants.ItemHeight = 20;
            this.lbParticipants.Location = new System.Drawing.Point(748, 50);
            this.lbParticipants.Name = "lbParticipants";
            this.lbParticipants.Size = new System.Drawing.Size(150, 344);
            this.lbParticipants.TabIndex = 8;
            this.lbParticipants.Click += new System.EventHandler(this.lbParticipants_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 426);
            this.Controls.Add(this.lbParticipants);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMess);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lvMessage);
            this.Controls.Add(this.btnConnect);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnConnect;
        private ListView lvMessage;
        private TextBox txtName;
        private TextBox txtMess;
        private Label label1;
        private Label label2;
        private Button btnSend;
        private Label label3;
        private ListBox lbParticipants;
    }
}