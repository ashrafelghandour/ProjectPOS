namespace POSDemo.Scren
{
    partial class frmNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewUser));
            tbpassw = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tbUserName = new TextBox();
            llSetImage = new LinkLabel();
            pbPersonImage = new PictureBox();
            llRemoveImage = new LinkLabel();
            btSave = new Button();
            btClose = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tbpassw
            // 
            tbpassw.Location = new Point(38, 186);
            tbpassw.Margin = new Padding(4, 3, 4, 3);
            tbpassw.Name = "tbpassw";
            tbpassw.Size = new Size(183, 23);
            tbpassw.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 155);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 17);
            label2.TabIndex = 41;
            label2.Text = "password : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 70);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 17);
            label1.TabIndex = 38;
            label1.Text = "User Name :";
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(38, 105);
            tbUserName.Margin = new Padding(4, 3, 4, 3);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(183, 23);
            tbUserName.TabIndex = 37;
            // 
            // llSetImage
            // 
            llSetImage.AutoSize = true;
            llSetImage.Location = new Point(38, 350);
            llSetImage.Margin = new Padding(4, 0, 4, 0);
            llSetImage.Name = "llSetImage";
            llSetImage.Size = new Size(59, 15);
            llSetImage.TabIndex = 86;
            llSetImage.TabStop = true;
            llSetImage.Text = "Set Image";
            llSetImage.LinkClicked += llSetImage_LinkClicked;
            // 
            // pbPersonImage
            // 
            pbPersonImage.BackgroundImageLayout = ImageLayout.Zoom;
            pbPersonImage.BorderStyle = BorderStyle.Fixed3D;
            pbPersonImage.Image = Properties.Resources.Female_512;
            pbPersonImage.InitialImage = null;
            pbPersonImage.Location = new Point(38, 218);
            pbPersonImage.Margin = new Padding(5, 6, 5, 6);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(183, 115);
            pbPersonImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPersonImage.TabIndex = 87;
            pbPersonImage.TabStop = false;
            // 
            // llRemoveImage
            // 
            llRemoveImage.AutoSize = true;
            llRemoveImage.Location = new Point(63, 377);
            llRemoveImage.Margin = new Padding(4, 0, 4, 0);
            llRemoveImage.Name = "llRemoveImage";
            llRemoveImage.Size = new Size(50, 15);
            llRemoveImage.TabIndex = 113;
            llRemoveImage.TabStop = true;
            llRemoveImage.Text = "Remove";
            llRemoveImage.LinkClicked += llRemoveImage_LinkClicked;
            // 
            // btSave
            // 
            btSave.Image = (Image)resources.GetObject("btSave.Image");
            btSave.ImageAlign = ContentAlignment.MiddleLeft;
            btSave.Location = new Point(247, 388);
            btSave.Name = "btSave";
            btSave.Size = new Size(86, 32);
            btSave.TabIndex = 131;
            btSave.Text = "Save";
            btSave.TextAlign = ContentAlignment.MiddleRight;
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 
            btClose.Image = (Image)resources.GetObject("btClose.Image");
            btClose.ImageAlign = ContentAlignment.MiddleLeft;
            btClose.Location = new Point(155, 388);
            btClose.Name = "btClose";
            btClose.Size = new Size(86, 32);
            btClose.TabIndex = 132;
            btClose.Text = "Close";
            btClose.TextAlign = ContentAlignment.MiddleRight;
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(315, 2);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 133;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bodoni MT Condensed", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(106, 32);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(97, 32);
            label3.TabIndex = 134;
            label3.Text = "New User";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(129, 67);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 135;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(129, 150);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 136;
            pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(354, 428);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(llRemoveImage);
            Controls.Add(llSetImage);
            Controls.Add(pbPersonImage);
            Controls.Add(tbpassw);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbUserName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmNewUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNewUser";
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbpassw;
        private Label label2;
        private Label label1;
        private TextBox tbUserName;
        public LinkLabel llSetImage;
        public PictureBox pbPersonImage;
        public LinkLabel llRemoveImage;
        private Button btSave;
        private Button btClose;
        private PictureBox pictureBox1;
        private Label label3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private OpenFileDialog openFileDialog1;
    }
}