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
    public partial class Yetkiliİslem : Form
    {
        public Yetkiliİslem()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle me = new MusteriEkle();
            me.Show();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            MusteriAra ma = new MusteriAra();
            ma.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            MusteriGuncelle mg = new MusteriGuncelle();
            mg.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            MusteriSil ms = new MusteriSil();
            ms.Show();

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            MusteriListele ml = new MusteriListele();
            ml.Show();
        }
    }
}
