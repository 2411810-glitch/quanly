namespace Bai1_lab3
{
	partial class frmQuanLySV
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.mtbMSSV = new System.Windows.Forms.MaskedTextBox();
			this.txtHoTenLot = new System.Windows.Forms.TextBox();
			this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.rdNam = new System.Windows.Forms.RadioButton();
			this.rdNu = new System.Windows.Forms.RadioButton();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.MSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.HoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.NgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Lop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CMMD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "MSSV ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ho Va Ten Lot";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Ngay Sinh";
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.CheckOnClick = true;
			this.checkedListBox1.ColumnWidth = 250;
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Items.AddRange(new object[] {
            "Mang may tinh",
            "He dieu hanh",
            "Lap trinh CSDL",
            "Lap Trinh Mang",
            "Do An Co So",
            "Phuong Phap NCKH",
            "Lap Trinh tren thiet bi di dong",
            "An toan bao mat he thong"});
			this.checkedListBox1.Location = new System.Drawing.Point(113, 200);
			this.checkedListBox1.MultiColumn = true;
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(572, 72);
			this.checkedListBox1.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 105);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "So CMND ";
			// 
			// mtbMSSV
			// 
			this.mtbMSSV.Location = new System.Drawing.Point(113, 6);
			this.mtbMSSV.Mask = "000000";
			this.mtbMSSV.Name = "mtbMSSV";
			this.mtbMSSV.Size = new System.Drawing.Size(224, 22);
			this.mtbMSSV.TabIndex = 5;
			// 
			// txtHoTenLot
			// 
			this.txtHoTenLot.Location = new System.Drawing.Point(113, 42);
			this.txtHoTenLot.Name = "txtHoTenLot";
			this.txtHoTenLot.Size = new System.Drawing.Size(224, 22);
			this.txtHoTenLot.TabIndex = 6;
			// 
			// dtpNgaySinh
			// 
			this.dtpNgaySinh.Location = new System.Drawing.Point(113, 74);
			this.dtpNgaySinh.Name = "dtpNgaySinh";
			this.dtpNgaySinh.Size = new System.Drawing.Size(224, 22);
			this.dtpNgaySinh.TabIndex = 8;
			// 
			// maskedTextBox2
			// 
			this.maskedTextBox2.Location = new System.Drawing.Point(113, 105);
			this.maskedTextBox2.Mask = "000000000";
			this.maskedTextBox2.Name = "maskedTextBox2";
			this.maskedTextBox2.Size = new System.Drawing.Size(224, 22);
			this.maskedTextBox2.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(16, 140);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 16);
			this.label5.TabIndex = 10;
			this.label5.Text = "Dia Chi";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(113, 140);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(572, 22);
			this.textBox1.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(372, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(60, 16);
			this.label6.TabIndex = 12;
			this.label6.Text = "Gioi Tinh";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(372, 42);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(31, 16);
			this.label7.TabIndex = 12;
			this.label7.Text = "Ten";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(372, 74);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(30, 16);
			this.label8.TabIndex = 12;
			this.label8.Text = "Lop";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(372, 105);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(46, 16);
			this.label9.TabIndex = 12;
			this.label9.Text = "So DT";
			// 
			// rdNam
			// 
			this.rdNam.AutoSize = true;
			this.rdNam.Checked = true;
			this.rdNam.Location = new System.Drawing.Point(460, 7);
			this.rdNam.Name = "rdNam";
			this.rdNam.Size = new System.Drawing.Size(57, 20);
			this.rdNam.TabIndex = 13;
			this.rdNam.TabStop = true;
			this.rdNam.Text = "Nam";
			this.rdNam.UseVisualStyleBackColor = true;
			// 
			// rdNu
			// 
			this.rdNu.AutoSize = true;
			this.rdNu.Location = new System.Drawing.Point(582, 7);
			this.rdNu.Name = "rdNu";
			this.rdNu.Size = new System.Drawing.Size(45, 20);
			this.rdNu.TabIndex = 13;
			this.rdNu.Text = "Nu";
			this.rdNu.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(460, 42);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(225, 22);
			this.textBox2.TabIndex = 14;
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(460, 99);
			this.maskedTextBox1.Mask = "0000.000.000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(225, 22);
			this.maskedTextBox1.TabIndex = 15;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "CTK45A",
            "CTK45B",
            "CTK46A",
            "CTK46B",
            "CTK47A",
            "CTK47B",
            "CTK48A",
            "CTK48B"});
			this.comboBox1.Location = new System.Drawing.Point(460, 69);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(225, 24);
			this.comboBox1.TabIndex = 16;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(24, 215);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(58, 32);
			this.label10.TabIndex = 17;
			this.label10.Text = "Mon hoc\r\ndang ky";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(404, 287);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 18;
			this.button1.Text = "Them moi";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(301, 287);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 18;
			this.button2.Text = "Tim kiem";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(643, 287);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 18;
			this.button3.Text = "Thoat";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(516, 287);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 18;
			this.button4.Text = "Cap Nhat";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// listView1
			// 
			this.listView1.CheckBoxes = true;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MSSV,
            this.HoTen,
            this.NgaySinh,
            this.Lop,
            this.CMMD,
            this.SDT,
            this.DiaChi});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(15, 334);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(773, 194);
			this.listView1.TabIndex = 19;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// MSSV
			// 
			this.MSSV.Text = "MSSV";
			// 
			// HoTen
			// 
			this.HoTen.Text = "Ho va ten lot";
			// 
			// NgaySinh
			// 
			this.NgaySinh.Text = "Ngay Sinh";
			// 
			// Lop
			// 
			this.Lop.Text = "Lop";
			// 
			// CMMD
			// 
			this.CMMD.Text = "So CMND";
			// 
			// SDT
			// 
			this.SDT.Text = "So DT";
			// 
			// DiaChi
			// 
			this.DiaChi.Text = "DIa Chi";
			// 
			// frmQuanLySV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 540);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.maskedTextBox1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.rdNu);
			this.Controls.Add(this.rdNam);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.maskedTextBox2);
			this.Controls.Add(this.dtpNgaySinh);
			this.Controls.Add(this.txtHoTenLot);
			this.Controls.Add(this.mtbMSSV);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.checkedListBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmQuanLySV";
			this.Text = "Nhap Thong Tin";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox mtbMSSV;
		private System.Windows.Forms.TextBox txtHoTenLot;
		private System.Windows.Forms.DateTimePicker dtpNgaySinh;
		private System.Windows.Forms.MaskedTextBox maskedTextBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.RadioButton rdNam;
		private System.Windows.Forms.RadioButton rdNu;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader MSSV;
		private System.Windows.Forms.ColumnHeader HoTen;
		private System.Windows.Forms.ColumnHeader NgaySinh;
		private System.Windows.Forms.ColumnHeader Lop;
		private System.Windows.Forms.ColumnHeader CMMD;
		private System.Windows.Forms.ColumnHeader SDT;
		private System.Windows.Forms.ColumnHeader DiaChi;
	}
}

