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

namespace POSDemo.Screens.Customer
{
    public partial class frmAddNewCusomer : Form
    {
        public frmAddNewCusomer()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btClose_Click(object sender, EventArgs e)
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
        private void frmAddNewCusomer_Load(object sender, EventArgs e)
        {

        }

        private void ValidateEmptyTextBoxAndIsNumber(object sender, EventArgs e)
        {

        }

        private void tbEmail_Validated(object sender, EventArgs e)
        {

        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            //validate email format
            if (!clsValidatoin.ValidateEmail(tbEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(tbEmail, null);
            };
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            try
            {
                using (AppDbContext context = new AppDbContext())
                {
                    if (context.Custmers.Any(s => s.Phone == Phone.Text && s.Name == tbName.Text))
                    {
                        MessageBox.Show("this Custmer is exthist", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Custmer custmer = new Custmer
                    {
                        Phone = Phone.Text,
                        Name  = tbName.Text,
                        Address = tbAddress.Text,
                        Company = tbCompany.Text,
                        Note    = tbNote.Text,
                        Image   = clsGlobal.GetPhoto(pbPersonImage),
                        Email   = tbEmail.Text,
                        IsActive= ChbisActive.Checked
                    };


                    context.Custmers.Add(custmer);
                    context.SaveChanges();
                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
