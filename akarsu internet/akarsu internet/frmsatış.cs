using DevExpress.ClipboardSource.SpreadsheetML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace akarsu_internet
{
    public partial class frmsatıs : Form
    {
       
       // SqlConnection baglanti = new SqlConnection("Data Source =.\\ MSSQLLocalDB; AttachDbFilename=C:Users ADMIN Documents\akarsu;Integrated Security = True; Connect Timeout = 30");
        public frmsatıs()
        {
            InitializeComponent();
        }
        Button btn;
        private void frmsatış_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '___DataSet.Tblsaatucreti' table. You can move, or remove it, as needed.
            this.tblsaatucretiTableAdapter.Fill(this.___DataSet.Tblsaatucreti);

            radioButtonsuresiz.Checked = true;
            Yenile();
            comboBosmasalar.Text = "";
            timer1.Start();




        }





        public void Yenile() 
        {

            veritabani.sepetlistele(dataGridView1);
            veritabani.listviewKayitlarıgoster(masaac);


            foreach (Control item in Controls) ;


                }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void secilenegore(object sender, MouseEventArgs e)
        {
        btn = sender as Button;
            if (btn.BackColor == Color.OrangeRed)
            {
                süreliMasaAçmaİsteğiGönderToolStripMenuItem.Visible = false;
                süresizMasaAçmaİsteğiGönderToolStripMenuItem.Visible = false;
            }
            if (btn.BackColor == Color.LawnGreen)
            {
                süreliMasaAçmaİsteğiGönderToolStripMenuItem.Visible = true;
                süresizMasaAçmaİsteğiGönderToolStripMenuItem.Visible = true;
            }
           
        }
        RadioButton radio;

        private void raddiobuttonseciliyegore(object sender, EventArgs e)
        {
            radio = sender as RadioButton;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnmasaac_Click(object sender, EventArgs e)
        {
            if (kulanici.kulaniciid==1)
            {



                string sqlsorgu = "insert into Tblsepet(masaid,masa,acilisturu,baslangic,tarih) values('" + comboBosmasalar.Text.Substring(5) + "', '" + combomasaucreti.Text + "' , '" + radio.Text + "', @baslangıc,@tarih)";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.AddWithValue("@baslangic", DateTime.Parse(DateTime.Now.ToString()));
                komut.Parameters.AddWithValue("@tarih", DateTime.Parse(DateTime.Now.ToString()));
                veritabani.esg(komut, sqlsorgu);
                MessageBox.Show(comboBosmasalar.Text.Substring(5) + "nolu masa açıldı.", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Yenile();
                radioButtonsuresiz.Checked = true;
              
            }
            else
            {
                MessageBox.Show("böyle bi yetkiniz bulunmuyo.!", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }








        }

        private void frmsatış_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataGridView1.Columns["hesapla"].Index)
            {
                if (combomasaucreti.Text !="")
                {

                    DateTime bitstarihi = DateTime.Now;
                    DateTime baslama = DateTime.Parse(dataGridView1.CurrentRow.Cells["baslamasatti"].Value.ToString());
                    TimeSpan saatfarkı = bitstarihi - baslama;
                    double saatfarki2 = saatfarkı.TotalHours;
                    dataGridView1.CurrentRow.Cells["sure"].Value = saatfarki2.ToString("0.00");
                    double toplamtutar = saatfarki2 * double.Parse(combomasaucreti.Text);
                    dataGridView1.CurrentRow.Cells["tutar"].Value = toplamtutar.ToString("0.00");
                    dataGridView1.CurrentRow.Cells["tutar"].Value = bitstarihi;
                }
                if (combomasaucreti.Text=="")
                {
                    MessageBox.Show("önce saat ücreti belirtilmelidir.!", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            if (e.ColumnIndex == dataGridView1.Columns["masa kapat"].Index)
           
                if (dataGridView1.CurrentRow.Cells["bittissaati"].Value!= null)
                {
                    frmMasaKapat frm = new frmMasaKapat();
                    frm.txtıd.Text = dataGridView1.CurrentRow.Cells["ıd"].Value.ToString();
                    frm.txtmasaıd.Text = dataGridView1.CurrentRow.Cells["masaıd"].Value.ToString();
                    frm.txtmasa.Text = dataGridView1.CurrentRow.Cells["masa"].Value.ToString();
                    frm.txtacılıs.Text = dataGridView1.CurrentRow.Cells["acılıs"].Value.ToString();
                    frm.txtbaslama.Text = dataGridView1.CurrentRow.Cells["baslama"].Value.ToString();
                    frm.txtbittis.Text = dataGridView1.CurrentRow.Cells["bittis"].Value.ToString();
                    frm.txtsaat.Text = dataGridView1.CurrentRow.Cells["saat"].Value.ToString();
                    frm.txtsure.Text = dataGridView1.CurrentRow.Cells["sure"].Value.ToString();
                    frm.txtsaat.Text = dataGridView1.CurrentRow.Cells["saat"].Value.ToString();
                    frm.txttarih.Text = dataGridView1.CurrentRow.Cells["tarih"].Value.ToString(); 
                }
            if (dataGridView1.CurrentRow.Cells["bittissaati"].Value == null) 
            {
                MessageBox.Show("önce hesaplama yapılmalıdır.!", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


          


       

          
           
        }
        string istek = "";


        private void yöneticiÇağırToolStripMenuItem_Click(object sender, EventArgs e)

        {
            istek = "yönetici çağırıyor.";
            Istekler();
        }

        private void Istekler()
        {
            string sqlsorgu = "insert into Tblhareketler(kulanıcııd,masaıd,masa,istekturu,acıklama,tarih)values(" +
               "'" + kulanici.kulaniciid + "', '" + btn.Text.Substring(5) + "','" + btn.Text + "','yapılmadı','" + DateTime.Now + "')";
            SqlCommand komut = new SqlCommand();
            veritabani.esg(komut, sqlsorgu);
            veritabani.listviewKayitlarıgoster(masaac);
        }

        private void süresizMasaAçmaİsteğiGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            istek = "süresiz masa açma isteği gönderildi.";
            Istekler();

        }

        private void masaDeğişmeİsteğiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            istek = "masa değiştirme isteği gönderildi.";
            Istekler();
        }
        ToolStripMenuItem item;




        private void sureliisteksecilirse(object sender, EventArgs e)
        {
            item = new ToolStripMenuItem();
            istek = item.Text + "dk süre ile masa açma isteği gönderildi.";
            Istekler();
        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac > 29)
            {
                if (combomasaucreti.Text != "")
                {

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        DateTime bitstarihi = DateTime.Now;
                        DateTime baslama = DateTime.Parse(dataGridView1.Rows[i].Cells["baslamasatti"].Value.ToString());
                        TimeSpan saatfarkı = bitstarihi - baslama;
                        double saatfarki2 = saatfarkı.TotalHours;
                        dataGridView1.Rows[i].Cells["sure"].Value = saatfarki2.ToString("0.00");
                        double toplamtutar = saatfarki2 * double.Parse(combomasaucreti.Text);
                        dataGridView1.Rows[i].Cells["tutar"].Value = toplamtutar.ToString("0.00");
                        dataGridView1.Rows[i].Cells["bittissaati"].Value = bitstarihi; 
                    }
                }
                if (combomasaucreti.Text == "")
                {
                    MessageBox.Show("önce saat ücreti belirtilmelidir.!", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnmasadegiş_Click(object sender, EventArgs e)
        {
            int sepetıd = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            int masaıd= int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
          
            ///////////////////////////////
            string sql2 = "update tlmasalar durumu ='bos' where masaıd='"+masaıd+"'";
            SqlCommand cmd2 = new SqlCommand();
            veritabani.esg(cmd2, sql2);
            /////////////////////////////////
              string sql3 = "update masalar durumu ='dolu' where masaıd ='"+int.Parse(comboBosmasalar.Text.Substring(5))+"'";
            SqlCommand cmd3 = new SqlCommand();
            veritabani.esg(cmd3, sql3);
            Yenile();
            MessageBox.Show("masa değiştirme işlemi başarılı", MessageBoxButtons.OK.ToString());
            ///////////////////////////////
        }

        private void btngerial_Click(object sender, EventArgs e)
        {
            frmsatislistele frm = new frmsatislistele();
            
            frm.Enabled = true;
            frm.ShowDialog();
        }

        private void btnsatis_Click(object sender, EventArgs e)
        {
            frmsatısraporu frm = new frmsatısraporu();
            frm.ShowDialog();

        }

        private void btnhareket_Click(object sender, EventArgs e)
        {
            frmhareketraporu frm = new frmhareketraporu();
            frm.ShowDialog();

        }
    }
    }

