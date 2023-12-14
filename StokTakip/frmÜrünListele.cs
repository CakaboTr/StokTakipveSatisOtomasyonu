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

namespace StokTakip
{
    public partial class frmÜrünListele : Form
    {
        public frmÜrünListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-48INIBJ\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");

        DataSet daset = new DataSet();

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

        private void frmÜrünListele_Load(object sender, EventArgs e)
        {
            ÜrünListele();
            kategorigetir();
        }

        private void ÜrünListele()
        {
            baglanti.Open();

            SqlDataAdapter adtr = new SqlDataAdapter("select * from urun", baglanti);
            adtr.Fill(daset, "urun");
            dataGridView1.DataSource = daset.Tables["urun"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BarkodNoTxt.Text = dataGridView1.CurrentRow.Cells["barkodNo"].Value.ToString();
            KategoriTxt.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            MarkaTxt.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            urunAdiTxt.Text = dataGridView1.CurrentRow.Cells["ürünAdi"].Value.ToString();
            MiktariTxt.Text = dataGridView1.CurrentRow.Cells["miktarı"].Value.ToString();
            AlisFiyatiTxt.Text = dataGridView1.CurrentRow.Cells["alisfiyati"].Value.ToString();
            SatisFiyatiTxt.Text = dataGridView1.CurrentRow.Cells["satisfiyati"].Value.ToString();

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("update urun set ürünAdi = @ürünAdi,miktarı = @miktarı,alisfiyati = @alisfiyati, satisfiyati = @satisfiyati where barkodNo = @barkodNo ", baglanti);

            komut.Parameters.AddWithValue("@barkodNo", BarkodNoTxt.Text);
            komut.Parameters.AddWithValue("@ürünAdi", urunAdiTxt.Text);
            komut.Parameters.AddWithValue("@miktarı", int.Parse(MiktariTxt.Text));
            komut.Parameters.AddWithValue("@alisfiyati", double.Parse(AlisFiyatiTxt.Text));
            komut.Parameters.AddWithValue("@satisfiyati", double.Parse(SatisFiyatiTxt.Text));
            komut.ExecuteNonQuery();

            baglanti.Close();

            daset.Tables["urun"].Clear();

            ÜrünListele();
            MessageBox.Show("Güncelleme Yapıldı", "Bilgi");

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnMarkaGuncelle_Click(object sender, EventArgs e)
        {

            if (BarkodNoTxt.Text != "")
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("update urun set kategori = @kategori,marka = @marka where barkodNo = @barkodNo ", baglanti);

                komut.Parameters.AddWithValue("@barkodNo", BarkodNoTxt.Text);
                komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);

                komut.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Güncelleme Yapıldı", "Bilgi");

                daset.Tables["urun"].Clear();

                ÜrünListele();
            }

            else
            {
                MessageBox.Show("BarkodNo yazılı değil", "Uyarı");
            }

            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("delete from urun where barkodNo='" + dataGridView1.CurrentRow.Cells["barkodNo"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            daset.Tables["urun"].Clear();
            ÜrünListele();
            MessageBox.Show("Kayıt Silindi.", "Bilgi");
        }

        private void txtBarkodNoAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from urun where barkodNo like '%" + txtBarkodNoAra.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
