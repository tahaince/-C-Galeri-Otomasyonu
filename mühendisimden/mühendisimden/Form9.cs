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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.........;Initial Catalog=arabalar;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI DOLDURUNUZ", "UYARI");
            }
            else if (textBox2.Text != textBox4.Text)
            {
                MessageBox.Show("GİRDİĞİNİZ İLK VE İKİNCİ ŞİFRE AYNI OLMALIDIR", "UYARI");
            }
           
            else
            {
                baglanti.Open();
                string sorgulama = "INSERT INTO kgiris(ad,sifre,mail) VALUES(@adi,@sifresi,@maill) ";
                SqlCommand komut = new SqlCommand(sorgulama, baglanti);

                komut.Parameters.AddWithValue("@adi", textBox1.Text);
                komut.Parameters.AddWithValue("@sifresi", textBox2.Text);
                komut.Parameters.AddWithValue("@maill", textBox3.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("KAYDINIZ YAPILMIŞTIR");
                MessageBox.Show("MÜHENDİSİNDEN AİLESİNE HOŞGELDİNİZ");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
