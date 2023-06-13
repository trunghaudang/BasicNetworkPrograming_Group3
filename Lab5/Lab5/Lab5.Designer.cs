namespace Lab5
{
    partial class Lab5
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnBai1 = new Button();
            btnBai2 = new Button();
            btnBai3 = new Button();
            btnBai4 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(145, 29);
            label1.Name = "label1";
            label1.Size = new Size(467, 38);
            label1.TabIndex = 0;
            label1.Text = "Lab 5 - Gửi và Nhận Mail trong C#";
            // 
            // btnBai1
            // 
            btnBai1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBai1.ForeColor = SystemColors.MenuHighlight;
            btnBai1.Location = new Point(155, 95);
            btnBai1.Name = "btnBai1";
            btnBai1.Size = new Size(106, 53);
            btnBai1.TabIndex = 1;
            btnBai1.Text = "Bài 1";
            btnBai1.UseVisualStyleBackColor = true;
            btnBai1.Click += btnBai1_Click;
            // 
            // btnBai2
            // 
            btnBai2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBai2.ForeColor = SystemColors.MenuHighlight;
            btnBai2.Location = new Point(155, 179);
            btnBai2.Name = "btnBai2";
            btnBai2.Size = new Size(106, 53);
            btnBai2.TabIndex = 2;
            btnBai2.Text = "Bài 2";
            btnBai2.UseVisualStyleBackColor = true;
            btnBai2.Click += btnBai2_Click;
            // 
            // btnBai3
            // 
            btnBai3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBai3.ForeColor = SystemColors.MenuHighlight;
            btnBai3.Location = new Point(155, 265);
            btnBai3.Name = "btnBai3";
            btnBai3.Size = new Size(106, 53);
            btnBai3.TabIndex = 3;
            btnBai3.Text = "Bài 3";
            btnBai3.UseVisualStyleBackColor = true;
            btnBai3.Click += btnBai3_Click;
            // 
            // btnBai4
            // 
            btnBai4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBai4.ForeColor = SystemColors.MenuHighlight;
            btnBai4.Location = new Point(155, 351);
            btnBai4.Name = "btnBai4";
            btnBai4.Size = new Size(106, 53);
            btnBai4.TabIndex = 4;
            btnBai4.Text = "Bài 4";
            btnBai4.UseVisualStyleBackColor = true;
            btnBai4.Click += btnBai4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(277, 107);
            label2.Name = "label2";
            label2.Size = new Size(315, 28);
            label2.TabIndex = 5;
            label2.Text = "Viết ứng dụng cho phép gửi mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(277, 191);
            label3.Name = "label3";
            label3.Size = new Size(388, 28);
            label3.TabIndex = 6;
            label3.Text = "Viết ứng dụng cho phép đọc mail (IMAP)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(277, 277);
            label4.Name = "label4";
            label4.Size = new Size(378, 28);
            label4.TabIndex = 7;
            label4.Text = "Viết ứng dụng cho phép đọc mail (POP)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(277, 363);
            label5.Name = "label5";
            label5.Size = new Size(256, 28);
            label5.TabIndex = 8;
            label5.Text = "Viết ứng dụng Email Client";
            // 
            // Lab5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 451);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnBai4);
            Controls.Add(btnBai3);
            Controls.Add(btnBai2);
            Controls.Add(btnBai1);
            Controls.Add(label1);
            Name = "Lab5";
            Text = "Lab5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBai1;
        private Button btnBai2;
        private Button btnBai3;
        private Button btnBai4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}