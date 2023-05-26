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
    public partial class MusteriGuncelle : Form
    {
        public MusteriGuncelle()
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
                MessageBox.Show(txtID.Text + "Numaralı Kayıt Bulunamadı!", "Kayıt Arama", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Musteriler set AdSoyad = @m1, Adres = @m2, Telefon = @m3 Where ID = @a1 or TcNo = @a2", con);
            cmd.Parameters.AddWithValue("@a1", txtAra.Text);
            cmd.Parameters.AddWithValue("@a2", txtAra.Text);
            cmd.Parameters.AddWithValue("@m1", txtAdSoyad.Text);
            cmd.Parameters.AddWithValue("@m2", txtAdres.Text);
            cmd.Parameters.AddWithValue("@m3", txtTel.Text);

            con.Open();
            int sonuc = cmd.ExecuteNonQuery();
            if (sonuc == 1)
            {
               MessageBox.Show("Güncelleme Yapıldı!", "Güncelleme İşlemi",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Güncelleme Yapılamadı!", "Güncelleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
