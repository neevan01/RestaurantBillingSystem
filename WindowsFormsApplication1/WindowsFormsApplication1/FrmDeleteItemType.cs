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
        public DataLayer dll = new DataLayer();
        public FrmDeleteItemType()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //Search From Item Type Table             
            string query = "Select * From tblItemType where ItemTypeID='" + txtItemID.Text + "'";
            GvItemType.DataSource = dll.DataReturn(query);
            DataTable dt = dll.DataReturn(query);
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
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //Delete Item Type Name in Item Type Table 

            string deleteQuery = "delete from tblItemType where ItemTypeID=" + txtItemID.Text + "";
            MessageBox.Show("Are you sure to delete this item?");
            dll.DbConn(deleteQuery);
            MessageBox.Show("Item Type Deleted Successfully");
            btnDelete.Enabled = false;
            DeleteAllTextBoes();
            GvItemType.DataSource = dll.DataReturn("Select * from tblItemType");
        }

        private void DeleteAllTextBoes()
        {
            txtItemID.Text = "";
            txtItemType.Text = "";
        }

        private void FrmDeleteItemType_Load(object sender, EventArgs e)
        {
            string Query = "select * from tblItemType";
            GvItemType.DataSource = dll.DataReturn(Query);
            //fillGridView();
        }

        private void txtItemID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        //private void fillGridView()
        //{
        //    string connectionString = ConfigurationManager.ConnectionStrings["DemoC"].ToString();
        //    SqlConnection con = new SqlConnection(connectionString);
        //    con.Open();
        //    string viewQuery = "Select ItemTypeID,ItemType From tblItemType";
        //    SqlCommand cmd = new SqlCommand(viewQuery, con);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    cmd.ExecuteNonQuery();
        //    con.Close();

        //    //Fill data grid view with data table
        //    GvItemType.DataSource = dt;
        //}

    }

}
