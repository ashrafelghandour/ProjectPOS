using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSDemo.Screens.Customer;

namespace POSDemo.Screens
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void acountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addProduictToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddProduct frm = new frmAddProduct();
            frm.ShowDialog();

        }

        private void editProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducts frmProducts = new frmProducts();
            frmProducts.ShowDialog();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewCusomer frmAddNewCusomer = new frmAddNewCusomer();
            frmAddNewCusomer.ShowDialog();
        }

        private void listCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer();
            frmCustomer.ShowDialog();
        }
    }
}
