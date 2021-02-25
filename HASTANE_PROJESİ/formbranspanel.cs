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
    public partial class formbranspanel : Form
    {
        public formbranspanel()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl =new sqlbaglanti();
        private void formbranspanel_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tablo_branslar",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void butonekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tablo_branslar (bransad) values (@p1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textbransad.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("ekleme tamamlandı");
        }

        private void butonsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tablo_branslar where bransid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textbransid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("başarıyla silindi...");
        }

        private void butongüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tablo_branslar set bransad=@p1 where bransid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",textbransad.Text);
            komut.Parameters.AddWithValue("@p2", textbransid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("güncelleme başarıyla gerçekleşti");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textbransid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textbransad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

        }
    }
}
