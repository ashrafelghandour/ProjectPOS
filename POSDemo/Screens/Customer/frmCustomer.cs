using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using POSDemo.DB.Data;
using POSDemo.DB.Entites;
using Syncfusion.XlsIO.Implementation.Security;

namespace POSDemo.Screens.Customer
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
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

                            dataGridView1.DataSource = dbContext.Custmers.Where(p => p.Phone.Contains(txtFilterValue.Text)).ToList();
                        }
                    }
                    else if (cbFilterBy.Text == "Name")
                    {

                        dataGridView1.DataSource = dbContext.Custmers.Where(p => p.Name.Contains(txtFilterValue.Text)).ToList();

                    }
                }
                catch
                {

                }

            }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            using (AppDbContext dbContext = new AppDbContext())
            {
                dataGridView1.DataSource = dbContext.Custmers.ToList();


            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                using (AppDbContext dbContext = new AppDbContext())
                {
                    int? custmerid = Convert.ToInt32(dataGridView1.CurrentRow!.Cells[0].Value);
                    if (custmerid == 0 || custmerid == null)
                    {
                        return;
                    }
                    Custmer? custmer = dbContext.Custmers.SingleOrDefault(p => p.Id == custmerid);


                    if (custmer != null)
                    {
                        tbName.Text = custmer!.Name!.ToString();
                        Phone.Text = custmer.Phone!.ToString();
                        tbNote.Text = custmer.Note!.ToString();
                        tbCompany.Text = custmer?.Company!.ToString();
                        tbAddress.Text = custmer?.Address!.ToString();
                        tbEmail.Text = custmer!.Email!.ToString();
                        ChbisActive.Checked = (custmer.IsActive == null) ? false : (custmer.IsActive == true) ? true : false;
                        if (custmer.Image != null)
                        {
                            MemoryStream stream = new MemoryStream(custmer.Image!);
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (AppDbContext context = new AppDbContext())
                {

                    int custmerid = Convert.ToInt32(dataGridView1.CurrentRow!.Cells[0].Value);

                    Custmer? custmer = context.Custmers.SingleOrDefault(p => p.Id == custmerid);


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
                        int productid = Convert.ToInt32(dataGridView1.CurrentRow!.Cells[0].Value);

                        var prod = context.Custmers.SingleOrDefault(p => p.Id == productid);

                        context.Custmers.Remove(prod!);

                        context.SaveChanges();
                        MessageBox.Show("Data Deleted Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridView1.DataSource = context.Custmers.ToArray();

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: Data Is not Deleted Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAddNewCusomer frmAddNewCusomer = new frmAddNewCusomer();
            frmAddNewCusomer.ShowDialog();
            dataGridView1.DataSource = new AppDbContext().Custmers.ToList();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
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
