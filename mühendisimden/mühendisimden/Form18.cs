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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.......;Initial Catalog=arabalar;Integrated Security=True");//veri tabanı bağlantımızı yapıyoruz..
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text && textBox1.Text=="" && textBox2.Text=="" && textBox4.Text=="")
            {
                
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update kgiris set sifre ='" + textBox2.Text + "',mail='" + textBox4.Text + "'where ad='" + textBox1.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Bilgileriniz Başarıyla Güncellendi");
            }
            else
            {
                MessageBox.Show("İLK ŞİFRE İLE İKİNCİ ŞİFRE AYNI OLMALIDIR");

            }

        }
    }
}
