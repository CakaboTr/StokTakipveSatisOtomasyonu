namespace StokTakip
{
    partial class frmSatisListeleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatisListeleme));
            dataGridView1 = new DataGridView();
            btnSatisSil = new Button();
            label1 = new Label();
            lblToplamMiktar = new Label();
            lblToplamFiyat = new Label();
            btnUrunSatisListele = new Button();
            btnTopluSil = new Button();
            label2 = new Label();
            lblToplamNakit = new Label();
            lblToplamKrediKarti = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MistyRose;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(278, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(695, 348);
            dataGridView1.TabIndex = 0;
            // 
            // btnSatisSil
            // 
            btnSatisSil.BackColor = Color.Tomato;
            btnSatisSil.Cursor = Cursors.Hand;
            btnSatisSil.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btnSatisSil.ForeColor = Color.DarkBlue;
            btnSatisSil.Location = new Point(153, 12);
            btnSatisSil.Name = "btnSatisSil";
            btnSatisSil.Size = new Size(103, 34);
            btnSatisSil.TabIndex = 1;
            btnSatisSil.Text = "Sil";
            btnSatisSil.UseVisualStyleBackColor = false;
            btnSatisSil.Click += btnSatisSil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 31);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 2;
            label1.Text = "Kayıt Silme Alanı";
            // 
            // lblToplamMiktar
            // 
            lblToplamMiktar.BorderStyle = BorderStyle.Fixed3D;
            lblToplamMiktar.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblToplamMiktar.Location = new Point(25, 135);
            lblToplamMiktar.Name = "lblToplamMiktar";
            lblToplamMiktar.Size = new Size(247, 23);
            lblToplamMiktar.TabIndex = 3;
            // 
            // lblToplamFiyat
            // 
            lblToplamFiyat.BorderStyle = BorderStyle.Fixed3D;
            lblToplamFiyat.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblToplamFiyat.Location = new Point(25, 158);
            lblToplamFiyat.Name = "lblToplamFiyat";
            lblToplamFiyat.Size = new Size(247, 23);
            lblToplamFiyat.TabIndex = 4;
            // 
            // btnUrunSatisListele
            // 
            btnUrunSatisListele.BackColor = Color.YellowGreen;
            btnUrunSatisListele.Cursor = Cursors.Hand;
            btnUrunSatisListele.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btnUrunSatisListele.ForeColor = Color.DarkBlue;
            btnUrunSatisListele.Location = new Point(25, 337);
            btnUrunSatisListele.Name = "btnUrunSatisListele";
            btnUrunSatisListele.Size = new Size(231, 23);
            btnUrunSatisListele.TabIndex = 5;
            btnUrunSatisListele.Text = "En Çok Satılan Ürün Listesi";
            btnUrunSatisListele.UseVisualStyleBackColor = false;
            btnUrunSatisListele.Click += btnUrunSatisListele_Click;
            // 
            // btnTopluSil
            // 
            btnTopluSil.BackColor = Color.Tomato;
            btnTopluSil.Cursor = Cursors.Hand;
            btnTopluSil.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btnTopluSil.ForeColor = Color.DarkBlue;
            btnTopluSil.Location = new Point(153, 63);
            btnTopluSil.Name = "btnTopluSil";
            btnTopluSil.Size = new Size(103, 34);
            btnTopluSil.TabIndex = 1;
            btnTopluSil.Text = "Toplu Sil";
            btnTopluSil.UseVisualStyleBackColor = false;
            btnTopluSil.Click += btnSatisSil_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 82);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Seçili";
            // 
            // lblToplamNakit
            // 
            lblToplamNakit.BorderStyle = BorderStyle.Fixed3D;
            lblToplamNakit.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblToplamNakit.Location = new Point(25, 195);
            lblToplamNakit.Name = "lblToplamNakit";
            lblToplamNakit.Size = new Size(247, 23);
            lblToplamNakit.TabIndex = 4;
            // 
            // lblToplamKrediKarti
            // 
            lblToplamKrediKarti.BorderStyle = BorderStyle.Fixed3D;
            lblToplamKrediKarti.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblToplamKrediKarti.Location = new Point(25, 218);
            lblToplamKrediKarti.Name = "lblToplamKrediKarti";
            lblToplamKrediKarti.Size = new Size(247, 23);
            lblToplamKrediKarti.TabIndex = 4;
            // 
            // frmSatisListeleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(985, 372);
            Controls.Add(btnUrunSatisListele);
            Controls.Add(lblToplamKrediKarti);
            Controls.Add(lblToplamNakit);
            Controls.Add(lblToplamFiyat);
            Controls.Add(lblToplamMiktar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTopluSil);
            Controls.Add(btnSatisSil);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmSatisListeleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Satış Listeme Sayfası";
            Load += frmSatisListeleme_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSatisSil;
        private Label label1;
        private Label lblToplamMiktar;
        private Label lblToplamFiyat;
        private Button btnUrunSatisListele;
        private Button btnTopluSil;
        private Label label2;
        private Label lblToplamNakit;
        private Label lblToplamKrediKarti;
    }
}