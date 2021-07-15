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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.........;Initial Catalog=arabalar;Integrated Security=True");

        void vericek(string veri)
        {

            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(veri, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglanti.Close();



        }
        private void sil()
        {
            baglanti.Open();
            string sorgulama = "DELETE  FROM notrezerv WHERE id=@idd";
           SqlCommand komut = new SqlCommand(sorgulama, baglanti);
            komut.Parameters.AddWithValue("@idd", Convert.ToInt32(textBox7.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            


        }
        private void button1_Click(object sender, EventArgs e)
        {
            vericek("Select *from notrezerv");
        }

        private void button2_Click(object sender, EventArgs e)
        {

           
            sil();


            Random rnd = new Random();
            int sayi = rnd.Next(1000,9999);
            MessageBox.Show("Kiralama İşleminiz Tamalandı");
            MessageBox.Show("Müşteri Numaranız = "+sayi.ToString()+" ");
            MessageBox.Show("Müşteri Numaranız ile Ödeme Yapabilrsiniz");
            MessageBox.Show("MÜHENDSİNDEN İYİ SÜRÜŞLER DİLER");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox7.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime baslangic = dateTimePicker1.Value;
            DateTime bitis = dateTimePicker2.Value;

            System.TimeSpan zaman;
            zaman = bitis.Subtract(baslangic);
            int toplam = Convert.ToInt32(zaman.TotalDays);
            
            int fiyat = Convert.ToInt32(textBox6.Text);
            int ucret = toplam * fiyat;
            textBox5.Text = ucret.ToString();
        }

        private void Form15_Load(object sender, EventArgs e)
        {

        }
    }
}
