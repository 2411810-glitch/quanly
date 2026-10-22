using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_lab3
{
	public partial class frmTim : Form
	{
		private QuanLySV qlsv;
		private frmQuanLySV frm;
		public frmTim( )
		{
			InitializeComponent( );
		}
		public frmTim(QuanLySV ds,frmQuanLySV frmSV)
		{
			InitializeComponent( );
			qlsv = ds;
			frm = frmSV;
		}

		private void btnTim_Click( object sender, EventArgs e )
		{
			
			string tim = txtTim.Text;
			string ten = txtTen.Text;
			string lop = cbLop.Text;
			string tuKhoa = tim + ten + lop;
			List<Student> kq,x,y;
			if(string.IsNullOrWhiteSpace(tim))
            {
				x = qlsv.TimTheoTen(ten);
				y = qlsv.TimTheoLop(lop);
				kq = qlsv.Tong(x,y);
            }
			else if(string.IsNullOrWhiteSpace(ten))
            {
				x = qlsv.TimTheoMa(tim);
				y = qlsv.TimTheoLop(lop);
				kq = qlsv.Tong(x, y);
            }
			else if (string.IsNullOrWhiteSpace(lop))
			{
				x = qlsv.TimTheoMa(tim);
				y = qlsv.TimTheoTen(ten);
				kq = qlsv.Tong(x, y);
			}
			else
            {
				kq = qlsv.TimKiem(tuKhoa);
            }

			frm.LoadListView(kq);
			this.Close();
		}
    }
}
