using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StokYonetim
{
    public partial class Giris : Form
    {
        public SqlConnection sqlbaglan = new SqlConnection("Data Source = ALIHAN\\SQLEXPRESS;Initial Catalog = StokYonetim; Integrated Security = True");

        public Giris()
        {
            InitializeComponent();
        }
        private void GirisYapBtn_Click(object sender, EventArgs e)
        {
            sqlbaglan.Open();
            SqlCommand cmd = new SqlCommand("select * from Yonetici where KullaniciAdi='" + txtKullaniciAdi.Text + "' and KullaniciSifre='" + txtSifre.Text + "'", sqlbaglan);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                AnaSayfa girisform = new AnaSayfa();
                girisform.Show();
                AnaSayfa formkapa = new AnaSayfa();
                formkapa.Close();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adınız veya Şifreniz Yanlış", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            sqlbaglan.Close();
        }
    }
}