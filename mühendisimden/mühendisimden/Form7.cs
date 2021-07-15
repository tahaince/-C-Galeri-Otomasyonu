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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            Form10 yeni = new Form10();
            yeni.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form18 frm = new Form18();
            frm.Show();
            
        }
    }
}
