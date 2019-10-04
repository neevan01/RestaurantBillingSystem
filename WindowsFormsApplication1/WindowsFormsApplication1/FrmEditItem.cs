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
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class FrmEditItem : Form
    {
        public FrmEditItem()
        {
            InitializeComponent();
        }

        private void frmEditItem_Load(object sender, EventArgs e)
        {

            fillGridView();
        }

        private void fillGridView()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DemoC"].ToString();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string viewQuery = "Select ItemID,Name,Rate From tblItem";
            SqlCommand cmd = new SqlCommand(viewQuery, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.ExecuteNonQuery();
            con.Close();

            //Fill data grid view with data table
            dgvEditItem.DataSource = dt;
        }

      


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtItemID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Search From Item Table 
            string connectionString = ConfigurationManager.ConnectionStrings["DemoC"].ToString();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string selectQuery = "Select * From tblItem where Name='" + txtItem.Text + "'";
            SqlCommand cmd = new SqlCommand(selectQuery, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            if (dt.Rows.Count > 0)
            {
                txtItemID.Text = dt.Rows[0]["ItemID"].ToString();
                btnUpdate.Enabled = true;
            }
            else
            {
                MessageBox.Show("Item Name Not Available");
                btnUpdate.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNewItem.Text == "")
            {
                MessageBox.Show("New Item should not be blank");
            }
            else
            {
                //Update Item Type Name in Item Type Table 
                string connectionString = ConfigurationManager.ConnectionStrings["DemoC"].ToString();
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string updateQuery = "Update tblItem set Name='" + txtNewItem.Text + "' where ItemID='" + txtItemID.Text + "'";
                SqlCommand cmd = new SqlCommand(updateQuery, con);
                string updateQuery1 = "Update tblItem set Rate='" + txtRate.Text + "' where ItemID='" + txtItemID.Text + "'";
                SqlCommand cmd1 = new SqlCommand(updateQuery1, con);
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Item Type Updated Successfully");
                btnUpdate.Enabled = true;
                DeleteAllTextBoxes();
                fillGridView();

            }
        }

        private void DeleteAllTextBoxes()
        {
            txtItem.Text="";
            txtItemID.Text = "";
            txtNewItem.Text = "";
        }

        private void dgvEditItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
