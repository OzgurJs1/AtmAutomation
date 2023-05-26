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
    public partial class MusteriSil : Form
    {
        public MusteriSil()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server = DESKTOP-LERKFDE; initial catalog = Bankamatik; integrated security = sspi; ");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From Musteriler Where ID = @p1 or TcNo = @p2", con);
            cmd.Parameters.AddWithValue("@p1",mtxtID.Text);
            cmd.Parameters.AddWithValue("@p2", txtTc.Text);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtID.Text = dr["ID"].ToString();
                txtTc.Text = dr["TcNo"].ToString();
                txtAdS.Text = dr["AdSoyad"].ToString();
                txtAdr.Text = dr["Adres"].ToString();
                mtxtTel.Text = dr["Telefon"].ToString();
                txtDurum.Text = dr["Durum"].ToString();
                txtBakiye.Text = dr["Bakiye"].ToString();
            }
            else
            {
                MessageBox.Show(mtxtID.Text + " Numaralı Kayıt Bulunamadı !", "Kayıt Arama", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtID.Text = "";
                txtTc.Text = "";
                txtAdr.Text = "";
                txtAdS.Text = "";
                txtBakiye.Text = "";
                mtxtTel.Text = "";
                txtID.Text = "";
                txtDurum.Text = "";
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete Musteriler where ID = @p1",con);
            cmd.Parameters.AddWithValue("@p1", txtID.Text);
            if (mtxtID.Text == "")
            {
                MessageBox.Show("Lütfen Silmek İstediginiz Kişinin Numarası / TcNo giriniz !", "Eksik Kayıt Hatası ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Müşteri Kaydını silmek istediğinize emin misiniz? ", "Kayıt Silme Ekranı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.No)
                {
                    MessageBox.Show("Silme İşlemi İptal Edildi!", "Kayıt Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    con.Open();
                    int sonuc = cmd.ExecuteNonQuery();
                    con.Close();
                    if (sonuc == 1)
                    {
                        MessageBox.Show("Müşteri kaydı silindi ", "Müşteri Kaydı Silme ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Müşteri kaydı daha öncesinden silinmiş veya pasif edilmiş durum olduğu için tekrar işlem yapılamadı ", "Müşteri Kaydı Silme ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
