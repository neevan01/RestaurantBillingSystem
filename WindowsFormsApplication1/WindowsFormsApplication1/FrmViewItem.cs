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
    public partial class FrmViewItem : Form
    {
        public FrmViewItem()
        {
            InitializeComponent();
        }
        private void frmViewItemType_Load(object sender, EventArgs e)
        {
            fillGridView();
        }

        private void fillGridView()
        {
            
           string connectionString = ConfigurationManager.ConnectionStrings["DemoC"].ToString();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string viewQuery = "select ItemID,ItemType,Name,Description,Rate from tblItem join tblItemType on tblItem.ItemTypeID=tblItemType.ItemTypeID";
            SqlCommand cmd = new SqlCommand(viewQuery, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            //Fill data grid view with data table
            dgvItem.DataSource = dt;
        }

      

        private void dvgItem_MouseClick(object sender, MouseEventArgs e)
        {
            Form f = new Form();
            f.ShowDialog();
        }
    }
}
