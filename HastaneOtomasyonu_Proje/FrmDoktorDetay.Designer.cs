namespace HastaneOtomasyonu_Proje
{
    partial class FrmDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorDetay));
            this.grpDoktorBilgileri = new System.Windows.Forms.GroupBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTCNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpRandevulistesi = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.btnDuyurular = new System.Windows.Forms.Button();
            this.btnBilgiDüzenle = new System.Windows.Forms.Button();
            this.grpDoktorBilgileri.SuspendLayout();
            this.grpRandevulistesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDoktorBilgileri
            // 
            this.grpDoktorBilgileri.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grpDoktorBilgileri.Controls.Add(this.lblAdSoyad);
            this.grpDoktorBilgileri.Controls.Add(this.label3);
            this.grpDoktorBilgileri.Controls.Add(this.lblTCNo);
            this.grpDoktorBilgileri.Controls.Add(this.label1);
            this.grpDoktorBilgileri.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpDoktorBilgileri.Location = new System.Drawing.Point(12, 13);
            this.grpDoktorBilgileri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDoktorBilgileri.Name = "grpDoktorBilgileri";
            this.grpDoktorBilgileri.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDoktorBilgileri.Size = new System.Drawing.Size(311, 136);
            this.grpDoktorBilgileri.TabIndex = 1;
            this.grpDoktorBilgileri.TabStop = false;
            this.grpDoktorBilgileri.Text = "Doktor Bilgileri";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(134, 88);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(84, 22);
            this.lblAdSoyad.TabIndex = 1;
            this.lblAdSoyad.Text = "Null  Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ad Soyad :";
            // 
            // lblTCNo
            // 
            this.lblTCNo.AutoSize = true;
            this.lblTCNo.Location = new System.Drawing.Point(125, 37);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(109, 22);
            this.lblTCNo.TabIndex = 1;
            this.lblTCNo.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC No:";
            // 
            // grpRandevulistesi
            // 
            this.grpRandevulistesi.Controls.Add(this.dataGridView1);
            this.grpRandevulistesi.Location = new System.Drawing.Point(329, 13);
            this.grpRandevulistesi.Name = "grpRandevulistesi";
            this.grpRandevulistesi.Size = new System.Drawing.Size(456, 442);
            this.grpRandevulistesi.TabIndex = 3;
            this.grpRandevulistesi.TabStop = false;
            this.grpRandevulistesi.Text = "Randevu Listesi";
            this.grpRandevulistesi.Enter += new System.EventHandler(this.grpRandevulistesi_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(450, 421);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGeriDon);
            this.groupBox4.Controls.Add(this.btnCıkıs);
            this.groupBox4.Controls.Add(this.btnDuyurular);
            this.groupBox4.Controls.Add(this.btnBilgiDüzenle);
            this.groupBox4.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(30, 200);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(292, 255);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hızlı Erişim";
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(46, 149);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(170, 49);
            this.btnGeriDon.TabIndex = 3;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.Location = new System.Drawing.Point(46, 204);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(170, 45);
            this.btnCıkıs.TabIndex = 2;
            this.btnCıkıs.Text = "Çıkış";
            this.btnCıkıs.UseVisualStyleBackColor = true;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click_1);
            // 
            // btnDuyurular
            // 
            this.btnDuyurular.Location = new System.Drawing.Point(46, 88);
            this.btnDuyurular.Name = "btnDuyurular";
            this.btnDuyurular.Size = new System.Drawing.Size(170, 55);
            this.btnDuyurular.TabIndex = 1;
            this.btnDuyurular.Text = "Duyurular";
            this.btnDuyurular.UseVisualStyleBackColor = true;
            this.btnDuyurular.Click += new System.EventHandler(this.btnDuyurular_Click);
            // 
            // btnBilgiDüzenle
            // 
            this.btnBilgiDüzenle.Location = new System.Drawing.Point(46, 39);
            this.btnBilgiDüzenle.Name = "btnBilgiDüzenle";
            this.btnBilgiDüzenle.Size = new System.Drawing.Size(170, 43);
            this.btnBilgiDüzenle.TabIndex = 0;
            this.btnBilgiDüzenle.Text = "Bilgi Düzenle";
            this.btnBilgiDüzenle.UseVisualStyleBackColor = true;
            this.btnBilgiDüzenle.Click += new System.EventHandler(this.btnBilgiDüzenle_Click_1);
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(797, 477);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grpRandevulistesi);
            this.Controls.Add(this.grpDoktorBilgileri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDoktorDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoktorDetay";
            this.Load += new System.EventHandler(this.FrmDoktorDetay_Load_1);
            this.grpDoktorBilgileri.ResumeLayout(false);
            this.grpDoktorBilgileri.PerformLayout();
            this.grpRandevulistesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDoktorBilgileri;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTCNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpRandevulistesi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDuyurular;
        private System.Windows.Forms.Button btnBilgiDüzenle;
        private System.Windows.Forms.Button btnCıkıs;
        private System.Windows.Forms.Button btnGeriDon;
    }
}