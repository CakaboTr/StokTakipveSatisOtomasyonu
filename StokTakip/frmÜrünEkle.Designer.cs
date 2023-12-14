namespace StokTakip
{
    partial class frmÜrünEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmÜrünEkle));
            groupBox1 = new GroupBox();
            label9 = new Label();
            btnYeniEkle = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            comboMarka = new ComboBox();
            comboKategori = new ComboBox();
            txtSatisFiyati = new TextBox();
            txtAlisFiyati = new TextBox();
            txtMiktari = new TextBox();
            txtUrunAdi = new TextBox();
            txtBarkodNo = new TextBox();
            groupBox2 = new GroupBox();
            lblMiktari = new Label();
            btnVarOlanaEkle = new Button();
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
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(btnYeniEkle);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboMarka);
            groupBox1.Controls.Add(comboKategori);
            groupBox1.Controls.Add(txtSatisFiyati);
            groupBox1.Controls.Add(txtAlisFiyati);
            groupBox1.Controls.Add(txtMiktari);
            groupBox1.Controls.Add(txtUrunAdi);
            groupBox1.Controls.Add(txtBarkodNo);
            groupBox1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(49, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(244, 391);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "YENİ ÜRÜN";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(17, 322);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 13;
            label9.Text = "Satış Fiyatı";
            // 
            // btnYeniEkle
            // 
            btnYeniEkle.BackColor = Color.YellowGreen;
            btnYeniEkle.Cursor = Cursors.Hand;
            btnYeniEkle.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btnYeniEkle.ForeColor = Color.Firebrick;
            btnYeniEkle.Location = new Point(163, 362);
            btnYeniEkle.Name = "btnYeniEkle";
            btnYeniEkle.Size = new Size(75, 23);
            btnYeniEkle.TabIndex = 2;
            btnYeniEkle.Text = "EKLE";
            btnYeniEkle.UseVisualStyleBackColor = false;
            btnYeniEkle.Click += btnYeniEkle_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(17, 276);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 12;
            label8.Text = "Alış Fiyatı";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(17, 230);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 11;
            label7.Text = "Miktarı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(17, 184);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 10;
            label6.Text = "Ürün Adı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(17, 138);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 9;
            label5.Text = "Marka";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(17, 92);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 8;
            label4.Text = "Kategori";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 46);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 7;
            label3.Text = "Barkod No";
            // 
            // comboMarka
            // 
            comboMarka.BackColor = Color.MistyRose;
            comboMarka.FormattingEnabled = true;
            comboMarka.Location = new Point(119, 132);
            comboMarka.Name = "comboMarka";
            comboMarka.Size = new Size(119, 23);
            comboMarka.TabIndex = 6;
            // 
            // comboKategori
            // 
            comboKategori.BackColor = Color.MistyRose;
            comboKategori.FormattingEnabled = true;
            comboKategori.Location = new Point(119, 85);
            comboKategori.Name = "comboKategori";
            comboKategori.Size = new Size(119, 23);
            comboKategori.TabIndex = 5;
            comboKategori.SelectedIndexChanged += comboKategori_SelectedIndexChanged;
            // 
            // txtSatisFiyati
            // 
            txtSatisFiyati.BackColor = Color.MistyRose;
            txtSatisFiyati.Location = new Point(119, 320);
            txtSatisFiyati.Name = "txtSatisFiyati";
            txtSatisFiyati.Size = new Size(119, 21);
            txtSatisFiyati.TabIndex = 4;
            // 
            // txtAlisFiyati
            // 
            txtAlisFiyati.BackColor = Color.MistyRose;
            txtAlisFiyati.Location = new Point(119, 273);
            txtAlisFiyati.Name = "txtAlisFiyati";
            txtAlisFiyati.Size = new Size(119, 21);
            txtAlisFiyati.TabIndex = 3;
            // 
            // txtMiktari
            // 
            txtMiktari.BackColor = Color.MistyRose;
            txtMiktari.Location = new Point(119, 226);
            txtMiktari.Name = "txtMiktari";
            txtMiktari.Size = new Size(119, 21);
            txtMiktari.TabIndex = 2;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.BackColor = Color.MistyRose;
            txtUrunAdi.Location = new Point(119, 179);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(119, 21);
            txtUrunAdi.TabIndex = 1;
            // 
            // txtBarkodNo
            // 
            txtBarkodNo.BackColor = Color.MistyRose;
            txtBarkodNo.Location = new Point(119, 38);
            txtBarkodNo.Name = "txtBarkodNo";
            txtBarkodNo.Size = new Size(119, 21);
            txtBarkodNo.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblMiktari);
            groupBox2.Controls.Add(btnVarOlanaEkle);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(SatisFiyatiTxt);
            groupBox2.Controls.Add(BarkodNoTxt);
            groupBox2.Controls.Add(AlisFiyatiTxt);
            groupBox2.Controls.Add(KategoriTxt);
            groupBox2.Controls.Add(MiktariTxt);
            groupBox2.Controls.Add(MarkaTxt);
            groupBox2.Controls.Add(urunAdiTxt);
            groupBox2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(351, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(244, 391);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "STOKTAKİ ÜRÜNLER";
            // 
            // lblMiktari
            // 
            lblMiktari.BorderStyle = BorderStyle.Fixed3D;
            lblMiktari.Location = new Point(20, 362);
            lblMiktari.Name = "lblMiktari";
            lblMiktari.Size = new Size(76, 23);
            lblMiktari.TabIndex = 21;
            // 
            // btnVarOlanaEkle
            // 
            btnVarOlanaEkle.BackColor = Color.YellowGreen;
            btnVarOlanaEkle.Cursor = Cursors.Hand;
            btnVarOlanaEkle.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btnVarOlanaEkle.ForeColor = Color.Firebrick;
            btnVarOlanaEkle.Location = new Point(163, 362);
            btnVarOlanaEkle.Name = "btnVarOlanaEkle";
            btnVarOlanaEkle.Size = new Size(75, 23);
            btnVarOlanaEkle.TabIndex = 3;
            btnVarOlanaEkle.Text = "EKLE";
            btnVarOlanaEkle.UseVisualStyleBackColor = false;
            btnVarOlanaEkle.Click += btnVarOlanaEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 322);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 20;
            label1.Text = "Satış Fiyatı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(20, 276);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 19;
            label2.Text = "Alış Fiyatı";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(20, 230);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 18;
            label10.Text = "Miktarı";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(20, 184);
            label11.Name = "label11";
            label11.Size = new Size(56, 15);
            label11.TabIndex = 17;
            label11.Text = "Ürün Adı";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(20, 138);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 16;
            label12.Text = "Marka";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(20, 92);
            label13.Name = "label13";
            label13.Size = new Size(55, 15);
            label13.TabIndex = 15;
            label13.Text = "Kategori";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(20, 46);
            label14.Name = "label14";
            label14.Size = new Size(66, 15);
            label14.TabIndex = 14;
            label14.Text = "Barkod No";
            // 
            // SatisFiyatiTxt
            // 
            SatisFiyatiTxt.BackColor = Color.MistyRose;
            SatisFiyatiTxt.Location = new Point(119, 319);
            SatisFiyatiTxt.Name = "SatisFiyatiTxt";
            SatisFiyatiTxt.Size = new Size(119, 21);
            SatisFiyatiTxt.TabIndex = 8;
            // 
            // BarkodNoTxt
            // 
            BarkodNoTxt.BackColor = Color.MistyRose;
            BarkodNoTxt.Location = new Point(119, 43);
            BarkodNoTxt.Name = "BarkodNoTxt";
            BarkodNoTxt.Size = new Size(119, 21);
            BarkodNoTxt.TabIndex = 2;
            BarkodNoTxt.TextChanged += BarkodNoTxt_TextChanged;
            // 
            // AlisFiyatiTxt
            // 
            AlisFiyatiTxt.BackColor = Color.MistyRose;
            AlisFiyatiTxt.Location = new Point(119, 273);
            AlisFiyatiTxt.Name = "AlisFiyatiTxt";
            AlisFiyatiTxt.Size = new Size(119, 21);
            AlisFiyatiTxt.TabIndex = 7;
            // 
            // KategoriTxt
            // 
            KategoriTxt.BackColor = Color.MistyRose;
            KategoriTxt.Location = new Point(119, 89);
            KategoriTxt.Name = "KategoriTxt";
            KategoriTxt.Size = new Size(119, 21);
            KategoriTxt.TabIndex = 3;
            // 
            // MiktariTxt
            // 
            MiktariTxt.BackColor = Color.MistyRose;
            MiktariTxt.Location = new Point(119, 227);
            MiktariTxt.Name = "MiktariTxt";
            MiktariTxt.Size = new Size(119, 21);
            MiktariTxt.TabIndex = 6;
            // 
            // MarkaTxt
            // 
            MarkaTxt.BackColor = Color.MistyRose;
            MarkaTxt.Location = new Point(119, 135);
            MarkaTxt.Name = "MarkaTxt";
            MarkaTxt.Size = new Size(119, 21);
            MarkaTxt.TabIndex = 4;
            // 
            // urunAdiTxt
            // 
            urunAdiTxt.BackColor = Color.MistyRose;
            urunAdiTxt.Location = new Point(119, 181);
            urunAdiTxt.Name = "urunAdiTxt";
            urunAdiTxt.Size = new Size(119, 21);
            urunAdiTxt.TabIndex = 5;
            // 
            // frmÜrünEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(655, 408);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmÜrünEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Ekleme Sayfası";
            Load += frmÜrünEkle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtSatisFiyati;
        private TextBox txtAlisFiyati;
        private TextBox txtMiktari;
        private TextBox txtUrunAdi;
        private TextBox txtBarkodNo;
        private TextBox SatisFiyatiTxt;
        private TextBox BarkodNoTxt;
        private TextBox AlisFiyatiTxt;
        private TextBox KategoriTxt;
        private TextBox MiktariTxt;
        private TextBox MarkaTxt;
        private TextBox urunAdiTxt;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox comboMarka;
        private ComboBox comboKategori;
        private Button btnYeniEkle;
        private Button btnVarOlanaEkle;
        private Label label1;
        private Label label2;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label lblMiktari;
    }
}