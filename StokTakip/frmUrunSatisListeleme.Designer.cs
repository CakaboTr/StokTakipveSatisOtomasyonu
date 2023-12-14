namespace StokTakip
{
    partial class frmUrunSatisListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunSatisListele));
            dataGridView1 = new DataGridView();
            lblEnCokSatilan1 = new Label();
            lblEnCokSatilan2 = new Label();
            lblEnCokSatilan3 = new Label();
            lblEnCokSatilan4 = new Label();
            lblEnCokSatilan5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MistyRose;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(386, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(557, 382);
            dataGridView1.TabIndex = 0;
            // 
            // lblEnCokSatilan1
            // 
            lblEnCokSatilan1.BorderStyle = BorderStyle.Fixed3D;
            lblEnCokSatilan1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEnCokSatilan1.Location = new Point(12, 12);
            lblEnCokSatilan1.Name = "lblEnCokSatilan1";
            lblEnCokSatilan1.Size = new Size(368, 42);
            lblEnCokSatilan1.TabIndex = 1;
            // 
            // lblEnCokSatilan2
            // 
            lblEnCokSatilan2.BorderStyle = BorderStyle.Fixed3D;
            lblEnCokSatilan2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEnCokSatilan2.Location = new Point(12, 81);
            lblEnCokSatilan2.Name = "lblEnCokSatilan2";
            lblEnCokSatilan2.Size = new Size(368, 42);
            lblEnCokSatilan2.TabIndex = 2;
            // 
            // lblEnCokSatilan3
            // 
            lblEnCokSatilan3.BorderStyle = BorderStyle.Fixed3D;
            lblEnCokSatilan3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEnCokSatilan3.Location = new Point(12, 150);
            lblEnCokSatilan3.Name = "lblEnCokSatilan3";
            lblEnCokSatilan3.Size = new Size(368, 42);
            lblEnCokSatilan3.TabIndex = 3;
            // 
            // lblEnCokSatilan4
            // 
            lblEnCokSatilan4.BorderStyle = BorderStyle.Fixed3D;
            lblEnCokSatilan4.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEnCokSatilan4.Location = new Point(12, 219);
            lblEnCokSatilan4.Name = "lblEnCokSatilan4";
            lblEnCokSatilan4.Size = new Size(368, 42);
            lblEnCokSatilan4.TabIndex = 4;
            // 
            // lblEnCokSatilan5
            // 
            lblEnCokSatilan5.BorderStyle = BorderStyle.Fixed3D;
            lblEnCokSatilan5.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEnCokSatilan5.Location = new Point(12, 288);
            lblEnCokSatilan5.Name = "lblEnCokSatilan5";
            lblEnCokSatilan5.Size = new Size(368, 42);
            lblEnCokSatilan5.TabIndex = 5;
            // 
            // frmUrunSatisListele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(955, 426);
            Controls.Add(lblEnCokSatilan5);
            Controls.Add(lblEnCokSatilan4);
            Controls.Add(lblEnCokSatilan3);
            Controls.Add(lblEnCokSatilan2);
            Controls.Add(lblEnCokSatilan1);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmUrunSatisListele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Satış Listeleme Sayfası";
            Load += frmUrunSatisListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblEnCokSatilan1;
        private Label lblEnCokSatilan2;
        private Label lblEnCokSatilan3;
        private Label lblEnCokSatilan4;
        private Label lblEnCokSatilan5;
    }
}