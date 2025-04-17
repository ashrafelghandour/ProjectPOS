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
using POSDemo.Screens.Seles;
using POSDemo.Screens.Suplier;
using POSDemo.Scren;

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

        private void listSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupplier frmSupplier = new frmSupplier();
            frmSupplier.ShowDialog();
        }

        private void addNewSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewSupplier form = new frmAddNewSupplier();
            form.ShowDialog();

        }

        private void newBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSelesBill frm = new frmSelesBill();
            frm.ShowDialog();
        }

        private void allBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSelesBills frm = new frmSelesBills();
            frm.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.ShowDialog();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewUser frmNewUser = new frmNewUser();
            frmNewUser.ShowDialog();
        }
    }
}
