using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyonu
{
    public partial class Musteriİslem : Form
    {
        public Musteriİslem()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void Musteriİslem_Load(object sender, EventArgs e)
        {
            lblAdSoyad.Text = Form1.AdSoyad;
            lblHesapNo.Text = Form1.mID.ToString();
        }

        private void btnBakiyeGoruntule_Click(object sender, EventArgs e)
        {
            Bakiye b = new Bakiye();
            b.Show();
            this.Close();
        }

        private void btnHavale_Click(object sender, EventArgs e)
        {
            Havale h = new Havale();
            h.Show();
            this.Close();
        }

        private void btnHesapH_Click(object sender, EventArgs e)
        {
            HesapHareketleri hh = new HesapHareketleri();
            hh.Show();
            this.Close();
        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            ParaCek pc = new ParaCek();
            pc.Show();
            this.Close();
        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            ParaYatir py = new ParaYatir();
            py.Show();
            this.Close();
        }
    }
}
