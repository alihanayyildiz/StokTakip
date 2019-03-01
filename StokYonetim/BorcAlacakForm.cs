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
    public partial class BorcAlacakForm : Form
    {
        public SqlConnection sqlbaglan = new SqlConnection("Data Source = ALIHAN\\SQLEXPRESS;Initial Catalog = StokYonetim; Integrated Security = True");
        public BorcAlacakForm()
        {
            InitializeComponent();
        }
        private void BorcAlacakForm_Load(object sender, EventArgs e)
        {
        }
        private void AnaSayfaDonBtn_Click(object sender, EventArgs e)
        {
            BorcAlacakForm formkapa = new BorcAlacakForm();
            formkapa.Close();
            AnaSayfa AnasayfaForm = new AnaSayfa();
            AnasayfaForm.Show();
            this.Hide();
        }
        private void txtBorcAlacakKayitBtn_Click(object sender, EventArgs e)
        {
            DialogResult BorcAlacakKayit = MessageBox.Show("Kayıt İşlemini Gerçekleştirmek İstiyor Musunuz ? ", "BORÇ ALACAK KAYIT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (BorcAlacakKayit == DialogResult.Yes)
            {
                sqlbaglan.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlbaglan;
                if (txtMusteriAdi.Text != "" && txtMusteriSoyadi.Text != "" && mstTel.Text != "" && txtMail.Text != "" && CmbBorcAlacak.Text != "" && CmbBorcAlacakDurum.Text != "" && txtUcret.Text != "")
                {
                    cmd.CommandText = "insert into Borc_Alacak(Musteri_Adi, Musteri_Soyadi, Musteri_Tel, Musteri_Mail, BorcAlacak, BorcAlacakDurum, BorcAlacakUcret, Tarih) values ('" + txtMusteriAdi.Text + "','" + txtMusteriSoyadi.Text + "','" + mstTel.Text + "','" + txtMail.Text + "','" + CmbBorcAlacak.Text + "','" + CmbBorcAlacakDurum.Text + "','" + txtUcret.Text + "','" + DTPTarih.Value.ToString("MM/dd/yyyy HH:mm:ss") + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("İşleminiz Başarılı Bir Şekilde Kaydedilmiştir", "KAYIT BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd.CommandText = "select * from Borc_Alacak";
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "Borc_Alacak");
                    dataGridView1.DataSource = ds.Tables["Borc_Alacak"];
                    txtMusteriAdi.Clear();
                    txtMusteriSoyadi.Clear();
                    mstTel.Clear();
                    txtMail.Clear();
                    CmbBorcAlacak.Text = "";
                    CmbBorcAlacakDurum.Text = "";
                    txtUcret.Clear();
                }
                else
                {
                    MessageBox.Show("Lütfen (*) İle İşaretli Alanları Boş Bıramayınız...", "!HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlbaglan.Close();
            }
        }
        private void UrunListeleBtn_Click(object sender, EventArgs e)
        {
            sqlbaglan.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlbaglan;
            cmd.CommandText = "select * from Borc_Alacak";
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds, "Borc_Alacak");
            dataGridView1.DataSource = ds.Tables["Borc_Alacak"];
            sqlbaglan.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int alansec = dataGridView1.SelectedCells[0].RowIndex;
            string Musteri_Adi = dataGridView1.Rows[alansec].Cells[1].Value.ToString();
            string Musteri_Soyadi = dataGridView1.Rows[alansec].Cells[2].Value.ToString();
            string Musteri_Tel = dataGridView1.Rows[alansec].Cells[3].Value.ToString();
            string Musteri_Mail = dataGridView1.Rows[alansec].Cells[4].Value.ToString();
            string BorcAlacak = dataGridView1.Rows[alansec].Cells[5].Value.ToString();
            string BorcAlacakDurum = dataGridView1.Rows[alansec].Cells[6].Value.ToString();
            string BorcAlacakUcret = dataGridView1.Rows[alansec].Cells[7].Value.ToString();
            string Tarih = dataGridView1.Rows[alansec].Cells[8].Value.ToString();
            txtMusteriAdi.Text = Musteri_Adi;
            txtMusteriSoyadi.Text = Musteri_Soyadi;
            mstTel.Text = Musteri_Tel;
            txtMail.Text = Musteri_Mail;
            CmbBorcAlacak.Text = BorcAlacak;
            CmbBorcAlacakDurum.Text = BorcAlacakDurum;
            txtUcret.Text = BorcAlacakUcret;
            DTPTarih.Text = Tarih;
        }
        private void BaSilBtn_Click(object sender, EventArgs e)
        {
            DialogResult BorcAlacakSil = MessageBox.Show("Kaydı Silmek İstediğinize Emin Misiniz ? ","KAYIT SİL", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (BorcAlacakSil == DialogResult.Yes)
            {
                sqlbaglan.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlbaglan;
                cmd.CommandText = "delete from Borc_Alacak where BA_ID = '" + dataGridView1.CurrentRow.Cells[0].Value + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarı İle Silinmiştir", "ONAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd.CommandText = "select * from Borc_Alacak";
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Borc_Alacak");
                dataGridView1.DataSource = ds.Tables["Borc_Alacak"];
                sqlbaglan.Close();
            }
        }
        private void BaGuncelleBtn_Click(object sender, EventArgs e)
        {
            DialogResult BorcAlacakGuncelle = MessageBox.Show("Kaydı Güncellemek İstediğinizden Emin Misiniz ? ", "KAYIT GÜNCELLE",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (BorcAlacakGuncelle == DialogResult.Yes)
            {
                sqlbaglan.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlbaglan;
                cmd.CommandText = "UPDATE Borc_Alacak SET Musteri_Adi='" + txtMusteriAdi.Text + "', Musteri_Soyadi='" + txtMusteriSoyadi.Text + "', Musteri_Tel='" + mstTel.Text + "', Musteri_Mail='" + txtMail.Text + "', BorcAlacak='" + CmbBorcAlacak.Text + "', BorcAlacakDurum='" + CmbBorcAlacakDurum.Text + "', BorcAlacakUcret='" + txtUcret.Text + "', Tarih='" + DTPTarih.Value.ToString("MM/dd/yyyy HH:mm:ss") + "'   where BA_ID='" + dataGridView1.CurrentRow.Cells[0].Value + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarıyla Güncellendi", "ONAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd.CommandText = "select * from Borc_Alacak";
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Borc_Alacak");
                dataGridView1.DataSource = ds.Tables["Borc_Alacak"];
                sqlbaglan.Close();
            }
        }
        private void txtMusteriAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("Lütfen Harf Girişi Yapınız", "UYARI!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtMusteriSoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("Lütfen Harf Girişi Yapınız", "UYARI!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtUcret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Lütfen Rakam Girişi Yapınız", "UYARI!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void gÜNCELLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaGuncelleBtn.Visible = true;
            BaSilBtn.Visible = false;
        }
        private void sİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaSilBtn.Visible = true;
            BaGuncelleBtn.Visible = false;
        }
    }
}
