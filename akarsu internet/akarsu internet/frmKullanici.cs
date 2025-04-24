using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace akarsu_internet
{
    public partial class frmKullanici: Form
    {
        public frmKullanici()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kulanici.kullanicigirişi(textBox1,textBox2);
            if (kulanici.durum == true)
            {
                frmsatıs frm = new frmsatıs();
                frm.Show();
                this.Hide();

            }
            else if (kulanici.durum==false)
            {
                MessageBox.Show("kulaniciadi ve şifrenizi kontrol ediniz.!", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void frmKullanici_Load(object sender, EventArgs e)
        {

        }
    }
}
