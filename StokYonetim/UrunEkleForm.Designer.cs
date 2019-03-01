namespace StokYonetim
{
    partial class UrunEkleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunEkleForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UrunGuncelleBtn = new System.Windows.Forms.Button();
            this.UrunSilBtn = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunResimYolu = new System.Windows.Forms.TextBox();
            this.UrunKaydetBtn = new System.Windows.Forms.Button();
            this.BarkodOlusturBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.UrunResimSeçBtn = new System.Windows.Forms.Button();
            this.CmbHBDurumEkle = new System.Windows.Forms.ComboBox();
            this.txtUrunSatisFiyati = new System.Windows.Forms.TextBox();
            this.txtUrunAlisFiyati = new System.Windows.Forms.TextBox();
            this.CmbBeden = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUrunStokEkle = new System.Windows.Forms.TextBox();
            this.CmbKategori = new System.Windows.Forms.ComboBox();
            this.txtUrunAdiEkle = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AnaSayfaDonBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokYonetimDataSet = new StokYonetim.StokYonetimDataSet();
            this.urunTableAdapter = new StokYonetim.StokYonetimDataSetTableAdapters.UrunTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üRÜNGÜNCELLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üRÜNSİLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUrunBarkodEkle = new System.Windows.Forms.MaskedTextBox();
            this.txtUrunRenkEkle = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokYonetimDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Barkod :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ürün Stok :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ürün Renk :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ürün Resim :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ürün Alış Fiyatı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ürün Satış Fiyatı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(300, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "HepsiBurada Durum :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Ürün Kategori :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUrunBarkodEkle);
            this.groupBox1.Controls.Add(this.UrunGuncelleBtn);
            this.groupBox1.Controls.Add(this.UrunSilBtn);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUrunResimYolu);
            this.groupBox1.Controls.Add(this.UrunKaydetBtn);
            this.groupBox1.Controls.Add(this.BarkodOlusturBtn);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.UrunResimSeçBtn);
            this.groupBox1.Controls.Add(this.CmbHBDurumEkle);
            this.groupBox1.Controls.Add(this.txtUrunSatisFiyati);
            this.groupBox1.Controls.Add(this.txtUrunAlisFiyati);
            this.groupBox1.Controls.Add(this.CmbBeden);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtUrunStokEkle);
            this.groupBox1.Controls.Add(this.CmbKategori);
            this.groupBox1.Controls.Add(this.txtUrunRenkEkle);
            this.groupBox1.Controls.Add(this.txtUrunAdiEkle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(37, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 236);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÜRÜN EKLEME İŞLEMLERİ";
            // 
            // UrunGuncelleBtn
            // 
            this.UrunGuncelleBtn.FlatAppearance.BorderSize = 0;
            this.UrunGuncelleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UrunGuncelleBtn.Image = ((System.Drawing.Image)(resources.GetObject("UrunGuncelleBtn.Image")));
            this.UrunGuncelleBtn.Location = new System.Drawing.Point(703, 174);
            this.UrunGuncelleBtn.Name = "UrunGuncelleBtn";
            this.UrunGuncelleBtn.Size = new System.Drawing.Size(35, 35);
            this.UrunGuncelleBtn.TabIndex = 29;
            this.UrunGuncelleBtn.UseVisualStyleBackColor = true;
            this.UrunGuncelleBtn.Visible = false;
            this.UrunGuncelleBtn.Click += new System.EventHandler(this.UrunGuncelleBtn_Click);
            // 
            // UrunSilBtn
            // 
            this.UrunSilBtn.FlatAppearance.BorderSize = 0;
            this.UrunSilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UrunSilBtn.Image = ((System.Drawing.Image)(resources.GetObject("UrunSilBtn.Image")));
            this.UrunSilBtn.Location = new System.Drawing.Point(703, 173);
            this.UrunSilBtn.Name = "UrunSilBtn";
            this.UrunSilBtn.Size = new System.Drawing.Size(35, 35);
            this.UrunSilBtn.TabIndex = 30;
            this.UrunSilBtn.UseVisualStyleBackColor = true;
            this.UrunSilBtn.Visible = false;
            this.UrunSilBtn.Click += new System.EventHandler(this.UrunSilBtn_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(541, 176);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 13);
            this.label21.TabIndex = 34;
            this.label21.Text = "(İsteğe Bağlı)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(541, 142);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 18);
            this.label20.TabIndex = 33;
            this.label20.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(541, 106);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 18);
            this.label19.TabIndex = 32;
            this.label19.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(541, 71);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 18);
            this.label18.TabIndex = 31;
            this.label18.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(226, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 18);
            this.label17.TabIndex = 30;
            this.label17.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(226, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 18);
            this.label16.TabIndex = 29;
            this.label16.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(226, 148);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 18);
            this.label15.TabIndex = 28;
            this.label15.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(226, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 18);
            this.label14.TabIndex = 27;
            this.label14.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(541, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 18);
            this.label13.TabIndex = 26;
            this.label13.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(226, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "*";
            // 
            // txtUrunResimYolu
            // 
            this.txtUrunResimYolu.Location = new System.Drawing.Point(506, 173);
            this.txtUrunResimYolu.Name = "txtUrunResimYolu";
            this.txtUrunResimYolu.Size = new System.Drawing.Size(29, 20);
            this.txtUrunResimYolu.TabIndex = 10;
            this.txtUrunResimYolu.Visible = false;
            // 
            // UrunKaydetBtn
            // 
            this.UrunKaydetBtn.FlatAppearance.BorderSize = 0;
            this.UrunKaydetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UrunKaydetBtn.Image = ((System.Drawing.Image)(resources.GetObject("UrunKaydetBtn.Image")));
            this.UrunKaydetBtn.Location = new System.Drawing.Point(703, 174);
            this.UrunKaydetBtn.Name = "UrunKaydetBtn";
            this.UrunKaydetBtn.Size = new System.Drawing.Size(43, 36);
            this.UrunKaydetBtn.TabIndex = 24;
            this.UrunKaydetBtn.UseVisualStyleBackColor = true;
            this.UrunKaydetBtn.Click += new System.EventHandler(this.UrunKaydetBtn_Click);
            // 
            // BarkodOlusturBtn
            // 
            this.BarkodOlusturBtn.FlatAppearance.BorderSize = 0;
            this.BarkodOlusturBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BarkodOlusturBtn.Image = ((System.Drawing.Image)(resources.GetObject("BarkodOlusturBtn.Image")));
            this.BarkodOlusturBtn.Location = new System.Drawing.Point(703, 21);
            this.BarkodOlusturBtn.Name = "BarkodOlusturBtn";
            this.BarkodOlusturBtn.Size = new System.Drawing.Size(35, 34);
            this.BarkodOlusturBtn.TabIndex = 23;
            this.BarkodOlusturBtn.UseVisualStyleBackColor = true;
            this.BarkodOlusturBtn.Click += new System.EventHandler(this.BarkodOlusturBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(614, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Barkod Oluştur :";
            // 
            // UrunResimSeçBtn
            // 
            this.UrunResimSeçBtn.Location = new System.Drawing.Point(414, 171);
            this.UrunResimSeçBtn.Name = "UrunResimSeçBtn";
            this.UrunResimSeçBtn.Size = new System.Drawing.Size(75, 23);
            this.UrunResimSeçBtn.TabIndex = 21;
            this.UrunResimSeçBtn.Text = "Dosya Seç";
            this.UrunResimSeçBtn.UseVisualStyleBackColor = true;
            this.UrunResimSeçBtn.Click += new System.EventHandler(this.UrunResimSeçBtn_Click);
            // 
            // CmbHBDurumEkle
            // 
            this.CmbHBDurumEkle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbHBDurumEkle.FormattingEnabled = true;
            this.CmbHBDurumEkle.Items.AddRange(new object[] {
            "Satışı Var",
            "Satışı Yok"});
            this.CmbHBDurumEkle.Location = new System.Drawing.Point(414, 137);
            this.CmbHBDurumEkle.Name = "CmbHBDurumEkle";
            this.CmbHBDurumEkle.Size = new System.Drawing.Size(121, 21);
            this.CmbHBDurumEkle.TabIndex = 9;
            // 
            // txtUrunSatisFiyati
            // 
            this.txtUrunSatisFiyati.Location = new System.Drawing.Point(414, 103);
            this.txtUrunSatisFiyati.Name = "txtUrunSatisFiyati";
            this.txtUrunSatisFiyati.Size = new System.Drawing.Size(121, 20);
            this.txtUrunSatisFiyati.TabIndex = 8;
            this.txtUrunSatisFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunSatisFiyati_KeyPress);
            // 
            // txtUrunAlisFiyati
            // 
            this.txtUrunAlisFiyati.Location = new System.Drawing.Point(414, 66);
            this.txtUrunAlisFiyati.Name = "txtUrunAlisFiyati";
            this.txtUrunAlisFiyati.Size = new System.Drawing.Size(121, 20);
            this.txtUrunAlisFiyati.TabIndex = 7;
            this.txtUrunAlisFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunAlisFiyati_KeyPress);
            // 
            // CmbBeden
            // 
            this.CmbBeden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBeden.FormattingEnabled = true;
            this.CmbBeden.Items.AddRange(new object[] {
            "5XL",
            "4XL",
            "3XL",
            "2XL",
            "XL",
            "L",
            "M",
            "S",
            "XS",
            "1 Yaş",
            "2 Yaş",
            "3Yaş",
            "4 Yaş",
            "5 Yaş",
            "6 Yaş",
            "7 Yaş",
            "8 Yaş",
            "9 Yaş",
            "10 Yaş",
            "11 Yaş",
            "12 Yaş",
            "1-3 Yaş",
            "3-6 Yaş",
            "6-9 Yaş",
            "9-12 Yaş",
            "0-3 Ay",
            "3-6 Ay",
            "6-9 Ay",
            "9-12 Ay",
            "12-15 Ay",
            "15-18 Ay",
            "18-21 Ay",
            "21-24 Ay",
            "2-3 Yaş",
            "3-4 Yaş",
            "4-5 Yaş",
            "5-6 Yaş"});
            this.CmbBeden.Location = new System.Drawing.Point(99, 103);
            this.CmbBeden.Name = "CmbBeden";
            this.CmbBeden.Size = new System.Drawing.Size(121, 21);
            this.CmbBeden.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Ürün Beden :";
            // 
            // txtUrunStokEkle
            // 
            this.txtUrunStokEkle.Location = new System.Drawing.Point(99, 181);
            this.txtUrunStokEkle.Name = "txtUrunStokEkle";
            this.txtUrunStokEkle.Size = new System.Drawing.Size(121, 20);
            this.txtUrunStokEkle.TabIndex = 5;
            this.txtUrunStokEkle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunStokEkle_KeyPress);
            // 
            // CmbKategori
            // 
            this.CmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbKategori.FormattingEnabled = true;
            this.CmbKategori.Items.AddRange(new object[] {
            "Bayan Giyim",
            "Bebek Giyim",
            "Çocuk Giyim",
            "Hediyelik",
            "Bijuteri",
            "Çanta",
            "Tekstil",
            "Diğer +"});
            this.CmbKategori.Location = new System.Drawing.Point(99, 144);
            this.CmbKategori.Name = "CmbKategori";
            this.CmbKategori.Size = new System.Drawing.Size(121, 21);
            this.CmbKategori.TabIndex = 4;
            // 
            // txtUrunAdiEkle
            // 
            this.txtUrunAdiEkle.Location = new System.Drawing.Point(100, 29);
            this.txtUrunAdiEkle.Name = "txtUrunAdiEkle";
            this.txtUrunAdiEkle.Size = new System.Drawing.Size(120, 20);
            this.txtUrunAdiEkle.TabIndex = 1;
            this.txtUrunAdiEkle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunAdiEkle_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(852, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // AnaSayfaDonBtn
            // 
            this.AnaSayfaDonBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AnaSayfaDonBtn.FlatAppearance.BorderSize = 0;
            this.AnaSayfaDonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnaSayfaDonBtn.Image = ((System.Drawing.Image)(resources.GetObject("AnaSayfaDonBtn.Image")));
            this.AnaSayfaDonBtn.Location = new System.Drawing.Point(4, 27);
            this.AnaSayfaDonBtn.Name = "AnaSayfaDonBtn";
            this.AnaSayfaDonBtn.Size = new System.Drawing.Size(29, 29);
            this.AnaSayfaDonBtn.TabIndex = 24;
            this.AnaSayfaDonBtn.UseVisualStyleBackColor = true;
            this.AnaSayfaDonBtn.Click += new System.EventHandler(this.AnaSayfaDonBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataMember = "Urun";
            this.urunBindingSource.DataSource = this.stokYonetimDataSet;
            // 
            // stokYonetimDataSet
            // 
            this.stokYonetimDataSet.DataSetName = "StokYonetimDataSet";
            this.stokYonetimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunTableAdapter
            // 
            this.urunTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1114, 357);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.üRÜNGÜNCELLEToolStripMenuItem,
            this.üRÜNSİLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.ekleToolStripMenuItem.Text = "ÜRÜN EKLE";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // üRÜNGÜNCELLEToolStripMenuItem
            // 
            this.üRÜNGÜNCELLEToolStripMenuItem.Name = "üRÜNGÜNCELLEToolStripMenuItem";
            this.üRÜNGÜNCELLEToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.üRÜNGÜNCELLEToolStripMenuItem.Text = "ÜRÜN GÜNCELLE";
            this.üRÜNGÜNCELLEToolStripMenuItem.Click += new System.EventHandler(this.üRÜNGÜNCELLEToolStripMenuItem_Click);
            // 
            // üRÜNSİLToolStripMenuItem
            // 
            this.üRÜNSİLToolStripMenuItem.Name = "üRÜNSİLToolStripMenuItem";
            this.üRÜNSİLToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.üRÜNSİLToolStripMenuItem.Text = "ÜRÜN SİL";
            this.üRÜNSİLToolStripMenuItem.Click += new System.EventHandler(this.üRÜNSİLToolStripMenuItem_Click);
            // 
            // txtUrunBarkodEkle
            // 
            this.txtUrunBarkodEkle.Location = new System.Drawing.Point(414, 29);
            this.txtUrunBarkodEkle.Mask = "0-000000-999999";
            this.txtUrunBarkodEkle.Name = "txtUrunBarkodEkle";
            this.txtUrunBarkodEkle.Size = new System.Drawing.Size(121, 20);
            this.txtUrunBarkodEkle.TabIndex = 35;
            // 
            // txtUrunRenkEkle
            // 
            this.txtUrunRenkEkle.Location = new System.Drawing.Point(100, 65);
            this.txtUrunRenkEkle.Name = "txtUrunRenkEkle";
            this.txtUrunRenkEkle.Size = new System.Drawing.Size(120, 20);
            this.txtUrunRenkEkle.TabIndex = 2;
            this.txtUrunRenkEkle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunRenkEkle_KeyPress);
            // 
            // UrunEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.AnaSayfaDonBtn;
            this.ClientSize = new System.Drawing.Size(1184, 669);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AnaSayfaDonBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UrunEkleForm";
            this.Text = "Ürün Ekle";
            this.Load += new System.EventHandler(this.UrunEkleForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokYonetimDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BarkodOlusturBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button UrunResimSeçBtn;
        private System.Windows.Forms.ComboBox CmbHBDurumEkle;
        private System.Windows.Forms.TextBox txtUrunSatisFiyati;
        private System.Windows.Forms.TextBox txtUrunAlisFiyati;
        private System.Windows.Forms.ComboBox CmbBeden;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUrunStokEkle;
        private System.Windows.Forms.ComboBox CmbKategori;
        private System.Windows.Forms.TextBox txtUrunAdiEkle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UrunKaydetBtn;
        private System.Windows.Forms.Button AnaSayfaDonBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtUrunResimYolu;
        private StokYonetimDataSet stokYonetimDataSet;
        private System.Windows.Forms.BindingSource urunBindingSource;
        private StokYonetimDataSetTableAdapters.UrunTableAdapter urunTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UrunGuncelleBtn;
        private System.Windows.Forms.Button UrunSilBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üRÜNGÜNCELLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üRÜNSİLToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox txtUrunBarkodEkle;
        private System.Windows.Forms.TextBox txtUrunRenkEkle;
    }
}