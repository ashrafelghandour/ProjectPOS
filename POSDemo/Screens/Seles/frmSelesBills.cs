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
using Microsoft.EntityFrameworkCore;
using POSDemo.Data;

namespace POSDemo.Screens.Seles
{
    public partial class frmSelesBills : Form
    {
        public frmSelesBills()
        {
            InitializeComponent();
        }

        private void frmSelesBills_Load(object sender, EventArgs e)
        {
            using (AppDbContext dbContext = new AppDbContext())
            {

                dataGridView2.DataSource = dbContext.SelesBills.Select(a => new { a.BillId, a.TotalAfterDiscount, a.User.UserName, a.Date }).ToList();

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            using (AppDbContext dbContext = new AppDbContext())
            {


                int billid = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());

                var bill = dbContext.SelesBills.Include(a => a.Customer).Include(b => b.SelesBillDetills).ThenInclude(b => b.Pruduct).FirstOrDefault(a => a.BillId == billid);

                tbBillid.Text = billid.ToString();

                tbNote.Text = bill.Notes;
                dateTimePicker1.Text = bill.Date.ToString();
                comboBox1.Text = bill.Customer.Name.ToString();
                llTotalprice.Text = bill.TotalPrice.ToString();
                tbDiscout.Text = bill.TotalAfterDiscount.ToString();
                tbDiscout.Text = bill.Discount.ToString();


                dataGridView1.Rows.Clear();
                foreach (var row in bill.SelesBillDetills)
                {

                    if (row.Pruduct.Image != null)
                    {
                        MemoryStream memoryStream = new MemoryStream(row.Pruduct.Image);
                        dataGridView1.Rows.Add(row.Id, row.Name, Image.FromStream(memoryStream), row.Price, row.TotalPrice, row.Quntity);


                    }
                    else
                    {
                        Bitmap bitmap = new Bitmap(20, 200);


                        dataGridView1.Rows.Add(row.Id, row.Name, bitmap, row.Price, row.TotalPrice);

                    }
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
