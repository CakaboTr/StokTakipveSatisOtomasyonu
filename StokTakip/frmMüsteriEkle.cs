using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class frmMüsteriEkle : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-48INIBJ\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");

        public frmMüsteriEkle()
        {
            InitializeComponent();
        }

        private void frmMüsteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("insert into müşteri(tc,adsoyad,telefon,adres,email) values (@tc,@adsoyad,@telefon,@adres,@email)", baglanti);

            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@email", txtEmail.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Eklendi","Bilgi");
            this.Close();
            // TextBox'ları temizleme
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

     
    }
}