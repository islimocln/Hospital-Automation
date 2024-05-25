namespace HastaneOtomasyonu_Proje
{
    partial class FrmBilgiDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgiDüzenle));
            this.buttonGüncelle = new System.Windows.Forms.Button();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.cmbBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.msktxtBoxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.mskTxtBoxTCkimlik = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxSifre = new System.Windows.Forms.TextBox();
            this.txtBoxSoyad = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblTCKimlik = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtBoxAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGüncelle
            // 
            this.buttonGüncelle.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonGüncelle.Location = new System.Drawing.Point(212, 388);
            this.buttonGüncelle.Name = "buttonGüncelle";
            this.buttonGüncelle.Size = new System.Drawing.Size(121, 40);
            this.buttonGüncelle.TabIndex = 26;
            this.buttonGüncelle.Text = "Güncelle";
            this.buttonGüncelle.UseVisualStyleBackColor = false;
            this.buttonGüncelle.Click += new System.EventHandler(this.buttonKayıtYap_Click);
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(80, 331);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(87, 24);
            this.lblCinsiyet.TabIndex = 25;
            this.lblCinsiyet.Text = "Cinsiyet :";
            // 
            // cmbBoxCinsiyet
            // 
            this.cmbBoxCinsiyet.FormattingEnabled = true;
            this.cmbBoxCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbBoxCinsiyet.Location = new System.Drawing.Point(177, 323);
            this.cmbBoxCinsiyet.Name = "cmbBoxCinsiyet";
            this.cmbBoxCinsiyet.Size = new System.Drawing.Size(173, 32);
            this.cmbBoxCinsiyet.TabIndex = 6;
            // 
            // msktxtBoxTelefon
            // 
            this.msktxtBoxTelefon.Location = new System.Drawing.Point(177, 228);
            this.msktxtBoxTelefon.Mask = "(000) 000-0000";
            this.msktxtBoxTelefon.Name = "msktxtBoxTelefon";
            this.msktxtBoxTelefon.Size = new System.Drawing.Size(173, 32);
            this.msktxtBoxTelefon.TabIndex = 4;
            // 
            // mskTxtBoxTCkimlik
            // 
            this.mskTxtBoxTCkimlik.Location = new System.Drawing.Point(177, 178);
            this.mskTxtBoxTCkimlik.Mask = "00000000000";
            this.mskTxtBoxTCkimlik.Name = "mskTxtBoxTCkimlik";
            this.mskTxtBoxTCkimlik.Size = new System.Drawing.Size(173, 32);
            this.mskTxtBoxTCkimlik.TabIndex = 3;
            // 
            // txtBoxSifre
            // 
            this.txtBoxSifre.Location = new System.Drawing.Point(177, 278);
            this.txtBoxSifre.Name = "txtBoxSifre";
            this.txtBoxSifre.Size = new System.Drawing.Size(173, 32);
            this.txtBoxSifre.TabIndex = 5;
            // 
            // txtBoxSoyad
            // 
            this.txtBoxSoyad.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxSoyad.Location = new System.Drawing.Point(177, 131);
            this.txtBoxSoyad.Name = "txtBoxSoyad";
            this.txtBoxSoyad.Size = new System.Drawing.Size(173, 32);
            this.txtBoxSoyad.TabIndex = 2;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(107, 278);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(58, 24);
            this.lblSifre.TabIndex = 19;
            this.lblSifre.Text = "Şifre :";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(84, 231);
            this.lblTelefon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(82, 24);
            this.lblTelefon.TabIndex = 18;
            this.lblTelefon.Text = "Telefon :";
            // 
            // lblTCKimlik
            // 
            this.lblTCKimlik.AutoSize = true;
            this.lblTCKimlik.Location = new System.Drawing.Point(42, 185);
            this.lblTCKimlik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTCKimlik.Name = "lblTCKimlik";
            this.lblTCKimlik.Size = new System.Drawing.Size(129, 24);
            this.lblTCKimlik.TabIndex = 17;
            this.lblTCKimlik.Text = "TC Kimlik No :";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(94, 131);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(72, 24);
            this.lblSoyad.TabIndex = 16;
            this.lblSoyad.Text = "Soyad :";
            // 
            // txtBoxAd
            // 
            this.txtBoxAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxAd.Location = new System.Drawing.Point(177, 77);
            this.txtBoxAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxAd.Name = "txtBoxAd";
            this.txtBoxAd.Size = new System.Drawing.Size(173, 34);
            this.txtBoxAd.TabIndex = 1;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(128, 83);
            this.lblAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(43, 24);
            this.lblAd.TabIndex = 14;
            this.lblAd.Text = "Ad: ";
            // 
            // FrmBilgiDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(417, 462);
            this.Controls.Add(this.buttonGüncelle);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.cmbBoxCinsiyet);
            this.Controls.Add(this.msktxtBoxTelefon);
            this.Controls.Add(this.mskTxtBoxTCkimlik);
            this.Controls.Add(this.txtBoxSifre);
            this.Controls.Add(this.txtBoxSoyad);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblTCKimlik);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.txtBoxAd);
            this.Controls.Add(this.lblAd);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmBilgiDüzenle";
            this.Text = "Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.FrmBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGüncelle;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.ComboBox cmbBoxCinsiyet;
        private System.Windows.Forms.MaskedTextBox msktxtBoxTelefon;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxTCkimlik;
        private System.Windows.Forms.TextBox txtBoxSifre;
        private System.Windows.Forms.TextBox txtBoxSoyad;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblTCKimlik;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtBoxAd;
        private System.Windows.Forms.Label lblAd;
    }
}