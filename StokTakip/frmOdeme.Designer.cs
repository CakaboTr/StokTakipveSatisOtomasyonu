namespace StokTakip
{
    partial class frmOdeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdeme));
            btnNakit = new Button();
            btnKrediKarti = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNakit
            // 
            btnNakit.BackColor = Color.White;
            btnNakit.BackgroundImage = (Image)resources.GetObject("btnNakit.BackgroundImage");
            btnNakit.BackgroundImageLayout = ImageLayout.Stretch;
            btnNakit.Cursor = Cursors.Hand;
            btnNakit.Location = new Point(106, 64);
            btnNakit.Name = "btnNakit";
            btnNakit.Size = new Size(167, 116);
            btnNakit.TabIndex = 0;
            btnNakit.UseVisualStyleBackColor = false;
            btnNakit.Click += btnNakit_Click;
            // 
            // btnKrediKarti
            // 
            btnKrediKarti.BackColor = Color.White;
            btnKrediKarti.BackgroundImage = (Image)resources.GetObject("btnKrediKarti.BackgroundImage");
            btnKrediKarti.BackgroundImageLayout = ImageLayout.Stretch;
            btnKrediKarti.Cursor = Cursors.Hand;
            btnKrediKarti.Location = new Point(409, 64);
            btnKrediKarti.Name = "btnKrediKarti";
            btnKrediKarti.Size = new Size(156, 116);
            btnKrediKarti.TabIndex = 0;
            btnKrediKarti.UseVisualStyleBackColor = false;
            btnKrediKarti.Click += btnKrediKarti_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnKrediKarti);
            groupBox1.Controls.Add(btnNakit);
            groupBox1.Location = new Point(32, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(619, 233);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ödeme Seçenekleri";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(409, 30);
            label2.Name = "label2";
            label2.Size = new Size(156, 24);
            label2.TabIndex = 1;
            label2.Text = "KREDİ KARTI";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(106, 30);
            label1.Name = "label1";
            label1.Size = new Size(167, 24);
            label1.TabIndex = 1;
            label1.Text = "NAKİT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmOdeme
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(705, 305);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmOdeme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ödeme Sayfası";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnNakit;
        private Button btnKrediKarti;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
    }
}