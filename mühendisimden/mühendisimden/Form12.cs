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
namespace mühendisimden
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.......;Initial Catalog=arabalar;Integrated Security=True");

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void servisekle()
        {
            baglanti.Open();
            string sorgulama = "INSERT INTO servisalani(isim,soyisim,telefon,plaka,bakim,tarih) VALUES(@ad,@soyad,@tel,@plakaa,@bakimm,@tarihh) ";
            SqlCommand komut = new SqlCommand(sorgulama, baglanti);
            
            komut.Parameters.AddWithValue("@ad", isim.Text);
            komut.Parameters.AddWithValue("@soyad", soyisim.Text);
            komut.Parameters.AddWithValue("@tel", textBox4.Text);
            komut.Parameters.AddWithValue("@plakaa", plaka.Text);
            komut.Parameters.AddWithValue("@bakimm", bakım.Text);
            komut.Parameters.AddWithValue("@tarihh", dateTimePicker1.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""||soyisim.Text==""||isim.Text==""||bakım.Text=="")
            {
                MessageBox.Show("LÜTFEN TÜM BİLGİLERİ GİRİNİZ");
            }
            else
            {

                servisekle();
                MessageBox.Show("SERVİS RANDEVUNUZ ALINMIŞTIR");



            }
        }

        private void textBox4_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
