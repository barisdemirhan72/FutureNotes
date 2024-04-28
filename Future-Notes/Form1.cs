using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureNotes
{
    public partial class Form1 : Form
    {
        //Notların birbiri ardına görüntülenebilmesi için list string fonksiyonu içerisine bir liste tanımladık.
        List<string> notlar = new List<string>();
        //Sql bağlantısı için sırasıyla conn,command ve dataAdapter fonksiyonlarını tanımladık.
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            /*txtTarih.Text = DateTime.Now.ToShortDateString();
            txtSaat.Text = DateTime.Now.ToShortTimeString(); */
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            dateTimePicker2.Text = DateTime.Now.ToShortTimeString();
            notEkle();
        }

        void notEkle()
        {
            baglanti = new SqlConnection("server=.;Initial Catalog=FutureNotes;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM future_notes", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void lblTarih_Click(object sender, EventArgs e)
        {

        }

        private void lblSaat_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblDateTime.Text = DateTime.Now.ToString();
        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {

        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (txtNotGiris.Text != "")
            {
                notlar.Add(dateTimePicker1.Text + dateTimePicker2.Text + "#" + txtNotGiris.Text);
                timer2.Start();
                MessageBox.Show("Not girildi");
            }
            else
            {
                MessageBox.Show("Tarih ve Saat girilmedi!!!");
                txtNotGiris.Clear();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            foreach (string not in notlar.ToList())
            {
                string BirlesikZaman = DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString();
                string[] words = not.Split('#');

                if (BirlesikZaman == words[0] )
                {
                    lblNotGoruntule.Visible = true;
                    notlar.Remove(not);
                    lblNotGoruntule.Text = words[1];
                    string sorgu = "INSERT INTO future_notes(message,display_date,created_at) VALUES(@message,@display_date,@created_at)";
                    komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@message", txtNotGiris.Text);
                    komut.Parameters.AddWithValue("@display_date", dateTimePicker1.Value);
                    komut.Parameters.AddWithValue("@created_at", dateTimePicker2.Value);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    notEkle(); 

                }
            }
        }

        private void lblNot_Click(object sender, EventArgs e)
        {

        }

        private void lblNotGoruntule_Click(object sender, EventArgs e)
        {

        }

        private void txtTarih_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFutureNotes_Click(object sender, EventArgs e)
        {

        }

        private void txtTarih_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
