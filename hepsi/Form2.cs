using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, kn, k, a;
            n = Convert.ToInt32(textBox1.Text);     
            kn = Convert.ToInt32(textBox2.Text);
            int[] dizi = new int[kn];
            k = n / kn;
            Random rast = new Random();
            a = rast.Next(1, k);
            listBox1.Items.Clear();
            for (int i = 0; i < kn; i++)
            {
                dizi[i] = a + i * k;
                listBox1.Items.Add(dizi[i]);
                
            }

        }
    }
}
