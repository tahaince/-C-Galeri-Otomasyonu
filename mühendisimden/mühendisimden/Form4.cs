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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(textBox1.Text==""||textBox2.Text=="")
            {
                MessageBox.Show("Tüm Alanları Doldurunuz");
            }
            SqlConnection baglanti = new SqlConnection("Data Source=.......;Initial Catalog=arabalar;Integrated Security=True");
            baglanti.Open();
            string sorgulama = "INSERT INTO arabagiriş(ad,sifre) VALUES(@adi,@sifresi) ";
            SqlCommand  komut = new SqlCommand(sorgulama, baglanti);
           
            komut.Parameters.AddWithValue("@adi", textBox1.Text);
            komut.Parameters.AddWithValue("@sifresi", textBox2.Text);
           
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("KAYDINIZ YAPILMIŞTIR");
            

        }
    }
}
