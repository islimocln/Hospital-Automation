namespace HastaneOtomasyonu_Proje
{
    partial class FrmSekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterDetay));
            this.grpBoxSekreterBilgi = new System.Windows.Forms.GroupBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpBoxDuyuruOluştur = new System.Windows.Forms.GroupBox();
            this.progressBarDuyuru = new System.Windows.Forms.ProgressBar();
            this.btnOluştur = new System.Windows.Forms.Button();
            this.rchtextBoxDuyuruOluştur = new System.Windows.Forms.RichTextBox();
            this.grpBoxRandevuPaneli = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtBoxid = new System.Windows.Forms.TextBox();
            this.chckBoxDurum = new System.Windows.Forms.CheckBox();
            this.mskBoxTC = new System.Windows.Forms.MaskedTextBox();
            this.cmbBoxBrans = new System.Windows.Forms.ComboBox();
            this.cmbBoxDoktorlar = new System.Windows.Forms.ComboBox();
            this.mskBoxSaat = new System.Windows.Forms.MaskedTextBox();
            this.mskBoxTarih = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxBranslar = new System.Windows.Forms.GroupBox();
            this.dataGridBranslar = new System.Windows.Forms.DataGridView();
            this.grpBoxDoktorlar = new System.Windows.Forms.GroupBox();
            this.dataGridDoktorlar = new System.Windows.Forms.DataGridView();
            this.grpBoxHızlıErişim = new System.Windows.Forms.GroupBox();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnCıkısYap = new System.Windows.Forms.Button();
            this.btnDuyurular = new System.Windows.Forms.Button();
            this.btnRandevuListele = new System.Windows.Forms.Button();
            this.btnBransPaneli = new System.Windows.Forms.Button();
            this.grpBoxSekreterBilgi.SuspendLayout();
            this.grpBoxDuyuruOluştur.SuspendLayout();
            this.grpBoxRandevuPaneli.SuspendLayout();
            this.grpBoxBranslar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBranslar)).BeginInit();
            this.grpBoxDoktorlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDoktorlar)).BeginInit();
            this.grpBoxHızlıErişim.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxSekreterBilgi
            // 
            this.grpBoxSekreterBilgi.Controls.Add(this.lblAdSoyad);
            this.grpBoxSekreterBilgi.Controls.Add(this.lblTc);
            this.grpBoxSekreterBilgi.Controls.Add(this.label8);
            this.grpBoxSekreterBilgi.Controls.Add(this.label7);
            this.grpBoxSekreterBilgi.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxSekreterBilgi.Location = new System.Drawing.Point(12, 12);
            this.grpBoxSekreterBilgi.Name = "grpBoxSekreterBilgi";
            this.grpBoxSekreterBilgi.Size = new System.Drawing.Size(258, 132);
            this.grpBoxSekreterBilgi.TabIndex = 0;
            this.grpBoxSekreterBilgi.TabStop = false;
            this.grpBoxSekreterBilgi.Text = "Sekreter Bilgi";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(112, 84);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(76, 21);
            this.lblAdSoyad.TabIndex = 3;
            this.lblAdSoyad.Text = "Null  Null";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(112, 44);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(109, 21);
            this.lblTc.TabIndex = 2;
            this.lblTc.Text = "00000000000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ad Soyad :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "TC No :";
            // 
            // grpBoxDuyuruOluştur
            // 
            this.grpBoxDuyuruOluştur.Controls.Add(this.progressBarDuyuru);
            this.grpBoxDuyuruOluştur.Controls.Add(this.btnOluştur);
            this.grpBoxDuyuruOluştur.Controls.Add(this.rchtextBoxDuyuruOluştur);
            this.grpBoxDuyuruOluştur.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxDuyuruOluştur.Location = new System.Drawing.Point(12, 167);
            this.grpBoxDuyuruOluştur.Name = "grpBoxDuyuruOluştur";
            this.grpBoxDuyuruOluştur.Size = new System.Drawing.Size(258, 373);
            this.grpBoxDuyuruOluştur.TabIndex = 1;
            this.grpBoxDuyuruOluştur.TabStop = false;
            this.grpBoxDuyuruOluştur.Text = "Duyuru Oluştur";
            // 
            // progressBarDuyuru
            // 
            this.progressBarDuyuru.Location = new System.Drawing.Point(46, 229);
            this.progressBarDuyuru.Name = "progressBarDuyuru";
            this.progressBarDuyuru.Size = new System.Drawing.Size(168, 34);
            this.progressBarDuyuru.TabIndex = 2;
            // 
            // btnOluştur
            // 
            this.btnOluştur.Location = new System.Drawing.Point(46, 308);
            this.btnOluştur.Name = "btnOluştur";
            this.btnOluştur.Size = new System.Drawing.Size(168, 39);
            this.btnOluştur.TabIndex = 1;
            this.btnOluştur.Text = "Oluştur";
            this.btnOluştur.UseVisualStyleBackColor = true;
            this.btnOluştur.Click += new System.EventHandler(this.btnOluştur_Click);
            // 
            // rchtextBoxDuyuruOluştur
            // 
            this.rchtextBoxDuyuruOluştur.Location = new System.Drawing.Point(6, 21);
            this.rchtextBoxDuyuruOluştur.Name = "rchtextBoxDuyuruOluştur";
            this.rchtextBoxDuyuruOluştur.Size = new System.Drawing.Size(246, 180);
            this.rchtextBoxDuyuruOluştur.TabIndex = 0;
            this.rchtextBoxDuyuruOluştur.Text = "";
            this.rchtextBoxDuyuruOluştur.TextChanged += new System.EventHandler(this.rchtextBoxDuyuruOluştur_TextChanged);
            // 
            // grpBoxRandevuPaneli
            // 
            this.grpBoxRandevuPaneli.Controls.Add(this.btnKaydet);
            this.grpBoxRandevuPaneli.Controls.Add(this.txtBoxid);
            this.grpBoxRandevuPaneli.Controls.Add(this.chckBoxDurum);
            this.grpBoxRandevuPaneli.Controls.Add(this.mskBoxTC);
            this.grpBoxRandevuPaneli.Controls.Add(this.cmbBoxBrans);
            this.grpBoxRandevuPaneli.Controls.Add(this.cmbBoxDoktorlar);
            this.grpBoxRandevuPaneli.Controls.Add(this.mskBoxSaat);
            this.grpBoxRandevuPaneli.Controls.Add(this.mskBoxTarih);
            this.grpBoxRandevuPaneli.Controls.Add(this.label6);
            this.grpBoxRandevuPaneli.Controls.Add(this.label5);
            this.grpBoxRandevuPaneli.Controls.Add(this.label4);
            this.grpBoxRandevuPaneli.Controls.Add(this.label3);
            this.grpBoxRandevuPaneli.Controls.Add(this.label2);
            this.grpBoxRandevuPaneli.Controls.Add(this.label1);
            this.grpBoxRandevuPaneli.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxRandevuPaneli.Location = new System.Drawing.Point(276, 12);
            this.grpBoxRandevuPaneli.Name = "grpBoxRandevuPaneli";
            this.grpBoxRandevuPaneli.Size = new System.Drawing.Size(291, 395);
            this.grpBoxRandevuPaneli.TabIndex = 2;
            this.grpBoxRandevuPaneli.TabStop = false;
            this.grpBoxRandevuPaneli.Text = "Randevu Paneli";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(57, 332);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(159, 33);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtBoxid
            // 
            this.txtBoxid.Location = new System.Drawing.Point(82, 44);
            this.txtBoxid.Name = "txtBoxid";
            this.txtBoxid.Size = new System.Drawing.Size(154, 28);
            this.txtBoxid.TabIndex = 13;
            // 
            // chckBoxDurum
            // 
            this.chckBoxDurum.AutoSize = true;
            this.chckBoxDurum.Location = new System.Drawing.Point(82, 283);
            this.chckBoxDurum.Name = "chckBoxDurum";
            this.chckBoxDurum.Size = new System.Drawing.Size(82, 25);
            this.chckBoxDurum.TabIndex = 12;
            this.chckBoxDurum.Text = "Durum";
            this.chckBoxDurum.UseVisualStyleBackColor = true;
            // 
            // mskBoxTC
            // 
            this.mskBoxTC.Location = new System.Drawing.Point(82, 237);
            this.mskBoxTC.Mask = "00000000000";
            this.mskBoxTC.Name = "mskBoxTC";
            this.mskBoxTC.Size = new System.Drawing.Size(154, 28);
            this.mskBoxTC.TabIndex = 11;
            // 
            // cmbBoxBrans
            // 
            this.cmbBoxBrans.FormattingEnabled = true;
            this.cmbBoxBrans.Location = new System.Drawing.Point(82, 155);
            this.cmbBoxBrans.Name = "cmbBoxBrans";
            this.cmbBoxBrans.Size = new System.Drawing.Size(154, 29);
            this.cmbBoxBrans.TabIndex = 10;
            this.cmbBoxBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBoxBrans_SelectedIndexChanged);
            // 
            // cmbBoxDoktorlar
            // 
            this.cmbBoxDoktorlar.FormattingEnabled = true;
            this.cmbBoxDoktorlar.Location = new System.Drawing.Point(82, 196);
            this.cmbBoxDoktorlar.Name = "cmbBoxDoktorlar";
            this.cmbBoxDoktorlar.Size = new System.Drawing.Size(154, 29);
            this.cmbBoxDoktorlar.TabIndex = 9;
            // 
            // mskBoxSaat
            // 
            this.mskBoxSaat.Location = new System.Drawing.Point(82, 115);
            this.mskBoxSaat.Mask = "00:00";
            this.mskBoxSaat.Name = "mskBoxSaat";
            this.mskBoxSaat.Size = new System.Drawing.Size(154, 28);
            this.mskBoxSaat.TabIndex = 8;
            this.mskBoxSaat.ValidatingType = typeof(System.DateTime);
            // 
            // mskBoxTarih
            // 
            this.mskBoxTarih.Location = new System.Drawing.Point(82, 81);
            this.mskBoxTarih.Mask = "00/00/0000";
            this.mskBoxTarih.Name = "mskBoxTarih";
            this.mskBoxTarih.Size = new System.Drawing.Size(154, 28);
            this.mskBoxTarih.TabIndex = 7;
            this.mskBoxTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "TC :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Doktor :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Branş :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarih :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "İd  :";
            // 
            // grpBoxBranslar
            // 
            this.grpBoxBranslar.Controls.Add(this.dataGridBranslar);
            this.grpBoxBranslar.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxBranslar.Location = new System.Drawing.Point(573, 12);
            this.grpBoxBranslar.Name = "grpBoxBranslar";
            this.grpBoxBranslar.Size = new System.Drawing.Size(485, 258);
            this.grpBoxBranslar.TabIndex = 3;
            this.grpBoxBranslar.TabStop = false;
            this.grpBoxBranslar.Text = "Branşlar";
            // 
            // dataGridBranslar
            // 
            this.dataGridBranslar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBranslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBranslar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridBranslar.Location = new System.Drawing.Point(3, 25);
            this.dataGridBranslar.Name = "dataGridBranslar";
            this.dataGridBranslar.RowHeadersWidth = 51;
            this.dataGridBranslar.RowTemplate.Height = 24;
            this.dataGridBranslar.Size = new System.Drawing.Size(479, 230);
            this.dataGridBranslar.TabIndex = 0;
            this.dataGridBranslar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBranslar_CellContentClick);
            // 
            // grpBoxDoktorlar
            // 
            this.grpBoxDoktorlar.Controls.Add(this.dataGridDoktorlar);
            this.grpBoxDoktorlar.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxDoktorlar.Location = new System.Drawing.Point(576, 276);
            this.grpBoxDoktorlar.Name = "grpBoxDoktorlar";
            this.grpBoxDoktorlar.Size = new System.Drawing.Size(482, 283);
            this.grpBoxDoktorlar.TabIndex = 4;
            this.grpBoxDoktorlar.TabStop = false;
            this.grpBoxDoktorlar.Text = "Doktorlar";
            // 
            // dataGridDoktorlar
            // 
            this.dataGridDoktorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDoktorlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDoktorlar.Location = new System.Drawing.Point(3, 25);
            this.dataGridDoktorlar.Name = "dataGridDoktorlar";
            this.dataGridDoktorlar.RowHeadersWidth = 51;
            this.dataGridDoktorlar.RowTemplate.Height = 24;
            this.dataGridDoktorlar.Size = new System.Drawing.Size(476, 255);
            this.dataGridDoktorlar.TabIndex = 0;
            this.dataGridDoktorlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDoktorlar_CellContentClick);
            // 
            // grpBoxHızlıErişim
            // 
            this.grpBoxHızlıErişim.Controls.Add(this.btnGeriDon);
            this.grpBoxHızlıErişim.Controls.Add(this.btnCıkısYap);
            this.grpBoxHızlıErişim.Controls.Add(this.btnDuyurular);
            this.grpBoxHızlıErişim.Controls.Add(this.btnRandevuListele);
            this.grpBoxHızlıErişim.Controls.Add(this.btnBransPaneli);
            this.grpBoxHızlıErişim.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxHızlıErişim.Location = new System.Drawing.Point(276, 396);
            this.grpBoxHızlıErişim.Name = "grpBoxHızlıErişim";
            this.grpBoxHızlıErişim.Size = new System.Drawing.Size(291, 185);
            this.grpBoxHızlıErişim.TabIndex = 5;
            this.grpBoxHızlıErişim.TabStop = false;
            this.grpBoxHızlıErişim.Text = "Hızlı Erişim";
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(161, 137);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(121, 42);
            this.btnGeriDon.TabIndex = 5;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnCıkısYap
            // 
            this.btnCıkısYap.Location = new System.Drawing.Point(19, 137);
            this.btnCıkısYap.Name = "btnCıkısYap";
            this.btnCıkısYap.Size = new System.Drawing.Size(117, 42);
            this.btnCıkısYap.TabIndex = 4;
            this.btnCıkısYap.Text = "Çıkış Yap";
            this.btnCıkısYap.UseVisualStyleBackColor = true;
            this.btnCıkısYap.Click += new System.EventHandler(this.btnCıkısYap_Click);
            // 
            // btnDuyurular
            // 
            this.btnDuyurular.Location = new System.Drawing.Point(82, 79);
            this.btnDuyurular.Name = "btnDuyurular";
            this.btnDuyurular.Size = new System.Drawing.Size(105, 42);
            this.btnDuyurular.TabIndex = 3;
            this.btnDuyurular.Text = "Duyurlar";
            this.btnDuyurular.UseVisualStyleBackColor = true;
            this.btnDuyurular.Click += new System.EventHandler(this.btnDuyurular_Click);
            // 
            // btnRandevuListele
            // 
            this.btnRandevuListele.Location = new System.Drawing.Point(142, 28);
            this.btnRandevuListele.Name = "btnRandevuListele";
            this.btnRandevuListele.Size = new System.Drawing.Size(143, 45);
            this.btnRandevuListele.TabIndex = 2;
            this.btnRandevuListele.Text = "Randevu Listele";
            this.btnRandevuListele.UseVisualStyleBackColor = true;
            this.btnRandevuListele.Click += new System.EventHandler(this.btnRandevuListele_Click);
            // 
            // btnBransPaneli
            // 
            this.btnBransPaneli.Location = new System.Drawing.Point(6, 28);
            this.btnBransPaneli.Name = "btnBransPaneli";
            this.btnBransPaneli.Size = new System.Drawing.Size(130, 44);
            this.btnBransPaneli.TabIndex = 1;
            this.btnBransPaneli.Text = "Branş Paneli";
            this.btnBransPaneli.UseVisualStyleBackColor = true;
            this.btnBransPaneli.Click += new System.EventHandler(this.btnBransPaneli_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1083, 593);
            this.Controls.Add(this.grpBoxHızlıErişim);
            this.Controls.Add(this.grpBoxDoktorlar);
            this.Controls.Add(this.grpBoxBranslar);
            this.Controls.Add(this.grpBoxRandevuPaneli);
            this.Controls.Add(this.grpBoxDuyuruOluştur);
            this.Controls.Add(this.grpBoxSekreterBilgi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSekreterDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekreter Detay";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.grpBoxSekreterBilgi.ResumeLayout(false);
            this.grpBoxSekreterBilgi.PerformLayout();
            this.grpBoxDuyuruOluştur.ResumeLayout(false);
            this.grpBoxRandevuPaneli.ResumeLayout(false);
            this.grpBoxRandevuPaneli.PerformLayout();
            this.grpBoxBranslar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBranslar)).EndInit();
            this.grpBoxDoktorlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDoktorlar)).EndInit();
            this.grpBoxHızlıErişim.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxSekreterBilgi;
        private System.Windows.Forms.GroupBox grpBoxDuyuruOluştur;
        private System.Windows.Forms.Button btnOluştur;
        private System.Windows.Forms.RichTextBox rchtextBoxDuyuruOluştur;
        private System.Windows.Forms.GroupBox grpBoxRandevuPaneli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chckBoxDurum;
        private System.Windows.Forms.MaskedTextBox mskBoxTC;
        private System.Windows.Forms.ComboBox cmbBoxBrans;
        private System.Windows.Forms.ComboBox cmbBoxDoktorlar;
        private System.Windows.Forms.MaskedTextBox mskBoxSaat;
        private System.Windows.Forms.MaskedTextBox mskBoxTarih;
        private System.Windows.Forms.TextBox txtBoxid;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox grpBoxBranslar;
        private System.Windows.Forms.DataGridView dataGridBranslar;
        private System.Windows.Forms.GroupBox grpBoxDoktorlar;
        private System.Windows.Forms.DataGridView dataGridDoktorlar;
        private System.Windows.Forms.GroupBox grpBoxHızlıErişim;
        private System.Windows.Forms.Button btnRandevuListele;
        private System.Windows.Forms.Button btnBransPaneli;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDuyurular;
        private System.Windows.Forms.ProgressBar progressBarDuyuru;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnCıkısYap;
    }
}