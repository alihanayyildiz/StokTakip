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
    public partial class SiparisListeleForm : Form
    {
        public SqlConnection sqlbaglan = new SqlConnection("Data Source = ALIHAN\\SQLEXPRESS;Initial Catalog = StokYonetim; Integrated Security = True");
        public SiparisListeleForm()
        {
            InitializeComponent();
        }

        private void AnaSayfaDonBtn_Click(object sender, EventArgs e)
        {
            SiparisListeleForm formkapa = new SiparisListeleForm();
            formkapa.Close();
            AnaSayfa AnasayfaForm = new AnaSayfa();
            AnasayfaForm.Show();
            this.Hide();
        }

        private void SiparisKayitBtn_Click(object sender, EventArgs e)
        {
            DialogResult siparisKaydet = MessageBox.Show("Siparişi Kaydetmek İstediğinize Emin Misiniz ?", "Sipariş Kaydet", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (siparisKaydet == DialogResult.Yes)
            {
                sqlbaglan.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlbaglan;
                if (CmbSiparisTuru.Text != "" && txtSiparis.Text != "")
                {
                    cmd.CommandText = "insert into Siparis (Siparis_Turu, Siparis_Aciklama) values ('" + CmbSiparisTuru.Text + "', '" + txtSiparis.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Oluşturuldu","KAYIT BAŞARILI",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd.CommandText = "select * from Siparis";
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "Siparis");
                    dataGridView1.DataSource = ds.Tables["Siparis"];
                }
                else
                {
                    MessageBox.Show("Lütfen Gerekli Alanları Doldurun", "BOŞ ALAN BIRAKMAYIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                sqlbaglan.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int alansec = dataGridView1.SelectedCells[0].RowIndex;
            string Siparis_Turu     = dataGridView1.Rows[alansec].Cells[1].Value.ToString();
            string Siparis_Aciklama = dataGridView1.Rows[alansec].Cells[2].Value.ToString();
            
            CmbSiparisTuru.Text = Siparis_Turu;
            txtSiparis.Text = Siparis_Aciklama;
        }

        private void SiparisGuncelleBtn_Click(object sender, EventArgs e)
        {
            DialogResult siparisGuncelle = MessageBox.Show("Siparişi Güncellemek İstediğinize Emin Misiniz ?", "Sipariş Güncelle", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (siparisGuncelle == DialogResult.Yes)
            {
                sqlbaglan.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlbaglan;
                cmd.CommandText = "UPDATE Siparis SET Siparis_Turu='" + CmbSiparisTuru.Text + "', Siparis_Aciklama='" + txtSiparis.Text + "' where Siparis_ID='" + dataGridView1.CurrentRow.Cells[0].Value + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sipariş Başarıyla Güncellendi", "ONAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd.CommandText = "select * from Siparis";
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Siparis");
                dataGridView1.DataSource = ds.Tables["Siparis"];
                sqlbaglan.Close();
            }
            
        }

        private void ListeleBtn_Click(object sender, EventArgs e)
        {
            sqlbaglan.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlbaglan;
            cmd.CommandText = "Select * from Siparis";
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds,"Siparis");
            dataGridView1.DataSource = ds.Tables["Siparis"];
            sqlbaglan.Close();
        }

        private void SiparisSilBtn_Click(object sender, EventArgs e)
        {
            DialogResult siparisSil = MessageBox.Show("Siparişi Silmek İstediğinize Emin Misiniz ?","Sipariş Sil",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (siparisSil == DialogResult.Yes)
            {
                sqlbaglan.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlbaglan;
                cmd.CommandText = "delete from Siparis where Siparis_ID = '" + dataGridView1.CurrentRow.Cells[0].Value + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sipariş Başarıyla Silindi", "ONAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd.CommandText = "select * from Siparis";
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Siparis");
                dataGridView1.DataSource = ds.Tables["Siparis"];
                sqlbaglan.Close();
            }
            
        }
        private void gÜNCELLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisGuncelleBtn.Visible = true;
            SiparisSilBtn.Visible = false;
        }

        private void sİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisSilBtn.Visible = true;
            SiparisGuncelleBtn.Visible = false;
        }

        private void SiparisListeleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
