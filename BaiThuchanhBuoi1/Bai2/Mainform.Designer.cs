namespace Bai2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdDo = new System.Windows.Forms.RadioButton();
            this.rdXanh = new System.Windows.Forms.RadioButton();
            this.btnToMau = new System.Windows.Forms.Button();
            this.tbHopMau = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdNam);
            this.groupBox1.Controls.Add(this.rdNu);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chon Gioi Tinh";
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.BackColor = System.Drawing.Color.Transparent;
            this.rdNu.Location = new System.Drawing.Point(6, 42);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 1;
            this.rdNu.Text = "Nu";
            this.rdNu.UseVisualStyleBackColor = false;
            this.rdNu.CheckedChanged += new System.EventHandler(this.rdNu_CheckedChanged);
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(6, 19);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 1;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            this.rdNam.CheckedChanged += new System.EventHandler(this.rdNam_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnToMau);
            this.groupBox2.Controls.Add(this.rdDo);
            this.groupBox2.Controls.Add(this.rdXanh);
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chon Mau";
            // 
            // rdDo
            // 
            this.rdDo.AutoSize = true;
            this.rdDo.Checked = true;
            this.rdDo.Location = new System.Drawing.Point(6, 19);
            this.rdDo.Name = "rdDo";
            this.rdDo.Size = new System.Drawing.Size(63, 17);
            this.rdDo.TabIndex = 1;
            this.rdDo.TabStop = true;
            this.rdDo.Text = "Mau Do";
            this.rdDo.UseVisualStyleBackColor = true;
            this.rdDo.CheckedChanged += new System.EventHandler(this.rdNam_CheckedChanged);
            // 
            // rdXanh
            // 
            this.rdXanh.AutoSize = true;
            this.rdXanh.BackColor = System.Drawing.Color.Transparent;
            this.rdXanh.Location = new System.Drawing.Point(6, 42);
            this.rdXanh.Name = "rdXanh";
            this.rdXanh.Size = new System.Drawing.Size(74, 17);
            this.rdXanh.TabIndex = 1;
            this.rdXanh.Text = "Mau Xanh";
            this.rdXanh.UseVisualStyleBackColor = false;
            this.rdXanh.CheckedChanged += new System.EventHandler(this.rdNu_CheckedChanged);
            // 
            // btnToMau
            // 
            this.btnToMau.Location = new System.Drawing.Point(119, 71);
            this.btnToMau.Name = "btnToMau";
            this.btnToMau.Size = new System.Drawing.Size(75, 23);
            this.btnToMau.TabIndex = 1;
            this.btnToMau.Text = "To Mau";
            this.btnToMau.UseVisualStyleBackColor = true;
            this.btnToMau.Click += new System.EventHandler(this.btnToMau_Click);
            // 
            // tbHopMau
            // 
            this.tbHopMau.Location = new System.Drawing.Point(266, 130);
            this.tbHopMau.Multiline = true;
            this.tbHopMau.Name = "tbHopMau";
            this.tbHopMau.Size = new System.Drawing.Size(100, 94);
            this.tbHopMau.TabIndex = 1;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.tbHopMau);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Mainform";
            this.Text = "bai2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnToMau;
        private System.Windows.Forms.RadioButton rdDo;
        private System.Windows.Forms.RadioButton rdXanh;
        private System.Windows.Forms.TextBox tbHopMau;
    }
}

