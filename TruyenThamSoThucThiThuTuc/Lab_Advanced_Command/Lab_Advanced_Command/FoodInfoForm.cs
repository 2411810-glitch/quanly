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
    public partial class FoodInfoForm : Form
    {
        public FoodInfoForm()
        {
            InitializeComponent();
        }

        private void FoodInfoForm_Load(object sender, EventArgs e)
        {
            this.InitValues();
        }
        private void InitValues()
        {
            string kn = @"server = PC512\SQLEXPRESS;database = RestaurantManagement;Integrated Security = true;";
            SqlConnection conn = new SqlConnection(kn);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID,Name FROM Category";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            conn.Open();
            adapter.Fill(ds, "Category");
            cbbCatName.DataSource = ds.Tables["Category"];
            cbbCatName.DisplayMember = "Name";
            cbbCatName.ValueMember = "ID";
            conn.Close();
            conn.Dispose();
        }
        private void ResetText()
        {
            txtFoodID.ResetText();
            txtName.ResetText();
            txtNotes.ResetText();
            txtUnit.ResetText();
            cbbCatName.ResetText();
            nudPrice.ResetText();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                string kn = @"server = PC512\SQLEXPRESS;database = RestaurantManagement;Integrated Security = true;";
                SqlConnection conn = new SqlConnection(kn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE InsertFood @ID OUTPUT, @Name, @Unit, @foodCategoryID, @Price, @Notes";
                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@Unit", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@foodCategoryID", SqlDbType.Int);
                cmd.Parameters.Add("@Price", SqlDbType.Int);
                cmd.Parameters.Add("@Notes", SqlDbType.NVarChar, 3000);

                cmd.Parameters["@ID"].Value = int.Parse(txtFoodID.Text);
                cmd.Parameters["@Name"].Value = txtName.Text;
                cmd.Parameters["@Unit"].Value = txtUnit.Text;
                cmd.Parameters["@foodCategoryID"].Value = cbbCatName.SelectedValue;
                cmd.Parameters["@Price"].Value = nudPrice.Value;
                cmd.Parameters["@Notes"].Value = txtNotes.Text;
                conn.Open();
                int numRowAffected = cmd.ExecuteNonQuery();
                if (numRowAffected > 0)
                {
                    string foodID = cmd.Parameters["@ID"].Value.ToString();
                    MessageBox.Show("successfully adding new food, Food ID =" + foodID, "Message");
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("adding food failed");
                }
                conn.Close();
                conn.Dispose();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        public void DisPlayFoodInfo(DataRowView rowView)
        {
            try
            {
                txtFoodID.Text = rowView["ID"].ToString();
                txtName.Text = rowView["Name"].ToString();
                txtUnit.Text = rowView["Unit"].ToString();
                txtNotes.Text = rowView["Notes"].ToString();
                nudPrice.Text = rowView["Price"].ToString();
                cbbCatName.SelectedIndex = -1;
                for(int index =0;index <cbbCatName.Items.Count;index++)
                {
                    DataRowView cat = cbbCatName.Items[index] as DataRowView;
                    if (cat["ID"].ToString()==rowView["FoodCategoryID"].ToString())
                    {
                        cbbCatName.SelectedIndex = index;
                        break;
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                this.Close();
            }
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            try
            {
                string kn = @"server = PC512\SQLEXPRESS;database = RestaurantManagement;Integrated Security = true;";
                SqlConnection conn = new SqlConnection(kn);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE UpdateFood @ID, @Name, @Unit, @foodCategoryID, @Price, @Notes";
                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@Unit", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@foodCategoryId", SqlDbType.Int);
                cmd.Parameters.Add("@Price", SqlDbType.Int);
                cmd.Parameters.Add("@Notes", SqlDbType.NVarChar, 3000);

                cmd.Parameters["@ID"].Value = int.Parse(txtFoodID.Text);
                cmd.Parameters["@Name"].Value = txtName.Text;
                cmd.Parameters["@Unit"].Value = txtUnit.Text;
                cmd.Parameters["@foodCategoryId"].Value = cbbCatName.SelectedValue;
                cmd.Parameters["@Price"].Value = nudPrice.Value;
                cmd.Parameters["@Notes"].Value = txtNotes.Text;
                conn.Open();
                int numRowAffected = cmd.ExecuteNonQuery();
                if (numRowAffected > 0)
                {
                    MessageBox.Show("successfull update food", "Message");
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("update food failed");
                }
                conn.Close();
                conn.Dispose();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
