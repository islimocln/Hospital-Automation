namespace HastaneOtomasyonu_Proje
{
    partial class FrmGirisler
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.btnDoktorgrs = new System.Windows.Forms.Button();
            this.btnSekretergrs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDoktorgrs
            // 
            this.btnDoktorgrs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoktorgrs.BackgroundImage")));
            this.btnDoktorgrs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoktorgrs.Location = new System.Drawing.Point(10, 21);
            this.btnDoktorgrs.Name = "btnDoktorgrs";
            this.btnDoktorgrs.Size = new System.Drawing.Size(162, 180);
            this.btnDoktorgrs.TabIndex = 0;
            this.btnDoktorgrs.UseVisualStyleBackColor = true;
            this.btnDoktorgrs.Click += new System.EventHandler(this.btnDoktorgrs_Click);
            // 
            // btnSekretergrs
            // 
            this.btnSekretergrs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSekretergrs.BackgroundImage")));
            this.btnSekretergrs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSekretergrs.Location = new System.Drawing.Point(15, 18);
            this.btnSekretergrs.Name = "btnSekretergrs";
            this.btnSekretergrs.Size = new System.Drawing.Size(191, 180);
            this.btnSekretergrs.TabIndex = 1;
            this.btnSekretergrs.UseVisualStyleBackColor = true;
            this.btnSekretergrs.Click += new System.EventHandler(this.btnSekretergrs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(303, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Doktor ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(618, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDoktorgrs);
            this.groupBox1.Location = new System.Drawing.Point(238, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 221);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSekretergrs);
            this.groupBox3.Location = new System.Drawing.Point(538, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 221);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(478, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 49);
            this.label4.TabIndex = 10;
            this.label4.Text = "LİFES HOSPİTAL";
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(849, 465);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmGirisler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoktorgrs;
        private System.Windows.Forms.Button btnSekretergrs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
    }
}

