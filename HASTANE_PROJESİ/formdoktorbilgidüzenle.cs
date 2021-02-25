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
    public partial class formdoktorbilgidüzenle : Form
    {
        public formdoktorbilgidüzenle()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        public string TCNO;
        private void formdoktorbilgidüzenle_Load(object sender, EventArgs e)
        {
            maskedtc.Text = TCNO;

            //

            SqlCommand komut1 = new SqlCommand("select * from tablo_doktorlar where doktortc=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", maskedtc.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                textad.Text= dr[1].ToString();
                textsoyad.Text = dr[2].ToString();
                combobrans.Text= dr[3].ToString();
                textsifre.Text = dr[5].ToString();


            }
            bgl.baglanti().ToString();
        }
        private void butongüncelle_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tablo_doktorlar set doktorad=@p1,doktorsoyad=@p2,doktorbrans=@p3,doktorsifre=@p4 where doktortc=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textad.Text);
            komut.Parameters.AddWithValue("@p2", textsoyad.Text);
            komut.Parameters.AddWithValue("@p3", combobrans.Text); ;
            komut.Parameters.AddWithValue("@p4", textsifre.Text);
            komut.Parameters.AddWithValue("@p5", maskedtc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("güncelleme başarıyla tamamlandı");
        }
    }
}
