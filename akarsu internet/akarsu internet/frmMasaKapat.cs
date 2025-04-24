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
    public partial class frmMasaKapat: Form
    {
        public frmMasaKapat()
        {
            InitializeComponent();
        }

        private void btnmasaac_Click(object sender, EventArgs e)
        {
            string sqlsorgu = "";
            SqlCommand komut = new SqlCommand("update Tblmasalar set durumu='bos'where masaıd='" + txtmasaıd.Text + "'");

            veritabani.esg(komut, sqlsorgu);
            string sqlsorgu2 = "dalete from Tblsepetıd='" + txtıd.Text + "'";
            SqlCommand komut2 = new SqlCommand();
            veritabani.esg(komut2, sqlsorgu);
            this.Close();
            frmsatıs frm = (frmsatıs)Application.OpenForms["frmsatıs"];
            frm.Yenile();

        }

        private void masaiptal_Click(object sender, EventArgs e)
        {
          
            this.Close();

        }
    }
}
