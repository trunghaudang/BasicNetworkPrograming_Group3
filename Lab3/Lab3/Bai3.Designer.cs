namespace Lab3
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
            this.btnServerB3 = new System.Windows.Forms.Button();
            this.btnClientB3 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnServerB3
            // 
            this.btnServerB3.Location = new System.Drawing.Point(118, 69);
            this.btnServerB3.Name = "btnServerB3";
            this.btnServerB3.Size = new System.Drawing.Size(94, 29);
            this.btnServerB3.TabIndex = 0;
            this.btnServerB3.Text = "TCP Server";
            this.btnServerB3.UseVisualStyleBackColor = true;
            this.btnServerB3.Click += new System.EventHandler(this.btnServerB3_Click);
            // 
            // btnClientB3
            // 
            this.btnClientB3.Location = new System.Drawing.Point(352, 69);
            this.btnClientB3.Name = "btnClientB3";
            this.btnClientB3.Size = new System.Drawing.Size(94, 29);
            this.btnClientB3.TabIndex = 1;
            this.btnClientB3.Text = "TCP Client";
            this.btnClientB3.UseVisualStyleBackColor = true;
            this.btnClientB3.Click += new System.EventHandler(this.btnClientB3_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(597, 69);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 171);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClientB3);
            this.Controls.Add(this.btnServerB3);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnServerB3;
        private Button btnClientB3;
        private Button btnExit;
    }
}