namespace POSDemo.Screens
{
    partial class frmAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProduct));
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            btClose = new Button();
            btSave = new Button();
            pbPersonImage = new PictureBox();
            tbNamePtod = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tbBarcode = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            pictureBox4 = new PictureBox();
            tbPrice = new TextBox();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            tbquantity = new TextBox();
            label5 = new Label();
            pictureBox6 = new PictureBox();
            tbNote = new TextBox();
            label6 = new Label();
            errorProvider1 = new ErrorProvider(components);
            llSetImage = new LinkLabel();
            llRemoveImage = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources._10951869;
            pictureBox2.Location = new Point(118, 159);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 149;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(118, 112);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 148;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bodoni MT Condensed", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(309, 21);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(129, 32);
            label3.TabIndex = 147;
            label3.Text = "New product";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(586, 1);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 146;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btClose
            // 
            btClose.BackColor = Color.Transparent;
            btClose.Image = (Image)resources.GetObject("btClose.Image");
            btClose.Location = new Point(369, 262);
            btClose.Name = "btClose";
            btClose.Size = new Size(86, 32);
            btClose.TabIndex = 145;
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
            btSave.Location = new Point(461, 262);
            btSave.Name = "btSave";
            btSave.Size = new Size(86, 32);
            btSave.TabIndex = 144;
            btSave.Text = "Save";
            btSave.TextAlign = ContentAlignment.MiddleRight;
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // pbPersonImage
            // 
            pbPersonImage.BackColor = Color.Transparent;
            pbPersonImage.BackgroundImageLayout = ImageLayout.Zoom;
            pbPersonImage.BorderStyle = BorderStyle.Fixed3D;
            pbPersonImage.InitialImage = null;
            pbPersonImage.Location = new Point(162, 248);
            pbPersonImage.Margin = new Padding(5, 6, 5, 6);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(129, 76);
            pbPersonImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPersonImage.TabIndex = 142;
            pbPersonImage.TabStop = false;
            pbPersonImage.Click += pbPersonImage_Click;
            // 
            // tbNamePtod
            // 
            tbNamePtod.Location = new Point(162, 158);
            tbNamePtod.Margin = new Padding(4, 3, 4, 3);
            tbNamePtod.Name = "tbNamePtod";
            tbNamePtod.Size = new Size(129, 23);
            tbNamePtod.TabIndex = 140;
            tbNamePtod.Validating += ValidateEmptyTextBox;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 164);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 17);
            label2.TabIndex = 139;
            label2.Text = "Name Product : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 112);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 17);
            label1.TabIndex = 138;
            label1.Text = "Barcode :";
            // 
            // tbBarcode
            // 
            tbBarcode.Location = new Point(162, 112);
            tbBarcode.Margin = new Padding(4, 3, 4, 3);
            tbBarcode.Name = "tbBarcode";
            tbBarcode.Size = new Size(129, 23);
            tbBarcode.TabIndex = 137;
            tbBarcode.Validating += ValidateEmptyTextBoxAndIsNumber;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(118, 201);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(33, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 152;
            pictureBox4.TabStop = false;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(162, 200);
            tbPrice.Margin = new Padding(4, 3, 4, 3);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(129, 23);
            tbPrice.TabIndex = 151;
            tbPrice.Validating += ValidateEmptyTextBoxAndIsNumber;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 206);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 17);
            label4.TabIndex = 150;
            label4.Text = "Price :";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(374, 108);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(33, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 155;
            pictureBox5.TabStop = false;
            // 
            // tbquantity
            // 
            tbquantity.Location = new Point(418, 107);
            tbquantity.Margin = new Padding(4, 3, 4, 3);
            tbquantity.Name = "tbquantity";
            tbquantity.Size = new Size(129, 23);
            tbquantity.TabIndex = 154;
            tbquantity.Validating += ValidateEmptyTextBoxAndIsNumber;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(298, 112);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 17);
            label5.TabIndex = 153;
            label5.Text = "Quantity :";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(374, 148);
            pictureBox6.Margin = new Padding(4, 3, 4, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(33, 28);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 158;
            pictureBox6.TabStop = false;
            // 
            // tbNote
            // 
            tbNote.Location = new Point(418, 147);
            tbNote.Margin = new Padding(4, 3, 4, 3);
            tbNote.Multiline = true;
            tbNote.Name = "tbNote";
            tbNote.Size = new Size(129, 57);
            tbNote.TabIndex = 157;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(320, 148);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(46, 17);
            label6.TabIndex = 156;
            label6.Text = "Note :";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // llSetImage
            // 
            llSetImage.AutoSize = true;
            llSetImage.BackColor = Color.Transparent;
            llSetImage.Location = new Point(32, 249);
            llSetImage.Margin = new Padding(4, 0, 4, 0);
            llSetImage.Name = "llSetImage";
            llSetImage.Size = new Size(59, 15);
            llSetImage.TabIndex = 141;
            llSetImage.TabStop = true;
            llSetImage.Text = "Set Image";
            llSetImage.LinkClicked += llSetImage_LinkClicked;
            // 
            // llRemoveImage
            // 
            llRemoveImage.AutoSize = true;
            llRemoveImage.BackColor = Color.Transparent;
            llRemoveImage.Location = new Point(71, 288);
            llRemoveImage.Margin = new Padding(4, 0, 4, 0);
            llRemoveImage.Name = "llRemoveImage";
            llRemoveImage.Size = new Size(50, 15);
            llRemoveImage.TabIndex = 143;
            llRemoveImage.TabStop = true;
            llRemoveImage.Text = "Remove";
            llRemoveImage.LinkClicked += llRemoveImage_LinkClicked;
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dfg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(623, 339);
            Controls.Add(pictureBox6);
            Controls.Add(tbNote);
            Controls.Add(label6);
            Controls.Add(pictureBox5);
            Controls.Add(tbquantity);
            Controls.Add(label5);
            Controls.Add(pictureBox4);
            Controls.Add(tbPrice);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(llRemoveImage);
            Controls.Add(llSetImage);
            Controls.Add(pbPersonImage);
            Controls.Add(tbNamePtod);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbBarcode);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProduct";
            Load += frmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btClose;
        private Button btSave;
        public PictureBox pbPersonImage;
        private TextBox tbNamePtod;
        private Label label2;
        private Label label1;
        private TextBox tbBarcode;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox4;
        private TextBox tbPrice;
        private Label label4;
        private PictureBox pictureBox5;
        private TextBox tbquantity;
        private Label label5;
        private PictureBox pictureBox6;
        private TextBox tbNote;
        private Label label6;
        private ErrorProvider errorProvider1;
        public LinkLabel llRemoveImage;
        public LinkLabel llSetImage;
    }
}