using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HASTANE_PROJESİ
{
    public partial class formgirisler : Form
    {
        public formgirisler()
        {
            InitializeComponent();
        }

        private void butonhastagiris_Click(object sender, EventArgs e)
        {
            formhastagiris frm = new formhastagiris();
            frm.Show();
            this.Hide();
        }

        private void butondoktorgiris_Click(object sender, EventArgs e)
        {
            formdoktorgiris frm = new formdoktorgiris();
            frm.Show();
            this.Hide();
        }

        private void butonsekretergiris_Click(object sender, EventArgs e)
        {
            formsekretergiris frm = new formsekretergiris();
            frm.Show();
            this.Hide();
        }
    }
}
