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
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        static string connectionString = "Data Source=NEEVAN; Initial Catalog=Test; Integrated Security=True";
        SqlConnection Con = new SqlConnection(connectionString);

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string username, password, cpassword;
            username = TbUserName.Text;
            password = TbPw.Text;
            cpassword = TbCPw.Text;
            if (username == "" || password == "" || cpassword == "")
            {
                MessageBox.Show("All the data must be filled");
            }
            else if (password != cpassword)
            {
                MessageBox.Show("Mismatched Password \n Both Password must match!!!");
            }
            else
            {            
                string chkUser = "select * from TblUser where UserName='"+TbUserName+"'";
                SqlCommand cmd = new SqlCommand(chkUser, Con);
                //cmd.Parameters.AddWithValue("@un", TbUserName.Text);
                Con.Open();
                SqlDataReader data = cmd.ExecuteReader();
                if (data.HasRows)
                {
                    MessageBox.Show("UserName already Exist");
                    TbCPw.Clear();
                    TbPw.Clear();
                    TbUserName.Clear();                   
                }
                else
                {
                    Con.Close();
                    string insertQuery = "Insert into TblUser values('" + username + "','" + password + "')";
                    SqlCommand cmd1 = new SqlCommand(insertQuery, Con);
                    Con.Open();
                    cmd1.ExecuteNonQuery();                    
                    MessageBox.Show("ID registered successfully");                   
                    Hide();
                    FrmLogIn obj = new FrmLogIn();
                    obj.Show();
                }
                Con.Close();
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            FrmLogIn obj = new FrmLogIn();
            obj.Show();
        }
    }
}



