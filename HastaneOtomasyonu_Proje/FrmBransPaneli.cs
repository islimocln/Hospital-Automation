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
    public partial class FrmBransPaneli : Form
    {
        public FrmBransPaneli()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmBransPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar", bgl.Adres);
            da.Fill(dt);
            dataGridDoktor.DataSource = dt;


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            try
            {

                SqlCommand komut = new SqlCommand("insert into Tbl_Branslar (BransAd)values (@b1)",baglanti);
                baglanti.Open();
                komut.Parameters.AddWithValue("@b1", txtBoxBransAd.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Branş Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridDoktor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridDoktor.SelectedCells[0].RowIndex;
            txtBoxBransİd.Text = dataGridDoktor.Rows[secilen].Cells[0].Value.ToString();
            txtBoxBransAd.Text = dataGridDoktor.Rows[secilen].Cells[1].Value.ToString();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            SqlCommand komut = new SqlCommand("delete From Tbl_Branslar where Bransid=@b1", baglanti);
            baglanti.Open(); 
            komut.Parameters.AddWithValue("@b1",txtBoxBransİd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Branş silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

              
            
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            SqlCommand komut = new SqlCommand("update Tbl_Branslar set BransAd=@p1 where Bransid=@p2", baglanti);
            baglanti.Open(); 
            komut.Parameters.AddWithValue("@p1", txtBoxBransAd.Text);
            komut.Parameters.AddWithValue("@p2", txtBoxBransİd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Branş Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
