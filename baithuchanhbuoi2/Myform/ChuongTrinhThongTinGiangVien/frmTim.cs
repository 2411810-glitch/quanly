using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChuongTrinhThongTinGiangVien
{
    public partial class frmTim : ChuongTrinhThongTinGiangVien.frmTBGiangVien
    {
        public frmTim()
        {
            InitializeComponent();
        }

        private void rdMa_CheckedChanged(object sender, EventArgs e)
        {
            if(rdMa.Checked)
            {
                lbTim.Text = "Ma GV";
            }
        }
    }
}
