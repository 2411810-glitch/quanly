using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNam.Checked)
                MessageBox.Show("ban chon gioi tinh nam", "thong bao");
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNu.Checked)
                MessageBox.Show("ban chon gioi tinh nu", "thong bao");
        }

        private void btnToMau_Click(object sender, EventArgs e)
        {
            if (rdDo.Checked)
                tbHopMau.BackColor = Color.Red;
            else
                tbHopMau.BackColor = Color.Green;
        }
    }
}
