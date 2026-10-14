using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien_lab2
{
    public partial class frmTuyChon : Form
    {
        QuanLySinhVien ds;
        public frmTuyChon()
        {
            InitializeComponent();
        }
        public frmTuyChon(QuanLySinhVien dsSV)
        {
            InitializeComponent();
            ds = dsSV;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
			SinhVien sv = null;
			if(rdMa.Checked)
			{
				sv = ds.Tim(QuanLySinhVien.Kieu.MaSV,txtTim.Text.Trim());
			}
			else if(rdHoTen.Checked)
			{
				sv = ds.Tim(QuanLySinhVien.Kieu.MaSV,txtTim.Text.Trim());
			}
			else if(rdNgaySinh.Checked) 
			{
				sv = ds.Tim(QuanLySinhVien.Kieu.MaSV,txtTim.Text);
			}
			if(sv != null)
			{
				MessageBox.Show( "Tim thay 1 sinh vien", "thong bao", MessageBoxButtons.OK );
			}
			else
			{
				MessageBox.Show( "khong tim thay sinh vien nao" );
			}
        }

		private void btnSapXep_Click( object sender, EventArgs e )
		{
			if(rdMa.Checked)
			{
				ds.SapXep(QuanLySinhVien.Kieu.MaSV);
			}
			else if(rdHoTen.Checked)
			{
				ds.SapXep( QuanLySinhVien.Kieu.HoTen );
			}
			else if(rdNgaySinh.Checked)
			{
				ds.SapXep(QuanLySinhVien.Kieu.NgaySinh );
			}
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
