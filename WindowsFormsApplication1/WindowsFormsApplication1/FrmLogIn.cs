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
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["DemoC"].ToString();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "Select * From tblUser Where UserName='" + txtUsername.Text + "' and Password='" + txtPassword.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Insert Username or Password");
            }
            else if (dt.Rows.Count > 0)
            {
                Main f = new Main();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User Name or Password Incorrect");
            }
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Hide();
            FrmSelection obj = new FrmSelection();
            obj.Show();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
