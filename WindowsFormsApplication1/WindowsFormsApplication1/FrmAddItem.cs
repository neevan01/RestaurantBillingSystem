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
    public partial class FrmAddItem : Form
    {
        private object dt;
        private object txtItemTypeID;

        public FrmAddItem()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbItemType.Text == "")
            {
                MessageBox.Show("Item Type should not be blank");
            }
            else
            {

                //Read ItemTypeId from table
                //string connectionString = "Data Source=Neevan; Initial Catalog=Test; Integrated Security=True";
                string connectionString = ConfigurationManager.ConnectionStrings["DemoC"].ToString();
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string selectQuery = "Select ItemTypeID From tblItemType where ItemType='" + cbItemType.Text +"'";
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();

                float ID = float.Parse(dt.Rows[0]["ItemTypeID"].ToString());
                string connectionString1 = "Data Source=Neevan; Initial Catalog=Test; Integrated Security=True";
                //Insert Item Type to Database
                //string connectionString1 = ConfigurationManager.ConnectionStrings["DemoC"].ToString();
                SqlConnection con1 = new SqlConnection(connectionString1);
                con1.Open();
                string insertQuery = "Insert into tblItem values(" + ID + ",'" + txtItemName.Text + "','" + txtDescription.Text + "'," + txtRate.Text + ")";
                SqlCommand cmd1 = new SqlCommand(insertQuery, con1);
                cmd1.ExecuteNonQuery();
                con1.Close();

                MessageBox.Show("Item inserted successfully");
            }
        }

        private void frmAddItem_Load(object sender, EventArgs e)
        {
            fillItemComboBox();
        }

        void fillItemComboBox()
        {
            //Read Details from Item Type Table
            string connectionString = ConfigurationManager.ConnectionStrings["DemoC"].ToString();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string selectQuery = "Select * From tblItemType";
            SqlCommand cmd = new SqlCommand(selectQuery, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            //Fill Item Type Data to Combo Box
            foreach (DataRow dr in dt.Rows)
            {
                cbItemType.Items.Add(dr["ItemType"].ToString());
            }
        }

        private void cbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
