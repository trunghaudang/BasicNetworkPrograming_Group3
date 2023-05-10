namespace Lab3
{
    partial class UDPServer
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
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnListen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lvReceiveMessage = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(92, 29);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(195, 27);
            this.txtPort.TabIndex = 1;
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(670, 23);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(94, 29);
            this.btnListen.TabIndex = 2;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Received messages";
            // 
            // lvReceiveMessage
            // 
            this.lvReceiveMessage.Location = new System.Drawing.Point(42, 93);
            this.lvReceiveMessage.Name = "lvReceiveMessage";
            this.lvReceiveMessage.Size = new System.Drawing.Size(722, 320);
            this.lvReceiveMessage.TabIndex = 4;
            this.lvReceiveMessage.UseCompatibleStateImageBehavior = false;
            this.lvReceiveMessage.View = System.Windows.Forms.View.List;
            // 
            // UDPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvReceiveMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label1);
            this.Name = "UDPServer";
            this.Text = "UDPServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtPort;
        private Button btnListen;
        private Label label2;
        private ListView lvReceiveMessage;
    }
}