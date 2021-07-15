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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.......;Initial Catalog=arabalar;Integrated Security=True");




        private void button1_Click(object sender, EventArgs e)
        {
           


             if(yakit.Text=="EVET")
            {
                yakit.Text = "DİZEL";

                if (yil.Text == "ARACIM 0 KM OLMALIDIR")
                {
                    yil.Text = "2020";
                }
                else if(yil.Text=="FARKETMEZ") 
                        {

                    yil.Text = "";
                        }
            }

            else if(yakit.Text=="HAYIR")
            {
                yakit.Text = "BENZİN";
                if (yil.Text == "ARACIM 0 KM OLMALIDIR")
                {
                    yil.Text = "2021 2020";
                }
                else
                {

                    yil.Text = "2019 2018 2017 2016 2015 2014 2013 2012 2011";
                }

            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from arabaveri where vites like '%" + vites.Text + "%' and yakıt like '%" + yakit.Text + "%' and yıl like'%" +yil.Text+"%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
