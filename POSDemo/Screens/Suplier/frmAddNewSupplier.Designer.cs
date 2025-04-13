namespace POSDemo.Screens.Suplier
{
    partial class frmAddNewSupplier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewSupplier));
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ChbisActive = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            pictureBox10 = new PictureBox();
            tbCompany = new TextBox();
            label7 = new Label();
            llRemoveImage = new LinkLabel();
            llSetImage = new LinkLabel();
            pbPersonImage = new PictureBox();
            pictureBox6 = new PictureBox();
            tbNote = new TextBox();
            label6 = new Label();
            pictureBox5 = new PictureBox();
            tbEmail = new TextBox();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            tbAddress = new TextBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            Phone = new TextBox();
            label1 = new Label();
            label3 = new Label();
            tbName = new TextBox();
            pictureBox1 = new PictureBox();
            btClose = new Button();
            btSave = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChbisActive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ChbisActive
            // 
            ChbisActive.AccessibilityEnabled = true;
            ChbisActive.ForeColor = Color.White;
            ChbisActive.Location = new Point(301, 224);
            ChbisActive.Name = "ChbisActive";
            ChbisActive.Size = new Size(150, 21);
            ChbisActive.TabIndex = 263;
            ChbisActive.Text = "isActive";
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.Transparent;
            pictureBox10.Image = Properties.Resources._24120611;
            pictureBox10.Location = new Point(400, 84);
            pictureBox10.Margin = new Padding(4, 3, 4, 3);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(33, 28);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 262;
            pictureBox10.TabStop = false;
            // 
            // tbCompany
            // 
            tbCompany.Location = new Point(441, 89);
            tbCompany.Margin = new Padding(4, 3, 4, 3);
            tbCompany.Name = "tbCompany";
            tbCompany.Size = new Size(129, 23);
            tbCompany.TabIndex = 261;
            tbCompany.Validating += ValidateEmptyTextBox;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(301, 89);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(74, 17);
            label7.TabIndex = 260;
            label7.Text = "Company :";
            // 
            // llRemoveImage
            // 
            llRemoveImage.AutoSize = true;
            llRemoveImage.BackColor = Color.Transparent;
            llRemoveImage.Location = new Point(41, 354);
            llRemoveImage.Margin = new Padding(4, 0, 4, 0);
            llRemoveImage.Name = "llRemoveImage";
            llRemoveImage.Size = new Size(50, 15);
            llRemoveImage.TabIndex = 259;
            llRemoveImage.TabStop = true;
            llRemoveImage.Text = "Remove";
            llRemoveImage.LinkClicked += llRemoveImage_LinkClicked;
            // 
            // llSetImage
            // 
            llSetImage.AutoSize = true;
            llSetImage.BackColor = Color.Transparent;
            llSetImage.Location = new Point(2, 315);
            llSetImage.Margin = new Padding(4, 0, 4, 0);
            llSetImage.Name = "llSetImage";
            llSetImage.Size = new Size(59, 15);
            llSetImage.TabIndex = 258;
            llSetImage.TabStop = true;
            llSetImage.Text = "Set Image";
            llSetImage.LinkClicked += llSetImage_LinkClicked;
            // 
            // pbPersonImage
            // 
            pbPersonImage.BackColor = Color.Transparent;
            pbPersonImage.BackgroundImageLayout = ImageLayout.Zoom;
            pbPersonImage.BorderStyle = BorderStyle.Fixed3D;
            pbPersonImage.InitialImage = null;
            pbPersonImage.Location = new Point(151, 315);
            pbPersonImage.Margin = new Padding(5, 6, 5, 6);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(129, 76);
            pbPersonImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPersonImage.TabIndex = 257;
            pbPersonImage.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(397, 162);
            pictureBox6.Margin = new Padding(4, 3, 4, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(33, 28);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 256;
            pictureBox6.TabStop = false;
            // 
            // tbNote
            // 
            tbNote.Location = new Point(441, 161);
            tbNote.Margin = new Padding(4, 3, 4, 3);
            tbNote.Multiline = true;
            tbNote.Name = "tbNote";
            tbNote.Size = new Size(129, 57);
            tbNote.TabIndex = 255;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(301, 162);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(46, 17);
            label6.TabIndex = 254;
            label6.Text = "Note :";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.Email_32;
            pictureBox5.Location = new Point(107, 215);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(33, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 253;
            pictureBox5.TabStop = false;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(151, 214);
            tbEmail.Margin = new Padding(4, 3, 4, 3);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(129, 23);
            tbEmail.TabIndex = 252;
            tbEmail.Validating += tbEmail_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(2, 214);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(50, 17);
            label5.TabIndex = 251;
            label5.Text = "Email :";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.Address_32;
            pictureBox4.Location = new Point(107, 179);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(33, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 250;
            pictureBox4.TabStop = false;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(151, 178);
            tbAddress.Margin = new Padding(4, 3, 4, 3);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(129, 23);
            tbAddress.TabIndex = 249;
            tbAddress.Validating += ValidateEmptyTextBox;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(2, 178);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 17);
            label4.TabIndex = 248;
            label4.Text = "Address :";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Phone_32;
            pictureBox2.Location = new Point(107, 137);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 247;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.Man_32;
            pictureBox3.Location = new Point(107, 90);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 246;
            pictureBox3.TabStop = false;
            // 
            // Phone
            // 
            Phone.Location = new Point(151, 136);
            Phone.Margin = new Padding(4, 3, 4, 3);
            Phone.Name = "Phone";
            Phone.Size = new Size(129, 23);
            Phone.TabIndex = 245;
            Phone.Validating += ValidateEmptyTextBoxAndIsNumber;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(2, 142);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 17);
            label1.TabIndex = 244;
            label1.Text = "Phone : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(2, 93);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(52, 17);
            label3.TabIndex = 243;
            label3.Text = "Name :";
            // 
            // tbName
            // 
            tbName.Location = new Point(151, 90);
            tbName.Margin = new Padding(4, 3, 4, 3);
            tbName.Name = "tbName";
            tbName.Size = new Size(129, 23);
            tbName.TabIndex = 242;
            tbName.Validating += ValidateEmptyTextBox;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(591, -3);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 241;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btClose
            // 
            btClose.BackColor = Color.Transparent;
            btClose.Image = (Image)resources.GetObject("btClose.Image");
            btClose.Location = new Point(344, 337);
            btClose.Name = "btClose";
            btClose.Size = new Size(86, 32);
            btClose.TabIndex = 240;
            btClose.Text = "Back";
            btClose.TextAlign = ContentAlignment.MiddleRight;
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.BackColor = Color.Transparent;
            btSave.Image = (Image)resources.GetObject("btSave.Image");
            btSave.ImageAlign = ContentAlignment.MiddleLeft;
            btSave.Location = new Point(454, 337);
            btSave.Name = "btSave";
            btSave.Size = new Size(86, 32);
            btSave.TabIndex = 239;
            btSave.Text = "Save";
            btSave.TextAlign = ContentAlignment.MiddleRight;
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // frmAddNewSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dfg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(627, 399);
            Controls.Add(ChbisActive);
            Controls.Add(pictureBox10);
            Controls.Add(tbCompany);
            Controls.Add(label7);
            Controls.Add(llRemoveImage);
            Controls.Add(llSetImage);
            Controls.Add(pbPersonImage);
            Controls.Add(pictureBox6);
            Controls.Add(tbNote);
            Controls.Add(label6);
            Controls.Add(pictureBox5);
            Controls.Add(tbEmail);
            Controls.Add(label5);
            Controls.Add(pictureBox4);
            Controls.Add(tbAddress);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(Phone);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(tbName);
            Controls.Add(pictureBox1);
            Controls.Add(btClose);
            Controls.Add(btSave);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Name = "frmAddNewSupplier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddNewSupplier";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChbisActive).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv ChbisActive;
        private PictureBox pictureBox10;
        private TextBox tbCompany;
        private Label label7;
        public LinkLabel llRemoveImage;
        public LinkLabel llSetImage;
        public PictureBox pbPersonImage;
        private PictureBox pictureBox6;
        private TextBox tbNote;
        private Label label6;
        private PictureBox pictureBox5;
        private TextBox tbEmail;
        private Label label5;
        private PictureBox pictureBox4;
        private TextBox tbAddress;
        private Label label4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox Phone;
        private Label label1;
        private Label label3;
        private TextBox tbName;
        private PictureBox pictureBox1;
        private Button btClose;
        private Button btSave;
        private OpenFileDialog openFileDialog1;
    }
}