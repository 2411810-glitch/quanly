using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKeForm1
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTrang.Checked)
                tbDonGia.Text = "20000";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTongTien_Click(object sender, EventArgs e)
        {

        }

        private void rdxanh_CheckedChanged(object sender, EventArgs e)
        {
            if (rdxanh.Checked)
                tbDonGia.Text = "22000";
        }

        private void rdDo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDo.Checked)
                tbDonGia.Text = "21000";
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int soTien = int.Parse(tbDonGia.Text) * int.Parse(tbSL.Text);
            lblTongTien.Text = soTien.ToString();
        }
    }
}
