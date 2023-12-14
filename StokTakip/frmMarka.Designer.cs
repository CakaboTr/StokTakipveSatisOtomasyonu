namespace StokTakip
{
    partial class frmMarka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarka));
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.MistyRose;
            comboBox1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(192, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(137, 23);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(99, 68);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 1;
            label1.Text = "Kategori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(99, 123);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Marka";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MistyRose;
            textBox1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(192, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 22);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            button1.ForeColor = Color.Firebrick;
            button1.Location = new Point(220, 162);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 4;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmMarka
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(439, 232);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMarka";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Marka Sayfası";
            Load += frmMarka_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
    }
}