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
        public DataLayer dll = new DataLayer();
        public FrmEditItemType()
        {
            InitializeComponent();
        }

        private void FrmEditItemType_Load(object sender, EventArgs e)
        {
            FillGridView();
        }

        private void FillGridView()
        {            
            string viewQuery = "Select ItemType,ItemTypeID From tblItemType";            
            //Fill data grid view with data table
            dgvEditItemType.DataSource = dll.DataReturn(viewQuery);

        }



        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //Search From Item Type Table             
            string selectQuery = "Select * From tblItemType where ItemType='" + txtItemType.Text + "'";            
            DataTable dt = dll.DataReturn(selectQuery);                      

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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNewItemType.Text == "")
            {
                MessageBox.Show("New Item Type should not be blank");
            }
            else
            {
                //Update Item Type Name in Item Type Table                 
                string updateQuery = "Update tblItemType set ItemType='" + txtNewItemType.Text + "' where ItemTypeId='" + txtItemTypeID.Text + "'";
                dll.DbConn(updateQuery);
                MessageBox.Show("Item Type Updated Successfully");
                btnUpdate.Enabled = false;
                DeleteAllTextBoxes();
                FillGridView();
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

        

        