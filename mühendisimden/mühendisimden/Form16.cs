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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=........;Initial Catalog=arabalar;Integrated Security=True");

        void kiralikarac(string kiralik)
        {

            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(kiralik, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            kiralikarac("Select *from kiralik");
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kiralikarac("Select *from notrezerv");
           
        }
    }
}
