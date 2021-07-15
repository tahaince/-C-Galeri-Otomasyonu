using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//veri tabanı için gerekli kütüphaneyi indİyoruz...
namespace mühendisimden
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;//gerekli bağlantı elemanları için atamaları yapıyoruz...
        SqlCommand komut;
        SqlDataAdapter da;



        public Form1()
        {
            InitializeComponent();
        }





        private void aracgetir()
        {

            baglanti = new SqlConnection("Data Source=..........;Initial Catalog=arabalar;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("select *from arabaveri", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void aracsil()
        {
            baglanti.Open();
            string sorgulama = "DELETE  FROM arabaveri WHERE arabaId=@arabaId";
             komut = new SqlCommand(sorgulama, baglanti);
            komut.Parameters.AddWithValue("@arabaId", Convert.ToInt32(arabaId.Text));
            
            komut.ExecuteNonQuery();
            baglanti.Close();
            aracgetir();


        }
          private void arama()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from arabaveri where marka like '%" + marka.Text + "%' and model like '%" + model.Text + "%'" +
                "  and vites like '%" + vites.Text + "%' and yakıt like '%" + yakit.Text + "%' and yıl like '%" + yil.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            komut.ExecuteNonQuery();
            baglanti.Close();
        }




        private void aracekle()
        {
            baglanti.Open();
            string sorgulama = "INSERT INTO arabaveri(marka,model,yakıt,yıl,vites,fiyat) VALUES(@markaa,@modell,@yakıtt,@yıll,@vitess,@fiyatt) ";
             komut = new SqlCommand(sorgulama, baglanti);
            //komut.Parameters.AddWithValue("@arabaId", arabaId.Text);
            komut.Parameters.AddWithValue("@markaa", marka.Text);
            komut.Parameters.AddWithValue("@modell", model.Text);
            komut.Parameters.AddWithValue("@yakıtt", yakit.Text);
            komut.Parameters.AddWithValue("@yıll", yil.Text);
            komut.Parameters.AddWithValue("@vitess", vites.Text);
            komut.Parameters.AddWithValue("@fiyatt", fiyat.Text);
           
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void aracgüncelle()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update arabaveri set marka ='" + marka.Text + "',model='" + model.Text + "',yakıt='" + yakit.Text + "'" +
                ",yıl='" + yil.Text + "',vites='" + vites.Text + "',fiyat='" + fiyat.Text + "'where arabaId='" + arabaId.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            aracgetir();

        }

        private void temizle()
        {


            arabaId.Clear(); marka.Clear(); model.Clear(); yakit.Clear(); yil.Clear(); vites.Clear(); fiyat.Clear();



        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (marka.Text == "" || model.Text == "" || yakit.Text == "" || yil.Text == "" || vites.Text == "" || fiyat.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Alanları doldurunuz", "UYARI");

            }

            else
                aracekle();
                aracgetir();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            aracgetir();
            temizle();
        }

       

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            arama();

           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            arabaId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            marka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            model.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            yakit.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            yil.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            vites.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            fiyat.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        
        
        
        
        
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (arabaId.Text == "")
                MessageBox.Show("Lütfen Silmek İstediğiniz Aracın ID'sini giriniz", "UYARI");
            else
            aracsil();
            temizle();
            aracgetir();

        }





        private void button3_Click_1(object sender, EventArgs e)
        {
            aracgüncelle();
        }








        private void TEMİZLE_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }




        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
