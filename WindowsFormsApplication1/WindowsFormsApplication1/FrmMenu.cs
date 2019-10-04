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
    public partial class FrmMenu : Form
    {

        #region User Defined Datas

        int SN = 1;
        class menuItem
        {
            public int sn;
            public int itemID;
            public string itemName;
            public int quantity;
            public float rate;
        }

        List<menuItem> OrderMenuItem = new List<menuItem>();

        #endregion

        #region System Generated Functions
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            fillGridView("");
            txtOrderID.Text = getOrderID().ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            fillGridView(txtSearch.Text);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //Read name and rate from database

            string connectionString = ConfigurationManager.ConnectionStrings["DemoC"].ToString();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string viewQuery = "select Name,Rate from tblItem where ItemID=" + txtItemID.Text;
            SqlCommand cmd = new SqlCommand(viewQuery, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            //Exit if ItemID not Present
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("ItemID not Present");
            }
            else
            {
                // Create menuItem to add to data grid
                menuItem item = new menuItem();
                item.sn = SN;
                item.itemID = int.Parse(txtItemID.Text);
                item.itemName = dt.Rows[0]["Name"].ToString();
                item.quantity = int.Parse(txtQuantity.Text);
                item.rate = float.Parse(dt.Rows[0]["Rate"].ToString());

                //Add item to OderMenuItem
                OrderMenuItem.Add(item);

                //Bind to Grid View
                dgvMenu.DataSource = createDataTableForOrderList(OrderMenuItem);
             
                //Updatiing Total amount
                float Total = float.Parse(txtTotal.Text);
                Total = Total + item.rate * item.quantity;
                txtTotal.Text = Total.ToString();

                //To clear the text Boxes
                DeleteAllTextBox();
            }
        }

        private void DeleteAllTextBox()
        {
            txtItemID.Text = "";
            txtQuantity.Text = "";
        }
        #endregion

        #region User Defined Functions
        private void fillGridView(string searchText)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DemoC"].ToString();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string viewQuery = "select ItemID,Name,Rate,ItemType,Description from tblItem join tblItemType on tblItem.ItemTypeID=tblItemType.ItemTypeID and Name like '%" + searchText + "%'";
            SqlCommand cmd = new SqlCommand(viewQuery, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            //Fill data grid view with data table
            dgvItem.DataSource = dt;
        }

        private int getOrderID()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DemoC"].ToString();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string orderQuery = "Select max(OrderID) From tblOrder";
            SqlCommand cmd = new SqlCommand(orderQuery, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            // Get Order ID From Table
            if (dt.Rows[0][0].ToString() == "")
                return 1;
            else
                return (int.Parse(dt.Rows[0][0].ToString()) + 1);
        }

        DataTable createDataTableForOrderList(List<menuItem> orderItems)
        {
            DataTable orderTable = createDataTableSchemaForOrderList();
            foreach (menuItem item in orderItems)
            {
                orderTable.Rows.Add(item.sn, item.itemID, item.itemName, item.quantity, item.rate);
            }
            return orderTable;
        }

        DataTable createDataTableSchemaForOrderList()
        {
            DataTable orderTable = new DataTable();
            orderTable.Columns.Add("SN");
            orderTable.Columns.Add("ItemID");
            orderTable.Columns.Add("Name");
            orderTable.Columns.Add("Quantity");
            orderTable.Columns.Add("Rate");

            return orderTable;
        }

        void InsertMenuItemsToDatabase(List<menuItem> orderItems)
        {
            string insertQuery = string.Empty;
            //Iterate on Order Items
            foreach (menuItem menu in orderItems)
            {
                insertQuery = insertQuery + "Insert into tblOrder values(" + txtOrderID.Text + "," + menu.itemID + "," + menu.quantity + ")\n";
            }

            string connectionString = ConfigurationManager.ConnectionStrings["DemoC"].ToString();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (OrderMenuItem.Count <= 0)
            {
                MessageBox.Show("There is no item added in Menu");
            }
            else if (txtRecieved.Text == "")
            {
                MessageBox.Show("Please enter received amount");
                txtRecieved.Focus();
            }
            else if (float.Parse(txtRecieved.Text) < float.Parse(txtTotal.Text))
            {
                MessageBox.Show("Received Amount should be Greater than Total Bill Amount");
                txtRecieved.Focus();
            }
            else
            {
                float amount = float.Parse(txtRecieved.Text) - float.Parse(txtTotal.Text);
                txtReturn.Text = amount.ToString();
                InsertMenuItemsToDatabase(OrderMenuItem);
                MessageBox.Show("Item Insert to Database Succssfully");

                btnClearAll.Enabled = true;
                btnCalc.Enabled = false;
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            DeleteAllTextBox();
            txtTotal.Text = "0";
            txtReturn.Text = "";
            txtRecieved.Text = "";

            //Manipulate Order ID
            txtOrderID.Text = getOrderID().ToString(); ;

            //Clear Menu Grid View
            dgvMenu.DataSource = null;

            //Clear Order Menu Item List
            OrderMenuItem.Clear();

            btnClearAll.Enabled = false;
            btnCalc.Enabled = true;
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}