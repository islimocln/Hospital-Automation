using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Schema;

namespace HastaneOtomasyonu_Proje
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }


        public string TCnumara;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            lblTc.Text = TCnumara;

            //ad soyad
            SqlCommand komut1 = new SqlCommand("Select  SekreterAdSoyad From tbl_Sekreterler where SekreterTC=@p1", baglanti);
            baglanti.Open();
            komut1.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblAdSoyad.Text = dr1[0].ToString();
            }
            baglanti.Close();


            //branşları datagride aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BransAd From Tbl_Branslar", baglanti);
            baglanti.Open();
            da.Fill(dt1);
            dataGridBranslar.DataSource = dt1;
            baglanti.Close();

            //doktorları listeye aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd +' ' + DoktorSoyad) as 'Doktorlar',DoktorBrans From Tbl_Doktorlar", baglanti);
            baglanti.Open();
            da2.Fill(dt2);
            dataGridDoktorlar.DataSource = dt2;
            baglanti.Close();

            //Branşı combobox a aktarma

            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", baglanti);
            baglanti.Open();
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBoxBrans.Items.Add(dr2[0]);
            }
            baglanti.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection(bgl.Adres);

            // Mevcut tarih ve saat için randevu var mı kontrol et
            SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM Tbl_Randevular WHERE RandevuTarih = @r1 AND RandevuSaat = @r2", baglanti);
            baglanti.Open();
            kontrolKomut.Parameters.AddWithValue("@r1", mskBoxTarih.Text);
            kontrolKomut.Parameters.AddWithValue("@r2", mskBoxSaat.Text);
            int randevuSayisi = (int)kontrolKomut.ExecuteScalar();
            baglanti.Close();

            if (randevuSayisi > 0)
            {
                MessageBox.Show("Bu saatte randevu alınmıştır. Lütfen başka bir saat seçiniz.");
            }
            else
            {
                SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular(RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", baglanti);
                baglanti.Open();
                komutkaydet.Parameters.AddWithValue("@r1", mskBoxTarih.Text);
                komutkaydet.Parameters.AddWithValue("@r2", mskBoxSaat.Text);
                komutkaydet.Parameters.AddWithValue("@r3", cmbBoxBrans.Text);
                komutkaydet.Parameters.AddWithValue("@r4", cmbBoxDoktorlar.Text);
                komutkaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Randevu oluşturuldu.");
            }
        }
    
        private void cmbBoxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            cmbBoxDoktorlar.Items.Clear();


            //doktoradı comboboxa aktarma

            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", baglanti);
            baglanti.Open();
            komut.Parameters.AddWithValue("@p1", cmbBoxBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbBoxDoktorlar.Items.Add(dr[0] + " " + dr[1]);
            }
            baglanti.Close();
        }

        private void btnOluştur_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (duyuru) values(@d1)", baglanti);
            baglanti.Open();
            komut.Parameters.AddWithValue("@d1", rchtextBoxDuyuruOluştur.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Duyuru oluşturuldu.");

        }

        private void btnBransPaneli_Click(object sender, EventArgs e)
        {
            FrmBransPaneli fbr = new FrmBransPaneli();
            fbr.Show();
        }

        private void btnRandevuListele_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frl = new FrmRandevuListesi();
            frl.Show();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void rchtextBoxDuyuruOluştur_TextChanged(object sender, EventArgs e)
        {
            if (progressBarDuyuru.Value == 100)
            {
                MessageBox.Show("100 karakter sınırına ulaştınız");
            }
            else
            {
                progressBarDuyuru.Value = rchtextBoxDuyuruOluştur.Text.Length;
            }
        }

        private void btnCıkısYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            FrmGirisler fr = new FrmGirisler();
            fr.Show();
            this.Hide();
        }

        private void dataGridBranslar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridDoktorlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
