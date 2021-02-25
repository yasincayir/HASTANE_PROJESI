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
    public partial class formsekretedetay : Form
    {
        public formsekretedetay()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl= new sqlbaglanti();
        public string tcno;
        private void formsekretedetay_Load(object sender, EventArgs e)
        {
            labeltcno.Text = tcno;

            //

            //
            SqlCommand komut2 = new SqlCommand("select sekreteradsoyad from tablo_sekreterler where sekretertc=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1",tcno);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                labeladsoyad.Text = dr2[0].ToString();
            }
            bgl.baglanti().Close();

            //

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from tablo_branslar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select doktorad,doktorsoyad from tablo_doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //
            SqlCommand komutbrans = new SqlCommand("select bransad from tablo_branslar", bgl.baglanti());
            SqlDataReader drbrans = komutbrans.ExecuteReader();
            while (drbrans.Read())
            {
                combobrans.Items.Add(drbrans[0]);
            }
            bgl.baglanti().Close();



        }

        private void butonrandevukaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into tablo_randevular (randevutarih,randevusaat,randevubrans,randevudoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", maskedtarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2",maskedsaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", combobrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", combodoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("randevu oluşturuldu");
        }

        private void combobrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            combodoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("select doktorad,doktorsoyad from tablo_doktorlar where doktorbrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", combobrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                combodoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void butonduyuruolustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tablo_duyurular (duyuru) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", richduyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("duyuru oluşturuldu");
        }

        private void butondoktorpanel_Click(object sender, EventArgs e)
        {
            formdoktorpanel frm = new formdoktorpanel();
            frm.Show();
        }

        private void butonbranspanel_Click(object sender, EventArgs e)
        {
            formbranspanel frm = new formbranspanel();
            frm.Show();
            this.Hide();
        }

        private void butonrandevuliste_Click(object sender, EventArgs e)
        {
            formrandevulistesi frm = new formrandevulistesi();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formduyurular frm = new formduyurular();
            frm.Show();

        }
    }
}
