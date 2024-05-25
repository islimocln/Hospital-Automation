using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu_Proje
{
    public partial class FrmBilgiDüzenle : Form
    {
        public FrmBilgiDüzenle()
        {
            InitializeComponent();
        }

        public string TCno;

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmBilgiDüzenle_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            mskTxtBoxTCkimlik.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1",baglanti);
            baglanti.Open();
            komut.Parameters.AddWithValue("@p1", mskTxtBoxTCkimlik.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtBoxAd.Text = dr[1].ToString();
                txtBoxSoyad.Text = dr[2].ToString();
                msktxtBoxTelefon.Text = dr[4].ToString();
                txtBoxSifre.Text = dr[5].ToString();
                cmbBoxCinsiyet.Text = dr[6].ToString();

            }
            baglanti.Close();

        }

        private void buttonKayıtYap_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where  HastaTC=@p6", baglanti);
            baglanti.Open();
            komut2.Parameters.AddWithValue("@p1", txtBoxAd.Text);
            komut2.Parameters.AddWithValue("@p2", txtBoxSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", msktxtBoxTelefon.Text);
            komut2.Parameters.AddWithValue("@p4", txtBoxSifre.Text);
            komut2.Parameters.AddWithValue("@p5", txtBoxSifre.Text);
            komut2.Parameters.AddWithValue("@p6", mskTxtBoxTCkimlik.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }
    }
}
