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

namespace BankaOtomasyonu
{
    public partial class MusteriAra : Form
    {
        public MusteriAra()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server = DESKTOP-LERKFDE; initial catalog = Bankamatik; integrated security = sspi; ");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Musteriler Where ID = @a1 or TcNo = @a2", con);
            cmd.Parameters.AddWithValue("@a1", txtAra.Text);
            cmd.Parameters.AddWithValue("@a2", txtAra.Text);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtID.Text = dr["ID"].ToString();
                txtTcNo.Text = dr["TcNo"].ToString();
                txtAdSoyad.Text = dr["AdSoyad"].ToString();
                txtAdres.Text = dr["Adres"].ToString();
                txtTel.Text = dr["Telefon"].ToString();
                txtBakiye.Text = dr["Bakiye"].ToString();
            }
            else
            {
                MessageBox.Show("Numaralı Kayıt Bulunamadı!","Kayıt Arama",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtID.Text = "";
                txtTcNo.Text = "";
                txtAdSoyad.Text = "";
                txtAdres.Text = "";
                txtTel.Text = "";
                txtBakiye.Text = "";
                txtID.Text = "";
            }
            con.Close();
        }
    }
}
