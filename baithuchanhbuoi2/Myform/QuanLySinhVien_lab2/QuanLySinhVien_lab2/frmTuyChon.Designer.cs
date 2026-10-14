namespace QuanLySinhVien_lab2
{
    partial class frmTuyChon
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
			this.rdNgaySinh = new System.Windows.Forms.RadioButton();
			this.rdHoTen = new System.Windows.Forms.RadioButton();
			this.rdMa = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnTim = new System.Windows.Forms.Button();
			this.txtTim = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSapXep = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdNgaySinh);
			this.groupBox1.Controls.Add(this.rdHoTen);
			this.groupBox1.Controls.Add(this.rdMa);
			this.groupBox1.Location = new System.Drawing.Point(59, 15);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(516, 123);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// rdNgaySinh
			// 
			this.rdNgaySinh.AutoSize = true;
			this.rdNgaySinh.ForeColor = System.Drawing.SystemColors.Highlight;
			this.rdNgaySinh.Location = new System.Drawing.Point(355, 52);
			this.rdNgaySinh.Margin = new System.Windows.Forms.Padding(4);
			this.rdNgaySinh.Name = "rdNgaySinh";
			this.rdNgaySinh.Size = new System.Drawing.Size(90, 20);
			this.rdNgaySinh.TabIndex = 2;
			this.rdNgaySinh.TabStop = true;
			this.rdNgaySinh.Text = "Ngay Sinh";
			this.rdNgaySinh.UseVisualStyleBackColor = true;
			// 
			// rdHoTen
			// 
			this.rdHoTen.AutoSize = true;
			this.rdHoTen.ForeColor = System.Drawing.SystemColors.Highlight;
			this.rdHoTen.Location = new System.Drawing.Point(200, 52);
			this.rdHoTen.Margin = new System.Windows.Forms.Padding(4);
			this.rdHoTen.Name = "rdHoTen";
			this.rdHoTen.Size = new System.Drawing.Size(73, 20);
			this.rdHoTen.TabIndex = 1;
			this.rdHoTen.TabStop = true;
			this.rdHoTen.Text = "Ho Ten";
			this.rdHoTen.UseVisualStyleBackColor = true;
			// 
			// rdMa
			// 
			this.rdMa.AutoSize = true;
			this.rdMa.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.rdMa.Location = new System.Drawing.Point(36, 52);
			this.rdMa.Margin = new System.Windows.Forms.Padding(4);
			this.rdMa.Name = "rdMa";
			this.rdMa.Size = new System.Drawing.Size(68, 20);
			this.rdMa.TabIndex = 0;
			this.rdMa.TabStop = true;
			this.rdMa.Text = "Ma SV";
			this.rdMa.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnTim);
			this.groupBox2.Controls.Add(this.txtTim);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(59, 169);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(516, 84);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// btnTim
			// 
			this.btnTim.ForeColor = System.Drawing.Color.Fuchsia;
			this.btnTim.Location = new System.Drawing.Point(428, 32);
			this.btnTim.Margin = new System.Windows.Forms.Padding(4);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(80, 28);
			this.btnTim.TabIndex = 2;
			this.btnTim.Text = "Tim";
			this.btnTim.UseVisualStyleBackColor = true;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// txtTim
			// 
			this.txtTim.Location = new System.Drawing.Point(163, 34);
			this.txtTim.Margin = new System.Windows.Forms.Padding(4);
			this.txtTim.Name = "txtTim";
			this.txtTim.Size = new System.Drawing.Size(256, 22);
			this.txtTim.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 38);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nhap Thong Tin";
			// 
			// btnSapXep
			// 
			this.btnSapXep.ForeColor = System.Drawing.Color.Fuchsia;
			this.btnSapXep.Location = new System.Drawing.Point(119, 303);
			this.btnSapXep.Margin = new System.Windows.Forms.Padding(4);
			this.btnSapXep.Name = "btnSapXep";
			this.btnSapXep.Size = new System.Drawing.Size(100, 28);
			this.btnSapXep.TabIndex = 2;
			this.btnSapXep.Text = "SapXep";
			this.btnSapXep.UseVisualStyleBackColor = true;
			this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.ForeColor = System.Drawing.Color.Fuchsia;
			this.btnThoat.Location = new System.Drawing.Point(379, 303);
			this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(100, 28);
			this.btnThoat.TabIndex = 3;
			this.btnThoat.Text = "Thoat";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// frmTuyChon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(592, 348);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnSapXep);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmTuyChon";
			this.Text = "frmTuyChon";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdNgaySinh;
        private System.Windows.Forms.RadioButton rdHoTen;
        private System.Windows.Forms.RadioButton rdMa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Button btnThoat;
    }
}