using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class frmMarka : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-48INIBJ\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");

        public frmMarka()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BosMarkaMi(textBox1.Text))
            {
                MessageBox.Show("Marka boş olamaz.", "Uyarı");
                return;
            }

            if (MarkaVarMi(comboBox1.Text, textBox1.Text))
            {
                MessageBox.Show("Bu kategori ve marka zaten var.", "Uyarı");
                return;
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into markabilgileri(kategori,marka) values('" + comboBox1.Text + "','" + textBox1.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            textBox1.Text = "";
            comboBox1.Text = "";

            MessageBox.Show("Marka Eklendi.", "Bilgi");
        }

        private void frmMarka_Load(object sender, EventArgs e)
        {
            KategorileriGetir();
        }

        private void KategorileriGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }

        private bool BosMarkaMi(string marka)
        {
            return string.IsNullOrWhiteSpace(marka);
        }

        private bool MarkaVarMi(string kategori, string marka)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM markabilgileri WHERE kategori = @kategori AND marka = @marka", baglanti);
            komut.Parameters.AddWithValue("@kategori", kategori);
            komut.Parameters.AddWithValue("@marka", marka);
            int markaSayisi = (int)komut.ExecuteScalar();
            baglanti.Close();

            return markaSayisi > 0;
        }
    }
}
