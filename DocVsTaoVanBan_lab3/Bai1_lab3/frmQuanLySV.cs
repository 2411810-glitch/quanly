using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bai1_lab3
{
	public partial class frmQuanLySV : Form
	{
		QuanLySV dssv = new QuanLySV();
		public frmQuanLySV( )
		{
			InitializeComponent( );
		}

        private void btnThoat_Click(object sender, EventArgs e)
        {
			DialogResult result = MessageBox.Show("Ban co chac muon thoat chuong trinh", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
			if (result == DialogResult.OK)
				Application.Exit();
			
        }
		private Student GetSV()
        {
			Student sv = new Student();
			sv.MSSV = mtbMSSV.Text;
			sv.HoVaTenLot = txtHoTenLot.Text;
			sv.Ten = txtTen.Text;
			sv.NgaySinh = dtpNgaySinh.Value;
			sv.Lop = cbLop.Text;
			sv.SoCMND = mtxtCMND.Text;
			sv.SoDT = mtxtDT.Text;
			sv.DiaChi = txtDiaChi.Text;
			List<string> monDK = new List<string>();
			for (int i = 0; i < clbMon.Items.Count; i++)
			{
				if (clbMon.GetItemChecked(i))
				{
					monDK.Add(clbMon.Items[i].ToString());
				}
			}
			sv.MonDangKy = monDK;
			return sv;
		}
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
			Student sv = GetSV();
			dssv.CapNhat(sv);
        }
		private void ThemSV(Student sv)
        {
			ListViewItem lv = new ListViewItem(sv.MSSV);
			lv.SubItems.Add(sv.HoVaTenLot);
			lv.SubItems.Add(sv.Ten);
			lv.SubItems.Add(sv.NgaySinh.ToShortDateString());
			lv.SubItems.Add(sv.Lop);
			lv.SubItems.Add(sv.SoCMND);
			lv.SubItems.Add(sv.SoDT);
			lv.SubItems.Add(sv.DiaChi);
			string gt = "";
			if (rdNam.Checked)
				gt = "Nam";
			else
				gt = "Nu";
			lv.SubItems.Add(gt);
			string monDK = "";
			foreach (string s in sv.MonDangKy)
				monDK += s + ", ";
			this.lvDSSV.Items.Add(lv);

        }
		private void LoadListView()
        {
			this.lvDSSV.Items.Clear();
			foreach (Student sv in dssv.dssv)
				ThemSV(sv);
        }
		

        private void btnthem_Click(object sender, EventArgs e)
        {
			Student sv = GetSV();
			dssv.ThemSV(sv);
			LoadListView();
        }

        private void frmQuanLySV_Load(object sender, EventArgs e)
        {
			dssv = new QuanLySV();
			dssv.DocTuFile("data.txt");
			LoadListView();
        }

        private void lvDSSV_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (lvDSSV.SelectedItems.Count == 0)
				return;
			int index = lvDSSV.SelectedItems[0].Index;
			Student sv = dssv[index];
			mtbMSSV.Text = sv.MSSV;
			txtHoTenLot.Text = sv.HoVaTenLot;
			txtTen.Text = sv.Ten;
			dtpNgaySinh.Value = sv.NgaySinh;
			cbLop.Text = sv.Lop;
			mtxtCMND.Text = sv.SoCMND;
			mtxtDT.Text = sv.SoDT;
			for (int i = 0; i < clbMon.Items.Count; i++)
				clbMon.SetItemChecked(i, false);
			foreach(string mon in sv.MonDangKy)
            {
				for(int i=0;i<clbMon.Items.Count;i++)
                {
					if (clbMon.Items[i].ToString() == mon)
						clbMon.SetItemChecked(i, true);
                }
            }
        }
    }
}
