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
			List<Student> kq;
			kq = qlsv.TimKiem( tim );
			frm.LoadListView(kq);
			this.Close();
		}
	}
}
