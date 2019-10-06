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
        public DataLayer dll = new DataLayer();
        public FrmViewItemType()
        {
            InitializeComponent();
        }       

        private void FrmViewItemType_Load_1(object sender, EventArgs e)
        {
            FillGridView();
        }

        private void FillGridView()
        {           
            string viewQuery = "Select * From tblItemType";          
            //Fill data grid view with data table
            dgvViewItemType.DataSource =dll.DataReturn(viewQuery) ;
        }

    }

}