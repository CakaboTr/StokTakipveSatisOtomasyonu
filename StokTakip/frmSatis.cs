using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class frmSatis : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-48INIBJ\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");
        DataSet daset = new DataSet();

        public frmSatis()
        {
            InitializeComponent();
            lblTarihSaat.Text = "Tarih: "+ DateTime.Now.ToString("D");

        }





        private void sepetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from sepet", baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMüsteriEkle ekle = new frmMüsteriEkle();
            ekle.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMüsteriListeleme listele = new frmMüsteriListeleme();
            listele.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmÜrünEkle ekle = new frmÜrünEkle();
            ekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmKategori kategori = new frmKategori();
            kategori.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmÜrünListele listele = new frmÜrünListele();
            listele.ShowDialog();
        }

        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select sum(toplamfiyati) from sepet", baglanti);
                lblGenelToplam.Text = komut.ExecuteScalar() + " TL";
                baglanti.Close();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void frmSatis_Load(object sender, EventArgs e)
        {
            sepetListele();


        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {


            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from müşteri where tc like '%" + txtTc.Text + "%' ", baglanti);
            SqlDataReader read = komut.ExecuteReader();



            while (read.Read())
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtTelefon.Text = read["telefon"].ToString();

            }

            Temizle();

            baglanti.Close();

            if (txtTc.Text == "")
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtTc)
                        {
                            item.Text = "";
                        }
                    }

                }
            }
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            Temizle();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from urun where barkodNo like '" + txtBarkodNo.Text + "' ", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                txtUrunAdi.Text = read["ürünAdi"].ToString();
                txtSatisFiyati.Text = read["satisfiyati"].ToString();

            }

            baglanti.Close();
        }

        private void Temizle()
        {
            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtMiktari)
                        {
                            item.Text = "";
                        }
                    }

                }
            }
        }

        bool durum;
        private void barkodKontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from sepet", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkodNo.Text == read["barkodno"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();



        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            barkodKontrol();
            if (durum == true)
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("INSERT INTO sepet(tc, adsoyad, telefon, barkodno, urunadi, miktari, satisfiyati, toplamfiyati, tarih) VALUES(@tc, @adsoyad, @telefon, @barkodno, @urunadi, @miktari, @satisfiyati, @toplamfiyati, @tarih)", baglanti);

                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@urunadi", txtUrunAdi.Text);

                if (double.TryParse(txtMiktari.Text, out double miktari))
                    komut.Parameters.AddWithValue("@miktari", miktari);
                else
                {
                    baglanti.Close();
                    MessageBox.Show("Miktar alanına geçerli bir sayı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (double.TryParse(txtSatisFiyati.Text, out double satisFiyati))
                    komut.Parameters.AddWithValue("@satisfiyati", satisFiyati);
                else
                {
                    baglanti.Close();
                    MessageBox.Show("Satış fiyatı alanına geçerli bir sayı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (double.TryParse(txtToplamFiyat.Text, out double toplamFiyat)) // Güvenli dönüşüm
                    komut.Parameters.AddWithValue("@toplamfiyati", toplamFiyat);
                else
                {
                    baglanti.Close();
                    MessageBox.Show("Toplam fiyat alanına geçerli bir sayı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());

                komut.ExecuteNonQuery();

                baglanti.Close();
            }

            txtMiktari.Text = "1";

            daset.Tables["sepet"].Clear();

            sepetListele();
            hesapla();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtMiktari)
                    {
                        item.Text = "";
                    }
                }
            }
        }



        private void txtMiktari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktari.Text) * double.Parse(txtSatisFiyati.Text)).ToString("F2");
            }
            catch (Exception)
            {


            }
        }

        private void txtSatisFiyati_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktari.Text) * double.Parse(txtSatisFiyati.Text)).ToString("F2");
            }
            catch (Exception)
            {


            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string barkodNo = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();

                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM sepet WHERE barkodno = @barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", barkodNo);

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Ürün sepetten silindi", "Uyarı");

                daset.Tables["sepet"].Clear();
                sepetListele();
                hesapla();
            }
        }


        private void btnSatisİptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Satış İptal Edildi", "Uyarı");

            daset.Tables["sepet"].Clear();
            sepetListele();
            hesapla();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmSatisListeleme listele = new frmSatisListeleme();
            listele.ShowDialog();
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            using (frmOdeme odemeForm = new frmOdeme())
            {
                odemeForm.OdemeSekliSecildi += (odemeSekli) =>
                {
                    string odemeMetni = odemeSekli == "Nakit" ? "Nakit" : "Kredi Kartı";

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        baglanti.Open();

                        SqlCommand komut = new SqlCommand("insert into satis(tc,adsoyad,telefon,barkodno,urunadi,miktari,satisfiyati,toplamfiyati,tarih, OdemeSekli) values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih, @OdemeSekli) ", baglanti);

                        komut.Parameters.AddWithValue("@tc", txtTc.Text);
                        komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                        komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                        komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                        komut.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["urunadi"].Value.ToString());
                        komut.Parameters.AddWithValue("@miktari", int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()));
                        komut.Parameters.AddWithValue("@satisfiyati", double.Parse(dataGridView1.Rows[i].Cells["satisfiyati"].Value.ToString()));
                        komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(dataGridView1.Rows[i].Cells["toplamfiyati"].Value.ToString()));
                        komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                        komut.Parameters.AddWithValue("@OdemeSekli", odemeMetni);

                        komut.ExecuteNonQuery();

                        SqlCommand komut2 = new SqlCommand("update urun set miktarı = miktarı - '" + int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()) + "' where barkodNo = '" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "' ", baglanti);
                        komut2.ExecuteNonQuery();

                        baglanti.Close();
                    }

                    if (odemeForm.OdemeBasarili)
                    {
                        baglanti.Open();
                        SqlCommand komut3 = new SqlCommand("delete from sepet ", baglanti);
                        komut3.ExecuteNonQuery();
                        baglanti.Close();

                        daset.Tables["sepet"].Clear();
                        sepetListele();
                        hesapla();

                        MessageBox.Show("Satış ve Ödeme Gerçekleşti", "Bilgi");
                    }
                    else
                    {
                        MessageBox.Show("Ödeme Başarısız. Satış gerçekleşmedi.", "Uyarı");
                    }
                };

                odemeForm.ShowDialog();
            }
        }

       
    }
}