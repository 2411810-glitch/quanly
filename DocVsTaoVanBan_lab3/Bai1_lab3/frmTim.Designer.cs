namespace Bai1_lab3
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
		protected override void Dispose( bool disposing )
		{
			if(disposing && (components != null))
			{
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent( )
		{
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lv3 = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(64, 11);
            this.txtTim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(223, 20);
            this.txtTim.TabIndex = 0;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(311, 78);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(71, 20);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tim Kiem";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ma ";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(12, 48);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(43, 13);
            this.lb2.TabIndex = 2;
            this.lb2.Text = "Ho Ten";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(64, 48);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(223, 20);
            this.txtTen.TabIndex = 3;
            // 
            // lv3
            // 
            this.lv3.AutoSize = true;
            this.lv3.Location = new System.Drawing.Point(12, 85);
            this.lv3.Name = "lv3";
            this.lv3.Size = new System.Drawing.Size(25, 13);
            this.lv3.TabIndex = 4;
            this.lv3.Text = "Lop";
            // 
            // cbLop
            // 
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Items.AddRange(new object[] {
            "CTK45A",
            "CTK45B",
            "CTK46A",
            "CTK46B",
            "CTK47A",
            "CTK47B",
            "CTK48A",
            "CTK48B"});
            this.cbLop.Location = new System.Drawing.Point(64, 77);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(223, 21);
            this.cbLop.TabIndex = 5;
            // 
            // frmTim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 112);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.lv3);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTim);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmTim";
            this.Text = "frmTim";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtTim;
		private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lv3;
        private System.Windows.Forms.ComboBox cbLop;
    }
}