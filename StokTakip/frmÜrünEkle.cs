using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Forms;


namespace StokTakip
{
    public partial class frmÜrünEkle : Form
    {
        public frmÜrünEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-48INIBJ\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");

        bool durum;
        private void barkodKontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from urun", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkodNo.Text == read["barkodNo"].ToString() || txtBarkodNo.Text =="")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }

        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboKategori.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }

        private void frmÜrünEkle_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from markabilgileri where kategori = '" + comboKategori.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            barkodKontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into urun (barkodNo,kategori,marka,ürünAdi,miktarı,alisfiyati,satisfiyati,tarih)  values (@barkodNo,@kategori,@marka,@ürünAdi,@miktarı,@alisfiyati,@satisfiyati,@tarih)", baglanti);

                komut.Parameters.AddWithValue("@barkodNo", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);
                komut.Parameters.AddWithValue("@ürünAdi", txtUrunAdi.Text);
                komut.Parameters.AddWithValue("@miktarı", int.Parse(txtMiktari.Text));
                komut.Parameters.AddWithValue("@alisfiyati", double.Parse(txtAlisFiyati.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatisFiyati.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Ürün Eklendi", "Bilgi");
            }
            else
            {
                MessageBox.Show("Böyle bir barkod no vardır." ,"Uyarı");
            }

            comboMarka.Items.Clear();

            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }

        }

        private void BarkodNoTxt_TextChanged(object sender, EventArgs e)
        {
            if (BarkodNoTxt.Text == "")
            {
                lblMiktari.Text = "";

                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from urun where barkodNo like '" + BarkodNoTxt.Text + "'  ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                KategoriTxt.Text = read["kategori"].ToString();
                MarkaTxt.Text = read["marka"].ToString();
                urunAdiTxt.Text = read["ürünAdi"].ToString();
                lblMiktari.Text = read["miktarı"].ToString();
                AlisFiyatiTxt.Text = read["alisfiyati"].ToString();
                SatisFiyatiTxt.Text = read["satisfiyati"].ToString();


            }
            baglanti.Close();
        }

        private void btnVarOlanaEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set miktarı = miktarı + '"+int.Parse(MiktariTxt.Text)+"' where barkodNo = '"+BarkodNoTxt.Text+"' ",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close() ;

            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("Stoktaki ürüne ekleme yapıldı.", "Bilgi");
        }
    }
}
