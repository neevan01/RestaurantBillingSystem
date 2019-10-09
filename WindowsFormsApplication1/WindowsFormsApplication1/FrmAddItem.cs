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
        public DataLayer dll = new DataLayer();       
        public FrmAddItem()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (cbItemType.Text == "")
            {
                MessageBox.Show("Item Type should not be blank");
            }
            else
            {
                //Read ItemTypeId from table               
                string selectQuery = "Select ItemTypeID From tblItemType where ItemType='" + cbItemType.Text +"'";
                DataTable dt = dll.DataReturn(selectQuery);
                int ID = int.Parse(dt.Rows[0]["ItemTypeID"].ToString());
                //Insert Item Type to Database  
                string insertQuery = "Insert into TblItem values('" + txtItemName.Text + "', '" + ID + "', '" + txtDescription.Text + "', '" + Convert.ToInt32(txtRate.Text) + "')";                
                dll.DbConn(insertQuery);               
                MessageBox.Show("Item inserted successfully");
                DeleteAllTextBoxes();
            }
        }

        private void FrmAddItem_Load(object sender, EventArgs e)
        {
            FillItemComboBox();
        }

        void FillItemComboBox()
        {
            //Read Details from Item Type Table           
            string selectQuery = "Select * From tblItemType";           
            DataTable dt = dll.DataReturn(selectQuery);           

            //Fill Item Type Data to Combo Box
            foreach (DataRow dr in dt.Rows)
            {
                cbItemType.Items.Add(dr["ItemType"].ToString());
            }
        }

        private void DeleteAllTextBoxes()
        {
            txtDescription.Text = "";
            txtItemName.Text = "";
            txtRate.Text = "";
        }
    }
}
