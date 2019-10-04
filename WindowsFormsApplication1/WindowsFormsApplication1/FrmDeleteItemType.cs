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
    public partial class FrmDeleteItemType : Form
    {
        public FrmDeleteItemType()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Search From Item Type Table 
            string connectionString = ConfigurationManager.ConnectionStrings["DemoC"].ToString();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string selectQuery = "Select * From tblItemType where ItemTypeID='" + txtItemID.Text + "'";
            SqlCommand cmd = new SqlCommand(selectQuery, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                txtItemType.Text = dt.Rows[0]["ItemType"].ToString();
                btnDelete.Enabled = true;
            }
            else
            {
                MessageBox.Show("Item Type Not Available");
                btnDelete.Enabled = false;
             }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Delete Item Type Name in Item Type Table 
            string connectionString = ConfigurationManager.ConnectionStrings["DemoC"].ToString();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string deleteQuery = "delete from tblItemType where ItemTypeID=" + txtItemID.Text + "";
            SqlCommand cmd = new SqlCommand(deleteQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Item Type Deleted Successfully");
            btnDelete.Enabled = false;
            DeleteAllTextBoes();
            fillGridView();
        }

        private void DeleteAllTextBoes()
        {
            txtItemID.Text = "";
            txtItemType.Text = "";
        }

        private void dgvDeleteItemType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDeleteItemType_Load(object sender, EventArgs e)
        {

            fillGridView();
        }

        private void fillGridView()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DemoC"].ToString();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string viewQuery = "Select ItemTypeID,ItemType From tblItemType";
            SqlCommand cmd = new SqlCommand(viewQuery, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.ExecuteNonQuery();
            con.Close();

            //Fill data grid view with data table
            dgvDeleteItemType.DataSource = dt;
        }

    }

}
      