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
using POSDemo.Properties;
using POSDemo.Screens.Seles;

namespace POSDemo.Screens
{
    public partial class frmSelesBill : Form
    {

        public frmSelesBill()
        {
            InitializeComponent();

            tbDiscout.Text = 0.ToString();
        }
        decimal disc = 0;
        decimal _totalprice = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSelesBill_Load(object sender, EventArgs e)
        {
            try
            {
                int index = 0;

                using (AppDbContext context = new AppDbContext())
                {

                    comboBox1.DataSource = context.Custmers.Where(c => c.IsActive == true).ToList();

                    comboBox1.DisplayMember = "Name";
                    comboBox1.ValueMember = "ID";
                    comboBox1.SelectedValue = "ID";


                    List<Entites.Product> products = context.Products.ToList();

                    foreach (var product in products)
                    {

                        if (product.Image != null)
                        {

                            MemoryStream stream = new MemoryStream(product.Image!);

                            imageList1.Images.Add(Image.FromStream(stream));

                            stream.Dispose();

                        }
                        else
                        {
                            Bitmap bitmap = new Bitmap(70, 70);
                            imageList1.Images.Add(bitmap);
                        }


                        ListViewItem Item = new ListViewItem();

                        Item.Text = product.Name;
                        Item.ImageIndex = index++;
                        Item.Tag = product;

                        listView1.Items.Add(Item);

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {


            if (listView1.SelectedItems.Count > 0)
            {

                var product = (Entites.Product)listView1.SelectedItems[0].Tag;
                _totalprice += product.Price;
                disc = decimal.Parse(tbDiscout.Text);
                ttTotalafterdiscount.Text = (_totalprice - disc).ToString();

                llTotalprice.Text = _totalprice.ToString();

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    var rrr = dataGridView1.Rows[i].Cells["id"].Value ?? 0;

                    if (rrr.ToString() == product.Id.ToString())
                    {


                        var quntity = (int)dataGridView1.Rows[i].Cells["Quntity"].Value;
                        dataGridView1.Rows[i].Cells["Quntity"].Value = ++quntity;
                        dataGridView1.Rows[i].Cells["totalprice"].Value = product.Price * quntity;

                        return;
                    }

                }


                Image image;
                if (product.Image != null)
                {

                    image = Image.FromStream(new MemoryStream(product.Image));
                }
                else
                {
                    image = Resources.Close_64;
                }



                dataGridView1.Rows.Add(product.Id, product.Name, image, product.Price, (product.Price * 1), 1);



            }
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

                using (AppDbContext dbContext = new AppDbContext())
                {




                    POSDemo.Entites.SelesBill billDetills = new Entites.SelesBill
                    {
                        UserId = clsGlobal.CurrentUser.Id,
                        Notes = tbNote.Text,
                        TotalPrice = _totalprice
                        ,
                        TotalAfterDiscount = decimal.Parse(ttTotalafterdiscount.Text),
                        Discount = decimal.Parse(tbDiscout.Text),
                        Date = DateOnly.Parse(dateTimePicker1.Text),
                        CustomerId = int.Parse(comboBox1.SelectedValue.ToString()),



                    };

                    dbContext.SelesBills.Add(billDetills);




                    List<POSDemo.Entites.SelesBillDetill> BillDetill = new List<Entites.SelesBillDetill>();
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {

                        BillDetill.Add(new Entites.SelesBillDetill
                        {
                            PruductId = int.Parse(dataGridView1.Rows[i].Cells["id"].Value.ToString()),
                            Quntity = int.Parse(dataGridView1.Rows[i].Cells["Quntity"].Value.ToString()),
                            TotalPrice = decimal.Parse(dataGridView1.Rows[i].Cells["totalprice"].Value.ToString()),
                            Name = dataGridView1.Rows[i].Cells["Name"].Value.ToString(),
                            Price = decimal.Parse(dataGridView1.Rows[i].Cells["price"].Value.ToString())



                        });

                    }
                    billDetills.SelesBillDetills = BillDetill;


                    dbContext.SaveChanges();
                    tbBillid.Text = billDetills.BillId.ToString();
                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




        }

        private void tbDiscout_TextChanged(object sender, EventArgs e)
        {

            // disc = decimal.Parse(tbDiscout.Text);

            //  ttTotalafterdiscount.Text =(_totalprice - disc).ToString();
            if (string.IsNullOrEmpty(tbDiscout.Text))
                disc = 0;
            else
            {
                disc = decimal.Parse(tbDiscout.Text);

            }

            ttTotalafterdiscount.Text = (_totalprice - disc).ToString();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            _totalprice = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {

                _totalprice += decimal.Parse(dataGridView1.Rows[i].Cells["totalprice"].Value.ToString());


            }
            llTotalprice.Text = _totalprice.ToString();
            ttTotalafterdiscount.Text = (_totalprice - disc).ToString();

        }

        private void btallbills_Click(object sender, EventArgs e)
        {
            frmSelesBills frmSelesBills = new frmSelesBills();
            frmSelesBills.ShowDialog();
        }
    }

}
