using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bas, bit, sayi,uret;
            Random rast = new Random();
            bas = Convert.ToInt32(textBox3.Text);
            bit = Convert.ToInt32(textBox2.Text);
            sayi = Convert.ToInt32(textBox1.Text);
            int[] dizi = dizi = new int[sayi];
            if (bit - bas > sayi)
            {
                for (int i = 0; i < sayi; i++)
                {
                    //a:
                    uret = rast.Next(bas, bit);
                    dizi[i] = uret;
                    for (int j = 0; j < i; j++)
                    {
                        if (dizi[j] == uret)
                        {
                            i--;

                        }
                    }


                }
            }
            else
            {
                for (int i = 0; i < sayi; i++)
                {
                    uret = rast.Next(bas, bit);
                    dizi[i] = uret;

                }
            }
            listBox1.Items.Clear();

            for (int i = 0; i < sayi; i++)
            {
                
                listBox1.Items.Add(dizi[i]);

            }
          
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
