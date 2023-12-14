namespace StokTakip
{
    partial class frmKategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKategori));
            label1 = new Label();
            textBox1 = new TextBox();
            btnKategoriEkle = new Button();
            label2 = new Label();
            btnKategoriSil = new Button();
            comboKategoriSil = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(64, 54);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Kategori";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MistyRose;
            textBox1.Location = new Point(140, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 23);
            textBox1.TabIndex = 1;
            // 
            // btnKategoriEkle
            // 
            btnKategoriEkle.BackColor = Color.YellowGreen;
            btnKategoriEkle.Cursor = Cursors.Hand;
            btnKategoriEkle.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btnKategoriEkle.ForeColor = Color.Brown;
            btnKategoriEkle.Location = new Point(235, 75);
            btnKategoriEkle.Name = "btnKategoriEkle";
            btnKategoriEkle.Size = new Size(80, 32);
            btnKategoriEkle.TabIndex = 2;
            btnKategoriEkle.Text = "Ekle";
            btnKategoriEkle.UseVisualStyleBackColor = false;
            btnKategoriEkle.Click += btnKategoriEkle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 170);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 0;
            label2.Text = "Kategori Silme Alanı";
            // 
            // btnKategoriSil
            // 
            btnKategoriSil.BackColor = Color.Tomato;
            btnKategoriSil.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btnKategoriSil.ForeColor = Color.DarkBlue;
            btnKategoriSil.Location = new Point(240, 206);
            btnKategoriSil.Name = "btnKategoriSil";
            btnKategoriSil.Size = new Size(75, 33);
            btnKategoriSil.TabIndex = 4;
            btnKategoriSil.Text = "Sil";
            btnKategoriSil.UseVisualStyleBackColor = false;
            btnKategoriSil.Click += btnKategoriSil_Click;
            // 
            // comboKategoriSil
            // 
            comboKategoriSil.BackColor = Color.MistyRose;
            comboKategoriSil.FormattingEnabled = true;
            comboKategoriSil.Location = new Point(140, 162);
            comboKategoriSil.Name = "comboKategoriSil";
            comboKategoriSil.Size = new Size(175, 23);
            comboKategoriSil.TabIndex = 3;
            // 
            // frmKategori
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(382, 263);
            Controls.Add(btnKategoriSil);
            Controls.Add(comboKategoriSil);
            Controls.Add(btnKategoriEkle);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmKategori";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kategori Sayfası";
            Load += frmKategori_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btnKategoriEkle;
        private Label label2;
        private Button btnKategoriSil;
        private ComboBox comboKategoriSil;
    }
}