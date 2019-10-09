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
        public DataLayer dll = new DataLayer();
        #region User Defined Datas
        int SN = 1;
        class MenuItem
        {
            public int sn;
            public int itemID;
            public string itemName;
            public int quantity;
            public int rate;
        }

        private List<MenuItem> OrderMenuItem = new List<MenuItem>();

        #endregion

        #region System Generated Functions
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            FillGridView("");
            txtOrderID.Text = GetOrderID().ToString();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            FillGridView(txtSearch.Text);
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            //Read name and rate from database
            string viewQuery = "select ItemName,Rate from tblItem where ItemID=" + txtItemID.Text;
            DataTable dt = dll.DataReturn(viewQuery);
            //Exit if ItemID not Present
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("ItemID not Present");
            }
            else
            {
                // Create menuItem to add to data grid
                MenuItem item = new MenuItem
                {
                    sn = SN,
                    itemID = int.Parse(txtItemID.Text),
                    itemName = dt.Rows[0]["ItemName"].ToString(),
                    quantity = int.Parse(txtQuantity.Text),
                    rate = int.Parse(dt.Rows[0]["Rate"].ToString()),

                };

                //Add item to OderMenuItem
                OrderMenuItem.Add(item);

                //Bind to Grid View
                dgvMenu.DataSource = CreateDataTableForOrderList(OrderMenuItem);

                //Updating Total amount
                int Total = int.Parse(txtTotal.Text);
                Total += item.rate * item.quantity;
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
        private void FillGridView(string searchText)
        {
            string viewQuery = "select ItemID,ItemName,Rate,ItemType,Description from tblItem join tblItemType on tblItem.ItemTypeID=tblItemType.ItemTypeID and ItemName like '%" + searchText + "%'";
            //Fill data grid view with data table
            dgvItem.DataSource = dll.DataReturn(viewQuery);
        }
        private int GetOrderID()
        {
            string orderQuery = "Select max(OrderID) From tblOrder";
            DataTable dt = dll.DataReturn(orderQuery);
            // Get Order ID From Table
            if (dt.Rows[0][0].ToString() == "")
                return 1;
            else
                return (int.Parse(dt.Rows[0][0].ToString()) + 1);
        }

        DataTable CreateDataTableForOrderList(List<MenuItem> orderItems)
        {
            DataTable orderTable = CreateDataTableSchemaForOrderList();
            foreach (MenuItem item in orderItems)
            {
                orderTable.Rows.Add(item.sn, item.itemID, item.itemName, item.quantity, item.rate);
            }
            return orderTable;
        }

        DataTable CreateDataTableSchemaForOrderList()
        {
            DataTable orderTable = new DataTable();
            orderTable.Columns.Add("SN");
            orderTable.Columns.Add("ItemID");
            orderTable.Columns.Add("ItemName");
            orderTable.Columns.Add("Quantity");
            orderTable.Columns.Add("Rate");

            return orderTable;
        }

        void InsertMenuItemsToDatabase(List<MenuItem> orderItems)
        {
            string insertQuery = string.Empty;
            //Iterate on Order Items
            foreach (MenuItem menu in orderItems)
            {
                insertQuery = insertQuery + "Insert into tblOrder values('" + txtOrderID.Text + "','" + menu.itemID + "','" + menu.quantity + "','" + menu.rate + "','" + DateTime.Now + "')\n";
            }
            dll.DbConn(insertQuery);
        }
        #endregion

        private void Button1_Click(object sender, EventArgs e)
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
            else if (int.Parse(txtRecieved.Text) < int.Parse(txtTotal.Text))
            {
                MessageBox.Show("Received Amount should be Greater than Total Bill Amount");
                txtRecieved.Focus();
            }
            else
            {
                int amount = int.Parse(txtRecieved.Text) - int.Parse(txtTotal.Text);
                txtReturn.Text = amount.ToString();
                InsertMenuItemsToDatabase(OrderMenuItem);
                MessageBox.Show("Item Insert to Database Succssfully");

                btnClearAll.Enabled = true;
                btnCalc.Enabled = false;
            }
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            DeleteAllTextBox();
            txtTotal.Text = "0";
            txtReturn.Text = "";
            txtRecieved.Text = "";

            //Manipulate Order ID
            txtOrderID.Text = GetOrderID().ToString(); ;

            //Clear Menu Grid View
            dgvMenu.DataSource = null;

            //Clear Order Menu Item List
            OrderMenuItem.Clear();

            btnClearAll.Enabled = false;
            btnCalc.Enabled = true;
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void TabControl1_Click(object sender, EventArgs e)
        {
            DataTable dt = dgvMenu.DataSource as DataTable;
            int i = 0;
            txtReceipt.Text += Environment.NewLine;
            foreach (var row in dt.Rows)
            {
                txtReceipt.Text += dt.Rows[i]["ItemName"].ToString() + "  |  " + dt.Rows[i]["Quantity"].ToString() + "  |  " + dt.Rows[i]["Rate"].ToString() + Environment.NewLine;
                i++;
            }
            label18.Text = txtTotal.Text;
            label19.Text = txtRecieved.Text;
            label20.Text = txtReturn.Text;
            label21.Text = DateTime.Now.ToString();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}