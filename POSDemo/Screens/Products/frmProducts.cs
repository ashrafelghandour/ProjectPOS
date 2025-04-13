
using System.ComponentModel;
using System.Data;
using Microsoft.EntityFrameworkCore;
using POSDemo.Data;



namespace POSDemo.Screens
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void _loadData()
        {


            using (AppDbContext dbContext = new AppDbContext())
            {

                var re = new AppDbContext().Productclassifications;
                foreach (var item in re) {
                     
                    comboBox1.Items.Add(item.Categoryname);
                    comboBox2.Items.Add(item.Categoryname);
                }

                dataGridView1.DataSource = dbContext.Products.ToArray();

            }


        }
        private void frmProducts_Load(object sender, EventArgs e)
        {
            _loadData();
            cbFilterBy.TabIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
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



        private void txtFilterValue_TextChanged_1(object sender, EventArgs e)
        {
            using (AppDbContext dbContext = new AppDbContext())
            {
                try
                {

                    if (cbFilterBy.Text == "Phone")
                    {
                        dataGridView1.DataSource = dbContext.Products.Where(p => p.Name.Contains(txtFilterValue.Text)).ToList();


                    }
                    else if (cbFilterBy.Text == "Name")
                    {

                        dataGridView1.DataSource = dbContext.Products.Where(p => p.Name.Contains(txtFilterValue.Text)).ToList();

                    }
                }
                catch
                {

                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                using (AppDbContext dbContext = new AppDbContext())
                {
                    int productid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                    Entites.Product? product = dbContext.Products.Include(p => p.ClassesProductNavigation).SingleOrDefault(p => p.Id == productid);

             //       comboBox1.Text = new AppDbContext().Productclassifications.SingleOrDefault(p=> p.);


                    if (product != null)
                    {
                        tbBarcode.Text = product.Code.ToString();
                        tbNamePtod.Text = product.Name;
                        tbNote.Text = product.Note;
                        tbPrice.Text = product.Price.ToString();
                        tbquantity.Text = product.Quantity.ToString();
                        comboBox1.Text = product.ClassesProductNavigation.Categoryname;
                        if (product.Image != null)
                        {
                            MemoryStream stream = new MemoryStream(product.Image!);
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
                    int productid = Convert.ToInt32(dataGridView1.CurrentRow!.Cells[0].Value);

                    Entites.Product? product = context.Products.SingleOrDefault(p => p.Id == productid);


                    product.Code = Convert.ToInt32(tbBarcode.Text);
                    product.Name = tbNamePtod.Text;
                    product.Price = Convert.ToDecimal(tbPrice.Text);
                    product.Quantity = Convert.ToInt32(tbquantity.Text);
                    product.Note = tbNote.Text;

                    product.Image = clsGlobal.GetPhoto(pbPersonImage);




                    context.SaveChanges();
                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dataGridView1.DataSource = context.Products.ToArray();

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

                        var prod = context.Products.SingleOrDefault(p => p.Id == productid);

                        context.Products.Remove(prod!);

                        context.SaveChanges();
                        MessageBox.Show("Data Deleted Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridView1.DataSource = context.Products.ToArray();

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
            frmAddProduct frmAddProduct
                = new frmAddProduct();
            frmAddProduct.ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new AppDbContext().Products.Include(p=> p.ClassesProductNavigation).Where(p => p.ClassesProductNavigation.Categoryname == comboBox2.Text).ToList();

        }
    }
}

