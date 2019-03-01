using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StokYonetim
{
    public partial class AnaSayfa : Form
    {
        public SqlConnection sqlbaglan = new SqlConnection("Data Source = ALIHAN\\SQLEXPRESS;Initial Catalog = StokYonetim; Integrated Security = True");
        public AnaSayfa()
        {
            InitializeComponent();
        }
        private void UrunEkleFrm_Click(object sender, System.EventArgs e)
        {
            UrunEkleForm UrunEkleFrm = new UrunEkleForm();
            UrunEkleFrm.Show();
            UrunEkleForm formkapa = new UrunEkleForm();
            formkapa.Close();
            this.Hide();
        }
        private void StokGorFrm_Click(object sender, System.EventArgs e)
        {

        }
        private void BorcAlacakFrm_Click(object sender, System.EventArgs e)
        {
            BorcAlacakForm BorcAlacakFrm = new BorcAlacakForm();
            BorcAlacakFrm.Show();
            BorcAlacakForm formkapa = new BorcAlacakForm();
            formkapa.Close();
            this.Hide();
        }
        private void SatisFrm_Click(object sender, System.EventArgs e)
        {
            SatisForm SatisFrm = new SatisForm();
            SatisFrm.Show();
            SatisForm formkapa = new SatisForm();
            formkapa.Close();
            this.Hide();
        }
        private void SiparisFrm_Click(object sender, System.EventArgs e)
        {
            SiparisListeleForm SiparisFrm = new SiparisListeleForm();
            SiparisFrm.Show();
            SiparisListeleForm formkapa = new SiparisListeleForm();
            formkapa.Close();
            this.Hide();
        }
        private void GiderlerFrm_Click(object sender, System.EventArgs e)
        {
            GiderlerForm GiderlerFrm = new GiderlerForm();
            GiderlerFrm.Show();
            GiderlerForm formkapa = new GiderlerForm();
            formkapa.Close();
            this.Hide();
        }
        private void AnaSayfaBarkodOkuBtn_Click(object sender, System.EventArgs e)
        {
            sqlbaglan.Open();
            
            if (txtUrunBarkodAra.Text != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlbaglan;
                cmd.CommandText = "select Urun_Barkod, Urun_Adi, Urun_SatisFiyati from Urun where Urun_Barkod like '%" + txtUrunBarkodAra.Text + "%'";
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Urun");
                dataGridView1.DataSource = ds.Tables["Urun"];
            }
            else
            {
                MessageBox.Show("Barkod Alanı Boş Bırakılamaz", "TEKRAR DENEYİN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            sqlbaglan.Close();
        }
        private void txtUrunBarkodAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Lütfen Rakam Girişi Yapınız", "UYARI!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
    
