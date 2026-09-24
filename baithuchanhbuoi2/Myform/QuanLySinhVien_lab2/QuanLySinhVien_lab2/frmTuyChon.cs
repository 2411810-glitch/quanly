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

            MessageBox.Show("hay nhap thong tin tim", "loi nhap thong tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
