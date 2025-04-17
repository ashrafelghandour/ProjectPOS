using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSDemo.Data;
using POSDemo.Entites;
using POSDemo.Properties;
using Syncfusion.CompoundFile.XlsIO.Native;

namespace POSDemo.Scren
{
    public partial class frmNewUser : Form
    {
        public frmNewUser()
        {
            InitializeComponent();
            llRemoveImage.Visible = false;
            pbPersonImage.ImageLocation = null;
            pbPersonImage.Image = Resources.Female_512;
        }
        private byte[]? GetPhoto()
        {
            //    Resources.Female_512;



            if (pbPersonImage.ImageLocation != null)
            {
                MemoryStream stream = new MemoryStream();
                pbPersonImage.Image.Save(stream, pbPersonImage.Image.RawFormat);
                return stream.GetBuffer();
            }
            return null;
        }
        private void btSave_Click(object sender, EventArgs e)
        {



            if (tbUserName.Text != null && tbpassw.Text != null)
            {

                User newuser = new User
                {
                    Password = tbpassw.Text,
                    UserName = tbUserName.Text,
                    Image = GetPhoto()!
                };

                using (AppDbContext dbContext = new AppDbContext())
                {


                    dbContext.Users.Add(newuser);
                    dbContext.SaveChanges();

                }

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Some fileds are not valide!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;
            pbPersonImage.Image = Resources.Female_512;
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
                llRemoveImage.Visible = true;
                // ...
            }
        }

        private void frmNewUser_Load(object sender, EventArgs e)
        {

        }
    }
}
