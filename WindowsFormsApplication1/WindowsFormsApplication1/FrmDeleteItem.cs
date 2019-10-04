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
    public partial class FrmDeleteItem : Form
    {
        public FrmDeleteItem()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Search From Item Table 
            string connectionString = ConfigurationManager.ConnectionStrings["DemoC"].ToString();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string selectQuery = "Select * From tblItem where ItemID='" + txtItemID.Text + "'";
            SqlCommand cmd = new SqlCommand(selectQuery, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                txtItemName.Text = dt.Rows[0]["Name"].ToString();
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
            //Delete Item Name in Item Table 
            string connectionString = ConfigurationManager.ConnectionStrings["DemoC"].ToString();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string deleteQuery = "delete from tblItem where ItemID=" + txtItemID.Text + "";
            SqlCommand cmd = new SqlCommand(deleteQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Item Type Deleted Successfully");
            btnDelete.Enabled = true;
            DeleteAllTextBoes();
            fillGridView();
        }

        private void DeleteAllTextBoes()
        {
            txtItemID.Text = "";
            txtItemName.Text = "";
        }

        private void frmDeleteItem_Load(object sender, EventArgs e)
        {
            fillGridView();
        }

        private void fillGridView()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DemoC"].ToString();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string viewQuery = "Select ItemID,Name From tblItem";
            SqlCommand cmd = new SqlCommand(viewQuery, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.ExecuteNonQuery();
            con.Close();

            //Fill data grid view with data table
            dgvDeleteItem.DataSource = dt;
        }

        private void dgvDeleteItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
