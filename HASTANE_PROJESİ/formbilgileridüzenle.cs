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

namespace HASTANE_PROJESİ
{
    public partial class formbilgileridüzenle : Form
    {
        public formbilgileridüzenle()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        public string tcno;
        private void formbilgileridüzenle_Load(object sender, EventArgs e)
        {
            maskedtc.Text = tcno;
            SqlCommand komut = new SqlCommand("select * from tablo_hastalar where hastatc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedtc.Text);
            SqlDataReader dt = komut.ExecuteReader();
            while (dt.Read())
            {
                textad.Text = dt[1].ToString();
                textsoyad.Text = dt[2].ToString();
                maskedcepno.Text = dt[4].ToString();
                textsifre.Text = dt[5].ToString();
                combocinsiyet.Text = dt[6].ToString();
                
            }
            bgl.baglanti().Close();
        }
        
        private void butongüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tablo_hastalar set hastaad=@p1,hastasoyad=@p2,hastatelefon=@p3,hastasifre=@p4,hastacinsiyet=@p5 where hastatc=@p6", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textad.Text);
            komut.Parameters.AddWithValue("@p2", textsoyad.Text);
            komut.Parameters.AddWithValue("@p3", maskedcepno.Text);
            komut.Parameters.AddWithValue("@p4", textsifre.Text);
            komut.Parameters.AddWithValue("@p5", combocinsiyet.Text);
            komut.Parameters.AddWithValue("@p6",maskedtc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("GÜNCELLEME BAŞARIYLA TAMAMLANDI", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
