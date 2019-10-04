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
    public partial class FrmViewItemType : Form
    {
        public FrmViewItemType()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

    private void frmViewItemType_Load_1(object sender, EventArgs e)
        {
            fillGridView();
        }

        private void fillGridView()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DemoC"].ToString();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string viewQuery = "Select * From tblItemType";
            SqlCommand cmd = new SqlCommand(viewQuery, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            //Fill data grid view with data table
            dgvViewItemType.DataSource = dt;
        }

    }

}