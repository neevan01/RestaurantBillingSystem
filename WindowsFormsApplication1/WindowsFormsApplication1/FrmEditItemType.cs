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
    public partial class FrmEditItemType : Form
    {
        public FrmEditItemType()
        {
            InitializeComponent();
        }

        private void frmEditItemType_Load(object sender, EventArgs e)
        {
            fillGridView();
        }

        private void fillGridView()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DemoC"].ToString();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string viewQuery = "Select ItemType,ItemTypeID From tblItemType";
            SqlCommand cmd = new SqlCommand(viewQuery, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.ExecuteNonQuery();
            con.Close();

            //Fill data grid view with data table
            dgvEditItemType.DataSource = dt;

        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Search From Item Type Table 
            string connectionString = ConfigurationManager.ConnectionStrings["DemoC"].ToString();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string selectQuery = "Select * From tblItemType where ItemType='" + txtItemType.Text + "'";
            SqlCommand cmd = new SqlCommand(selectQuery, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            if (dt.Rows.Count > 0)
            {
                txtItemTypeID.Text = dt.Rows[0]["ItemTypeId"].ToString();
                btnUpdate.Enabled = true;
            }
            else
            {
                MessageBox.Show("Item Type Not Available");
                DeleteAllTextBoxes();
                btnUpdate.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNewItemType.Text == "")
            {
                MessageBox.Show("New Item Type should not be blank");
            }
            else
            {
                //Update Item Type Name in Item Type Table 
                string connectionString = ConfigurationManager.ConnectionStrings["DemoC"].ToString();
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string updateQuery = "Update tblItemType set ItemType='" + txtNewItemType.Text + "' where ItemTypeId='" + txtItemTypeID.Text + "'";
                SqlCommand cmd = new SqlCommand(updateQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Item Type Updated Successfully");
                btnUpdate.Enabled = true;
                DeleteAllTextBoxes();
            }
        }

        private void DeleteAllTextBoxes()
        {
            txtItemType.Text = "";
            txtItemTypeID.Text = "";
            txtNewItemType.Text = "";
        }

        private void txtNewItemType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtItemTypeID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEditItemType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

        

        