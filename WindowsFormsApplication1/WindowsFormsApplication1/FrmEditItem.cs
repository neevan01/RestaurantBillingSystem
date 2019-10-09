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
    public partial class FrmEditItem : Form
    {
        public DataLayer dll = new DataLayer();
        public FrmEditItem()
        {
            InitializeComponent();                      
        }

        private void FrmEditItem_Load(object sender, EventArgs e)
        {

            FillGridView();
        }

        private void FillGridView()
        {           
            string viewQuery = "Select * From tblItem";                     
            //Fill data grid view with data table
            dgvEditItem.DataSource = dll.DataReturn(viewQuery);
        }
        
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //Search From Item Table            
            string selectQuery = "Select ItemName,Rate From tblItem where ItemName='" + txtItem.Text + "'";
            DataTable dt = dll.DataReturn(selectQuery);            
            if (dt.Rows.Count > 0)
            {
                txtItemID.Text = dt.Rows[0]["ItemID"].ToString();
                btnUpdate.Enabled = true;
            }
            else
            {
                MessageBox.Show("Item Name Not Available");
                btnUpdate.Enabled = false;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNewItem.Text == ""|| txtRate.Text==""||txtItem.Text=="")
            {
                MessageBox.Show("Fields should not be blank");
            }
            else
            {
                //Update Item Type Name in Item Type Table                
                string updateQuery = "Update tblItem set ItemName='" + txtNewItem.Text + "', Rate='" + txtRate.Text + "'  where ItemID='" + txtItemID.Text + "'";
                dll.DbConn(updateQuery);
                MessageBox.Show("Item Type Updated Successfully");
                btnUpdate.Enabled = false;
                DeleteAllTextBoxes();
                FillGridView();
            }
        }

        private void DeleteAllTextBoxes()
        {
            txtItem.Text="";
            txtItemID.Text = "";
            txtNewItem.Text = "";
        }       
    }
}
