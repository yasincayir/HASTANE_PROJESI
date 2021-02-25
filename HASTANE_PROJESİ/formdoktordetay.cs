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
    public partial class formdoktordetay : Form
    {
        public formdoktordetay()
        {
            InitializeComponent();
        }
        public string tcno;
        sqlbaglanti bgl = new sqlbaglanti();
        private void formdoktordetay_Load(object sender, EventArgs e)
        {
            labeltcno.Text = tcno;

            //

            SqlCommand komut1 = new SqlCommand("select doktorad,doktorsoyad from tablo_doktorlar where doktortc=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", tcno);
            SqlDataReader dr1 = komut1.ExecuteReader();
            if (dr1.Read())
            {
                labeladsoyad.Text = dr1[0] + " " + dr1[1];
            }
            bgl.baglanti().Close();

            //

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tablo_randevular where randevudoktor='"+labeladsoyad.Text+"'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void butonbilgidüzenle_Click(object sender, EventArgs e)
        {
            formdoktorbilgidüzenle frm = new formdoktorbilgidüzenle();
            frm.TCNO = labeltcno.Text;
            frm.Show();
        }

        private void butonduyurular_Click(object sender, EventArgs e)
        {
            formduyurular frm = new formduyurular();
            frm.Show();
        }

        private void butoncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richrandevudetay.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
