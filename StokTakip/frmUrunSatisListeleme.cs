using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class frmUrunSatisListele : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-48INIBJ\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");
        DataSet daset = new DataSet();

        public frmUrunSatisListele()
        {
            InitializeComponent();
        }

        private void urunSatisListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from satis", baglanti);
            adtr.Fill(daset, "satis");
            dataGridView1.DataSource = daset.Tables["satis"];
            baglanti.Close();
        }

        private void frmUrunSatisListele_Load(object sender, EventArgs e)
        {
            urunSatisListele();
            EnCokSatanUrunleriListele();
        }

        private void EnCokSatanUrunleriListele()
        {
            // Satis tablosundan en çok satılan 5 ürünü getir
            baglanti.Open();
            SqlCommand komut = new SqlCommand(@"
                SELECT TOP 5 urunadi, SUM(miktari) AS toplamMiktar
                FROM satis
                GROUP BY urunadi
                ORDER BY toplamMiktar DESC", baglanti);

            SqlDataReader read = komut.ExecuteReader();
            int i = 0;

            while (read.Read() && i < 5)
            {
                string urunAdi = read["urunadi"].ToString();
                int toplamMiktar = Convert.ToInt32(read["toplamMiktar"]);

                // Label isimlendirme
                string labelName = $"lblEnCokSatilan{i + 1}";

                // Kontrol isminin doğruluğunu kontrol et
                if (Controls.ContainsKey(labelName))
                {
                    Controls[labelName].Text = $"{(i + 1)}. En Çok Satan Ürün: {urunAdi} \n Toplam Miktar: {toplamMiktar}";


                }

                i++;
            }

            baglanti.Close();
        }
    }
}
