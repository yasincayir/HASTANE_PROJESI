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
    public partial class formhastakayıt : Form
    {
        public formhastakayıt()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void butonkayıtyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tablo_Hastalar (hastaad,hastasoyad,hastatc,hastatelefon,hastacinsiyet,hastasifre) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textad.Text);
            komut.Parameters.AddWithValue("@p2", textsoyad.Text);
            komut.Parameters.AddWithValue("@p3",maskedtc.Text );
            komut.Parameters.AddWithValue("@p4",maskedcepno.Text );
            komut.Parameters.AddWithValue("@p5", combocinsiyet.Text);
            komut.Parameters.AddWithValue("@p6", textsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("KAYIT BAŞARIYLA YAPILDI...");
        }
    }
}
