namespace ChuongTrinhThongTinGiangVien
{
    partial class frmTim
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
			this.rdDT = new System.Windows.Forms.RadioButton();
			this.rdHoTen = new System.Windows.Forms.RadioButton();
			this.rdMa = new System.Windows.Forms.RadioButton();
			this.lbTim = new System.Windows.Forms.Label();
			this.txtTim = new System.Windows.Forms.TextBox();
			this.btnTim = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdDT);
			this.groupBox1.Controls.Add(this.rdHoTen);
			this.groupBox1.Controls.Add(this.rdMa);
			this.groupBox1.Location = new System.Drawing.Point(36, 48);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(580, 123);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tim Theo";
			// 
			// rdDT
			// 
			this.rdDT.AutoSize = true;
			this.rdDT.Location = new System.Drawing.Point(381, 54);
			this.rdDT.Margin = new System.Windows.Forms.Padding(4);
			this.rdDT.Name = "rdDT";
			this.rdDT.Size = new System.Drawing.Size(56, 20);
			this.rdDT.TabIndex = 0;
			this.rdDT.Text = "SDT";
			this.rdDT.UseVisualStyleBackColor = true;
			this.rdDT.CheckedChanged += new System.EventHandler(this.rdDT_CheckedChanged);
			// 
			// rdHoTen
			// 
			this.rdHoTen.AutoSize = true;
			this.rdHoTen.Location = new System.Drawing.Point(215, 54);
			this.rdHoTen.Margin = new System.Windows.Forms.Padding(4);
			this.rdHoTen.Name = "rdHoTen";
			this.rdHoTen.Size = new System.Drawing.Size(73, 20);
			this.rdHoTen.TabIndex = 0;
			this.rdHoTen.Text = "Ho Ten";
			this.rdHoTen.UseVisualStyleBackColor = true;
			this.rdHoTen.CheckedChanged += new System.EventHandler(this.rdHoTen_CheckedChanged);
			// 
			// rdMa
			// 
			this.rdMa.AutoSize = true;
			this.rdMa.Checked = true;
			this.rdMa.Location = new System.Drawing.Point(56, 54);
			this.rdMa.Margin = new System.Windows.Forms.Padding(4);
			this.rdMa.Name = "rdMa";
			this.rdMa.Size = new System.Drawing.Size(69, 20);
			this.rdMa.TabIndex = 0;
			this.rdMa.TabStop = true;
			this.rdMa.Text = "Ma GV";
			this.rdMa.UseVisualStyleBackColor = true;
			this.rdMa.CheckedChanged += new System.EventHandler(this.rdMa_CheckedChanged);
			// 
			// lbTim
			// 
			this.lbTim.AutoSize = true;
			this.lbTim.Location = new System.Drawing.Point(32, 194);
			this.lbTim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbTim.Name = "lbTim";
			this.lbTim.Size = new System.Drawing.Size(48, 16);
			this.lbTim.TabIndex = 2;
			this.lbTim.Text = "Ma GV";
			// 
			// txtTim
			// 
			this.txtTim.Location = new System.Drawing.Point(155, 191);
			this.txtTim.Margin = new System.Windows.Forms.Padding(4);
			this.txtTim.Name = "txtTim";
			this.txtTim.Size = new System.Drawing.Size(328, 22);
			this.txtTim.TabIndex = 3;
			// 
			// btnTim
			// 
			this.btnTim.Location = new System.Drawing.Point(516, 185);
			this.btnTim.Margin = new System.Windows.Forms.Padding(4);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(100, 28);
			this.btnTim.TabIndex = 4;
			this.btnTim.Text = "Tim";
			this.btnTim.UseVisualStyleBackColor = true;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// frmTim
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.ClientSize = new System.Drawing.Size(652, 263);
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.txtTim);
			this.Controls.Add(this.lbTim);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "frmTim";
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.lbTim, 0);
			this.Controls.SetChildIndex(this.txtTim, 0);
			this.Controls.SetChildIndex(this.btnTim, 0);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.RadioButton rdDT;
        private System.Windows.Forms.RadioButton rdHoTen;
        private System.Windows.Forms.RadioButton rdMa;
    }
}
