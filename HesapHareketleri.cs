using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyonu
{
    public partial class HesapHareketleri : Form
    {
        public HesapHareketleri()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server = DESKTOP-LERKFDE; initial catalog = Bankamatik; integrated security = sspi; ");
        private void HesapHareketleri_Load(object sender, EventArgs e)
        {
            label2.Text = Form1.AdSoyad;
            label3.Text = Form1.mID.ToString();

            SqlCommand komut = new SqlCommand("select * from Hareketler where musteriID= @p1", con);
            komut.Parameters.AddWithValue("@p1", Form1.mID);
            SqlDataAdapter dr = new SqlDataAdapter(komut);

            DataTable tablo = new DataTable();
            dr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
    }
}
