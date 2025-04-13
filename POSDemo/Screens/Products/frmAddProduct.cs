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
using POSDemo.Properties;

namespace POSDemo.Screens
{
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
            pbPersonImage.Image = null;
        }

        private void pbPersonImage_Click(object sender, EventArgs e)
        {

        }
        private void ValidateEmptyTextBoxAndIsNumber(object sender, CancelEventArgs e)
        {
            TextBox Temp = ((TextBox)sender);

            if (!clsValidatoin.IsNumber(Temp.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required Numbers!");
            }


            else if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }
        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            TextBox Temp = ((TextBox)sender);

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }
        private void frmProduct_Load(object sender, EventArgs e)
        {
            // comboBox1.DataSource =  new AppDbContext().Productclassifications.Select(a => new[]{ a.Categoryname});



            using (AppDbContext dbContext = new AppDbContext())
            {

                var re = new AppDbContext().Productclassifications;
                foreach (var item in re)
                {

                    comboBox1.Items.Add(item.Categoryname);
                }

                comboBox1.TabIndex = 0;

            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private byte[]? _GetPhoto()
        {


            if (pbPersonImage.Image != null)
            {
                MemoryStream stream = new MemoryStream();
                pbPersonImage.Image.Save(stream, pbPersonImage.Image.RawFormat);
                return stream.GetBuffer();
            }
            return null;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren() || string.IsNullOrEmpty(comboBox1.Text))
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            try
            {
                using (AppDbContext context = new AppDbContext())
                {

                    var rr = context.Productclassifications.SingleOrDefault(p => p.Categoryname == comboBox1.Text).Id;


                    Entites.Product product = new POSDemo.Entites.Product
                    {
                        Code = Convert.ToInt32(tbBarcode.Text),
                        Name = tbNamePtod.Text,
                        Price = Convert.ToInt32(tbPrice.Text),
                        Quantity = Convert.ToInt32(tbquantity.Text),
                        Note = tbNote.Text,
                        ClassesProduct = rr,
                         Image = _GetPhoto(),

                    };


                    context.Products.Add(product);
                    context.SaveChanges();
                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
