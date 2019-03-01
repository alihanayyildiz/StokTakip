namespace StokYonetim
{
    partial class SatisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatisForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.UrunSatisTamamlaBtn = new System.Windows.Forms.Button();
            this.UrunSatisBarkodBtn = new System.Windows.Forms.Button();
            this.txtUrunSatilanAdet = new System.Windows.Forms.TextBox();
            this.CBUrunSatisTuru = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrunSatBarkod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblToplamSatis = new System.Windows.Forms.Label();
            this.lblKrediKartiSatis = new System.Windows.Forms.Label();
            this.lblNakitSatis = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.AnaSayfaDonBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSatisUcret = new System.Windows.Forms.TextBox();
            this.stokYonetimDataSet = new StokYonetim.StokYonetimDataSet();
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunTableAdapter = new StokYonetim.StokYonetimDataSetTableAdapters.UrunTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stokYonetimDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtSatisUcret);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.UrunSatisTamamlaBtn);
            this.groupBox1.Controls.Add(this.UrunSatisBarkodBtn);
            this.groupBox1.Controls.Add(this.txtUrunSatilanAdet);
            this.groupBox1.Controls.Add(this.CBUrunSatisTuru);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUrunSatBarkod);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(597, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÜRÜN SATIŞI";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 178);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // UrunSatisTamamlaBtn
            // 
            this.UrunSatisTamamlaBtn.FlatAppearance.BorderSize = 0;
            this.UrunSatisTamamlaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UrunSatisTamamlaBtn.Image = ((System.Drawing.Image)(resources.GetObject("UrunSatisTamamlaBtn.Image")));
            this.UrunSatisTamamlaBtn.Location = new System.Drawing.Point(496, 151);
            this.UrunSatisTamamlaBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UrunSatisTamamlaBtn.Name = "UrunSatisTamamlaBtn";
            this.UrunSatisTamamlaBtn.Size = new System.Drawing.Size(73, 49);
            this.UrunSatisTamamlaBtn.TabIndex = 11;
            this.UrunSatisTamamlaBtn.UseVisualStyleBackColor = true;
            this.UrunSatisTamamlaBtn.Click += new System.EventHandler(this.UrunSatisTamamlaBtn_Click);
            // 
            // UrunSatisBarkodBtn
            // 
            this.UrunSatisBarkodBtn.FlatAppearance.BorderSize = 0;
            this.UrunSatisBarkodBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UrunSatisBarkodBtn.Image = ((System.Drawing.Image)(resources.GetObject("UrunSatisBarkodBtn.Image")));
            this.UrunSatisBarkodBtn.Location = new System.Drawing.Point(384, 20);
            this.UrunSatisBarkodBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UrunSatisBarkodBtn.Name = "UrunSatisBarkodBtn";
            this.UrunSatisBarkodBtn.Size = new System.Drawing.Size(56, 44);
            this.UrunSatisBarkodBtn.TabIndex = 8;
            this.UrunSatisBarkodBtn.UseVisualStyleBackColor = true;
            this.UrunSatisBarkodBtn.Click += new System.EventHandler(this.UrunSatisBarkodBtn_Click);
            // 
            // txtUrunSatilanAdet
            // 
            this.txtUrunSatilanAdet.Location = new System.Drawing.Point(140, 141);
            this.txtUrunSatilanAdet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUrunSatilanAdet.Name = "txtUrunSatilanAdet";
            this.txtUrunSatilanAdet.Size = new System.Drawing.Size(232, 22);
            this.txtUrunSatilanAdet.TabIndex = 7;
            // 
            // CBUrunSatisTuru
            // 
            this.CBUrunSatisTuru.FormattingEnabled = true;
            this.CBUrunSatisTuru.Items.AddRange(new object[] {
            "Kredi Kartı",
            "Nakit"});
            this.CBUrunSatisTuru.Location = new System.Drawing.Point(140, 68);
            this.CBUrunSatisTuru.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBUrunSatisTuru.Name = "CBUrunSatisTuru";
            this.CBUrunSatisTuru.Size = new System.Drawing.Size(232, 24);
            this.CBUrunSatisTuru.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Satış Türü :";
            // 
            // txtUrunSatBarkod
            // 
            this.txtUrunSatBarkod.Location = new System.Drawing.Point(140, 31);
            this.txtUrunSatBarkod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUrunSatBarkod.Name = "txtUrunSatBarkod";
            this.txtUrunSatBarkod.Size = new System.Drawing.Size(232, 22);
            this.txtUrunSatBarkod.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Satılan Adet :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Barkodu :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 299);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1511, 486);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblToplamSatis);
            this.groupBox2.Controls.Add(this.lblKrediKartiSatis);
            this.groupBox2.Controls.Add(this.lblNakitSatis);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(1213, 142);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(329, 150);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUGÜN YAPILAN SATIŞ";
            // 
            // lblToplamSatis
            // 
            this.lblToplamSatis.AutoSize = true;
            this.lblToplamSatis.Location = new System.Drawing.Point(115, 113);
            this.lblToplamSatis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamSatis.Name = "lblToplamSatis";
            this.lblToplamSatis.Size = new System.Drawing.Size(54, 17);
            this.lblToplamSatis.TabIndex = 5;
            this.lblToplamSatis.Text = "label11";
            // 
            // lblKrediKartiSatis
            // 
            this.lblKrediKartiSatis.AutoSize = true;
            this.lblKrediKartiSatis.Location = new System.Drawing.Point(115, 78);
            this.lblKrediKartiSatis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKrediKartiSatis.Name = "lblKrediKartiSatis";
            this.lblKrediKartiSatis.Size = new System.Drawing.Size(54, 17);
            this.lblKrediKartiSatis.TabIndex = 4;
            this.lblKrediKartiSatis.Text = "label10";
            // 
            // lblNakitSatis
            // 
            this.lblNakitSatis.AutoSize = true;
            this.lblNakitSatis.Location = new System.Drawing.Point(115, 43);
            this.lblNakitSatis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNakitSatis.Name = "lblNakitSatis";
            this.lblNakitSatis.Size = new System.Drawing.Size(46, 17);
            this.lblNakitSatis.TabIndex = 3;
            this.lblNakitSatis.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kredi Kartı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nakit :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Toplam :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.Location = new System.Drawing.Point(1409, 11);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.MinimumSize = new System.Drawing.Size(133, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 123);
            this.label12.TabIndex = 16;
            // 
            // AnaSayfaDonBtn
            // 
            this.AnaSayfaDonBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AnaSayfaDonBtn.FlatAppearance.BorderSize = 0;
            this.AnaSayfaDonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnaSayfaDonBtn.Image = ((System.Drawing.Image)(resources.GetObject("AnaSayfaDonBtn.Image")));
            this.AnaSayfaDonBtn.Location = new System.Drawing.Point(4, 1);
            this.AnaSayfaDonBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AnaSayfaDonBtn.Name = "AnaSayfaDonBtn";
            this.AnaSayfaDonBtn.Size = new System.Drawing.Size(39, 36);
            this.AnaSayfaDonBtn.TabIndex = 25;
            this.AnaSayfaDonBtn.UseVisualStyleBackColor = true;
            this.AnaSayfaDonBtn.Click += new System.EventHandler(this.AnaSayfaDonBtn_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(496, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 64);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Satış Ücreti";
            // 
            // txtSatisUcret
            // 
            this.txtSatisUcret.Location = new System.Drawing.Point(140, 107);
            this.txtSatisUcret.Name = "txtSatisUcret";
            this.txtSatisUcret.Size = new System.Drawing.Size(232, 22);
            this.txtSatisUcret.TabIndex = 15;
            // 
            // stokYonetimDataSet
            // 
            this.stokYonetimDataSet.DataSetName = "StokYonetimDataSet";
            this.stokYonetimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataMember = "Urun";
            this.urunBindingSource.DataSource = this.stokYonetimDataSet;
            // 
            // urunTableAdapter
            // 
            this.urunTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(508, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 45);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Satış Tarihi";
            // 
            // SatisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 814);
            this.Controls.Add(this.AnaSayfaDonBtn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SatisForm";
            this.Text = "SatisForm";
            this.Load += new System.EventHandler(this.SatisForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stokYonetimDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUrunSatilanAdet;
        private System.Windows.Forms.ComboBox CBUrunSatisTuru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUrunSatBarkod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UrunSatisBarkodBtn;
        private System.Windows.Forms.Button UrunSatisTamamlaBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblToplamSatis;
        private System.Windows.Forms.Label lblKrediKartiSatis;
        private System.Windows.Forms.Label lblNakitSatis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button AnaSayfaDonBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSatisUcret;
        private System.Windows.Forms.Label label5;
        private StokYonetimDataSet stokYonetimDataSet;
        private System.Windows.Forms.BindingSource urunBindingSource;
        private StokYonetimDataSetTableAdapters.UrunTableAdapter urunTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}