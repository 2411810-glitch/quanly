using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhThongTinGiangVien
{
    public partial class frmTBGiangVien : Form
    {
		GiangVien gv;
        public frmTBGiangVien()
        {
            InitializeComponent();
        }
		public frmTBGiangVien(GiangVien gv)
        {
            InitializeComponent();
			this.gv = gv;
        }
        public void SetText(string s)
        {
            this.lblThongBao.Text = s;
        }
    }
}
