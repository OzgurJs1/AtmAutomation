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
    public partial class ParaCek : Form
    {
        public ParaCek()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server = DESKTOP-LERKFDE; initial catalog = Bankamatik; integrated security = sspi; ");
        private void button1_Click(object sender, EventArgs e)
        {

            float sayi = float.Parse(maskedTextBox1.Text);
            if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("Tüm Alanı Eksiksiz Giriniz ", "Para Çekme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (sayi > Form1.mBakiye)
            {
                MessageBox.Show("Yetersiz Bakiye", "Para Çekme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("update Musteriler set bakiye = bakiye - @p1 where ID = @p2",con);
                cmd.Parameters.AddWithValue("@p1", sayi);
                cmd.Parameters.AddWithValue("@p2", Form1.mID);
                if (sayi < 10)
                {
                    MessageBox.Show("Lütfen 10 tl üzeri giriniz!", "Eksik Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                }
                else
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Para çekme işlemi gerçekleştirildi!", "Para çekme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1.mBakiye -= sayi;
                    HareketKaydet.Kaydet(Form1.mID, (sayi + "TL Para Çekildi"));

                    DialogResult dr = MessageBox.Show("Başka Bir işlem yapmak ister misiniz?", "Bilgi",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr==DialogResult.Yes)
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
                
            }
            
        }
    }
}
