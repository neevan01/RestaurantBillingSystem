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
    public partial class FrmAddItemType : Form
    {
        public FrmAddItemType()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtItemType.Text == "")
            {
                MessageBox.Show("Item Type should not be blank");
            }
            else
            {
                //Insert Item Type to Database
                string connectionString = ConfigurationManager.ConnectionStrings["DemoC"].ToString();
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string insertQuery = "Insert into tblItemType values('" + txtItemType.Text + "')";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Item Type inserted successfully");
            }
        }

        private void txtItemType_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
