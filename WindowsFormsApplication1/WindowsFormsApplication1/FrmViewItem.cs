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
        public DataLayer dll = new DataLayer();
        public FrmViewItem()
        {
            InitializeComponent();
        }
        private void FrmViewItemType_Load(object sender, EventArgs e)
        {
            FillGridView();
        }

        private void FillGridView()
        {
            string viewQuery = "select ItemID,ItemType,ItemName,Description,Rate from tblItem join tblItemType on tblItem.ItemTypeID=tblItemType.ItemTypeID";          
            //Fill data grid view with data table
            dgvItem.DataSource = dll.DataReturn(viewQuery);
        }

      

        private void dvgItem_MouseClick(object sender, MouseEventArgs e)
        {
            Form f = new Form();
            f.ShowDialog();
        }
    }
}
