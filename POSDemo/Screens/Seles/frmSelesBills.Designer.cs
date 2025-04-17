namespace POSDemo.Screens.Seles
{
    partial class frmSelesBills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelesBills));
            btSave = new Button();
            tbDiscout = new TextBox();
            label4 = new Label();
            ttTotalafterdiscount = new Label();
            ف = new Label();
            llTotalprice = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            image = new DataGridViewImageColumn();
            price = new DataGridViewTextBoxColumn();
            totalprice = new DataGridViewTextBoxColumn();
            Quntity = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            pictureBox5 = new PictureBox();
            label2 = new Label();
            pictureBox10 = new PictureBox();
            tbBillid = new TextBox();
            label7 = new Label();
            pictureBox6 = new PictureBox();
            tbNote = new TextBox();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView2 = new DataGridView();
            pageSetupDialog1 = new PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // btSave
            // 
            btSave.BackColor = Color.Transparent;
            btSave.Image = (Image)resources.GetObject("btSave.Image");
            btSave.ImageAlign = ContentAlignment.MiddleLeft;
            btSave.Location = new Point(815, 733);
            btSave.Name = "btSave";
            btSave.Size = new Size(86, 32);
            btSave.TabIndex = 288;
            btSave.Text = "Save";
            btSave.TextAlign = ContentAlignment.MiddleRight;
            btSave.UseVisualStyleBackColor = false;
            // 
            // tbDiscout
            // 
            tbDiscout.Enabled = false;
            tbDiscout.Location = new Point(329, 733);
            tbDiscout.Margin = new Padding(4, 3, 4, 3);
            tbDiscout.Name = "tbDiscout";
            tbDiscout.Size = new Size(129, 23);
            tbDiscout.TabIndex = 287;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(235, 739);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 17);
            label4.TabIndex = 286;
            label4.Text = "Discount  :";
            // 
            // ttTotalafterdiscount
            // 
            ttTotalafterdiscount.AutoSize = true;
            ttTotalafterdiscount.BackColor = Color.Transparent;
            ttTotalafterdiscount.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ttTotalafterdiscount.ForeColor = Color.White;
            ttTotalafterdiscount.Location = new Point(665, 739);
            ttTotalafterdiscount.Margin = new Padding(4, 0, 4, 0);
            ttTotalafterdiscount.Name = "ttTotalafterdiscount";
            ttTotalafterdiscount.Size = new Size(15, 17);
            ttTotalafterdiscount.TabIndex = 285;
            ttTotalafterdiscount.Text = "0";
            // 
            // ف
            // 
            ف.AutoSize = true;
            ف.BackColor = Color.Transparent;
            ف.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ف.ForeColor = Color.White;
            ف.Location = new Point(494, 739);
            ف.Margin = new Padding(4, 0, 4, 0);
            ف.Name = "ف";
            ف.Size = new Size(137, 17);
            ف.TabIndex = 284;
            ف.Text = "Total after discount :";
            // 
            // llTotalprice
            // 
            llTotalprice.AutoSize = true;
            llTotalprice.BackColor = Color.Transparent;
            llTotalprice.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llTotalprice.ForeColor = Color.White;
            llTotalprice.Location = new Point(189, 739);
            llTotalprice.Margin = new Padding(4, 0, 4, 0);
            llTotalprice.Name = "llTotalprice";
            llTotalprice.Size = new Size(15, 17);
            llTotalprice.TabIndex = 283;
            llTotalprice.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(86, 739);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 17);
            label1.TabIndex = 282;
            label1.Text = "Total price  :";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, Name, image, price, totalprice, Quntity });
            dataGridView1.Enabled = false;
            dataGridView1.Location = new Point(40, 249);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Size = new Size(617, 455);
            dataGridView1.TabIndex = 281;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(159, 161);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 280;
            // 
            // comboBox1
            // 
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(159, 90);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(179, 23);
            comboBox1.TabIndex = 278;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(115, 154);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(33, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 277;
            pictureBox5.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 167);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 276;
            label2.Text = "Date : ";
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.Transparent;
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(501, 156);
            pictureBox10.Margin = new Padding(4, 3, 4, 3);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(33, 28);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 275;
            pictureBox10.TabStop = false;
            // 
            // tbBillid
            // 
            tbBillid.Enabled = false;
            tbBillid.Location = new Point(542, 161);
            tbBillid.Margin = new Padding(4, 3, 4, 3);
            tbBillid.Name = "tbBillid";
            tbBillid.ReadOnly = true;
            tbBillid.Size = new Size(129, 23);
            tbBillid.TabIndex = 274;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(402, 161);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(54, 17);
            label7.TabIndex = 273;
            label7.Text = "Bill ID :";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(498, 85);
            pictureBox6.Margin = new Padding(4, 3, 4, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(33, 28);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 272;
            pictureBox6.TabStop = false;
            // 
            // tbNote
            // 
            tbNote.Enabled = false;
            tbNote.Location = new Point(542, 84);
            tbNote.Margin = new Padding(4, 3, 4, 3);
            tbNote.Multiline = true;
            tbNote.Name = "tbNote";
            tbNote.Size = new Size(129, 57);
            tbNote.TabIndex = 271;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(402, 84);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(46, 17);
            label6.TabIndex = 270;
            label6.Text = "Note :";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.Man_32;
            pictureBox3.Location = new Point(115, 85);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 269;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 88);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 268;
            label3.Text = "Custmer :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(958, 1);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 267;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(678, 103);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(313, 601);
            dataGridView2.TabIndex = 289;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
            // 
            // frmSelesBills
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dfg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(992, 787);
            Controls.Add(dataGridView2);
            Controls.Add(btSave);
            Controls.Add(tbDiscout);
            Controls.Add(label4);
            Controls.Add(ttTotalafterdiscount);
            Controls.Add(ف);
            Controls.Add(llTotalprice);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
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
            FormBorderStyle = FormBorderStyle.None;
            Text = "frmSelesBills";
            Load += frmSelesBills_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSave;
        private TextBox tbDiscout;
        private Label label4;
        private Label ttTotalafterdiscount;
        private Label ف;
        private Label llTotalprice;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewImageColumn image;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn totalprice;
        private DataGridViewTextBoxColumn Quntity;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private PictureBox pictureBox5;
        private Label label2;
        private PictureBox pictureBox10;
        private TextBox tbBillid;
        private Label label7;
        private PictureBox pictureBox6;
        private TextBox tbNote;
        private Label label6;
        private PictureBox pictureBox3;
        private Label label3;
        private PictureBox pictureBox1;
        private DataGridView dataGridView2;
        private PageSetupDialog pageSetupDialog1;
    }
}