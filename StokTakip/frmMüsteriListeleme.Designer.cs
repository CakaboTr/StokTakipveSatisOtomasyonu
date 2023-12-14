namespace StokTakip
{
    partial class frmMüsteriListeleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMüsteriListeleme));
            dataGridView1 = new DataGridView();
            btnGuncelle = new Button();
            txtEmail = new TextBox();
            txtAdres = new TextBox();
            txtTelefon = new TextBox();
            txtAdSoyad = new TextBox();
            txtTc = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblAdSoyad = new Label();
            lblTc = new Label();
            btnSil = new Button();
            txtTcAra = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MistyRose;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(335, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(440, 240);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.GreenYellow;
            btnGuncelle.Cursor = Cursors.Hand;
            btnGuncelle.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btnGuncelle.ForeColor = Color.Firebrick;
            btnGuncelle.Location = new Point(162, 265);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(103, 36);
            btnGuncelle.TabIndex = 21;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.MistyRose;
            txtEmail.Location = new Point(133, 213);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(166, 23);
            txtEmail.TabIndex = 20;
            // 
            // txtAdres
            // 
            txtAdres.BackColor = Color.MistyRose;
            txtAdres.Location = new Point(133, 175);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(166, 23);
            txtAdres.TabIndex = 19;
            // 
            // txtTelefon
            // 
            txtTelefon.BackColor = Color.MistyRose;
            txtTelefon.Location = new Point(133, 137);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(166, 23);
            txtTelefon.TabIndex = 18;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.BackColor = Color.MistyRose;
            txtAdSoyad.Location = new Point(133, 99);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(166, 23);
            txtAdSoyad.TabIndex = 17;
            // 
            // txtTc
            // 
            txtTc.BackColor = Color.MistyRose;
            txtTc.Location = new Point(133, 61);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(166, 23);
            txtTc.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(24, 221);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 15;
            label5.Text = "E-Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(24, 183);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 14;
            label4.Text = "Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(24, 145);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 13;
            label3.Text = "Telefon Numarası";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdSoyad.Location = new Point(24, 107);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(57, 15);
            lblAdSoyad.TabIndex = 12;
            lblAdSoyad.Text = "Ad Soyad";
            // 
            // lblTc
            // 
            lblTc.AutoSize = true;
            lblTc.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTc.Location = new Point(24, 69);
            lblTc.Name = "lblTc";
            lblTc.Size = new Size(38, 15);
            lblTc.TabIndex = 11;
            lblTc.Text = "Tc No";
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Tomato;
            btnSil.Cursor = Cursors.Hand;
            btnSil.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btnSil.ForeColor = Color.DarkBlue;
            btnSil.Location = new Point(782, 69);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(89, 35);
            btnSil.TabIndex = 22;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // txtTcAra
            // 
            txtTcAra.BackColor = Color.MistyRose;
            txtTcAra.Location = new Point(551, 25);
            txtTcAra.Name = "txtTcAra";
            txtTcAra.Size = new Size(224, 23);
            txtTcAra.TabIndex = 23;
            txtTcAra.TextChanged += txtTcAra_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(493, 33);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 24;
            label1.Text = "Tc Ara";
            // 
            // frmMüsteriListeleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(883, 369);
            Controls.Add(label1);
            Controls.Add(txtTcAra);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
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
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMüsteriListeleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri Listeleme Sayfası";
            Load += frmMüsteriListeleme_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnGuncelle;
        private TextBox txtEmail;
        private TextBox txtAdres;
        private TextBox txtTelefon;
        private TextBox txtAdSoyad;
        private TextBox txtTc;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblAdSoyad;
        private Label lblTc;
        private Button btnSil;
        private TextBox txtTcAra;
        private Label label1;
    }
}