using System;
using POSDemo.Screens;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Syncfusion.Windows.Forms;
using POSDemo.Data;
using POSDemo.Entites;

namespace POSDemo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }




        private void Login_Load(object sender, EventArgs e)
        {

            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                tbUserName.Text = UserName;

                tbpassw.Text = Password;
                chkRememberMe.Checked = true;

            }
            else
                chkRememberMe.Checked = false;

            pbOpenEye.Visible = false;
            pbClose_Eye.Visible = true;

            tbpassw.PasswordChar = '*';


        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {

                this.Opacity -= 0.05;
            }
            else
            {
                this.Close();
            }
        }

        private void chbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPass.Checked)
            {

                pbOpenEye.Visible = true;
                pbClose_Eye.Visible = false;
                //   tbpassw.PasswordChar =  ;



            }
            else
            {
                pbOpenEye.Visible = false;
                pbClose_Eye.Visible = true;
                tbpassw.PasswordChar = '*';
            }
        }

        private bool _Login()
        {


            var HashPass = clsGlobal.ComputeHash(tbpassw.Text.Trim());
            try
            {
                using (AppDbContext dbContext = new AppDbContext())
                {






                    User? cruntuser = dbContext.Users.FirstOrDefault(u => u.UserName == tbUserName.Text.Trim() && u.Password == HashPass);


                    if (cruntuser != null)
                    {

                        if (chkRememberMe.Checked)
                        {
                            //store username and password
                            clsGlobal.RememberUsernameAndPassword(tbUserName.Text.Trim(), tbpassw.Text.Trim());

                        }
                        else
                        {
                            //store empty username and password
                            clsGlobal.RememberUsernameAndPassword("", "");

                        }



                        clsGlobal.CurrentUser = cruntuser;
                        this.Hide();
                        MainForm mainForm = new MainForm();
                        mainForm.ShowDialog();


                    }
                    else
                    {
                        tbUserName.Focus();
                        MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                }

            }
            catch
            {
                return false;
            }

            return false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure to Close Programm ?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                timer1.Start();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUserName.Text) || string.IsNullOrEmpty(tbpassw.Text))
            {
                MessageBox.Show("Please enter your username and passwored !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            while (_Login())
                this.Close();
        }

        private void tbpassw_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
