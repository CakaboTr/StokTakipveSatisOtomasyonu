using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class frmKategori : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-48INIBJ\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");

        public frmKategori()
        {
            InitializeComponent();
        }

        bool durum;

        private void KategoriKontrol()
        {
            durum = true;

            try
            {
                if (baglanti.State == System.Data.ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                using (SqlCommand komut = new SqlCommand("SELECT * FROM kategoribilgileri WHERE kategori = @kategori", baglanti))
                {
                    komut.Parameters.AddWithValue("@kategori", textBox1.Text);
                    SqlDataReader read = komut.ExecuteReader();

                    while (read.Read())
                    {
                        if (textBox1.Text == read["kategori"].ToString() || textBox1.Text == "")
                        {
                            durum = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategori kontrolünde bir hata oluştu: " + ex.Message, "Hata");
            }
            finally
            {
                KapatBaglanti();
            }
        }

        private void frmKategori_Load(object sender, EventArgs e)
        {
            // comboKategoriSil içeriğini doldur
            ComboKategoriSilDoldur();
        }

        private void ComboKategoriSilDoldur()
        {
            try
            {
                // Önce comboKategoriSil'i temizle
                comboKategoriSil.Items.Clear();

                if (baglanti.State == System.Data.ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                // Sonra kategorileri veritabanından çekip comboKategoriSil'e ekleyin
                using (SqlCommand komut = new SqlCommand("SELECT * FROM kategoribilgileri", baglanti))
                {
                    SqlDataReader read = komut.ExecuteReader();

                    while (read.Read())
                    {
                        comboKategoriSil.Items.Add(read["kategori"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Combo doldurma hatası: " + ex.Message, "Hata");
            }
            finally
            {
                KapatBaglanti();
            }
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            KategoriKontrol();
            if (durum)
            {
                try
                {
                    if (baglanti.State == System.Data.ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }

                    using (SqlCommand komut = new SqlCommand("INSERT INTO kategoribilgileri(kategori) VALUES (@kategori)", baglanti))
                    {
                        komut.Parameters.AddWithValue("@kategori", textBox1.Text);
                        komut.ExecuteNonQuery();
                    }

                    MessageBox.Show("Kategori Eklendi", "Bilgi");

                    // Yeni kategori ekledikten sonra comboKategoriSil içeriğini güncelle
                    ComboKategoriSilDoldur();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kategori ekleme işleminde bir hata oluştu: " + ex.Message, "Hata");
                }
                finally
                {
                    KapatBaglanti();
                }
            }
            else
            {
                MessageBox.Show("Böyle bir kategori var veya kategori adı boş", "Uyarı");
            }
            textBox1.Text = "";
        }

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            // Seçili kategoriyi sil
            string seciliKategori = comboKategoriSil.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(seciliKategori))
            {
                try
                {
                    if (baglanti.State == System.Data.ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }

                    using (SqlCommand komut = new SqlCommand("DELETE FROM kategoribilgileri WHERE kategori = @kategori", baglanti))
                    {
                        komut.Parameters.AddWithValue("@kategori", seciliKategori);
                        komut.ExecuteNonQuery();
                    }

                    MessageBox.Show("Kategori Silindi", "Bilgi");

                    // Kategori silindikten sonra comboKategoriSil içeriğini güncelle ve sıfırla
                    ComboKategoriSilDoldur();
                    comboKategoriSil.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kategori silme işleminde bir hata oluştu: " + ex.Message, "Hata");
                }
                finally
                {
                    KapatBaglanti();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kategori seçin", "Uyarı");
            }
        }

        private void KapatBaglanti()
        {
            if (baglanti != null && baglanti.State == System.Data.ConnectionState.Open)
            {
                baglanti.Close();
            }
        }
    }
}
