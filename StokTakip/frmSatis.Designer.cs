namespace StokTakip
{
    partial class frmSatis
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatis));
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtTelefon = new TextBox();
            txtAdSoyad = new TextBox();
            txtTc = new TextBox();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtToplamFiyat = new TextBox();
            txtSatisFiyati = new TextBox();
            txtMiktari = new TextBox();
            txtUrunAdi = new TextBox();
            txtBarkodNo = new TextBox();
            btnSil = new Button();
            btnEkle = new Button();
            btnSatisİptal = new Button();
            btnSatisYap = new Button();
            lblGenelToplam = new Label();
            label10 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            lblTarihSaat = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AntiqueWhite;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(346, 181);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(637, 371);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTelefon);
            groupBox1.Controls.Add(txtAdSoyad);
            groupBox1.Controls.Add(txtTc);
            groupBox1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(20, 181);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(296, 151);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri İşlemleri";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 117);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 3;
            label3.Text = "Telefon No";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 74);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 3;
            label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 32);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "TC No";
            // 
            // txtTelefon
            // 
            txtTelefon.BackColor = Color.LavenderBlush;
            txtTelefon.Location = new Point(121, 109);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(142, 22);
            txtTelefon.TabIndex = 0;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.BackColor = Color.LavenderBlush;
            txtAdSoyad.Location = new Point(121, 66);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(142, 22);
            txtAdSoyad.TabIndex = 0;
            // 
            // txtTc
            // 
            txtTc.BackColor = Color.LavenderBlush;
            txtTc.Location = new Point(121, 24);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(142, 22);
            txtTc.TabIndex = 0;
            txtTc.TextChanged += txtTc_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtToplamFiyat);
            groupBox2.Controls.Add(txtSatisFiyati);
            groupBox2.Controls.Add(txtMiktari);
            groupBox2.Controls.Add(txtUrunAdi);
            groupBox2.Controls.Add(txtBarkodNo);
            groupBox2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(20, 365);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(296, 231);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ürün İşlemleri";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(19, 193);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 3;
            label8.Text = "Toplam Fiyat";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(19, 151);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 3;
            label7.Text = "Satış Fiyatı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(19, 111);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 3;
            label6.Text = "Miktarı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(19, 73);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 3;
            label5.Text = "Ürün Adı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 30);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 3;
            label4.Text = "Barkod No";
            // 
            // txtToplamFiyat
            // 
            txtToplamFiyat.BackColor = Color.LavenderBlush;
            txtToplamFiyat.Location = new Point(121, 185);
            txtToplamFiyat.Name = "txtToplamFiyat";
            txtToplamFiyat.ReadOnly = true;
            txtToplamFiyat.Size = new Size(142, 22);
            txtToplamFiyat.TabIndex = 1;
            // 
            // txtSatisFiyati
            // 
            txtSatisFiyati.BackColor = Color.LavenderBlush;
            txtSatisFiyati.Location = new Point(121, 143);
            txtSatisFiyati.Name = "txtSatisFiyati";
            txtSatisFiyati.Size = new Size(142, 22);
            txtSatisFiyati.TabIndex = 0;
            txtSatisFiyati.TextChanged += txtSatisFiyati_TextChanged;
            // 
            // txtMiktari
            // 
            txtMiktari.BackColor = Color.LavenderBlush;
            txtMiktari.Location = new Point(121, 103);
            txtMiktari.Name = "txtMiktari";
            txtMiktari.Size = new Size(142, 22);
            txtMiktari.TabIndex = 0;
            txtMiktari.Text = "1";
            txtMiktari.TextAlign = HorizontalAlignment.Center;
            txtMiktari.TextChanged += txtMiktari_TextChanged;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.BackColor = Color.LavenderBlush;
            txtUrunAdi.Location = new Point(121, 65);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(142, 22);
            txtUrunAdi.TabIndex = 0;
            // 
            // txtBarkodNo
            // 
            txtBarkodNo.BackColor = Color.LavenderBlush;
            txtBarkodNo.Location = new Point(121, 22);
            txtBarkodNo.Name = "txtBarkodNo";
            txtBarkodNo.Size = new Size(142, 22);
            txtBarkodNo.TabIndex = 0;
            txtBarkodNo.TextChanged += txtBarkodNo_TextChanged;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Tomato;
            btnSil.Cursor = Cursors.Hand;
            btnSil.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btnSil.ForeColor = Color.DarkBlue;
            btnSil.Location = new Point(1009, 181);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 40);
            btnSil.TabIndex = 3;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.YellowGreen;
            btnEkle.Cursor = Cursors.Hand;
            btnEkle.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btnEkle.ForeColor = Color.Firebrick;
            btnEkle.Location = new Point(346, 559);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(109, 37);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSatisİptal
            // 
            btnSatisİptal.BackColor = Color.Tomato;
            btnSatisİptal.Cursor = Cursors.Hand;
            btnSatisİptal.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btnSatisİptal.ForeColor = Color.DarkBlue;
            btnSatisİptal.Location = new Point(1009, 247);
            btnSatisİptal.Name = "btnSatisİptal";
            btnSatisİptal.Size = new Size(75, 37);
            btnSatisİptal.TabIndex = 3;
            btnSatisİptal.Text = "Satış İptal";
            btnSatisİptal.UseVisualStyleBackColor = false;
            btnSatisİptal.Click += btnSatisİptal_Click;
            // 
            // btnSatisYap
            // 
            btnSatisYap.BackColor = Color.YellowGreen;
            btnSatisYap.Cursor = Cursors.Hand;
            btnSatisYap.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btnSatisYap.ForeColor = Color.Firebrick;
            btnSatisYap.Location = new Point(883, 558);
            btnSatisYap.Name = "btnSatisYap";
            btnSatisYap.Size = new Size(100, 38);
            btnSatisYap.TabIndex = 3;
            btnSatisYap.Text = "Satış Yap";
            btnSatisYap.UseVisualStyleBackColor = false;
            btnSatisYap.Click += btnSatisYap_Click;
            // 
            // lblGenelToplam
            // 
            lblGenelToplam.BackColor = Color.LavenderBlush;
            lblGenelToplam.BorderStyle = BorderStyle.Fixed3D;
            lblGenelToplam.Location = new Point(673, 573);
            lblGenelToplam.Name = "lblGenelToplam";
            lblGenelToplam.Size = new Size(159, 23);
            lblGenelToplam.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(586, 581);
            label10.Name = "label10";
            label10.Size = new Size(81, 15);
            label10.TabIndex = 4;
            label10.Text = "Genel Toplam";
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1337, 100);
            panel1.TabIndex = 5;
            // 
            // button3
            // 
            button3.BackColor = Color.LavenderBlush;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            button3.ForeColor = Color.ForestGreen;
            button3.Location = new Point(1191, 31);
            button3.Name = "button3";
            button3.Size = new Size(134, 44);
            button3.TabIndex = 3;
            button3.Text = "Marka";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LavenderBlush;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            button2.ForeColor = Color.ForestGreen;
            button2.Location = new Point(1051, 31);
            button2.Name = "button2";
            button2.Size = new Size(134, 44);
            button2.TabIndex = 2;
            button2.Text = "Kategori";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LavenderBlush;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            button1.ForeColor = Color.ForestGreen;
            button1.Location = new Point(20, 31);
            button1.Name = "button1";
            button1.Size = new Size(144, 44);
            button1.TabIndex = 1;
            button1.Text = "Müşteri Ekleme";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.LavenderBlush;
            button9.Cursor = Cursors.Hand;
            button9.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            button9.ForeColor = Color.ForestGreen;
            button9.Location = new Point(787, 31);
            button9.Name = "button9";
            button9.Size = new Size(134, 44);
            button9.TabIndex = 0;
            button9.Text = "Satışları Listeleme";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.LavenderBlush;
            button8.Cursor = Cursors.Hand;
            button8.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            button8.ForeColor = Color.ForestGreen;
            button8.Location = new Point(647, 31);
            button8.Name = "button8";
            button8.Size = new Size(134, 44);
            button8.TabIndex = 0;
            button8.Text = "Ürün Listeleme";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.LavenderBlush;
            button7.Cursor = Cursors.Hand;
            button7.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            button7.ForeColor = Color.ForestGreen;
            button7.Location = new Point(507, 31);
            button7.Name = "button7";
            button7.Size = new Size(134, 44);
            button7.TabIndex = 0;
            button7.Text = "Ürün Ekleme";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.LavenderBlush;
            button6.Cursor = Cursors.Hand;
            button6.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            button6.ForeColor = Color.ForestGreen;
            button6.Location = new Point(170, 31);
            button6.Name = "button6";
            button6.Size = new Size(138, 44);
            button6.TabIndex = 0;
            button6.Text = "Müşteri Listeleme";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // lblTarihSaat
            // 
            lblTarihSaat.BackColor = Color.BurlyWood;
            lblTarihSaat.BorderStyle = BorderStyle.Fixed3D;
            lblTarihSaat.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTarihSaat.ForeColor = Color.Black;
            lblTarihSaat.Location = new Point(1009, 561);
            lblTarihSaat.Name = "lblTarihSaat";
            lblTarihSaat.Size = new Size(316, 46);
            lblTarihSaat.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.BurlyWood;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1090, 298);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 254);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frmSatis
            // 
            AcceptButton = btnEkle;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1337, 656);
            Controls.Add(pictureBox1);
            Controls.Add(lblTarihSaat);
            Controls.Add(panel1);
            Controls.Add(label10);
            Controls.Add(lblGenelToplam);
            Controls.Add(btnEkle);
            Controls.Add(btnSatisYap);
            Controls.Add(btnSatisİptal);
            Controls.Add(btnSil);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmSatis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Satış Sayfası";
            WindowState = FormWindowState.Maximized;
            Load += frmSatis_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox txtTelefon;
        private TextBox txtAdSoyad;
        private TextBox txtTc;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtToplamFiyat;
        private TextBox txtSatisFiyati;
        private TextBox txtMiktari;
        private TextBox txtUrunAdi;
        private TextBox txtBarkodNo;
        private Button btnSil;
        private Button btnEkle;
        private Button btnSatisİptal;
        private Button btnSatisYap;
        private Label lblGenelToplam;
        private Label label10;
        private Panel panel1;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button1;
        private Button button3;
        private Button button2;
        private Label lblTarihSaat;
        private PictureBox pictureBox1;
    }
}
