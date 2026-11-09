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

namespace Lab_Advanced_Command
{
    public partial class FoodForm : Form
    {
        private DataTable foodTable;
        public FoodForm()
        {
            InitializeComponent();
        }

        private void FoodForm_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }
        private void LoadCategory()
        {
            string connectionString = @"server = PC512\SQLEXPRESS ;database = RestaurantManagement; integrated Security = true;";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID, NAME FROM Category";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            conn.Dispose();
            cbbChon.DataSource = dt;
            cbbChon.DisplayMember = "Name";
            cbbChon.ValueMember = "ID";
        }

        private void cbbChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChon.SelectedIndex == -1) return;
            string connecString = @"server = PC512\SQLEXPRESS ;database = RestaurantManagement; integrated Security = true;";
            SqlConnection conn = new SqlConnection(connecString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = @categoryId";
            cmd.Parameters.Add("@categoryId", SqlDbType.Int);
            if(cbbChon.SelectedValue is DataRowView)
            {
                DataRowView rowView = cbbChon.SelectedValue as DataRowView;
                cmd.Parameters["@categoryId"].Value = rowView["ID"];
            }
            else
            {
                cmd.Parameters["@categoryId"].Value = cbbChon.SelectedValue;
            }
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            foodTable = new DataTable();
            conn.Open();
            adapter.Fill(foodTable);
            conn.Close();
            conn.Dispose();
            dgvFoodList.DataSource = foodTable;
            lblQuantity.Text = foodTable.Rows.Count.ToString();
            lblCatName.Text = cbbChon.Text;
        }

        private void tsmCalculateQuantity_Click(object sender, EventArgs e)
        {
            string connecString = @"server = PC512\SQLEXPRESS ;database = RestaurantManagement; integrated Security = true;";
            SqlConnection conn = new SqlConnection(connecString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT @numSaleFood = sum(Quantity) FROM BillDetails WHERE FoodID = @foodId";
            if (dgvFoodList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectRow = dgvFoodList.SelectedRows[0];
                DataRowView rowView = selectRow.DataBoundItem as DataRowView;
                cmd.Parameters.Add("@foodId", SqlDbType.Int);
                cmd.Parameters["@foodId"].Value = rowView["ID"];
                cmd.Parameters.Add("@numSaleFood", SqlDbType.Int);
                cmd.Parameters["@numSaleFood"].Direction = ParameterDirection.Output;
                conn.Open();
                cmd.ExecuteNonQuery();
                string result = cmd.Parameters["@numSaleFood"].Value.ToString();
                MessageBox.Show("Tong so luong mon an " + rowView["Name"] + " da ban la: " + result + " " + rowView["Unit"]);
                conn.Close();
            }
            cmd.Dispose();
            conn.Dispose();
        }
        private void tsmAddFood_Click(object sender, EventArgs e)
        {

        }

        private void tsmUpdateFood_Click(object sender, EventArgs e)
        {

        }
    }
}
