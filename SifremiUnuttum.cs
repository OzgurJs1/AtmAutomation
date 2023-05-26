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
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server = DESKTOP-LERKFDE; initial catalog = Bankamatik; integrated security = sspi; ");

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Musteriler set Sifre = @n1 where TcNo = @n2 and Telefon = @n3", con);
            cmd.Parameters.AddWithValue("@n1",txtTcNo);
            cmd.Parameters.AddWithValue("@n2", txtTelefon);
            cmd.Parameters.AddWithValue("@n3", txtYsifre);
            if (txtYsifre.Text.Length<5)
            {
                MessageBox.Show("Lütfen yeni şifreniz en az 5 karakter uzunluğunda olsun!", "Şifre Değiştirme Hatası!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.Open();
                int sonuc = cmd.ExecuteNonQuery();
                con.Close();
                if (sonuc == 1) 
                {
                    MessageBox.Show("Yeni Şifreniz Üretilmiştir!", "Şifre üretme işlemi",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("TcNo / Telefon no uyuşmadı !", "Şifre Üretme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
