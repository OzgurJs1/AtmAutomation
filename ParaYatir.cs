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
    public partial class ParaYatir : Form
    {
        public ParaYatir()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server = DESKTOP-LERKFDE; initial catalog = Bankamatik; integrated security = sspi; ");
        private void button1_Click(object sender, EventArgs e)
        {
            float sayi = float.Parse(maskedTextBox1.Text);
            SqlCommand cmd = new SqlCommand("update Musteriler set Bakiye = Bakiye + @p1 where ID = @p2",con);
            cmd.Parameters.AddWithValue("@p1",sayi);
            cmd.Parameters.AddWithValue("@p2", Form1.mID);
            if (sayi<10)
            {
                MessageBox.Show("Lütfen 10 TL üzeri giriniz!", "Eksik Kayıt Hatası ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.Open();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Para Yatırma İşlemi gerçekleştirildi! ", "Para Yatırma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1.mBakiye += sayi;
                HareketKaydet.Kaydet(Form1.mID, (" TL Para Yatırıldı!"));
                DialogResult dr = MessageBox.Show("Başka Bir İşlem Yapmak İster Misiniz?","Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        }
    }
}
