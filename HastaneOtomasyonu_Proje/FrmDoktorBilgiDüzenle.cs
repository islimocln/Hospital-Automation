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

namespace HastaneOtomasyonu_Proje
{
    public partial class FrmDoktorBilgiDüzenle : Form
    {
        public FrmDoktorBilgiDüzenle()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TCNO;

        private void FrmDoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            mskTxtBoxTCkimlik.Text = TCNO;

            SqlCommand komut=new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@p1",baglanti);
            baglanti.Open();
            komut.Parameters.AddWithValue("@p1", mskTxtBoxTCkimlik.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtBoxAd.Text = dr[1].ToString();
                txtBoxSoyad.Text = dr[2].ToString();
                cmbBrans.Text = dr[3].ToString();
                txtBoxSifre.Text = dr[5].ToString();
            }
            baglanti.Close();

        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5", baglanti);
            baglanti.Open();
            komut.Parameters.AddWithValue("@p1", txtBoxAd.Text);
            komut.Parameters.AddWithValue("@p2", txtBoxSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@p4", txtBoxSifre.Text);
            komut.Parameters.AddWithValue("@p5", mskTxtBoxTCkimlik.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi.");
        }
    }
}
