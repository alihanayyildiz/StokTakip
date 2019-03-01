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
    public partial class SatisForm : Form
    {
        public SqlConnection sqlbaglan = new SqlConnection("Data Source = ALIHAN\\SQLEXPRESS;Initial Catalog = StokYonetim; Integrated Security = True");
        public SatisForm()
        {
            InitializeComponent();
        }

        private void AnaSayfaDonBtn_Click(object sender, EventArgs e)
        {
            SatisForm formkapa = new SatisForm();
            formkapa.Close();
            AnaSayfa AnasayfaForm = new AnaSayfa();
            AnasayfaForm.Show();
            this.Hide();
        }

        private void UrunSatisBarkodBtn_Click(object sender, EventArgs e)
        {
            //    sqlbaglan.Open();

            //    MessageBox.Show(Sorgusonuc.ToString());
            //    sqlbaglan.Close();
            if (txtUrunSatBarkod.Text != "")
            {
                sqlbaglan.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlbaglan;
                cmd.CommandText = "select * from Urun where Urun_Barkod like '%"+txtUrunSatBarkod.Text+"%'";
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds,"Urun");
                dataGridView1.DataSource = ds.Tables["Urun"];
                sqlbaglan.Close();
            }
            else
                MessageBox.Show("Lütfen Barkod Alanını Boş Bırakmayınız!!!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void UrunSatisTamamlaBtn_Click(object sender, EventArgs e)
        {
            sqlbaglan.Open();
            string sorgu = "select Urun_ID from Urun where Urun_Barkod like '%" + txtUrunSatBarkod.Text + "%'";
            SqlCommand kmt = new SqlCommand(sorgu, sqlbaglan);
            int Sorgusonuc = Convert.ToInt32(kmt.ExecuteScalar());
            SqlCommand Kayit = new SqlCommand();
            Kayit.Connection = sqlbaglan;
            Kayit.CommandText = "insert into Satis(Urun_ID, Satis_Turu, Satis_Tarihi, Satis_Adet, Urun_Barkod, Urun_SatisFiyati) values ('" + Sorgusonuc.ToString() + "','" + CBUrunSatisTuru.Text + "','" + dateTimePicker1.Value.ToString("MM/dd/yyyy HH:mm:ss") + "','" + txtUrunSatilanAdet.Text + "','" + txtUrunSatBarkod.Text + "','"+txtSatisUcret.Text+"')";
            Kayit.ExecuteNonQuery();

            Kayit.CommandText = "select * from Satis";
            SqlDataAdapter adp = new SqlDataAdapter(Kayit);
            DataSet ds = new DataSet();
            adp.Fill(ds, "Satis");
            dataGridView1.DataSource = ds.Tables["Satis"];
            sqlbaglan.Close();
        }

        private void SatisForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stokYonetimDataSet.Urun' table. You can move, or remove it, as needed.
            this.urunTableAdapter.Fill(this.stokYonetimDataSet.Urun);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlbaglan.Open();
            string sorgu = "select Urun_ID from Urun where Urun_Barkod like '%" + txtUrunSatBarkod.Text + "%'";
            SqlCommand kmt = new SqlCommand(sorgu, sqlbaglan);
            int Sorgusonuc = Convert.ToInt32(kmt.ExecuteScalar());
            SqlCommand UPT = new SqlCommand();
            UPT.Connection = sqlbaglan;
            UPT.CommandText = "UPDATE Urun SET Urun_Stok=Urun_Stok-'" + txtUrunSatilanAdet.Text + "'  where Urun_ID='" + Sorgusonuc.ToString() + "'";
            UPT.ExecuteNonQuery();
            MessageBox.Show("Ürün "+ txtUrunSatilanAdet.Text+" Adet Stoktan Düşüldü");
            UPT.CommandText = "select * from Urun";
            SqlDataAdapter adp = new SqlDataAdapter(UPT);
            DataSet ds = new DataSet();
            adp.Fill(ds,"Urun");
            dataGridView1.DataSource = ds.Tables["Urun"];
            sqlbaglan.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlbaglan.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlbaglan;
            cmd.CommandText = "select * from Satis";
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds,"Satis");
            dataGridView1.DataSource = ds.Tables["Satis"];
            sqlbaglan.Close();
        }
    }
}
