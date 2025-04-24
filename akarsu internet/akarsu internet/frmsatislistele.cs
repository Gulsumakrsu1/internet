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

namespace akarsu_internet
{
    public partial class frmsatislistele: Form
    {
        public frmsatislistele()
        {
            InitializeComponent();
        }

        private void frmsatislistele_Load(object sender, EventArgs e)
        {
            veritabani.listele(dataGridView1, "select * frm Tblsatis");

        }

        private void btngerial_Click(object sender, EventArgs e)
        {
            int masaıd = int.Parse(dataGridView1.CurrentRow.Cells["masaıd"].Value.ToString());
            int kulaniciıd = int.Parse(dataGridView1.CurrentRow.Cells["kulaniciıd"].Value.ToString());
            string masa = "masa-" + masaıd;
            string acilisturu = dataGridView1.CurrentRow.Cells["acilisturu"].Value.ToString();
            DateTime baslangic = DateTime.Parse(dataGridView1.CurrentRow.Cells["baslangic"].Value.ToString());
            DateTime tarih = DateTime.Parse(dataGridView1.CurrentRow.Cells["tarih"].Value.ToString());
            string sql="insert into tblsepet(masaıd,masa,acilisturu,baslangic,tarih) values " +" '"+masaıd+"',"'+masa+'","'+acilisturu+'",@baslangic,@tarih";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@baslangic", baslangic);
            cmd.Parameters.AddWithValue("@tarih", tarih);
            veritabani.esg(cmd, sql);
            //////////////////
            string sql2 = "dalete from tblsatis where satisıd='" + int.Parse(dataGridView1.CurrentRow.Cells["satisıd"].Value.ToString());
            SqlCommand cmd2 = new SqlCommand();
            veritabani.esg(cmd2, sql2);






            this.Close();
            frmsatıs frm = (frmsatıs)Application.OpenForms["frmsatis"];
            frm.Yenile();
        }
    }
}
