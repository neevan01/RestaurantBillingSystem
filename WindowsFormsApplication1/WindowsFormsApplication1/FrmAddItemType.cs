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
        public DataLayer dll = new DataLayer();
        public FrmAddItemType()
        {
            InitializeComponent();                                
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtItemType.Text == "")
            {
                MessageBox.Show("Item Type should not be blank");
            }
            else
            {
                //Insert Item Type to Database                               
                string insertQuery = "Insert into tblItemType values('" + txtItemType.Text + "')";
                dll.DbConn(insertQuery);
                MessageBox.Show("Item Type inserted successfully");   
                
                //Load data from data table
                string Query = "select * from tblItemType";
                GvItemType.DataSource = dll.DataReturn(Query);               
            }
        }

        private void txtItemType_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmAddItemType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itemTypeSet.TblItemType' table. You can move, or remove it, as needed.
            _ = tblItemTypeTableAdapter.Fill(itemTypeSet.TblItemType);

        }
    }
}
