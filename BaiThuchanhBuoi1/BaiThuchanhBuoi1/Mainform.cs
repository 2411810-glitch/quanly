using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThuchanhBuoi1
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var tenDaNhap = tbTen.Text;
            MessageBox.Show($"Xin chao ban {tenDaNhap} rat vui duoc gap ban","thong diep chao mung");

        }

        private void tbSaoChep_Click(object sender, EventArgs e)
        {
            tbSaoChep.Text = tbTen.Text;
        }

        private void tbSaoChep_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbTen_TextChanged(object sender, EventArgs e)
        {
            tbSaoChep.Text = tbTen.Text;
        }
    }
}
