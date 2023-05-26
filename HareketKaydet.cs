using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu
{
    internal class HareketKaydet
    {
        public static void Kaydet(int mID, string islem)
        {
            SqlConnection con = new SqlConnection("server = DESKTOP-LERKFDE; initial catalog = Bankamatik; integrated security = sspi; ");
            SqlCommand cmd = new SqlCommand("insert into Hareketler (musteriID,islem,tarih) values(@p1, @p2, @p3)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@p1", mID);
            cmd.Parameters.AddWithValue("@p2", islem);
            cmd.Parameters.AddWithValue("@p3", DateTime.Now);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
