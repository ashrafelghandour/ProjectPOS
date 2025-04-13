namespace POSDemo.Screens
{
    partial class frmSelesBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelesBill));
            pictureBox1 = new PictureBox();
            pictureBox10 = new PictureBox();
            tbBillid = new TextBox();
            label7 = new Label();
            pictureBox6 = new PictureBox();
            tbNote = new TextBox();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox5 = new PictureBox();
            comboBox1 = new ComboBox();
            listView1 = new ListView();
            imageList1 = new ImageList(components);
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            image = new DataGridViewImageColumn();
            price = new DataGridViewTextBoxColumn();
            totalprice = new DataGridViewTextBoxColumn();
            Quntity = new DataGridViewTextBoxColumn();
            label1 = new Label();
            llTotalprice = new Label();
            ttTotalafterdiscount = new Label();
            ف = new Label();
            label4 = new Label();
            tbDiscout = new TextBox();
            btSave = new Button();
            errorProvider1 = new ErrorProvider(components);
            custmerBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)custmerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(847, 3);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 148;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.Transparent;
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(701, 146);
            pictureBox10.Margin = new Padding(4, 3, 4, 3);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(33, 28);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 252;
            pictureBox10.TabStop = false;
            // 
            // tbBillid
            // 
            tbBillid.Location = new Point(742, 151);
            tbBillid.Margin = new Padding(4, 3, 4, 3);
            tbBillid.Name = "tbBillid";
            tbBillid.ReadOnly = true;
            tbBillid.Size = new Size(129, 23);
            tbBillid.TabIndex = 251;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(602, 151);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(54, 17);
            label7.TabIndex = 250;
            label7.Text = "Bill ID :";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(698, 75);
            pictureBox6.Margin = new Padding(4, 3, 4, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(33, 28);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 249;
            pictureBox6.TabStop = false;
            // 
            // tbNote
            // 
            tbNote.Location = new Point(742, 74);
            tbNote.Margin = new Padding(4, 3, 4, 3);
            tbNote.Multiline = true;
            tbNote.Name = "tbNote";
            tbNote.Size = new Size(129, 57);
            tbNote.TabIndex = 248;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(602, 75);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(46, 17);
            label6.TabIndex = 247;
            label6.Text = "Note :";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.Man_32;
            pictureBox3.Location = new Point(115, 101);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 242;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 104);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 239;
            label3.Text = "Custmer :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 183);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 254;
            label2.Text = "Date : ";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(115, 170);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(33, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 255;
            pictureBox5.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(159, 106);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(179, 23);
            comboBox1.TabIndex = 256;
            // 
            // listView1
            // 
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(633, 231);
            listView1.Name = "listView1";
            listView1.Size = new Size(238, 455);
            listView1.SmallImageList = imageList1;
            listView1.TabIndex = 257;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.MouseDoubleClick += listView1_MouseDoubleClick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(70, 70);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(159, 177);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 258;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, Name, image, price, totalprice, Quntity });
            dataGridView1.Location = new Point(10, 231);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Size = new Size(617, 455);
            dataGridView1.TabIndex = 259;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.RowsRemoved += dataGridView1_RowsRemoved;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // image
            // 
            image.HeaderText = "Image";
            image.ImageLayout = DataGridViewImageCellLayout.Stretch;
            image.Name = "image";
            image.ReadOnly = true;
            // 
            // price
            // 
            price.HeaderText = "Price";
            price.Name = "price";
            price.ReadOnly = true;
            // 
            // totalprice
            // 
            totalprice.HeaderText = "Total Price";
            totalprice.Name = "totalprice";
            totalprice.ReadOnly = true;
            // 
            // Quntity
            // 
            Quntity.HeaderText = "Quntity";
            Quntity.Name = "Quntity";
            Quntity.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(56, 721);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 17);
            label1.TabIndex = 260;
            label1.Text = "Total price  :";
            // 
            // llTotalprice
            // 
            llTotalprice.AutoSize = true;
            llTotalprice.BackColor = Color.Transparent;
            llTotalprice.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llTotalprice.ForeColor = Color.White;
            llTotalprice.Location = new Point(159, 721);
            llTotalprice.Margin = new Padding(4, 0, 4, 0);
            llTotalprice.Name = "llTotalprice";
            llTotalprice.Size = new Size(15, 17);
            llTotalprice.TabIndex = 261;
            llTotalprice.Text = "0";
            // 
            // ttTotalafterdiscount
            // 
            ttTotalafterdiscount.AutoSize = true;
            ttTotalafterdiscount.BackColor = Color.Transparent;
            ttTotalafterdiscount.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ttTotalafterdiscount.ForeColor = Color.White;
            ttTotalafterdiscount.Location = new Point(635, 721);
            ttTotalafterdiscount.Margin = new Padding(4, 0, 4, 0);
            ttTotalafterdiscount.Name = "ttTotalafterdiscount";
            ttTotalafterdiscount.Size = new Size(15, 17);
            ttTotalafterdiscount.TabIndex = 263;
            ttTotalafterdiscount.Text = "0";
            // 
            // ف
            // 
            ف.AutoSize = true;
            ف.BackColor = Color.Transparent;
            ف.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ف.ForeColor = Color.White;
            ف.Location = new Point(464, 721);
            ف.Margin = new Padding(4, 0, 4, 0);
            ف.Name = "ف";
            ف.Size = new Size(137, 17);
            ف.TabIndex = 262;
            ف.Text = "Total after discount :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(205, 721);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 17);
            label4.TabIndex = 264;
            label4.Text = "Discount  :";
            // 
            // tbDiscout
            // 
            tbDiscout.Location = new Point(299, 715);
            tbDiscout.Margin = new Padding(4, 3, 4, 3);
            tbDiscout.Name = "tbDiscout";
            tbDiscout.Size = new Size(129, 23);
            tbDiscout.TabIndex = 265;
            tbDiscout.TextChanged += tbDiscout_TextChanged;
            tbDiscout.Validating += ValidateEmptyTextBoxAndIsNumber;
            // 
            // btSave
            // 
            btSave.BackColor = Color.Transparent;
            btSave.Image = (Image)resources.GetObject("btSave.Image");
            btSave.ImageAlign = ContentAlignment.MiddleLeft;
            btSave.Location = new Point(785, 715);
            btSave.Name = "btSave";
            btSave.Size = new Size(86, 32);
            btSave.TabIndex = 266;
            btSave.Text = "Save";
            btSave.TextAlign = ContentAlignment.MiddleRight;
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // custmerBindingSource
            // 
            custmerBindingSource.DataSource = typeof(Entites.Custmer);
            // 
            // frmSelesBill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dfg1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(883, 777);
            Controls.Add(btSave);
            Controls.Add(tbDiscout);
            Controls.Add(label4);
            Controls.Add(ttTotalafterdiscount);
            Controls.Add(ف);
            Controls.Add(llTotalprice);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(listView1);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox5);
            Controls.Add(label2);
            Controls.Add(pictureBox10);
            Controls.Add(tbBillid);
            Controls.Add(label7);
            Controls.Add(pictureBox6);
            Controls.Add(tbNote);
            Controls.Add(label6);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            ForeColor = Color.Coral;
            FormBorderStyle = FormBorderStyle.None;
            Text = "frmSelesBill";
            Load += frmSelesBill_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)custmerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox10;
        private TextBox tbBillid;
        private Label label7;
        private PictureBox pictureBox6;
        private TextBox tbNote;
        private Label label6;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox5;
        private ComboBox comboBox1;
        private ListView listView1;
        private DateTimePicker dateTimePicker1;
        private ImageList imageList1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewImageColumn image;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn totalprice;
        private DataGridViewTextBoxColumn Quntity;
        private Label label1;
        private Label llTotalprice;
        private Label ttTotalafterdiscount;
        private Label ف;
        private Label label4;
        private TextBox tbDiscout;
        private Button btSave;
        private ErrorProvider errorProvider1;
        private BindingSource custmerBindingSource;
    }
}