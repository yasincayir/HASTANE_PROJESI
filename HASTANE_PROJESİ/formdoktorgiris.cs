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
    public partial class formdoktorgiris : Form
    {
        public formdoktorgiris()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void butongirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select *from tablo_doktorlar where doktortc=@p1 and doktorsifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedtcno.Text);
            komut.Parameters.AddWithValue("@p2", textsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                formdoktordetay frm = new formdoktordetay();
                frm.tcno = maskedtcno.Text;
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
