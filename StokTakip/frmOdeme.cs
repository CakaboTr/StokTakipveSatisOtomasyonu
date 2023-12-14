namespace StokTakip
{
    public partial class frmOdeme : Form
    {
        public bool OdemeBasarili { get; private set; }

        public event Action<string> OdemeSekliSecildi;

        public frmOdeme()
        {
            InitializeComponent();
        }

        private void btnNakit_Click(object sender, EventArgs e)
        {
          
            OdemeBasarili = true;

            OdemeSekliSecildi?.Invoke("Nakit");

            this.Close();
        }

        private void btnKrediKarti_Click(object sender, EventArgs e)
        {

            OdemeBasarili = true;

            OdemeSekliSecildi?.Invoke("Kredi Kartı");

            this.Close();
        }
    }
}
