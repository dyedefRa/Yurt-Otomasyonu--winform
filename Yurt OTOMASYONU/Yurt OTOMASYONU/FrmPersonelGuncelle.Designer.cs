namespace Yurt_OTOMASYONU
{
    partial class FrmPersonelGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelGuncelle));
            this.txtPerAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPerId = new System.Windows.Forms.TextBox();
            this.txtPerGorev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelGoreviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtkayitDataSet11 = new Yurt_OTOMASYONU.YurtkayitDataSet11();
            this.yurtkayitDataSet8 = new Yurt_OTOMASYONU.YurtkayitDataSet8();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelTableAdapter = new Yurt_OTOMASYONU.YurtkayitDataSet8TableAdapters.PersonelTableAdapter();
            this.yurtkayitDataSet9 = new Yurt_OTOMASYONU.YurtkayitDataSet9();
            this.personelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personelTableAdapter1 = new Yurt_OTOMASYONU.YurtkayitDataSet9TableAdapters.PersonelTableAdapter();
            this.yurtkayitDataSet10 = new Yurt_OTOMASYONU.YurtkayitDataSet10();
            this.personelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.personelTableAdapter2 = new Yurt_OTOMASYONU.YurtkayitDataSet10TableAdapters.PersonelTableAdapter();
            this.personelTableAdapter3 = new Yurt_OTOMASYONU.YurtkayitDataSet11TableAdapters.PersonelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtkayitDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtkayitDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtkayitDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtkayitDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPerAd
            // 
            this.txtPerAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPerAd.Location = new System.Drawing.Point(210, 89);
            this.txtPerAd.Name = "txtPerAd";
            this.txtPerAd.Size = new System.Drawing.Size(239, 30);
            this.txtPerAd.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(76, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Personel Ad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(83, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Personel ID :";
            // 
            // txtPerId
            // 
            this.txtPerId.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPerId.Location = new System.Drawing.Point(210, 47);
            this.txtPerId.Name = "txtPerId";
            this.txtPerId.ReadOnly = true;
            this.txtPerId.Size = new System.Drawing.Size(239, 30);
            this.txtPerId.TabIndex = 14;
            // 
            // txtPerGorev
            // 
            this.txtPerGorev.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPerGorev.Location = new System.Drawing.Point(210, 129);
            this.txtPerGorev.Name = "txtPerGorev";
            this.txtPerGorev.Size = new System.Drawing.Size(239, 30);
            this.txtPerGorev.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(45, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Personel Görevi :";
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(192, 255);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(154, 35);
            this.btnSil.TabIndex = 26;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(12, 255);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(154, 35);
            this.btnKaydet.TabIndex = 25;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(368, 255);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(154, 35);
            this.btnGuncelle.TabIndex = 27;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personleidDataGridViewTextBoxColumn,
            this.personelAdSoyadDataGridViewTextBoxColumn,
            this.personelGoreviDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(49, 332);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(455, 188);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // personleidDataGridViewTextBoxColumn
            // 
            this.personleidDataGridViewTextBoxColumn.DataPropertyName = "Personleid";
            this.personleidDataGridViewTextBoxColumn.HeaderText = "Personleid";
            this.personleidDataGridViewTextBoxColumn.Name = "personleidDataGridViewTextBoxColumn";
            this.personleidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelAdSoyadDataGridViewTextBoxColumn
            // 
            this.personelAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "PersonelAdSoyad";
            this.personelAdSoyadDataGridViewTextBoxColumn.HeaderText = "PersonelAdSoyad";
            this.personelAdSoyadDataGridViewTextBoxColumn.Name = "personelAdSoyadDataGridViewTextBoxColumn";
            this.personelAdSoyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelGoreviDataGridViewTextBoxColumn
            // 
            this.personelGoreviDataGridViewTextBoxColumn.DataPropertyName = "PersonelGorevi";
            this.personelGoreviDataGridViewTextBoxColumn.HeaderText = "PersonelGorevi";
            this.personelGoreviDataGridViewTextBoxColumn.Name = "personelGoreviDataGridViewTextBoxColumn";
            this.personelGoreviDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelBindingSource3
            // 
            this.personelBindingSource3.DataMember = "Personel";
            this.personelBindingSource3.DataSource = this.yurtkayitDataSet11;
            // 
            // yurtkayitDataSet11
            // 
            this.yurtkayitDataSet11.DataSetName = "YurtkayitDataSet11";
            this.yurtkayitDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yurtkayitDataSet8
            // 
            this.yurtkayitDataSet8.DataSetName = "YurtkayitDataSet8";
            this.yurtkayitDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            this.personelBindingSource.DataSource = this.yurtkayitDataSet8;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // yurtkayitDataSet9
            // 
            this.yurtkayitDataSet9.DataSetName = "YurtkayitDataSet9";
            this.yurtkayitDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelBindingSource1
            // 
            this.personelBindingSource1.DataMember = "Personel";
            this.personelBindingSource1.DataSource = this.yurtkayitDataSet9;
            // 
            // personelTableAdapter1
            // 
            this.personelTableAdapter1.ClearBeforeFill = true;
            // 
            // yurtkayitDataSet10
            // 
            this.yurtkayitDataSet10.DataSetName = "YurtkayitDataSet10";
            this.yurtkayitDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelBindingSource2
            // 
            this.personelBindingSource2.DataMember = "Personel";
            this.personelBindingSource2.DataSource = this.yurtkayitDataSet10;
            // 
            // personelTableAdapter2
            // 
            this.personelTableAdapter2.ClearBeforeFill = true;
            // 
            // personelTableAdapter3
            // 
            this.personelTableAdapter3.ClearBeforeFill = true;
            // 
            // FrmPersonelGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(534, 556);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtPerGorev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPerAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPerId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPersonelGuncelle";
            this.Text = "Personel Güncelleme Alanı";
            this.Load += new System.EventHandler(this.FrmPersonelGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtkayitDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtkayitDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtkayitDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtkayitDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPerAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPerId;
        private System.Windows.Forms.TextBox txtPerGorev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtkayitDataSet8 yurtkayitDataSet8;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private YurtkayitDataSet8TableAdapters.PersonelTableAdapter personelTableAdapter;
        private YurtkayitDataSet9 yurtkayitDataSet9;
        private System.Windows.Forms.BindingSource personelBindingSource1;
        private YurtkayitDataSet9TableAdapters.PersonelTableAdapter personelTableAdapter1;
        private YurtkayitDataSet10 yurtkayitDataSet10;
        private System.Windows.Forms.BindingSource personelBindingSource2;
        private YurtkayitDataSet10TableAdapters.PersonelTableAdapter personelTableAdapter2;
        private YurtkayitDataSet11 yurtkayitDataSet11;
        private System.Windows.Forms.BindingSource personelBindingSource3;
        private YurtkayitDataSet11TableAdapters.PersonelTableAdapter personelTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn personleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelGoreviDataGridViewTextBoxColumn;
    }
}