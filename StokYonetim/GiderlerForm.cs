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
    public partial class GiderlerForm : Form
    {
        public SqlConnection sqlbaglan = new SqlConnection("Data Source = ALIHAN\\SQLEXPRESS;Initial Catalog = StokYonetim; Integrated Security = True");
        public GiderlerForm()
        {
            InitializeComponent();
        }

        private void AnaSayfaDonBtn_Click(object sender, EventArgs e)
        {
            GiderlerForm formkapa = new GiderlerForm();
            formkapa.Close();
            AnaSayfa AnasayfaForm = new AnaSayfa();
            AnasayfaForm.Show();
            this.Hide();
        }

        private void EkleSecenekBtn_Click(object sender, EventArgs e)
        {
            GiderKaydetBtn.Visible = true;
            GiderGuncelleBtn.Visible = false;
            GiderSilBtn.Visible = false;
        }

        private void GuncelleSecenekBtn_Click(object sender, EventArgs e)
        {
            GiderGuncelleBtn.Visible = true;
            GiderKaydetBtn.Visible = false;
            GiderSilBtn.Visible = false;
        }

        private void SilSecenekBtn_Click(object sender, EventArgs e)
        {
            GiderSilBtn.Visible = true;
            GiderGuncelleBtn.Visible = false;
            GiderKaydetBtn.Visible = false;
        }
        

        private void GiderKaydetBtn_Click(object sender, EventArgs e)
        {
            DialogResult GiderKaydet = MessageBox.Show("Gideri Kaydetmek İstediğinize Emin Misiniz ?","Gider Kaydet",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (GiderKaydet == DialogResult.Yes)
            {
                sqlbaglan.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlbaglan;
                cmd.CommandText = "insert into Giderler (Gider_Turu, Gider_Ucret) values ('" + cmbGiderTuru.Text + "','" + txtGiderUcret.Text + "' ) ";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Gider Faturanız Başarı İle Kaydedilmiştir", "ONAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd.CommandText = "select * from Giderler";
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Giderler");
                dataGridView1.DataSource = ds.Tables["Giderler"];
                sqlbaglan.Close();
            }
        }

        private void GiderSilBtn_Click(object sender, EventArgs e)
        {
            DialogResult GiderSil = MessageBox.Show("Gideri Silmek İstediğinize Emin Misiniz ? ","Gider Sil",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(GiderSil == DialogResult.Yes)
            {
                sqlbaglan.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlbaglan;
                cmd.CommandText = "delete from Giderler where Gider_ID='"+dataGridView1.CurrentRow.Cells[0].Value+"'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Gider Başarı İle Silinmiştir","Gider Sil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd.CommandText = "select * from Giderler";
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds,"Giderler");
                dataGridView1.DataSource = ds.Tables["Giderler"];
                sqlbaglan.Close();
            }
        }

        private void GiderGuncelleBtn_Click(object sender, EventArgs e)
        {
            DialogResult GiderGuncelle = MessageBox.Show("Gideri Güncellemek İstediğinize Emin Misiniz ? ", "Gider Güncelle", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (GiderGuncelle == DialogResult.Yes)
            {
                sqlbaglan.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlbaglan;
                cmd.CommandText = "Update Giderler SET Gider_Turu='" + cmbGiderTuru.Text + "', Gider_Ucret='" + txtGiderUcret.Text + "' where Gider_ID='" + dataGridView1.CurrentRow.Cells[0].Value + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarı İle Güncellenmiştir", "ONAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd.CommandText = "select * from Giderler";
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Giderler");
                dataGridView1.DataSource = ds.Tables["Giderler"];
                sqlbaglan.Close();
            }
        }

        private void GiderlerForm_Load(object sender, EventArgs e)
        {
            sqlbaglan.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlbaglan;
            cmd.CommandText = "select * from Giderler";
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds, "Giderler");
            dataGridView1.DataSource = ds.Tables["Giderler"];
            sqlbaglan.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int alansec = dataGridView1.SelectedCells[0].RowIndex;

            string Gider_Turu = dataGridView1.Rows[alansec].Cells[1].Value.ToString();
            string Gider_Ucret = dataGridView1.Rows[alansec].Cells[2].Value.ToString();

            cmbGiderTuru.Text = Gider_Turu;
            txtGiderUcret.Text = Gider_Ucret;
        }
    }
}
