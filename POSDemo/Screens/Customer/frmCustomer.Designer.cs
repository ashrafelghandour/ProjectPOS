namespace POSDemo.Screens.Customer
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            llRemoveImage = new LinkLabel();
            llSetImage = new LinkLabel();
            button1 = new Button();
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
            txtFilterValue = new TextBox();
            cbFilterBy = new ComboBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            pictureBox10 = new PictureBox();
            tbCompany = new TextBox();
            label7 = new Label();
            ChbisActive = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChbisActive).BeginInit();
            SuspendLayout();
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Transparent;
            pictureBox9.Image = Properties.Resources._8787057;
            pictureBox9.Location = new Point(962, 652);
            pictureBox9.Margin = new Padding(4, 3, 4, 3);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(33, 28);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 211;
            pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.Image = Properties.Resources._10951869;
            pictureBox8.Location = new Point(1064, 648);
            pictureBox8.Margin = new Padding(4, 3, 4, 3);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(33, 28);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 210;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Image = Properties.Resources._7875891;
            pictureBox7.Location = new Point(853, 652);
            pictureBox7.Margin = new Padding(4, 3, 4, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(33, 28);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 209;
            pictureBox7.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(790, 652);
            button3.Name = "button3";
            button3.Size = new Size(56, 32);
            button3.TabIndex = 208;
            button3.Text = "Add";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(1001, 648);
            button2.Name = "button2";
            button2.Size = new Size(56, 32);
            button2.TabIndex = 207;
            button2.Text = "Delete";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // llRemoveImage
            // 
            llRemoveImage.AutoSize = true;
            llRemoveImage.BackColor = Color.Transparent;
            llRemoveImage.Location = new Point(836, 568);
            llRemoveImage.Margin = new Padding(4, 0, 4, 0);
            llRemoveImage.Name = "llRemoveImage";
            llRemoveImage.Size = new Size(50, 15);
            llRemoveImage.TabIndex = 206;
            llRemoveImage.TabStop = true;
            llRemoveImage.Text = "Remove";
            llRemoveImage.LinkClicked += llRemoveImage_LinkClicked;
            // 
            // llSetImage
            // 
            llSetImage.AutoSize = true;
            llSetImage.BackColor = Color.Transparent;
            llSetImage.Location = new Point(797, 529);
            llSetImage.Margin = new Padding(4, 0, 4, 0);
            llSetImage.Name = "llSetImage";
            llSetImage.Size = new Size(59, 15);
            llSetImage.TabIndex = 205;
            llSetImage.TabStop = true;
            llSetImage.Text = "Set Image";
            llSetImage.LinkClicked += llSetImage_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(899, 648);
            button1.Name = "button1";
            button1.Size = new Size(56, 32);
            button1.TabIndex = 204;
            button1.Text = "Edite";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pbPersonImage
            // 
            pbPersonImage.BackColor = Color.Transparent;
            pbPersonImage.BackgroundImageLayout = ImageLayout.Zoom;
            pbPersonImage.BorderStyle = BorderStyle.Fixed3D;
            pbPersonImage.InitialImage = null;
            pbPersonImage.Location = new Point(946, 529);
            pbPersonImage.Margin = new Padding(5, 6, 5, 6);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(129, 76);
            pbPersonImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPersonImage.TabIndex = 203;
            pbPersonImage.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(896, 450);
            pictureBox6.Margin = new Padding(4, 3, 4, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(33, 28);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 202;
            pictureBox6.TabStop = false;
            // 
            // tbNote
            // 
            tbNote.Location = new Point(940, 449);
            tbNote.Margin = new Padding(4, 3, 4, 3);
            tbNote.Multiline = true;
            tbNote.Name = "tbNote";
            tbNote.Size = new Size(129, 57);
            tbNote.TabIndex = 201;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(795, 450);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(46, 17);
            label6.TabIndex = 200;
            label6.Text = "Note :";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.Email_32;
            pictureBox5.Location = new Point(896, 296);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(33, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 199;
            pictureBox5.TabStop = false;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(940, 295);
            tbEmail.Margin = new Padding(4, 3, 4, 3);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(129, 23);
            tbEmail.TabIndex = 198;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(791, 295);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(50, 17);
            label5.TabIndex = 197;
            label5.Text = "Email :";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.Address_32;
            pictureBox4.Location = new Point(896, 260);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(33, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 196;
            pictureBox4.TabStop = false;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(940, 259);
            tbAddress.Margin = new Padding(4, 3, 4, 3);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(129, 23);
            tbAddress.TabIndex = 195;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(791, 259);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 17);
            label4.TabIndex = 194;
            label4.Text = "Address :";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Phone_32;
            pictureBox2.Location = new Point(896, 218);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 193;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.Man_32;
            pictureBox3.Location = new Point(896, 171);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 192;
            pictureBox3.TabStop = false;
            // 
            // Phone
            // 
            Phone.Location = new Point(940, 217);
            Phone.Margin = new Padding(4, 3, 4, 3);
            Phone.Name = "Phone";
            Phone.Size = new Size(129, 23);
            Phone.TabIndex = 191;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(791, 223);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 17);
            label1.TabIndex = 190;
            label1.Text = "Phone : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(791, 171);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(52, 17);
            label3.TabIndex = 189;
            label3.Text = "Name :";
            // 
            // tbName
            // 
            tbName.Location = new Point(940, 171);
            tbName.Margin = new Padding(4, 3, 4, 3);
            tbName.Name = "tbName";
            tbName.Size = new Size(129, 23);
            tbName.TabIndex = 188;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(260, 56);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(159, 23);
            txtFilterValue.TabIndex = 187;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            // 
            // cbFilterBy
            // 
            cbFilterBy.BackColor = SystemColors.ScrollBar;
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "Phone", "Name" });
            cbFilterBy.Location = new Point(105, 56);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(149, 23);
            cbFilterBy.TabIndex = 186;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(21, 55);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 19);
            label2.TabIndex = 185;
            label2.Text = "Filter By :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1082, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 212;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 107);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(774, 653);
            dataGridView1.TabIndex = 184;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.Transparent;
            pictureBox10.Image = Properties.Resources._24120611;
            pictureBox10.Location = new Point(896, 345);
            pictureBox10.Margin = new Padding(4, 3, 4, 3);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(33, 28);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 215;
            pictureBox10.TabStop = false;
            // 
            // tbCompany
            // 
            tbCompany.Location = new Point(940, 344);
            tbCompany.Margin = new Padding(4, 3, 4, 3);
            tbCompany.Name = "tbCompany";
            tbCompany.Size = new Size(129, 23);
            tbCompany.TabIndex = 214;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(791, 345);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(74, 17);
            label7.TabIndex = 213;
            label7.Text = "Company :";
            // 
            // ChbisActive
            // 
            ChbisActive.AccessibilityEnabled = true;
            ChbisActive.ForeColor = Color.White;
            ChbisActive.Location = new Point(797, 393);
            ChbisActive.Name = "ChbisActive";
            ChbisActive.Size = new Size(150, 21);
            ChbisActive.TabIndex = 216;
            ChbisActive.Text = "isActive";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dfg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1118, 778);
            Controls.Add(ChbisActive);
            Controls.Add(pictureBox10);
            Controls.Add(tbCompany);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(llRemoveImage);
            Controls.Add(llSetImage);
            Controls.Add(button1);
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
            Controls.Add(txtFilterValue);
            Controls.Add(cbFilterBy);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCustomer";
            Text = "Customer";
            Load += frmCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChbisActive).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private Button button3;
        private Button button2;
        public LinkLabel llRemoveImage;
        public LinkLabel llSetImage;
        private Button button1;
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
        private TextBox txtFilterValue;
        private ComboBox cbFilterBy;
        private Label label2;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox10;
        private TextBox tbCompany;
        private Label label7;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv ChbisActive;
        private OpenFileDialog openFileDialog1;
    }
}