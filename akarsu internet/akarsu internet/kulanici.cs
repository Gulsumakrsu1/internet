using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace akarsu_internet
{

    class kulanici
    {
        public static int kulaniciid = 0;
        public static bool durum = false;
        public static SqlDataReader kullanicigirişi(TextBox kullaniciadi, TextBox sifre)
        {
            veritabani.baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from TBLKULLANICILAR where kullaniciadi='" + kullaniciadi.Text+"' and sifre ='"+sifre.Text+"'" ,veritabani.baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                durum = true;
                kulaniciid = int.Parse(dr["kullaniciid"].ToString());
            }
            else
            {
                durum = false;
            }
            veritabani.baglanti.Close();
            return dr;
        }

    }
}
