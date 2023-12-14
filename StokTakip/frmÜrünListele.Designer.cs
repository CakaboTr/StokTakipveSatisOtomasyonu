namespace StokTakip
{
    partial class frmÜrünListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmÜrünListele));
            dataGridView1 = new DataGridView();
            btnGüncelle = new Button();
            label1 = new Label();
            label2 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            SatisFiyatiTxt = new TextBox();
            BarkodNoTxt = new TextBox();
            AlisFiyatiTxt = new TextBox();
            KategoriTxt = new TextBox();
            MiktariTxt = new TextBox();
            MarkaTxt = new TextBox();
            urunAdiTxt = new TextBox();
            btnSil = new Button();
            txtBarkodNoAra = new TextBox();
            label3 = new Label();
            comboKategori = new ComboBox();
            comboMarka = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            btnMarkaGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MistyRose;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(257, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(506, 262);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btnGüncelle
            // 
            btnGüncelle.BackColor = Color.YellowGreen;
            btnGüncelle.Cursor = Cursors.Hand;
            btnGüncelle.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btnGüncelle.ForeColor = Color.Firebrick;
            btnGüncelle.Location = new Point(168, 390);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(75, 47);
            btnGüncelle.TabIndex = 23;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = false;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 362);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 36;
            label1.Text = "Satış Fiyatı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 316);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 35;
            label2.Text = "Alış Fiyatı";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(24, 270);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 34;
            label10.Text = "Miktarı";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(24, 224);
            label11.Name = "label11";
            label11.Size = new Size(56, 15);
            label11.TabIndex = 33;
            label11.Text = "Ürün Adı";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(24, 178);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 32;
            label12.Text = "Marka";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(24, 132);
            label13.Name = "label13";
            label13.Size = new Size(55, 15);
            label13.TabIndex = 31;
            label13.Text = "Kategori";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(24, 86);
            label14.Name = "label14";
            label14.Size = new Size(66, 15);
            label14.TabIndex = 30;
            label14.Text = "Barkod No";
            // 
            // SatisFiyatiTxt
            // 
            SatisFiyatiTxt.BackColor = Color.MistyRose;
            SatisFiyatiTxt.Location = new Point(123, 359);
            SatisFiyatiTxt.Name = "SatisFiyatiTxt";
            SatisFiyatiTxt.Size = new Size(119, 23);
            SatisFiyatiTxt.TabIndex = 29;
            // 
            // BarkodNoTxt
            // 
            BarkodNoTxt.BackColor = Color.MistyRose;
            BarkodNoTxt.Location = new Point(123, 83);
            BarkodNoTxt.Name = "BarkodNoTxt";
            BarkodNoTxt.Size = new Size(119, 23);
            BarkodNoTxt.TabIndex = 22;
            // 
            // AlisFiyatiTxt
            // 
            AlisFiyatiTxt.BackColor = Color.MistyRose;
            AlisFiyatiTxt.Location = new Point(123, 313);
            AlisFiyatiTxt.Name = "AlisFiyatiTxt";
            AlisFiyatiTxt.Size = new Size(119, 23);
            AlisFiyatiTxt.TabIndex = 28;
            // 
            // KategoriTxt
            // 
            KategoriTxt.Location = new Point(123, 129);
            KategoriTxt.Name = "KategoriTxt";
            KategoriTxt.ReadOnly = true;
            KategoriTxt.Size = new Size(119, 23);
            KategoriTxt.TabIndex = 24;
            // 
            // MiktariTxt
            // 
            MiktariTxt.BackColor = Color.MistyRose;
            MiktariTxt.Location = new Point(123, 267);
            MiktariTxt.Name = "MiktariTxt";
            MiktariTxt.Size = new Size(119, 23);
            MiktariTxt.TabIndex = 27;
            // 
            // MarkaTxt
            // 
            MarkaTxt.Location = new Point(123, 175);
            MarkaTxt.Name = "MarkaTxt";
            MarkaTxt.ReadOnly = true;
            MarkaTxt.Size = new Size(119, 23);
            MarkaTxt.TabIndex = 25;
            // 
            // urunAdiTxt
            // 
            urunAdiTxt.BackColor = Color.MistyRose;
            urunAdiTxt.Location = new Point(123, 221);
            urunAdiTxt.Name = "urunAdiTxt";
            urunAdiTxt.Size = new Size(119, 23);
            urunAdiTxt.TabIndex = 26;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Tomato;
            btnSil.Cursor = Cursors.Hand;
            btnSil.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btnSil.ForeColor = Color.DarkBlue;
            btnSil.Location = new Point(769, 99);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 33);
            btnSil.TabIndex = 38;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // txtBarkodNoAra
            // 
            txtBarkodNoAra.BackColor = Color.MistyRose;
            txtBarkodNoAra.Location = new Point(513, 31);
            txtBarkodNoAra.Name = "txtBarkodNoAra";
            txtBarkodNoAra.Size = new Size(250, 23);
            txtBarkodNoAra.TabIndex = 39;
            txtBarkodNoAra.TextChanged += txtBarkodNoAra_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(353, 39);
            label3.Name = "label3";
            label3.Size = new Size(143, 15);
            label3.TabIndex = 40;
            label3.Text = "BarkodNo ya göre arama";
            // 
            // comboKategori
            // 
            comboKategori.BackColor = Color.MistyRose;
            comboKategori.FormattingEnabled = true;
            comboKategori.Location = new Point(466, 378);
            comboKategori.Name = "comboKategori";
            comboKategori.Size = new Size(192, 23);
            comboKategori.TabIndex = 41;
            comboKategori.SelectedIndexChanged += comboKategori_SelectedIndexChanged;
            // 
            // comboMarka
            // 
            comboMarka.BackColor = Color.MistyRose;
            comboMarka.FormattingEnabled = true;
            comboMarka.Location = new Point(466, 414);
            comboMarka.Name = "comboMarka";
            comboMarka.Size = new Size(192, 23);
            comboMarka.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(375, 424);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 44;
            label4.Text = "Marka";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(375, 378);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 43;
            label5.Text = "Kategori";
            // 
            // btnMarkaGuncelle
            // 
            btnMarkaGuncelle.BackColor = Color.YellowGreen;
            btnMarkaGuncelle.Cursor = Cursors.Hand;
            btnMarkaGuncelle.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btnMarkaGuncelle.ForeColor = Color.Firebrick;
            btnMarkaGuncelle.Location = new Point(664, 390);
            btnMarkaGuncelle.Name = "btnMarkaGuncelle";
            btnMarkaGuncelle.Size = new Size(99, 47);
            btnMarkaGuncelle.TabIndex = 45;
            btnMarkaGuncelle.Text = "Marka Güncelle";
            btnMarkaGuncelle.UseVisualStyleBackColor = false;
            btnMarkaGuncelle.Click += btnMarkaGuncelle_Click;
            // 
            // frmÜrünListele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(856, 483);
            Controls.Add(btnMarkaGuncelle);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(comboMarka);
            Controls.Add(comboKategori);
            Controls.Add(label3);
            Controls.Add(txtBarkodNoAra);
            Controls.Add(btnSil);
            Controls.Add(btnGüncelle);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(SatisFiyatiTxt);
            Controls.Add(BarkodNoTxt);
            Controls.Add(AlisFiyatiTxt);
            Controls.Add(KategoriTxt);
            Controls.Add(MiktariTxt);
            Controls.Add(MarkaTxt);
            Controls.Add(urunAdiTxt);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmÜrünListele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Listeleme Sayfası";
            Load += frmÜrünListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnGüncelle;
        private Label label1;
        private Label label2;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox SatisFiyatiTxt;
        private TextBox BarkodNoTxt;
        private TextBox AlisFiyatiTxt;
        private TextBox KategoriTxt;
        private TextBox MiktariTxt;
        private TextBox MarkaTxt;
        private TextBox urunAdiTxt;
        private Button btnSil;
        private TextBox txtBarkodNoAra;
        private Label label3;
        private ComboBox comboKategori;
        private ComboBox comboMarka;
        private Label label4;
        private Label label5;
        private Button btnMarkaGuncelle;
    }
}