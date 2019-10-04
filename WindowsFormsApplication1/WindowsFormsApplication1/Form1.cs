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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Hide();
            Main ss = new Main();
            ss.Show();             
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
