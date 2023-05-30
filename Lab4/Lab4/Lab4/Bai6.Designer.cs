namespace Lab4
{
    partial class Bai6
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
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewWeb = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(53, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(635, 27);
            this.txtURL.TabIndex = 0;
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.Color.LightCyan;
            this.btnGet.Location = new System.Drawing.Point(694, 10);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(94, 29);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = false;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 45);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 29);
            this.progressBar1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL";
            // 
            // listViewWeb
            // 
            this.listViewWeb.Location = new System.Drawing.Point(12, 80);
            this.listViewWeb.Name = "listViewWeb";
            this.listViewWeb.Size = new System.Drawing.Size(776, 414);
            this.listViewWeb.TabIndex = 5;
            this.listViewWeb.UseCompatibleStateImageBehavior = false;
            this.listViewWeb.View = System.Windows.Forms.View.List;
            this.listViewWeb.DoubleClick += new System.EventHandler(this.listViewWeb_DoubleClick_1);
            // 
            // Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.listViewWeb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtURL);
            this.Name = "Bai6";
            this.Text = "Bai6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtURL;
        private Button btnGet;
        private ProgressBar progressBar1;
        private Label label1;
        private ListView listViewWeb;
    }
}