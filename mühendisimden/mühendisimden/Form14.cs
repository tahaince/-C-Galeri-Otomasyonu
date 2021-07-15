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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=......;Initial Catalog=arabalar;Integrated Security=True");
        void servis(string veri)
        {

            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(veri, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglanti.Close();



        }
        private void LİSTELE_Click(object sender, EventArgs e)
        {
            servis("Select *from servisalani");
        }

        private void ARA_Click(object sender, EventArgs e)
        {
           
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select *from servisalani where plaka like '%" +textBox1.Text+ "%'", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                komut.ExecuteNonQuery();
                baglanti.Close();
            

        }
    }
}
