namespace POSDemo
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            chbShowPass = new CheckBox();
            chkRememberMe = new CheckBox();
            pbOpenEye = new PictureBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            pbClose_Eye = new PictureBox();
            label1 = new Label();
            tbUserName = new TextBox();
            tbpassw = new TextBox();
            btlogin = new Button();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            contextMenuStripEx1 = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            ((System.ComponentModel.ISupportInitialize)pbOpenEye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbClose_Eye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // chbShowPass
            // 
            chbShowPass.AutoSize = true;
            chbShowPass.BackColor = Color.Transparent;
            chbShowPass.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chbShowPass.Location = new Point(41, 204);
            chbShowPass.Name = "chbShowPass";
            chbShowPass.Size = new Size(101, 24);
            chbShowPass.TabIndex = 34;
            chbShowPass.Text = "Show Pass";
            chbShowPass.UseVisualStyleBackColor = false;
            chbShowPass.CheckedChanged += chbShowPass_CheckedChanged;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.BackColor = Color.Transparent;
            chkRememberMe.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkRememberMe.Location = new Point(181, 204);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(131, 24);
            chkRememberMe.TabIndex = 33;
            chkRememberMe.Text = "Remember Me";
            chkRememberMe.UseVisualStyleBackColor = false;
            // 
            // pbOpenEye
            // 
            pbOpenEye.Image = (Image)resources.GetObject("pbOpenEye.Image");
            pbOpenEye.Location = new Point(153, 142);
            pbOpenEye.Margin = new Padding(4, 3, 4, 3);
            pbOpenEye.Name = "pbOpenEye";
            pbOpenEye.Size = new Size(33, 23);
            pbOpenEye.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOpenEye.TabIndex = 32;
            pbOpenEye.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 140);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 17);
            label2.TabIndex = 31;
            label2.Text = "password : ";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(153, 53);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            // 
            // pbClose_Eye
            // 
            pbClose_Eye.Image = (Image)resources.GetObject("pbClose_Eye.Image");
            pbClose_Eye.Location = new Point(153, 142);
            pbClose_Eye.Margin = new Padding(4, 3, 4, 3);
            pbClose_Eye.Name = "pbClose_Eye";
            pbClose_Eye.Size = new Size(33, 23);
            pbClose_Eye.SizeMode = PictureBoxSizeMode.StretchImage;
            pbClose_Eye.TabIndex = 29;
            pbClose_Eye.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 68);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 17);
            label1.TabIndex = 28;
            label1.Text = "User Name :";
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(41, 90);
            tbUserName.Margin = new Padding(4, 3, 4, 3);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(183, 23);
            tbUserName.TabIndex = 27;
            // 
            // tbpassw
            // 
            tbpassw.Location = new Point(41, 171);
            tbpassw.Margin = new Padding(4, 3, 4, 3);
            tbpassw.Name = "tbpassw";
            tbpassw.Size = new Size(183, 23);
            tbpassw.TabIndex = 35;
            tbpassw.TextChanged += tbpassw_TextChanged;
            // 
            // btlogin
            // 
            btlogin.BackColor = Color.Fuchsia;
            btlogin.BackgroundImageLayout = ImageLayout.Stretch;
            btlogin.Location = new Point(113, 265);
            btlogin.Name = "btlogin";
            btlogin.Size = new Size(95, 36);
            btlogin.TabIndex = 36;
            btlogin.Text = "Login";
            btlogin.UseVisualStyleBackColor = false;
            btlogin.Click += btlogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(371, 3);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // contextMenuStripEx1
            // 
            contextMenuStripEx1.MetroColor = Color.FromArgb(204, 236, 249);
            contextMenuStripEx1.Name = "contextMenuStripEx1";
            contextMenuStripEx1.Size = new Size(61, 4);
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(408, 313);
            Controls.Add(pictureBox1);
            Controls.Add(btlogin);
            Controls.Add(tbpassw);
            Controls.Add(chbShowPass);
            Controls.Add(chkRememberMe);
            Controls.Add(pbOpenEye);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pbClose_Eye);
            Controls.Add(label1);
            Controls.Add(tbUserName);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pbOpenEye).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbClose_Eye).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chbShowPass;
        private CheckBox chkRememberMe;
        private PictureBox pbOpenEye;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pbClose_Eye;
        private Label label1;
        private TextBox tbUserName;
        private TextBox tbpassw;
        private Button btlogin;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx contextMenuStripEx1;
    }
}
