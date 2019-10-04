using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmSelection : Form
    {
        public FrmSelection()
        {
            InitializeComponent();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu f = new FrmMenu();
            f.ShowDialog();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            FrmLogIn f = new FrmLogIn();
            f.Show();
            this.Hide();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegister ob = new FrmRegister();
            ob.Show();
        }        

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
