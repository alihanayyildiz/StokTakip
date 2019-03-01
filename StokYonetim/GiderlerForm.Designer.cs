namespace StokYonetim
{
    partial class GiderlerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiderlerForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GiderGuncelleBtn = new System.Windows.Forms.Button();
            this.GiderSilBtn = new System.Windows.Forms.Button();
            this.txtGiderUcret = new System.Windows.Forms.MaskedTextBox();
            this.GiderKaydetBtn = new System.Windows.Forms.Button();
            this.cmbGiderTuru = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.giderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giderTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giderUcretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giderlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokYonetimDataSet1 = new StokYonetim.StokYonetimDataSet1();
            this.label12 = new System.Windows.Forms.Label();
            this.AnaSayfaDonBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.EkleSecenekBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.GuncelleSecenekBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.SilSecenekBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.stokYonetimDataSet = new StokYonetim.StokYonetimDataSet();
            this.stokYonetimDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giderlerTableAdapter = new StokYonetim.StokYonetimDataSet1TableAdapters.GiderlerTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokYonetimDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stokYonetimDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokYonetimDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GiderGuncelleBtn);
            this.groupBox1.Controls.Add(this.GiderSilBtn);
            this.groupBox1.Controls.Add(this.txtGiderUcret);
            this.groupBox1.Controls.Add(this.GiderKaydetBtn);
            this.groupBox1.Controls.Add(this.cmbGiderTuru);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GİDERLER LİSTESİ";
            // 
            // GiderGuncelleBtn
            // 
            this.GiderGuncelleBtn.FlatAppearance.BorderSize = 0;
            this.GiderGuncelleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GiderGuncelleBtn.Image = ((System.Drawing.Image)(resources.GetObject("GiderGuncelleBtn.Image")));
            this.GiderGuncelleBtn.Location = new System.Drawing.Point(209, 99);
            this.GiderGuncelleBtn.Name = "GiderGuncelleBtn";
            this.GiderGuncelleBtn.Size = new System.Drawing.Size(35, 35);
            this.GiderGuncelleBtn.TabIndex = 27;
            this.GiderGuncelleBtn.TabStop = false;
            this.GiderGuncelleBtn.UseVisualStyleBackColor = true;
            this.GiderGuncelleBtn.Visible = false;
            this.GiderGuncelleBtn.Click += new System.EventHandler(this.GiderGuncelleBtn_Click);
            // 
            // GiderSilBtn
            // 
            this.GiderSilBtn.FlatAppearance.BorderSize = 0;
            this.GiderSilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GiderSilBtn.Image = ((System.Drawing.Image)(resources.GetObject("GiderSilBtn.Image")));
            this.GiderSilBtn.Location = new System.Drawing.Point(209, 99);
            this.GiderSilBtn.Name = "GiderSilBtn";
            this.GiderSilBtn.Size = new System.Drawing.Size(35, 35);
            this.GiderSilBtn.TabIndex = 28;
            this.GiderSilBtn.TabStop = false;
            this.GiderSilBtn.UseVisualStyleBackColor = true;
            this.GiderSilBtn.Visible = false;
            this.GiderSilBtn.Click += new System.EventHandler(this.GiderSilBtn_Click);
            // 
            // txtGiderUcret
            // 
            this.txtGiderUcret.Location = new System.Drawing.Point(97, 69);
            this.txtGiderUcret.Mask = "00000";
            this.txtGiderUcret.Name = "txtGiderUcret";
            this.txtGiderUcret.Size = new System.Drawing.Size(147, 20);
            this.txtGiderUcret.TabIndex = 26;
            this.txtGiderUcret.ValidatingType = typeof(int);
            // 
            // GiderKaydetBtn
            // 
            this.GiderKaydetBtn.FlatAppearance.BorderSize = 0;
            this.GiderKaydetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GiderKaydetBtn.Image = ((System.Drawing.Image)(resources.GetObject("GiderKaydetBtn.Image")));
            this.GiderKaydetBtn.Location = new System.Drawing.Point(209, 99);
            this.GiderKaydetBtn.Name = "GiderKaydetBtn";
            this.GiderKaydetBtn.Size = new System.Drawing.Size(35, 35);
            this.GiderKaydetBtn.TabIndex = 3;
            this.GiderKaydetBtn.UseVisualStyleBackColor = true;
            this.GiderKaydetBtn.Click += new System.EventHandler(this.GiderKaydetBtn_Click);
            // 
            // cmbGiderTuru
            // 
            this.cmbGiderTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGiderTuru.FormattingEnabled = true;
            this.cmbGiderTuru.Items.AddRange(new object[] {
            "Fatura",
            "Fiş",
            "Yeme / İçme"});
            this.cmbGiderTuru.Location = new System.Drawing.Point(97, 28);
            this.cmbGiderTuru.Name = "cmbGiderTuru";
            this.cmbGiderTuru.Size = new System.Drawing.Size(147, 21);
            this.cmbGiderTuru.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gider Ücreti :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gider Türü :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.giderIDDataGridViewTextBoxColumn,
            this.giderTuruDataGridViewTextBoxColumn,
            this.giderUcretDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.giderlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1119, 439);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // giderIDDataGridViewTextBoxColumn
            // 
            this.giderIDDataGridViewTextBoxColumn.DataPropertyName = "Gider_ID";
            this.giderIDDataGridViewTextBoxColumn.HeaderText = "Gider_ID";
            this.giderIDDataGridViewTextBoxColumn.Name = "giderIDDataGridViewTextBoxColumn";
            this.giderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giderTuruDataGridViewTextBoxColumn
            // 
            this.giderTuruDataGridViewTextBoxColumn.DataPropertyName = "Gider_Turu";
            this.giderTuruDataGridViewTextBoxColumn.HeaderText = "Gider_Turu";
            this.giderTuruDataGridViewTextBoxColumn.Name = "giderTuruDataGridViewTextBoxColumn";
            // 
            // giderUcretDataGridViewTextBoxColumn
            // 
            this.giderUcretDataGridViewTextBoxColumn.DataPropertyName = "Gider_Ucret";
            this.giderUcretDataGridViewTextBoxColumn.HeaderText = "Gider_Ucret";
            this.giderUcretDataGridViewTextBoxColumn.Name = "giderUcretDataGridViewTextBoxColumn";
            // 
            // giderlerBindingSource
            // 
            this.giderlerBindingSource.DataMember = "Giderler";
            this.giderlerBindingSource.DataSource = this.stokYonetimDataSet1;
            // 
            // stokYonetimDataSet1
            // 
            this.stokYonetimDataSet1.DataSetName = "StokYonetimDataSet1";
            this.stokYonetimDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.Location = new System.Drawing.Point(1072, 9);
            this.label12.MinimumSize = new System.Drawing.Size(100, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 100);
            this.label12.TabIndex = 18;
            // 
            // AnaSayfaDonBtn
            // 
            this.AnaSayfaDonBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AnaSayfaDonBtn.FlatAppearance.BorderSize = 0;
            this.AnaSayfaDonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnaSayfaDonBtn.Image = ((System.Drawing.Image)(resources.GetObject("AnaSayfaDonBtn.Image")));
            this.AnaSayfaDonBtn.Location = new System.Drawing.Point(0, 27);
            this.AnaSayfaDonBtn.Name = "AnaSayfaDonBtn";
            this.AnaSayfaDonBtn.Size = new System.Drawing.Size(29, 29);
            this.AnaSayfaDonBtn.TabIndex = 25;
            this.AnaSayfaDonBtn.UseVisualStyleBackColor = true;
            this.AnaSayfaDonBtn.Click += new System.EventHandler(this.AnaSayfaDonBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EkleSecenekBtn,
            this.GuncelleSecenekBtn,
            this.SilSecenekBtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // EkleSecenekBtn
            // 
            this.EkleSecenekBtn.Name = "EkleSecenekBtn";
            this.EkleSecenekBtn.Size = new System.Drawing.Size(44, 20);
            this.EkleSecenekBtn.Text = "EKLE";
            this.EkleSecenekBtn.Click += new System.EventHandler(this.EkleSecenekBtn_Click);
            // 
            // GuncelleSecenekBtn
            // 
            this.GuncelleSecenekBtn.Name = "GuncelleSecenekBtn";
            this.GuncelleSecenekBtn.Size = new System.Drawing.Size(76, 20);
            this.GuncelleSecenekBtn.Text = "GÜNCELLE";
            this.GuncelleSecenekBtn.Click += new System.EventHandler(this.GuncelleSecenekBtn_Click);
            // 
            // SilSecenekBtn
            // 
            this.SilSecenekBtn.Name = "SilSecenekBtn";
            this.SilSecenekBtn.Size = new System.Drawing.Size(34, 20);
            this.SilSecenekBtn.Text = "SİL";
            this.SilSecenekBtn.Click += new System.EventHandler(this.SilSecenekBtn_Click);
            // 
            // stokYonetimDataSet
            // 
            this.stokYonetimDataSet.DataSetName = "StokYonetimDataSet";
            this.stokYonetimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stokYonetimDataSetBindingSource
            // 
            this.stokYonetimDataSetBindingSource.DataSource = this.stokYonetimDataSet;
            this.stokYonetimDataSetBindingSource.Position = 0;
            // 
            // giderlerTableAdapter
            // 
            this.giderlerTableAdapter.ClearBeforeFill = true;
            // 
            // GiderlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.AnaSayfaDonBtn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GiderlerForm";
            this.Text = "GiderlerForm";
            this.Load += new System.EventHandler(this.GiderlerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokYonetimDataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stokYonetimDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokYonetimDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbGiderTuru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button GiderKaydetBtn;
        private System.Windows.Forms.Button AnaSayfaDonBtn;
        private System.Windows.Forms.MaskedTextBox txtGiderUcret;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EkleSecenekBtn;
        private System.Windows.Forms.ToolStripMenuItem GuncelleSecenekBtn;
        private System.Windows.Forms.ToolStripMenuItem SilSecenekBtn;
        private System.Windows.Forms.Button GiderGuncelleBtn;
        private System.Windows.Forms.Button GiderSilBtn;
        private System.Windows.Forms.BindingSource stokYonetimDataSetBindingSource;
        private StokYonetimDataSet stokYonetimDataSet;
        private StokYonetimDataSet1 stokYonetimDataSet1;
        private System.Windows.Forms.BindingSource giderlerBindingSource;
        private StokYonetimDataSet1TableAdapters.GiderlerTableAdapter giderlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn giderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giderTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giderUcretDataGridViewTextBoxColumn;
    }
}