using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace genel
{
    public partial class Genel : Form
    {
        public Genel()
        {
            InitializeComponent();
            this.Size = new Size(1200, 800);
        }
        private TextBox[] txtSoru;
        private Label[] txtlab;
        CheckBox secim,secim1,secim2,secim3,secim4,secim5, secim6, secim7, secim8, secim9, secim10, secim11, secim12, secim13;
         ListBox listekutu, listekutu1;
        int adet;
        double[] dizi1;
        double varyans = 0, sapma = 0, oms = 0, çarpıklık = 0, basıklık = 0, q1 = 0, q2 = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            //listekutu.Items.Clear();
            for (int i = 1; i <= adet; i++)
            {
                this.Controls.Remove(txtSoru[i - 1]);
                this.Controls.Remove(txtlab[i - 1]);

            }
            /* TextBox kutu = new TextBox();
             kutu.Size = new Size(75,36);
             kutu.Location = new Point(800,10);
             this.Controls.Add(kutu);*/
            secim = new CheckBox();
            secim.Size = new Size(200,20);
            secim.Text = "Verileri Sıralama";
            secim.Location = new Point(900, 40);
            this.Controls.Add(secim);

            secim1 = new CheckBox();
            secim1.Size = new Size(200, 20);
            secim1.Text = "Aritmetik Ortalama";
            secim1.Location = new Point(900, 65);
            this.Controls.Add(secim1);

            secim2 = new CheckBox();
            secim2.Size = new Size(200, 20);
            secim2.Text = "Medyan";
            secim2.Location = new Point(900, 90);
            this.Controls.Add(secim2);

            secim3 = new CheckBox();
            secim3.Size = new Size(200, 20);
            secim3.Text = "Mod";
            secim3.Location = new Point(900, 115);
            this.Controls.Add(secim3);

            secim4 = new CheckBox();
            secim4.Size = new Size(200, 20);
            secim4.Text = "Geometrik Ortalama";
            secim4.Location = new Point(900, 140);
            this.Controls.Add(secim4);

            secim5 = new CheckBox();
            secim5.Size = new Size(200, 20);
            secim5.Text = "Harmonik Ortalama";
            secim5.Location = new Point(900, 165);
            this.Controls.Add(secim5);

            secim6 = new CheckBox();
            secim6.Size = new Size(200, 20);
            secim6.Text = "Varyans";
            secim6.Location = new Point(900, 190);
            this.Controls.Add(secim6);

            secim7 = new CheckBox();
            secim7.Size = new Size(200, 20);
            secim7.Text = "Standart Sapma";
            secim7.Location = new Point(900, 215);
            this.Controls.Add(secim7);

            secim8 = new CheckBox();
            secim8.Size = new Size(200, 20);
            secim8.Text = "OMS";
            secim8.Location = new Point(900, 240);
            this.Controls.Add(secim8);

            secim9 = new CheckBox();
            secim9.Size = new Size(200, 20);
            secim9.Text = "Q1";
            secim9.Location = new Point(900, 265);
            this.Controls.Add(secim9);

            secim10 = new CheckBox();
            secim10.Size = new Size(200, 20);
            secim10.Text = "Q3";
            secim10.Location = new Point(900, 290);
            this.Controls.Add(secim10);

            secim11 = new CheckBox();
            secim11.Size = new Size(200, 20);
            secim11.Text = "Çarpıklık";
            secim11.Location = new Point(900, 315);
            this.Controls.Add(secim11);

            secim12 = new CheckBox();
            secim12.Size = new Size(200, 20);
            secim12.Text = "Basıklık";
            secim12.Location = new Point(900, 340);
            this.Controls.Add(secim12);

            secim13 = new CheckBox();
            secim13.Size = new Size(200, 20);
            secim13.Text = "Değişim Katsayısı";
            secim13.Location = new Point(900, 365);
            this.Controls.Add(secim13);


            Label yazı = new Label();
            yazı.Size = new Size(150, 30);
            yazı.Location = new Point(900,10);
            yazı.Text = "Yapılacak İşlemleri Seçiniz ";
            this.Controls.Add(yazı);
            listekutu = new ListBox();
            listekutu.Size = new Size(300,180);
            listekutu.Location = new Point(350,570);
            this.Controls.Add(listekutu);
            listekutu1 = new ListBox();
            listekutu1.Size = new Size(300, 180);
            listekutu1.Location = new Point(670, 570);
            this.Controls.Add(listekutu1);
            adet = Convert.ToInt32(textBox1.Text);
            string isim;
            string lab;
            txtSoru = new TextBox[adet];
            txtlab = new Label[adet];
            int ayar = 10;
            int a = 1;
            Button btn = new Button();
            Button btn1 = new Button();
            btn.Text = "Hesapla";
            btn.Width = 80;
            btn.Height = 50;
            btn.Location = new Point(230, 630);
            this.Controls.Add(btn);
            btn.Click += Btn_Click;
            btn1.Text = "Temizle";
            btn1.Width = 80;
            btn1.Height = 50;
            btn1.Location = new Point(230, 690);
            this.Controls.Add(btn1);
            btn1.Click += Btn1_Click;
            for (int i = 1; i <= adet; i++)

            {

                txtlab[i - 1] = new Label();
                txtlab[i - 1].Location = new Point(ayar, 32* (a + 2));
                txtlab[i - 1].Size = new Size(70, 36);
                txtlab[i - 1].Text = (i).ToString() + ".Veri";
                txtlab[i - 1].Font = new Font("Microsoft Sans Serif", 14);
                txtSoru[i - 1] = new TextBox();


                txtSoru[i - 1].Location = new Point((ayar + 100), 32 * (a + 2));

                txtSoru[i - 1].Size = new Size(75, 36);
                this.Controls.Add(txtlab[i - 1]);
                this.Controls.Add(txtSoru[i - 1]);
                txtSoru[i - 1].Name = "txtBox" + i;
                isim = txtSoru[i - 1].Text;
                txtlab[i - 1].Name = "txtLab" + i;
                lab = txtlab[i - 1].Text;
                a++;
                if (i % 15 == 0)
                {
                    ayar = ayar + 200;
                    a = 1;
                }

            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            listekutu.Items.Clear();
            listekutu1.Items.Clear();
            double toplam = 0, geo = 1;
            double[] dizi = new double[adet];
            double[,] tek = new double[adet, 2];
            int i1 = 0, i2 = 0, tekrar = 0;
            //sıralama
            int[] veriler = new int[adet];
            
            if (secim.Checked)
            {
                for (int i = 0; i < adet; i++)
                {
                    veriler[i] = Convert.ToInt32(txtSoru[i].Text);
                }
                Array.Sort(veriler);
                for (int i = 0; i < adet; i++)
                {
                    listekutu.Items.Add(veriler[i]);
                }
            }
            //aritmetik ortalama
            
            if (secim1.Checked)
            {
                for (int i = 0; i < adet; i++)
                {
                    dizi[i] = Convert.ToInt32(txtSoru[i].Text);

                }
                for (int i = 0; i < adet; i++)
                {
                    toplam = toplam + dizi[i];
                    geo = geo * dizi[i];
                }
                listekutu1.Items.Add("aritmetik ortalama = " + (double)toplam / adet);
            }
            //medyan
            if (secim2.Checked)
            {
                if (adet % 2 == 0)
                {
                    int orta = adet / 2;
                    listekutu1.Items.Add("Medyan = " + ((double)dizi[orta] + dizi[orta - 1]) / 2);

                }
                else
                {
                    listekutu1.Items.Add("Medyan = " + (dizi[(adet / 2)]));
                }
            }
            //mod
            string gec = "";
            if (secim3.Checked)
            {
                for (int i = 0; i < adet; i++)
                {

                    for (int j = i; j < adet; j++)
                    {
                        if (dizi[i] == dizi[j])
                        {
                            tekrar++;
                        }

                        else
                        {
                            tek[i1, 0] = dizi[i];
                            tek[i1, 1] = tekrar;
                            i1++;
                            i = j - 1;
                            break;

                        }

                    }
                    if (i2 < tekrar)
                    {
                        i2 = tekrar;
                    }

                    tekrar = 0;

                }

                for (int i = 0; i < adet; i++)
                {

                    if (tek[i, 1] == i2)
                    {
                        gec = gec + "," + (tek[i, 0] + " ");
                        //listekutu1.Items.Add("modlar: " + (tek[i, 0] + " "));

                    }
                }
                listekutu1.Items.Add("Modlar = "+gec);
            }
            //Geometrik ortalama
            if (secim4.Checked)
            {
                listekutu1.Items.Add("Geometik ortalama = " + Math.Pow(geo, (double)1 / adet));
            }
            //Harmonik Ortalama
            if (secim5.Checked)
            {
                double degisken = 0;
                for (int i = 0; i < adet; i++)
                {
                    degisken += (double)1 / dizi[i];
                }
                listekutu1.Items.Add("Harmonik ortalama = " + adet / degisken);
            }
            //varyans starndartsapma  qms q1 q3
            dizi1 = new double[adet];
            double stand = 0;
            for (int i = 0; i < adet; i++)
            {
                dizi1[i] = Convert.ToInt32(txtSoru[i].Text);
            }
            for (int i = 0; i < adet; i++)
            {
                stand += dizi1[i];
            }
            stand = stand / adet;
            for (int i = 0; i < adet; i++)
            {
                çarpıklık += Math.Pow(dizi1[i] - stand, 3);
                basıklık += Math.Pow(dizi1[i] - stand, 4);
                varyans += Math.Pow(dizi1[i] - stand, 2);
                oms += Math.Abs(dizi1[i] - stand);
            }
            oms /= adet;
            varyans /= adet - 1;
            sapma = Math.Sqrt(varyans);
            çarpıklık /= adet - 1;
            basıklık /= adet - 1;




            int k = 0, sayaç = 0;
            double sayaç2 = 0;

            Array.Sort(dizi1);



            double r, ilke = dizi1[0], sınıfsayısı, sınıfgenis;

            r = dizi1[dizi.Length - 1] - dizi1[0];

            double a;
            sınıfsayısı = (int)Math.Sqrt(dizi1.Length);
            if (Math.Sqrt(dizi1.Length) > sınıfsayısı) sınıfsayısı++;

            double[,] slimiti = new double[(int)sınıfsayısı, 2];
            double[,] ssınırları = new double[(int)sınıfsayısı, 2];
            double[,] sfrekansı = new double[(int)sınıfsayısı, 2];


            a = r / sınıfsayısı;//genişlik
            sınıfgenis = r / sınıfsayısı;
            sınıfgenis = (int)sınıfgenis;

            if (a > sınıfgenis) sınıfgenis++;




            double a2 = (int)ilke, list3 = 0;
            if (ilke / a2 == 0)
            {
                sayaç2 = 1;
                a = (((dizi1[0] + sınıfgenis) * 2) - 1) / 2.0;

                a = Math.Round(a, 2);
                list3 = Math.Round(a - sınıfgenis, 2);

            }
            else
            {
                sayaç2 = 0.1;
                a = (((dizi1[0] + sınıfgenis) * 2) - 0.1) / 2.0;

                a = Math.Round(a, 2);
                list3 = Math.Round(a - sınıfgenis, 2);

            }


            for (int i = 0; i < sınıfsayısı; i++)// sınıf limitleri
            {
                slimiti[i, 0] = (ilke + (i * sınıfgenis));
                slimiti[i, 1] = (ilke + ((i + 1) * sınıfgenis) - sayaç2);
                ssınırları[i, 1] = (Math.Round(a + (i * sınıfgenis), 2));
                ssınırları[i, 0] = (list3 + (i * sınıfgenis));


                for (; k < dizi1.Length; k++)
                {
                    sfrekansı[i, 0] = ((a - sınıfgenis) + (i * sınıfgenis));
                    for (int h = k; h < dizi1.Length; h++)
                    {

                        if ((a - sınıfgenis) + (i * sınıfgenis) <= dizi1[h] && a + (i * sınıfgenis) >= dizi1[h]) sayaç++;
                        else
                        {

                            k = h;
                            break;

                        }

                    }
                    sfrekansı[i, 1] = sayaç;
                    sayaç = 0;

                    break;

                }

            }



            q1 = hesapla(sfrekansı, sınıfsayısı, adet / sınıfsayısı, sınıfgenis);
            q2 = hesapla(sfrekansı, sınıfsayısı, (3 * adet) / sınıfsayısı, sınıfgenis);
            if (secim6.Checked)
            {
                listekutu1.Items.Add("Varyans = " + varyans);
            }
            if (secim7.Checked)
            {
                listekutu1.Items.Add("Standart Sapma = " + sapma);
            }
            if (secim8.Checked)
            {
                listekutu1.Items.Add("OMS = " + oms);
            }
            if (secim9.Checked)
            {
                listekutu1.Items.Add("Q1 = " + q1);
            }
            if (secim10.Checked)
            {
                listekutu1.Items.Add("Q3 = " + q2);
            }
            if (secim11.Checked)
            {
                listekutu1.Items.Add("carpıklık = " + çarpıklık);
            }
            if (secim12.Checked)
            {
                listekutu1.Items.Add("Basıklık = " + basıklık);
            }
            if (secim13.Checked)
            {
                listekutu1.Items.Add("Değişim Katsayısı  =" + (sapma / stand));
            }

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Application.Restart();
            //listBox1.Items.Clear();
            for (int i = 1; i <= adet; i++)
            {
                this.Controls.Remove(txtSoru[i - 1]);
                this.Controls.Remove(txtlab[i - 1]);

            }
        }
        static double hesapla(double[,] dizi, double yuksek, double k, double h)
        {
            double a = 0, q1 = 0;

            for (int i = 0; i < yuksek; i++)
            {
                a += dizi[i, 1];
                if (a >= k)
                {
                    a -= dizi[i, 1];
                    k -= a;

                    q1 = dizi[i, 0] + ((k * h) / dizi[i, 1]);
                    break;

                }
            }
            return q1;



        }
    }
}
