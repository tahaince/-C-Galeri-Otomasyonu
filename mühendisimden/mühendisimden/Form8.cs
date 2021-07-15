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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 yeni = new Form2();
            yeni.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 yenii = new Form6();
            yenii.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form13 yeniii = new Form13();
            yeniii.Show();
        }
    }
}
