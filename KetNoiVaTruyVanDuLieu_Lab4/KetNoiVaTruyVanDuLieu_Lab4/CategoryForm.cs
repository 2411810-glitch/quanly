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
            string ketNoi = @"server= PC512\SQLEXPRESS ;database = RestaurantManagement;Integrated Security = true";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connectionString = @"server= PC512\SQLEXPRESS ;database = RestaurantManagement;Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "INSERT INTO Category(Name,[Type])" +
                "VALUES (N'" + txtName.Text + "'," + txtType.Text + ")";
            sqlConnection.Open();
            int numOfRowEffectec = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if(numOfRowEffectec == 1)
            {
                MessageBox.Show("Them nhom mon an thanh cong");
                btnLoad.PerformClick();
                txtName.Text = "";
                txtType.Text = "";
            }
            else
            {
                MessageBox.Show("Da co loi xay ra. vui long thu lai");
            }
        }

        private void lvDS_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvDS.SelectedItems[0];
            txtID.Text = item.Text;
            txtName.Text = item.SubItems[1].Text;
            txtType.Text = item.SubItems[2].Text == "0" ? "Thuc uong" : "Do an";
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = @"server= PC512\SQLEXPRESS;database = RestaurantManagement ;Integrated Security =true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string so = txtType.Text == "Thuc uong" ? "0" : "1";
            sqlCommand.CommandText = "UPDATE Category SET Name =N'" + txtName.Text +
                "',[Type] = " + so + 
                "WHERE ID = " + txtID.Text;
            sqlConnection.Open();
            int numOfRowEffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if(numOfRowEffected==1)
            {
                ListViewItem item = lvDS.SelectedItems[0];
                item.SubItems[1].Text = txtName.Text;
                item.SubItems[2].Text = so;
                txtID.Text = "";
                txtName.Text = "";
                txtType.Text = "";
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                MessageBox.Show("Cap nhat nhom mon an thanh cong");
            }
            else
            {
                MessageBox.Show("Da co loi xay ra,vui long thu lai");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = @"server = PC512\SQLEXPRESS;database = RestaurantManagement;Integrated Security =true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = ("DELETE FROM Category "+"WHERE ID = "+txtID.Text);
            sqlConnection.Open();
            int numOfRowEffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if(numOfRowEffected==1)
            {
                ListViewItem item = lvDS.SelectedItems[0];
                lvDS.Items.Remove(item);
                txtID.Text = "";
                txtName.Text = "";
                txtType.Text = "";
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                MessageBox.Show("Xoa thanh cong");
            }
            else
            {
                MessageBox.Show("Da co loi xay ra, vui ong thu lai");
            }
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (lvDS.SelectedItems.Count > 0)
                btnDelete.PerformClick();
        }

        private void tsmViewFood_Click(object sender, EventArgs e)
        {

        }
    }
}
