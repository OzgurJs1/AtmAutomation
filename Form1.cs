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
using System.Security.Cryptography.X509Certificates;

namespace BankaOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server = DESKTOP-LERKFDE ; initial catalog = Bankamatik; integrated security = sspi; ");
        public static string AdSoyad = "";
        public static int mID=0;
        public static float mBakiye=0.0f;
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kAdi = textBox1.Text;
            string password = textBox2.Text;
            bool sonuc = false;
            
            
            if (radioButton1.Checked)
            {
                if (kAdi=="admin" && password=="123")
                {
                    Yetkiliİslem yi = new Yetkiliİslem();
                    yi.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı/TC veya parola!, Hatalı Giriş Denemesi!");
                }
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Musteriler where TcNo = @p1 and Sifre = @p2", con);
                cmd.Parameters.AddWithValue("@p1", kAdi);
                cmd.Parameters.AddWithValue("@p2", password);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    AdSoyad = dr["AdSoyad"].ToString();
                    mID = int.Parse(dr["ID"].ToString());
                    mBakiye = float.Parse(dr["Bakiye"].ToString());
                    sonuc = true;
                }
                
                con.Close();

                if (sonuc)
                {
                    sonuc = false; 
                    Musteriİslem mi = new Musteriİslem();
                    mi.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı/TC veya parola!, Hatalı Giriş Denemesi!");
                }
                textBox1.Text = "";
                textBox2.Text = "";
            }
         
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum su = new SifremiUnuttum();
            su.Show();
        }
    }
}
