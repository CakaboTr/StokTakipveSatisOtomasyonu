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
    public partial class frmSatisListeleme : Form
    {
        public frmSatisListeleme()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-48INIBJ\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");

        DataSet daset = new DataSet();

        private void satisListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from satis", baglanti);
            adtr.Fill(daset, "satis");
            dataGridView1.DataSource = daset.Tables["satis"];

            int toplamMiktar = 0;
            decimal toplamFiyat = 0;
            decimal toplamNakit = 0;
            decimal toplamKrediKarti = 0;

            foreach (DataRow row in daset.Tables["satis"].Rows)
            {
                int miktar;
                decimal fiyat;

                if (int.TryParse(row["miktari"].ToString(), out miktar) && decimal.TryParse(row["toplamfiyati"].ToString(), out fiyat))
                {
                    toplamMiktar += miktar;
                    toplamFiyat += fiyat;

                    // Ödeme şekline göre toplamı hesapla
                    string odemeSekli = row["OdemeSekli"].ToString();
                    if (odemeSekli.Equals("Nakit", StringComparison.OrdinalIgnoreCase))
                    {
                        toplamNakit += fiyat;
                    }
                    else if (odemeSekli.Equals("Kredi Kartı", StringComparison.OrdinalIgnoreCase))
                    {
                        toplamKrediKarti += fiyat;
                    }
                }
            }

            // Form üzerindeki Label'ları güncelle
            lblToplamMiktar.Text = "Toplam Satış Miktarı: " + toplamMiktar.ToString();
            lblToplamFiyat.Text = "Toplam Satış Fiyatı: " + toplamFiyat.ToString("C2");
            lblToplamNakit.Text = "Toplam Nakit Satış: " + toplamNakit.ToString("C2");
            lblToplamKrediKarti.Text = "Toplam Kredi Kartı Satış: " + toplamKrediKarti.ToString("C2");

            baglanti.Close();
        }

        private void frmSatisListeleme_Load(object sender, EventArgs e)
        {
            satisListele();
        }

        private void btnSatisSil_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Seçili satışı silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int selectedSatisID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("DELETE FROM satis WHERE id = @id", baglanti);
                    komut.Parameters.AddWithValue("@id", selectedSatisID);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    daset.Tables["satis"].Clear();
                    satisListele();

                    MessageBox.Show("Satış başarıyla silindi.", "Bilgi");

                    lblToplamNakit.Text = GetOdemeSekli(selectedSatisID);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satışı seçin.", "Uyarı");
            }
        }
        private void btnTopluSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Seçili satışları silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    baglanti.Open();

                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        int selectedSatisID = Convert.ToInt32(row.Cells["id"].Value);

                        SqlCommand komut = new SqlCommand("DELETE FROM satis WHERE id = @id", baglanti);
                        komut.Parameters.AddWithValue("@id", selectedSatisID);
                        komut.ExecuteNonQuery();

                        // Ödeme şeklini güncelle
                        lblToplamNakit.Text = GetOdemeSekli(selectedSatisID);
                    }

                    baglanti.Close();

                    daset.Tables["satis"].Clear();
                    satisListele();

                    MessageBox.Show("Seçili satışlar başarıyla silindi.", "Bilgi");
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satışları seçin.", "Uyarı");
            }
        }


        private void btnUrunSatisListele_Click(object sender, EventArgs e)
        {
            frmUrunSatisListele listele = new frmUrunSatisListele();
            listele.ShowDialog();
        }

        private string GetOdemeSekli(int satisID)
        {
            string odemeSekli = "";

            using (SqlCommand komut = new SqlCommand("SELECT OdemeSekli FROM satis WHERE id = @id", baglanti))
            {
                komut.Parameters.AddWithValue("@id", satisID);

                baglanti.Open();
                using (SqlDataReader reader = komut.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        odemeSekli = reader["OdemeSekli"].ToString();
                    }
                }
                baglanti.Close();
            }

            return odemeSekli;
        }
    }

}

