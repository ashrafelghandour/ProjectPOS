using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSDemo.Data;
using POSDemo.Entites;

namespace POSDemo.Screens.Suplier
{
    public partial class frmSupplier : Form
    {
        public frmSupplier()
        {
            InitializeComponent();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            using (AppDbContext dbContext = new AppDbContext())
            {
                dataGridView1.DataSource = dbContext.Suppliers.ToList();


            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtFilterValue.Visible = (cbFilterBy.Text != "None");


            if (cbFilterBy.Text == "None")
            {
                txtFilterValue.Enabled = false;
            }
            else
                txtFilterValue.Enabled = true;

            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {

            using (AppDbContext dbContext = new AppDbContext())
            {
                try
                {

                    if (cbFilterBy.Text == "Barcode")
                    {

                        if (int.TryParse(txtFilterValue.Text, out int code))
                        {

                            dataGridView1.DataSource = dbContext.Suppliers.Where(p => p.Phone.Contains(txtFilterValue.Text)).ToList();
                        }
                    }
                    else if (cbFilterBy.Text == "Name")
                    {

                        dataGridView1.DataSource = dbContext.Suppliers.Where(p => p.Name.Contains(txtFilterValue.Text)).ToList();

                    }
                }
                catch
                {

                }

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                using (AppDbContext dbContext = new AppDbContext())
                {
                    int? Suppliersid = Convert.ToInt32(dataGridView1.CurrentRow!.Cells[0].Value);
                    if (Suppliersid == 0 || Suppliersid == null)
                    {
                        return;
                    }
                    Supplier? supplier = dbContext.Suppliers.SingleOrDefault(s => s.Id == Suppliersid);


                    if (supplier != null)
                    {
                        tbName.Text = supplier!.Name!.ToString();
                        Phone.Text = supplier.Phone!.ToString();
                        tbNote.Text = supplier.Note!.ToString();
                        tbCompany.Text = supplier?.Company!.ToString();
                        tbAddress.Text = supplier?.Address!.ToString();
                        tbEmail.Text = supplier!.Email!.ToString();
                        ChbisActive.Checked = (supplier.IsActive == null) ? false : (supplier.IsActive == true) ? true : false;
                        if (supplier.Image != null)
                        {
                            MemoryStream stream = new MemoryStream(supplier.Image!);
                            pbPersonImage.Image = Image.FromStream(stream);
                        }
                        else
                        {
                            pbPersonImage.Image = null;
                        }



                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                frmAddNewSupplier frmAddNewCusomer = new frmAddNewSupplier();
                frmAddNewCusomer.ShowDialog();
                dataGridView1.DataSource = new AppDbContext().Suppliers.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                using (AppDbContext context = new AppDbContext())
                {

                    int Supplierid = Convert.ToInt32(dataGridView1.CurrentRow!.Cells[0].Value);

                    Supplier? custmer = context.Suppliers.SingleOrDefault(p => p.Id == Supplierid);


                    custmer!.Name = tbName.Text;
                    custmer.Company = tbCompany.Text;
                    custmer.Email = tbEmail.Text;
                    custmer.Address = tbAddress.Text;
                    custmer.Note = tbNote.Text;
                    custmer.IsActive = ChbisActive.Checked;
                    custmer.Phone = Phone.Text;

                    custmer.Image = clsGlobal.GetPhoto(pbPersonImage);




                    context.SaveChanges();
                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dataGridView1.DataSource = context.Custmers.ToList();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                var result = MessageBox.Show("you need delete Product", "Delete", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {

                    using (AppDbContext context = new AppDbContext())
                    {
                        var Currentreow = dataGridView1.CurrentRow.Cells[0].Value!;
                        int? supplierid = Convert.ToInt32(Currentreow == null ? 0 : Currentreow);
                        var prod = context.Suppliers.SingleOrDefault(p => p.Id == supplierid);

                        context.Suppliers.Remove(prod!);

                        context.SaveChanges();
                        MessageBox.Show("Data Deleted Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridView1.DataSource = context.Suppliers.ToArray();

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: Data Is not Deleted Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pbPersonImage.ImageLocation = selectedFilePath;
                pbPersonImage.Image = Image.FromFile(openFileDialog1.FileName);
                // ...
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;
            pbPersonImage.Image = null;
        }
    }
}
