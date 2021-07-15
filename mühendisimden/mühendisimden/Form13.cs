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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=......;Initial Catalog=arabalar;Integrated Security=True");

        void vericek(string veri)
        {

            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(veri, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();


        }


        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from arabaveri where marka like '%" + marka.Text + "%' and model like '%" + model.Text + "%'  and vites like '%" + vites.Text + "%' and yakıt like '%" + yakit.Text + "%' and yıl like '%" + yil.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vericek("Select *from arabaveri");
        }
    }
}
