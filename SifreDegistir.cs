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
    public partial class SifreDegistir : Form
    {
        public SifreDegistir()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server = DESKTOP-LERKFDE; initial catalog = Bankamatik; integrated security = sspi; ");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Musteriler set sifre = @p1 where ID = @p2 and Sifre = @p3",con);
            cmd.Parameters.AddWithValue("@p1", txtYsifre.Text);
            cmd.Parameters.AddWithValue("@p3", txtEsifre.Text);
            cmd.Parameters.AddWithValue("@p2", Form1.mID.ToString());
            if (txtYsifre.Text.Length < 5)
            {
                MessageBox.Show("Lütfen Yeni Şifreniz 5 Karakter Uzunluğunda Olsun! ", "Şifre Değiştirme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.Open();
                int s1 = cmd.ExecuteNonQuery();
                con.Close();
                if (s1 == 1)
                {
                    MessageBox.Show("Şifre Değiştirme İşlemi Başarılı! ", "Şifre Değiştirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult dr = MessageBox.Show("Başka Bir İşlem Yapmak İster Misiniz?","Bilgi", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes) 
                    {
                        Musteriİslem mi = new Musteriİslem();
                        mi.Show();
                        this.Hide();
                    }
                    else
                    {
                        Form1 frm = new Form1();
                        frm.Show();
                        this.Hide();
                    }
                }
                
                else
                {
                    MessageBox.Show("Eski Şifreniz Uyuşmadı! ", "Şifre Değiştirme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
