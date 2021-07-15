using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mühendisimden
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 fr = new Form4();
            fr.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form14 yenii = new Form14();
            yenii.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form16 frm = new Form16();
            frm.Show();
        }
    }
}
