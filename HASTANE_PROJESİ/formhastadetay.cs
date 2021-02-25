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
    public partial class formhastadetay : Form
    {
        public formhastadetay()
        {
            InitializeComponent();
        }
        public string tc;
        sqlbaglanti bgl = new sqlbaglanti();
        private void formhastadetay_Load(object sender, EventArgs e)
        {
            labeltc.Text = tc;
            SqlCommand komut = new SqlCommand("select hastaad,hastasoyad from tablo_hastalar where hastatc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", labeltc.Text);
            SqlDataReader rd = komut.ExecuteReader();
            while (rd.Read())
            {
                labeladsoyad.Text = rd[0] + " " + rd[1];
            }
            bgl.baglanti().Close();

            //
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tablo_randevular where hastatc=" + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //
            SqlCommand komut2 = new SqlCommand("select * from tablo_branslar",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                combobrans.Items.Add(dr2[1]);
            }
            bgl.baglanti().Close();
        }

        private void combobrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            combodoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select doktorad,doktorsoyad from tablo_doktorlar where doktorbrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1",combobrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                combodoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void combodoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tablo_randevular where randevubrans= '" + combobrans.Text + "'"+" and randevudoktor='"+combodoktor.Text+"'and randevudurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void linkbilgilerinidüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formbilgileridüzenle frm = new formbilgileridüzenle();
            frm.tcno = labeltc.Text;
            frm.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            textid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void butonrandevual_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tablo_randevular set randevudurum=1,hastatc=@p1,hastasikayet=@p2 where randevuid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", labeltc.Text);
            komut.Parameters.AddWithValue("@p2", richsikayet.Text);
            komut.Parameters.AddWithValue("@p3", textid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("randevunuz alındı");
        }
    }
}
