using akarsu_internet.__DataSetTableAdapters;
using DevExpress.ClipboardSource.SpreadsheetML;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace akarsu_internet
{
    class veritabani
    {
       public static SqlConnection baglanti = new SqlConnection("server =.;Database=internetCafe;Integrated Security = True; Connect Timeout = 30");
    public static DataTable sepetlistele(DataGridView dataGridView)
       
       
        {
            SqlDataAdapter ADTR = new SqlDataAdapter("select * from TBLSEPET", baglanti);
            DataTable tbl = new DataTable();
            ADTR.Fill(tbl);
            dataGridView.DataSource = tbl;
            return tbl;
        }

        public static DataTable listele(DataGridView gridView,string sorgu)
        {
            SqlDataAdapter adtr = new SqlDataAdapter(sorgu, baglanti);
            DataTable tbl = new DataTable();
            adtr.Fill(tbl);
            gridView.DataSource = tbl;
            return tbl;






        }
        public static DataTable Comboyabosmasalar(ComboBox combo)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Tblmasalar", baglanti);
            DataTable tbl = new DataTable();
            adtr.Fill(tbl);
            combo.DataSource = tbl;
            combo.DisplayMember = "Masalar";
            combo.ValueMember = "Masaid";
            baglanti.Close();
            return tbl;
        }
        public static void esg(SqlCommand command, string sorgu)
        {
            baglanti.Open();
            command.Connection = baglanti;
            command.CommandText = sorgu;
            command.ExecuteNonQuery();
            baglanti.Close();




        }

      public static SqlDataReader listviewKayitlarıgoster(ListView list)
        {
            list.Items.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from Tblhareketler where tarih>=@tarih", baglanti);
            cmd.Parameters.AddWithValue("@tarih", DateTime.Parse(DateTime.Now.ToShortDateString()));
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr[0].ToString();
                ekle.SubItems.Add(dr[1].ToString());
                ekle.SubItems.Add(dr[2].ToString());
                ekle.SubItems.Add(dr[3].ToString());
                ekle.SubItems.Add(dr[4].ToString());
                ekle.SubItems.Add(dr[5].ToString());
                ekle.SubItems.Add(dr[6].ToString());




            }
            baglanti.Close();
            return dr;
        

       }


    }
    }


                     
        
        













