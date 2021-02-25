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
    public partial class formhastagiris : Form
    {
        public formhastagiris()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void linküyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formhastakayıt frm = new formhastakayıt();
            frm.Show();
        }

        private void butongirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select *from tablo_hastalar where hastatc=@p1 and hastasifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedtcno.Text);
            komut.Parameters.AddWithValue("@p2", textsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                formhastadetay frm = new formhastadetay();
                frm.tc = maskedtcno.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatalı tc ya da şifre!");
            }
            bgl.baglanti().Close();
        }
    }
}
