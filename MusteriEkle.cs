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
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server = DESKTOP-LERKFDE; initial catalog = Bankamatik; integrated security = sspi; ");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Musteriler (TcNo,AdSoyad,Adres,Telefon,Bakiye,Durum) values (@txtTc,@txtAdSoyad,@txtAdres,@txtTel,@txtBakiye,@txtDurum)",con);
            cmd.Parameters.AddWithValue("@txtTc", txtTcNo.Text);
            cmd.Parameters.AddWithValue("@txtAdSoyad", txtAdSoyad.Text);
            cmd.Parameters.AddWithValue("@txtAdres", txtAdres.Text);
            cmd.Parameters.AddWithValue("@txtTel", txtTel.Text);
            cmd.Parameters.AddWithValue("@txtBakiye", txtBakiye.Text);
            cmd.Parameters.AddWithValue("@txtDurum", 1);

            if (txtTcNo.Text=="" || txtAdSoyad.Text== "" ||txtAdres.Text == "" || txtBakiye.Text==""|| txtTel.Text=="" )
            {
                MessageBox.Show("Tüm Alanları Eksiksiz Giriniz! ", "Müşteri Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                con.Open();
                int sonuc = cmd.ExecuteNonQuery();
                con.Close();
                if (sonuc == 1)
                {
                    MessageBox.Show("Yeni Müşteri Kaydı tamam!", "Müşteri Kaydı",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Yeni Kayıt Yapılamadı!", "Müşteri Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                    
            } 
            txtTcNo.Text = "";
            txtAdSoyad.Text = "";
            txtAdres.Text = "";
            txtTel.Text = "";
            txtBakiye.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Yetkiliİslem yi = new Yetkiliİslem();
            yi.Show();
            this.Close();
        }
    }
}
