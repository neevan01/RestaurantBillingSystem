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
        public DataLayer dll = new DataLayer();
        public FrmDeleteItem()
        {
            InitializeComponent();
        }
        
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //Search From Item Table            
            string selectQuery = "Select * From tblItem where ItemID='" + txtItemID.Text + "'";
            DataTable dt = dll.DataReturn(selectQuery);           
            if (dt.Rows.Count > 0)
            {
                txtItemName.Text = dt.Rows[0]["ItemName"].ToString();
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
            //Delete Item Name in Item Table 
            string connectionString = ConfigurationManager.ConnectionStrings["DemoC"].ToString();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string deleteQuery = "delete from tblItem where ItemID=" + txtItemID.Text + "";
            dll.DbConn(deleteQuery);           
            MessageBox.Show("Item Type Deleted Successfully");
            btnDelete.Enabled = true;
            DeleteAllTextBoes();
            FillGridView();
        }

        private void DeleteAllTextBoes()
        {
            txtItemID.Text = "";
            txtItemName.Text = "";
        }

        private void FrmDeleteItem_Load(object sender, EventArgs e)
        {
            FillGridView();
        }

        private void FillGridView()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DemoC"].ToString();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string viewQuery = "Select ItemID,ItemName From tblItem";          
            dgvDeleteItem.DataSource = dll.DataReturn(viewQuery);
        }        
    }
}
