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

namespace POSDemo
{
    public partial class frmAccountSettings : Form
    {
        public frmAccountSettings()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmAccountSettings_Load(object sender, EventArgs e)
        {
            tbUserName.Text = clsGlobal.CurrentUser.UserName.ToString();


            if (clsGlobal.CurrentUser.Image != null) {
                MemoryStream memoryStream = new MemoryStream(clsGlobal.CurrentUser.Image);
                
                pbPersonImage.Image = Image.FromStream(memoryStream);
            
            
            }
            
            
           
        }
    }
}
