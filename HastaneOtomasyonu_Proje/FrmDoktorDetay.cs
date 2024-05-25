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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TC;
       
        private void btnCıkıs_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
           // richTextBox1.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();

        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void btnBilgiDüzenle_Click_1(object sender, EventArgs e)
        {

            FrmDoktorBilgiDüzenle fr = new FrmDoktorBilgiDüzenle();
            fr.TCNO = lblTCNo.Text;
            fr.Show();
        }

        private void FrmDoktorDetay_Load_1(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);

            lblTCNo.Text = TC;

            //Doktor ad soyad çekme
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorTC=@p1 ", baglanti);
            baglanti.Open();
            komut.Parameters.AddWithValue("@p1", lblTCNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];


            }
            baglanti.Close();

            //Randevular

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select  * From Tbl_Randevular where RandevuDoktor='" + lblAdSoyad.Text + "'", baglanti);
            baglanti.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            FrmGirisler fr = new FrmGirisler();
            fr.Show();
            this.Hide();
        }

        private void grpRandevulistesi_Enter(object sender, EventArgs e)
        {

        }
    }
}
