using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StokYonetim
{
    public partial class UrunEkleForm : Form
    {
        public SqlConnection sqlbaglan = new SqlConnection("Data Source = ALIHAN\\SQLEXPRESS;Initial Catalog = StokYonetim; Integrated Security = True");
        public UrunEkleForm()
        {
            InitializeComponent();
        }
        void listele()
        {
            if (sqlbaglan.State == ConnectionState.Closed)
                sqlbaglan.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlbaglan;
            cmd.CommandText = "select * from Urun";
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds, "Urun");
            dataGridView1.DataSource = ds.Tables["Urun"];
            sqlbaglan.Close();
        }
        private void AnaSayfaDonBtn_Click(object sender, EventArgs e)
        {
            UrunEkleForm formkapa = new UrunEkleForm();
            formkapa.Close();
            AnaSayfa AnasayfaForm = new AnaSayfa();
            AnasayfaForm.Show();
            this.Hide();
        }
        private void UrunEkleForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlbaglan;
            cmd.CommandText = "select * from Urun";
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds, "Urun");
            dataGridView1.DataSource = ds.Tables["Urun"];
        }
        private void BarkodOlusturBtn_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            string harfler = "123456789";
            string uret = "";
            for (int i = 0; i < 13; i++)
            {
                uret += harfler[rastgele.Next(harfler.Length)];
            }
            txtUrunBarkodEkle.Text = uret;
        }
        private void UrunResimSeçBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            txtUrunResimYolu.Text = openFileDialog1.FileName;
        }
        private void UrunKaydetBtn_Click(object sender, EventArgs e)
        {
            DialogResult UrunKaydet = MessageBox.Show("Ürünü Kaydetmek İsyor Musunuz ?", "Ürün Kaydet", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (UrunKaydet == DialogResult.Yes)
            {
                sqlbaglan.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlbaglan;
                if (txtUrunAdiEkle.Text != "" && txtUrunRenkEkle.Text != "" && CmbBeden.Text != "" && CmbKategori.Text != "" && txtUrunStokEkle.Text != "" && txtUrunBarkodEkle.Text != "" && txtUrunAlisFiyati.Text != "" && txtUrunSatisFiyati.Text != "" && CmbHBDurumEkle.Text != "")
                {
                    cmd.CommandText = "insert into Urun (Urun_Adi, Urun_Renk, Urun_Beden, Urun_Kategori, Urun_Stok, Urun_Barkod, Urun_AlisFiyati, Urun_SatisFiyati, Urun_HBDurum, Urun_Resim ) Values ('" + txtUrunAdiEkle.Text + "','" + txtUrunRenkEkle.Text + "','" + CmbBeden.Text + "','" + CmbKategori.Text + "','" + txtUrunStokEkle.Text + "','" + txtUrunBarkodEkle.Text + "','" + txtUrunAlisFiyati.Text + "','" + txtUrunSatisFiyati.Text + "','" + CmbHBDurumEkle.Text + "','" + txtUrunResimYolu.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ürün Kaydı Başarıyla Gerçekleştirilmiştir");
                    txtUrunAdiEkle.Text = "";
                    txtUrunRenkEkle.Text = "";
                    CmbBeden.Text = "";
                    CmbKategori.Text = "";
                    txtUrunStokEkle.Text = "";
                    txtUrunBarkodEkle.Text = "";
                    txtUrunAlisFiyati.Text = "";
                    txtUrunSatisFiyati.Text = "";
                    CmbHBDurumEkle.Text = "";
                    txtUrunResimYolu.Text = "";
                    listele();
                }
                else
                {
                    MessageBox.Show("Lütfen (*) İle İşaretli Alanları Boş Bıramayınız...", "!HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlbaglan.Close();
            }
        }
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.urunTableAdapter.FillBy(this.stokYonetimDataSet.Urun);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunKaydetBtn.Visible = true;
            UrunGuncelleBtn.Visible = false;
            UrunSilBtn.Visible = false;
        }
        private void üRÜNGÜNCELLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunGuncelleBtn.Visible = true;
            UrunKaydetBtn.Visible = false;
            UrunSilBtn.Visible = false;
        }
        private void üRÜNSİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunSilBtn.Visible = true;
            UrunGuncelleBtn.Visible = false;
            UrunKaydetBtn.Visible = false;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int alansec = dataGridView1.SelectedCells[0].RowIndex;
            string Urun_Adi = dataGridView1.Rows[alansec].Cells[1].Value.ToString();
            string Urun_Barkod = dataGridView1.Rows[alansec].Cells[2].Value.ToString();
            string Urun_Renk = dataGridView1.Rows[alansec].Cells[3].Value.ToString();
            string Urun_Beden = dataGridView1.Rows[alansec].Cells[4].Value.ToString();
            string Urun_Stok = dataGridView1.Rows[alansec].Cells[5].Value.ToString();
            string Urun_Kategori = dataGridView1.Rows[alansec].Cells[6].Value.ToString();
            string Urun_Resim = dataGridView1.Rows[alansec].Cells[7].Value.ToString();
            string Urun_HBDurum = dataGridView1.Rows[alansec].Cells[8].Value.ToString();
            string Urun_AlisFiyati = dataGridView1.Rows[alansec].Cells[9].Value.ToString();
            string Urun_SatisFiyati = dataGridView1.Rows[alansec].Cells[10].Value.ToString();
            txtUrunAdiEkle.Text = Urun_Adi;
            txtUrunBarkodEkle.Text = Urun_Barkod;
            txtUrunRenkEkle.Text = Urun_Renk;
            CmbBeden.Text = Urun_Beden;
            txtUrunStokEkle.Text = Urun_Stok;
            CmbKategori.Text = Urun_Kategori;
            txtUrunResimYolu.Text = Urun_Resim;
            pictureBox1.ImageLocation = Urun_Resim;
            CmbHBDurumEkle.Text = Urun_HBDurum;
            txtUrunAlisFiyati.Text = Urun_AlisFiyati;
            txtUrunSatisFiyati.Text = Urun_SatisFiyati;
        }
        private void UrunSilBtn_Click(object sender, EventArgs e)
        {
            DialogResult UrunSil = MessageBox.Show("Ürünü Silmek İstediğinize Emin Misiniz ? ", "Ürün Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (UrunSil == DialogResult.Yes)
            {
                sqlbaglan.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlbaglan;
                cmd.CommandText = "delete from Urun where Urun_ID = '" + dataGridView1.CurrentRow.Cells[0].Value + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ürün Başarıyla Silindi", "ONAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd.CommandText = "select * from Urun";
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Urun");
                dataGridView1.DataSource = ds.Tables["Urun"];
                sqlbaglan.Close();
            }
        }
        private void UrunGuncelleBtn_Click(object sender, EventArgs e)
        {
            DialogResult UrunGuncelle = MessageBox.Show("Ürün Bilgilerini Güncellemek İstediğinize Emin Misiniz ? ", "Ürün Güncelle", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (UrunGuncelle == DialogResult.Yes)
            {
                sqlbaglan.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlbaglan;
                cmd.CommandText = "UPDATE Urun SET Urun_Adi='" + txtUrunAdiEkle.Text + "', Urun_Barkod='" + txtUrunBarkodEkle.Text + "', Urun_Renk='" + txtUrunRenkEkle.Text + "', Urun_Beden='" + CmbBeden.Text + "', Urun_Stok='" + txtUrunStokEkle.Text + "', Urun_Kategori='" + CmbKategori.Text + "', Urun_Resim='" + txtUrunResimYolu.Text + "', Urun_HBDurum='" + CmbHBDurumEkle.Text + "', Urun_AlisFiyati='" + txtUrunAlisFiyati.Text + "', Urun_SatisFiyati='" + txtUrunSatisFiyati.Text + "' where Urun_ID='" + dataGridView1.CurrentRow.Cells[0].Value + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ürün Bilgileri Başarıyla Güncellendi", "ONAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd.CommandText = "select * from Urun";
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Urun");
                dataGridView1.DataSource = ds.Tables["Urun"];
                sqlbaglan.Close();
            }
        }

        private void txtUrunRenkEkle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("Lütfen Harf Girişi Yapınız", "UYARI!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtUrunAdiEkle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("Lütfen Harf Girişi Yapınız", "UYARI!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtUrunStokEkle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Lütfen Rakam Girişi Yapınız", "UYARI!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtUrunAlisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Lütfen Rakam Girişi Yapınız", "UYARI!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtUrunSatisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Lütfen Rakam Girişi Yapınız", "UYARI!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}