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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
         SqlConnection baglanti = new SqlConnection(@"Data Source=..................;Initial Catalog=arabalar;Integrated Security=True");//veri tabanı bağlantımızı yapıyoruz...
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "") { MessageBox.Show("LÜTFEN TÜM ALANLARI DOLDURUNUZ"); }
            else
            {
                try
                {
                    baglanti.Open();
                    string sql = "Select * From arabagiriş where ad=@adi AND sifre=@sifresi";
                    SqlParameter prm1 = new SqlParameter("adi", textBox1.Text.Trim());
                    SqlParameter prm2 = new SqlParameter("sifresi", textBox2.Text.Trim());
                    SqlCommand komut = new SqlCommand(sql, baglanti);
                    komut.Parameters.Add(prm1);
                    komut.Parameters.Add(prm2);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        Form3 yeni = new Form3();
                        yeni.Show();
                        this.Hide();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("HATALI GİRİŞ YAPTINIZ", "UYARI");
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
