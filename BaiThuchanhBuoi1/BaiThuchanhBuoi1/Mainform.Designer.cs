namespace BaiThuchanhBuoi1
{
    partial class Mainform
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
            this.tbTen = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSaoChep = new System.Windows.Forms.TextBox();
            this.btnSaoChep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nhap ten cua ban: ";
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(105, 6);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(171, 20);
            this.tbTen.TabIndex = 0;
            this.tbTen.TextChanged += new System.EventHandler(this.tbTen_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(353, 230);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Xu Ly";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ban da nhap: ";
            // 
            // tbSaoChep
            // 
            this.tbSaoChep.Location = new System.Drawing.Point(105, 58);
            this.tbSaoChep.Name = "tbSaoChep";
            this.tbSaoChep.ReadOnly = true;
            this.tbSaoChep.Size = new System.Drawing.Size(171, 20);
            this.tbSaoChep.TabIndex = 3;
            this.tbSaoChep.TextChanged += new System.EventHandler(this.tbSaoChep_TextChanged);
            // 
            // btnSaoChep
            // 
            this.btnSaoChep.Location = new System.Drawing.Point(353, 55);
            this.btnSaoChep.Name = "btnSaoChep";
            this.btnSaoChep.Size = new System.Drawing.Size(75, 23);
            this.btnSaoChep.TabIndex = 1;
            this.btnSaoChep.Text = "Copy";
            this.btnSaoChep.UseVisualStyleBackColor = true;
            this.btnSaoChep.Click += new System.EventHandler(this.tbSaoChep_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 265);
            this.Controls.Add(this.tbSaoChep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaoChep);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.label1);
            this.Name = "Mainform";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSaoChep;
        private System.Windows.Forms.Button btnSaoChep;
    }
}

