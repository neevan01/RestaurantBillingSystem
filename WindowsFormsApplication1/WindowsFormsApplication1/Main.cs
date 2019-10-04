using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        //btn_LogOut Click Event
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main fl = new Main();
            fl.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Main_MouseEnter(object sender, EventArgs e)
        {

        }

        private void addCategeoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void addItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmAddItems ob = new frmAddItems();
            //ob.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
        }


        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addItemTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddItemType f = new FrmAddItemType();
            f.ShowDialog();
            
        }

        private void viewItemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmViewItemType f = new FrmViewItemType();
            f.ShowDialog();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void deleteItemTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeleteItemType f = new FrmDeleteItemType();
            f.ShowDialog();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddItem f = new FrmAddItem();
            f.ShowDialog();

        }

        private void viewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViewItem f = new FrmViewItem();
            f.ShowDialog();

        }

        private void editItemTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditItemType f = new FrmEditItemType();
            f.ShowDialog();
        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmEditItem f = new FrmEditItem();
            f.ShowDialog();
        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeleteItem f = new FrmDeleteItem();
            f.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSelection ob = new FrmSelection();
            ob.Show();
        }

        private void billingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenu f = new FrmMenu();
            f.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}

