namespace Lab3
{
    partial class Bai4
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
            this.btnServerB4 = new System.Windows.Forms.Button();
            this.btnClientB4 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnServerB4
            // 
            this.btnServerB4.Location = new System.Drawing.Point(132, 74);
            this.btnServerB4.Name = "btnServerB4";
            this.btnServerB4.Size = new System.Drawing.Size(94, 29);
            this.btnServerB4.TabIndex = 0;
            this.btnServerB4.Text = "Server";
            this.btnServerB4.UseVisualStyleBackColor = true;
            this.btnServerB4.Click += new System.EventHandler(this.btnServerB4_Click);
            // 
            // btnClientB4
            // 
            this.btnClientB4.Location = new System.Drawing.Point(353, 74);
            this.btnClientB4.Name = "btnClientB4";
            this.btnClientB4.Size = new System.Drawing.Size(94, 29);
            this.btnClientB4.TabIndex = 1;
            this.btnClientB4.Text = "Client";
            this.btnClientB4.UseVisualStyleBackColor = true;
            this.btnClientB4.Click += new System.EventHandler(this.btnClientB4_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(568, 74);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 178);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClientB4);
            this.Controls.Add(this.btnServerB4);
            this.Name = "Bai4";
            this.Text = "Bai4";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnServerB4;
        private Button btnClientB4;
        private Button btnExit;
    }
}