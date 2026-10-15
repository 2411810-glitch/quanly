using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace KetNoiVaTruyVanDuLieu_Lab4
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string ketNoi = "sever=.;database = ;Integrated Security = true";
            SqlConnection connection = new SqlConnection(ketNoi);
            SqlCommand command = connection.CreateCommand();
            string query = "select ID,Name,Type from category";
            command.CommandText = query;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            this.DisplayCategory(reader);
            connection.Close();
        }
        public void DisplayCategory(SqlDataReader r)
        {
            lvDS.Items.Clear();
            while(r.Read())
            {
                ListViewItem item = new ListViewItem(r["ID"].ToString());
                lvDS.Items.Add(item);
                item.SubItems.Add(r["Name"].ToString());
                item.SubItems.Add(r["Type"].ToString());
            }
        }
    }
}
