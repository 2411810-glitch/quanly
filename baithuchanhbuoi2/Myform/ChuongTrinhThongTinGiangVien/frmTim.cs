using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChuongTrinhThongTinGiangVien
{
    public partial class frmTim : Form
    {
		QuanLyGiangVien dsGiangVien;
        public frmTim()
        {
            InitializeComponent();
        }
		public frmTim(QuanLyGiangVien ds)
        {
            InitializeComponent();
			dsGiangVien = ds;
        }

        private void rdMa_CheckedChanged(object sender, EventArgs e)
        {
            if(rdMa.Checked)
            {
                lbTim.Text = "Ma GV";
            }
        }

		private void rdHoTen_CheckedChanged( object sender, EventArgs e )
		{
			if(rdHoTen.Checked)
            {
                lbTim.Text = "Ho Ten GV";
            }
		}

		private void rdDT_CheckedChanged( object sender, EventArgs e )
		{
			if(rdDT.Checked)
            {
                lbTim.Text = "So DT";
            }
		}
		int SoSanhMa(object a, object b)
		{
			string ma1 = a.ToString();
			GiangVien gv = (GiangVien)b;
			return string.Compare(ma1, gv.MaSo);
		}

		int SoSanhHoTen(object a, object b)
		{
			string hoten1 = a.ToString();
			GiangVien gv = (GiangVien)b;
			return string.Compare(hoten1, gv.HoTen);
		}

		int SoSanhSDT(object a, object b)
		{
			string sdt1 = a.ToString();
			GiangVien gv = (GiangVien)b;
			return string.Compare(sdt1, gv.SoDT);
		}

		private void btnTim_Click( object sender, EventArgs e )
		{
			 GiangVien gv = null;

    if (rdMa.Checked)
    {
        gv = dsGiangVien.Tim(txtTim.Text, SoSanhMa);
    }
    else if (rdHoTen.Checked)
    {
        gv = dsGiangVien.Tim(txtTim.Text, SoSanhHoTen);
    }
    else if (rdDT.Checked)
    {
        gv = dsGiangVien.Tim(txtTim.Text, SoSanhSDT);
    }

    if (gv != null)
    {
        frmTBGiangVien frm = new frmTBGiangVien(gv);
        frm.ShowDialog();
    }
    else
    {
        MessageBox.Show(
            "Không tìm thấy thông tin!",
            "Thông báo",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }
		}
	}
}
