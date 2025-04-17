namespace POSDemo
{
    partial class frmAccountSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountSettings));
            pictureBox3 = new PictureBox();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            btClose = new Button();
            pbPersonImage = new PictureBox();
            label1 = new Label();
            tbUserName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(173, 74);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 257;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bodoni MT Condensed", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(112, 9);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(97, 32);
            label3.TabIndex = 256;
            label3.Text = "New User";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(268, 0);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(33, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 255;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // btClose
            // 
            btClose.Image = Properties.Resources._17578298;
            btClose.Location = new Point(215, 341);
            btClose.Name = "btClose";
            btClose.Size = new Size(86, 32);
            btClose.TabIndex = 254;
            btClose.Text = "Back";
            btClose.TextAlign = ContentAlignment.MiddleRight;
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // pbPersonImage
            // 
            pbPersonImage.BackgroundImageLayout = ImageLayout.Zoom;
            pbPersonImage.BorderStyle = BorderStyle.Fixed3D;
            pbPersonImage.Enabled = false;
            pbPersonImage.Image = Properties.Resources.Female_512;
            pbPersonImage.InitialImage = null;
            pbPersonImage.Location = new Point(26, 171);
            pbPersonImage.Margin = new Padding(5, 6, 5, 6);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(183, 115);
            pbPersonImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPersonImage.TabIndex = 251;
            pbPersonImage.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(26, 75);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 17);
            label1.TabIndex = 247;
            label1.Text = "User Name :";
            // 
            // tbUserName
            // 
            tbUserName.Enabled = false;
            tbUserName.Location = new Point(26, 124);
            tbUserName.Margin = new Padding(4, 3, 4, 3);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(183, 26);
            tbUserName.TabIndex = 246;
            // 
            // frmAccountSettings
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.dfg1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(303, 374);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(pictureBox4);
            Controls.Add(btClose);
            Controls.Add(pbPersonImage);
            Controls.Add(label1);
            Controls.Add(tbUserName);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmAccountSettings";
            Text = "frmAccountSettings";
            Load += frmAccountSettings_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox3;
        private Label label3;
        private PictureBox pictureBox4;
        private Button btClose;
        public PictureBox pbPersonImage;
        private Label label1;
        private TextBox tbUserName;
    }
}