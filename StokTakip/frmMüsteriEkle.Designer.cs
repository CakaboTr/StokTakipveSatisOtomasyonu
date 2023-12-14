namespace StokTakip
{
    partial class frmMüsteriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMüsteriEkle));
            lblTc = new Label();
            lblAdSoyad = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTc = new TextBox();
            txtAdSoyad = new TextBox();
            txtTelefon = new TextBox();
            txtAdres = new TextBox();
            txtEmail = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblTc
            // 
            lblTc.AutoSize = true;
            lblTc.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTc.Location = new Point(30, 26);
            lblTc.Name = "lblTc";
            lblTc.Size = new Size(38, 15);
            lblTc.TabIndex = 0;
            lblTc.Text = "Tc No";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdSoyad.Location = new Point(30, 64);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(57, 15);
            lblAdSoyad.TabIndex = 1;
            lblAdSoyad.Text = "Ad Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 102);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefon Numarası";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 140);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 3;
            label4.Text = "Adres";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(30, 178);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 4;
            label5.Text = "E-Mail";
            // 
            // txtTc
            // 
            txtTc.BackColor = Color.MistyRose;
            txtTc.Location = new Point(178, 18);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(237, 23);
            txtTc.TabIndex = 5;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.BackColor = Color.MistyRose;
            txtAdSoyad.Location = new Point(178, 56);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(237, 23);
            txtAdSoyad.TabIndex = 6;
            // 
            // txtTelefon
            // 
            txtTelefon.BackColor = Color.MistyRose;
            txtTelefon.Location = new Point(178, 94);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(237, 23);
            txtTelefon.TabIndex = 7;
            // 
            // txtAdres
            // 
            txtAdres.BackColor = Color.MistyRose;
            txtAdres.Location = new Point(178, 132);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(237, 23);
            txtAdres.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.MistyRose;
            txtEmail.Location = new Point(178, 170);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(237, 23);
            txtEmail.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            button1.ForeColor = Color.Firebrick;
            button1.Location = new Point(178, 222);
            button1.Name = "button1";
            button1.Size = new Size(103, 36);
            button1.TabIndex = 10;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmMüsteriEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(427, 281);
            Controls.Add(button1);
            Controls.Add(txtEmail);
            Controls.Add(txtAdres);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtTc);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblAdSoyad);
            Controls.Add(lblTc);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMüsteriEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri Ekleme Sayfası";
            Load += frmMüsteriEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTc;
        private Label lblAdSoyad;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTc;
        private TextBox txtAdSoyad;
        private TextBox txtTelefon;
        private TextBox txtAdres;
        private TextBox txtEmail;
        private Button button1;
    }
}