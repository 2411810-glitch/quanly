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
    public partial class FoodForm : Form
    {
        public FoodForm()
        {
            InitializeComponent();
        }
        public void LoadFood(int categoryID)
        {
            string connectionString = @"server= PC512\SQLEXPRESS;database= RestaurantManagement;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT Name From Category WHERE ID ="+ID;
            sqlConnection.Open();
            string catName = sqlCommand.ExecuteScalar().ToString();
            this.Text = "Danh sach cac mon an thuoc nhom" + catName;
            sqlCommand.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = " +ID;
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable("Food");
            da.Fill(dt);
            dgvFood.DataSource = dt;
            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();
        }
    }
}
