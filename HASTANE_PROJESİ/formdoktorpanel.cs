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
    public partial class formdoktorpanel : Form
    {
        public formdoktorpanel()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void formdoktorpanel_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from tablo_doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //
            SqlCommand komutbrans = new SqlCommand("select bransad from tablo_branslar", bgl.baglanti());
            SqlDataReader drbrans = komutbrans.ExecuteReader();
            while (drbrans.Read())
            {
                combobrans.Items.Add(drbrans[0]);
            }
            bgl.baglanti().Close();
        }

        private void butonekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tablo_doktorlar (doktorad,doktorsoyad,doktorbrans,doktortc,doktorsifre) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", textad.Text);
            komut.Parameters.AddWithValue("@d2", textsoyad.Text);
            komut.Parameters.AddWithValue("@d3", combobrans.Text);
            komut.Parameters.AddWithValue("@d4", maskedtc.Text);
            komut.Parameters.AddWithValue("@d5", textsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("ekleme başarıyla tamamlandı");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            combobrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedtc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textsifre.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void butonsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tablo_doktorlar where doktortc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedtc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("silindi");
        }

        private void butongüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tablo_doktorlar set doktorad=@d1,doktorsoyad=@d2,doktorbrans=@d3,doktorsifre=@d5 where doktortc=@d4", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", textad.Text);
            komut.Parameters.AddWithValue("@d2", textsoyad.Text);
            komut.Parameters.AddWithValue("@d3", combobrans.Text);
            komut.Parameters.AddWithValue("@d4", maskedtc.Text);
            komut.Parameters.AddWithValue("@d5", textsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("güncelleme işlemi başarıyla tamamlandı");
        }
    }
}
