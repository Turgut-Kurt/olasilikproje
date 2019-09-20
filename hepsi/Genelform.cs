using form1;
using form2;
using genel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hepsi
{
    public partial class Genelform : Form
    {
        
        public Genelform()
        {
            InitializeComponent();
            this.Size = new Size(1200, 800);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        Button btn5a;
        private TextBox[] txtSoru1;
        private Label[] txtlab1;
        Button btn6c,btn6b, btn11a, btn11b, btn12a;
        CheckBox secim, secim1, secim2, secim3, secim4, secim5, secim6, secim7, secim8, secim9, secim10, secim11, secim12, secim13;
        ListBox listekutu6a, listekutu6b;
        int adet1,adet2,adet3,adet4,adet5;
        double[] dizi1;
        double varyans = 0, sapma = 0, oms = 0, çarpıklık = 0, basıklık = 0, q1 = 0, q2 = 0;
        private TextBox[] txtSoru;
        private Label[] txtlab;
        private TextBox[] txtSoru2;
        private Label[] txtlab2;
        private TextBox[] txtSoru3;
        private Label[] txtlab3;
        private TextBox[] txtSoru4;
        private Label[] txtlab4;
        private TextBox[] txtSoru5;
        private Label[] txtlab5;
        Label yazı11b, yazı11g, yazı11c, yazı11d, yazı11e, yazı11f, yazı11a, yazı5j, yazı5k,yazı5i, yazı5ı, yazı5e, yazı5h, yazı5f, yazı5g,yazı4a, yazı1a, yazı1b, yazı1c, yazı2a, yazı2b, yazı3a, yazı9a, yazı5d , yazı9b, yazı10a, yazı10b, yazı6a, yazı4b, yazı4c,yazı5a,yazı5b,yazı5c;
        int[] veriler1; int[] veriler2;


        ListBox listekutu11c, listekutu11e, listekutu11d,listekutu11a, listekutu11b, listekutu5f, listekutu5h, listekutu5ı, listekutu5g, listekutu5e, listekutu5c, listekutu5d,listekutu1a, listekutu2a, listekutu3a, listekutu9a, listekutu10a, listekutu4a, listekutu4b, listekutu5a, listekutu5b;
        int adet;
        TextBox kutu11b,kutu11a, kutu1a, kutu1b, kutu1c, kutu2a, kutu2b,kutu3a, kutu9a, kutu9b, kutu10a, kutu10b, kutu6a,kutu4a,kutu5a;
        private void öDEV11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yazı11a = new Label();
            yazı11a.Size = new Size(270, 25);
            yazı11a.Location = new Point(10, 25);
            yazı11a.Text = "1.Küme Eleman Sayısını Giriniz";
            yazı11a.Font = new Font("Microsoft Sans Serif", 14);
            this.Controls.Add(yazı11a);

            kutu11a = new TextBox();
            kutu11a.Size = new Size(50, 60);
            kutu11a.Location = new Point(280, 28);

            this.Controls.Add(kutu11a);

            btn11a = new Button();
            btn11a.Text = "Kontrol";
            btn11a.Size = new Size(100, 23);
            btn11a.Location = new Point(350, 25);
            this.Controls.Add(btn11a);
            btn11a.Click += Btn11a_Click;

            /////////////////////////////
            yazı11b = new Label();
            yazı11b.Size = new Size(270, 25);
            yazı11b.Location = new Point(500, 25);
            yazı11b.Text = "2.Küme Eleman Sayısını Giriniz";
            yazı11b.Font = new Font("Microsoft Sans Serif", 14);
            this.Controls.Add(yazı11b);

            kutu11b = new TextBox();
            kutu11b.Size = new Size(50, 60);
            kutu11b.Location = new Point(770, 28);

            this.Controls.Add(kutu11b);

            btn11b = new Button();
            btn11b.Text = "Kontrol";
            btn11b.Size = new Size(100, 23);
            btn11b.Location = new Point(840, 25);
            this.Controls.Add(btn11b);
            btn11b.Click += Btn11b_Click;
        }

        private void Btn11b_Click(object sender, EventArgs e)
        {
            
            for (int i = 1; i <= adet5; i++)
            {
                this.Controls.Remove(txtSoru5[i - 1]);
                this.Controls.Remove(txtlab5[i - 1]);
            }
            adet5 = Convert.ToInt32(kutu11b.Text);
            string isim20;
            string lab20;
            txtSoru5 = new TextBox[adet5];
            txtlab5 = new Label[adet5];
            int j = 500;
            int a = 1;


            for (int i = 1; i <= adet5; i++)

            {

                txtlab5[i - 1] = new Label();
                txtlab5[i - 1].Location = new Point(j, 28 * (a + 1));
                txtlab5[i - 1].Size = new Size(70, 30);
                txtlab5[i - 1].Text = (i).ToString() + ". veri";
                txtSoru5[i - 1] = new TextBox();


                txtSoru5[i - 1].Location = new Point((j + 70), 28 * (a + 1));

                txtSoru5[i - 1].Size = new Size(70, 30);
                this.Controls.Add(txtlab5[i - 1]);
                this.Controls.Add(txtSoru5[i - 1]);
                txtSoru5[i - 1].Name = "txtBox" + i;
                isim20 = txtSoru5[i - 1].Text;
                txtlab5[i - 1].Name = "txtLab" + i;
                lab20 = txtlab5[i - 1].Text;
                a++;
                if (i % 20 == 0)
                {
                    j = j + 160;
                    a = 1;
                }


            }
           
        }



        private void Btn11a_Click(object sender, EventArgs e)
        {
            btn12a = new Button();
            btn12a.Text = "Hesapla";
            btn12a.Size = new Size(100, 50);
            btn12a.Location = new Point(190, 320);
            btn12a.Click += Btn12a_Click;
            this.Controls.Add(btn12a);
            
            for (int i = 1; i <= adet4; i++)
            {
                this.Controls.Remove(txtSoru4[i - 1]);
                this.Controls.Remove(txtlab4[i - 1]);
            }
            adet4 = Convert.ToInt32(kutu11a.Text);
            string isim10;
            string lab10;
            txtSoru4 = new TextBox[adet4];
            txtlab4 = new Label[adet4];
            int j = 10;
            int a = 1;

          
            for (int i = 1; i <= adet4; i++)

            {

                txtlab4[i - 1] = new Label();
                txtlab4[i - 1].Location = new Point(j, 28 * (a + 1));
                txtlab4[i - 1].Size = new Size(70, 30);
                txtlab4[i - 1].Text = (i).ToString() + ". veri";
                txtSoru4[i - 1] = new TextBox();


                txtSoru4[i - 1].Location = new Point((j + 70), 28 * (a + 1));

                txtSoru4[i - 1].Size = new Size(70, 30);
                this.Controls.Add(txtlab4[i - 1]);
                this.Controls.Add(txtSoru4[i - 1]);
                txtSoru4[i - 1].Name = "txtBox" + i;
                isim10 = txtSoru4[i - 1].Text;
                txtlab4[i - 1].Name = "txtLab" + i;
                lab10 = txtlab4[i - 1].Text;
                a++;
                if (i % 20 == 0)
                {
                    j = j + 160;
                    a = 1;
                }


            }
            
        }

        private void Btn12a_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= adet5; i++)
            {
                this.Controls.Remove(txtSoru5[i - 1]);
                this.Controls.Remove(txtlab5[i - 1]);
            }
            for (int i = 1; i <= adet4; i++)
            {
                this.Controls.Remove(txtSoru4[i - 1]);
                this.Controls.Remove(txtlab4[i - 1]);
            }
            this.Controls.Remove(yazı11a);
            this.Controls.Remove(yazı11b);
            this.Controls.Remove(kutu11a);
            this.Controls.Remove(kutu11b);
            this.Controls.Remove(btn11b);
            this.Controls.Remove(btn11a);
            yazı11c = new Label();
            yazı11c.Size = new Size(80, 20);
            yazı11c.Location = new Point(5, 20);
            yazı11c.Text = "A Kümesi";
            yazı11c.Font = new Font("Microsoft Sans Serif", 12);
            this.Controls.Add(yazı11c);
            yazı11d = new Label();
            yazı11d.Size = new Size(80, 20);
            yazı11d.Location = new Point(95, 20);
            yazı11d.Text = "B Kümesi";
            yazı11d.Font = new Font("Microsoft Sans Serif", 12);
            this.Controls.Add(yazı11d);
            listekutu11a = new ListBox();
            listekutu11a.Size = new Size(60, 150);
            listekutu11a.Location = new Point(10, 50);
            this.Controls.Add(listekutu11a);
            listekutu11b = new ListBox();
            listekutu11b.Size = new Size(60, 150);
            listekutu11b.Location = new Point(100, 50);
            this.Controls.Add(listekutu11b);
            ///////////////////////////////////////
            yazı11e = new Label();
            yazı11e.Size = new Size(80, 20);
            yazı11e.Location = new Point(210, 20);
            yazı11e.Text = "AnB";
            yazı11e.Font = new Font("Microsoft Sans Serif", 12);
            this.Controls.Add(yazı11e);
            yazı11f = new Label();
            yazı11f.Size = new Size(80, 20);
            yazı11f.Location = new Point(340, 20);
            yazı11f.Text = "AUB";
            yazı11f.Font = new Font("Microsoft Sans Serif", 12);
            this.Controls.Add(yazı11f);
            listekutu11c = new ListBox();
            listekutu11c.Size = new Size(60, 150);
            listekutu11c.Location = new Point(200, 50);
            this.Controls.Add(listekutu11c);
            listekutu11d = new ListBox();
            listekutu11d.Size = new Size(120, 150);
            listekutu11d.Location = new Point(300, 50);
            this.Controls.Add(listekutu11d);
            yazı11g = new Label();
            yazı11g.Size = new Size(80, 20);
            yazı11g.Location = new Point(470, 20);
            yazı11g.Text = "A/B";
            yazı11g.Font = new Font("Microsoft Sans Serif", 12);
            this.Controls.Add(yazı11g);
            listekutu11e = new ListBox();
            listekutu11e.Size = new Size(60, 150);
            listekutu11e.Location = new Point(460, 50);
            this.Controls.Add(listekutu11e);
            listekutu11a.Items.Clear();
            veriler1 = new int[adet4];
            for (int i = 0; i < adet4; i++)
            {
                veriler1[i] = Convert.ToInt32(txtSoru4[i].Text);
            }
            for (int i = 0; i < adet4; i++)
            {
                listekutu11a.Items.Add(veriler1[i]);
            }
            listekutu11b.Items.Clear();
            veriler2 = new int[adet5];
            for (int i = 0; i < adet5; i++)
            {
                veriler2[i] = Convert.ToInt32(txtSoru5[i].Text);
            }
            for (int i = 0; i < adet5; i++)
            {
                listekutu11b.Items.Add(veriler2[i]);
            }
            Kume kume1 = new Kume(veriler1);
            Kume kume2 = new Kume(veriler2);
            var kesisim = kume1 & kume2;
            listekutu11c.Items.Add(kesisim);
            var birlesim = kume1 + kume2;
            listekutu11d.Items.Add(birlesim);
            var fark = kume1 / kume2;
            listekutu11e.Items.Add(fark);

        }

        private void öDEV5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yazı5a = new Label();
            yazı5a.Size = new Size(100, 25);
            yazı5a.Location = new Point(10, 25);
            yazı5a.Text = "Veri Sayısı ";
            yazı5a.Font = new Font("Microsoft Sans Serif", 14);
            this.Controls.Add(yazı5a);

            kutu5a = new TextBox();
            kutu5a.Size = new Size(50, 60);
            kutu5a.Location = new Point(120, 25);

            this.Controls.Add(kutu5a);

            btn5a = new Button();
            btn5a.Text = "Kontrol";
            btn5a.Size = new Size(100, 23);
            btn5a.Location = new Point(250, 25);
            this.Controls.Add(btn5a);
            btn5a.Click += Btn5a_Click;
        }

        private void Btn5a_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= adet3; i++)
            {
                this.Controls.Remove(txtSoru3[i - 1]);
                this.Controls.Remove(txtlab3[i - 1]);
            }
            adet3 = Convert.ToInt32(kutu5a.Text);
            string isim3;
            string lab3;
            txtSoru3 = new TextBox[adet3];
            txtlab3 = new Label[adet3];
            int j = 10;
            int a = 1;
            Button btn5b = new Button();
            btn5b.Text = "Hesapla";
            btn5b.Width = 80;
            btn5b.Height = 50;
            btn5b.Location = new Point(230, 630);
            this.Controls.Add(btn5b);
            btn5b.Click += Btn5b_Click;


            for (int i = 1; i <= adet3; i++)

            {

                txtlab3[i - 1] = new Label();
                txtlab3[i - 1].Location = new Point(j, 28 * (a + 1));
                txtlab3[i - 1].Size = new Size(70, 30);
                txtlab3[i - 1].Text = (i).ToString() + ". veri";
                txtSoru3[i - 1] = new TextBox();


                txtSoru3[i - 1].Location = new Point((j + 70), 28 * (a + 1));

                txtSoru3[i - 1].Size = new Size(70, 30);
                this.Controls.Add(txtlab3[i - 1]);
                this.Controls.Add(txtSoru3[i - 1]);
                txtSoru3[i - 1].Name = "txtBox" + i;
                isim3 = txtSoru3[i - 1].Text;
                txtlab3[i - 1].Name = "txtLab" + i;
                lab3 = txtlab3[i - 1].Text;
                a++;
                if (i % 20 == 0)
                {
                    j = j + 160;
                    a = 1;
                }


            }
        }



        private void Btn5b_Click(object sender, EventArgs e)
        {
            
            double[] dizi = new double[adet3];
            for (int i = 1; i <= adet3; i++)
            {
                dizi[i - 1] = Convert.ToDouble(txtSoru3[i - 1].Text);
            }
            Array.Sort(dizi);
            for (int i = 1; i <= adet3; i++)
            {
                this.Controls.Remove(txtSoru3[i - 1]);
                this.Controls.Remove(txtlab3[i - 1]);

            }
            this.Controls.Remove(yazı5a);
            this.Controls.Remove(kutu5a);
            this.Controls.Remove(btn5a);
            //dizi içerisindeki en büyük ve en küçük sayıyı bulma
            
            

            //sınıflimiti
            yazı5b = new Label();
            yazı5b.Size = new Size(130, 25);
            yazı5b.Location = new Point(40, 25);
            yazı5b.Text = "Sınıf Limiti ";
            yazı5b.Font = new Font("Microsoft Sans Serif", 14);
            this.Controls.Add(yazı5b);

            
            yazı5c = new Label();
            yazı5c.Size = new Size(50, 25);
            yazı5c.Location = new Point(20, 50);
            yazı5c.Text = "ALT ";
            yazı5c.Font = new Font("Microsoft Sans Serif", 14);
            this.Controls.Add(yazı5c);

            yazı5d = new Label();
            yazı5d.Size = new Size(50, 25);
            yazı5d.Location = new Point(90, 50);
            yazı5d.Text = "ÜST ";
            yazı5d.Font = new Font("Microsoft Sans Serif", 14);
            this.Controls.Add(yazı5d);

            listekutu5a = new ListBox();
            listekutu5a.Size = new Size(60, 150);
            listekutu5a.Location = new Point(10, 80);
            this.Controls.Add(listekutu5a);
            
            listekutu5b = new ListBox();
            listekutu5b.Size = new Size(60, 150);
            listekutu5b.Location = new Point(80, 80);
            this.Controls.Add(listekutu5b);

            //sınıf sınırları
            yazı5e = new Label();
            yazı5e.Size = new Size(130, 25);
            yazı5e.Location = new Point(180, 25);
            yazı5e.Text = "Sınıf Sınırları ";
            yazı5e.Font = new Font("Microsoft Sans Serif", 14);
            this.Controls.Add(yazı5e);


            yazı5f = new Label();
            yazı5f.Size = new Size(50, 25);
            yazı5f.Location = new Point(170, 50);
            yazı5f.Text = "ALT ";
            yazı5f.Font = new Font("Microsoft Sans Serif", 14);
            this.Controls.Add(yazı5f);

            yazı5g = new Label();
            yazı5g.Size = new Size(50, 25);
            yazı5g.Location = new Point(240, 50);
            yazı5g.Text = "ÜST ";
            yazı5g.Font = new Font("Microsoft Sans Serif", 14);
            this.Controls.Add(yazı5g);

            listekutu5c = new ListBox();
            listekutu5c.Size = new Size(60, 150);
            listekutu5c.Location = new Point(160, 80);
            this.Controls.Add(listekutu5c);

            listekutu5d = new ListBox();
            listekutu5d.Size = new Size(60, 150);
            listekutu5d.Location = new Point(230, 80);
            this.Controls.Add(listekutu5d);

            //sınıf frekansı
            yazı5h = new Label();
            yazı5h.Size = new Size(130, 25);
            yazı5h.Location = new Point(320, 25);
            yazı5h.Text = "Sınıf Frekansı";
            yazı5h.Font = new Font("Microsoft Sans Serif", 14);
            this.Controls.Add(yazı5h);

            listekutu5e = new ListBox();
            listekutu5e.Size = new Size(110, 150);
            listekutu5e.Location = new Point(320, 80);
            this.Controls.Add(listekutu5e);

            //sınıf orta noktası

            yazı5ı = new Label();
            yazı5ı.Size = new Size(160, 25);
            yazı5ı.Location = new Point(460, 25);
            yazı5ı.Text = "Sınıf Orta Noktası";
            yazı5ı.Font = new Font("Microsoft Sans Serif", 14);
            this.Controls.Add(yazı5ı);

            listekutu5f = new ListBox();
            listekutu5f.Size = new Size(110, 150);
            listekutu5f.Location = new Point(470, 80);
            this.Controls.Add(listekutu5f);

            //eklenik frekans
            yazı5i = new Label();
            yazı5i.Size = new Size(160, 25);
            yazı5i.Location = new Point(630, 25);
            yazı5i.Text = "Eklenik Frekans";
            yazı5i.Font = new Font("Microsoft Sans Serif", 14);
            this.Controls.Add(yazı5i);

            listekutu5g = new ListBox();
            listekutu5g.Size = new Size(110, 150);
            listekutu5g.Location = new Point(640, 80);
            this.Controls.Add(listekutu5g);

            //oransal frekans

            yazı5j = new Label();
            yazı5j.Size =new Size(160, 25);
            yazı5j.Location = new Point(785, 25);
            yazı5j.Text = "Oransal Frekans";
            yazı5j.Font = new Font("Microsoft Sans Serif", 14);
            this.Controls.Add(yazı5j);

            listekutu5h = new ListBox();
            listekutu5h.Size = new Size(110, 150);
            listekutu5h.Location = new Point(800, 80);
            this.Controls.Add(listekutu5h);

            //oransal eklenik frekans
            yazı5k = new Label();
            yazı5k.Size = new Size(200, 25);
            yazı5k.Location = new Point(950, 25);
            yazı5k.Text = "Oransal E. Frekans";
            yazı5k.Font = new Font("Microsoft Sans Serif", 14);
            this.Controls.Add(yazı5k);

            listekutu5ı = new ListBox();
            listekutu5ı.Size = new Size(110, 150);
            listekutu5ı.Location = new Point(960, 80);
            this.Controls.Add(listekutu5ı);
            double min = dizi[0];
            double max = dizi[0];
            for (int i = 1; i < dizi.Length; i++)
            {
                if (min > dizi[i])
                    min = dizi[i];
                if (max < dizi[i])
                    max = dizi[i];
            }
            
            double R = max - min;
            double k = Math.Sqrt(adet3);
            int k1 = Convert.ToInt32(Math.Sqrt(adet3));
            if (k > k1)
            {
                k1 = k1 + 1;
            }
            double h = R / k1;
            int h1 = Convert.ToInt32(R / k1);
            double[] kdizi = new double[k1];
            double [] kdizi1 = new double [k1];
            if (h > h1)
            {
                h1 = h1 + 1;
            }
            for (int i = 0; i < k1; i++)
            {
                listekutu5a.Items.Add(min+i*h1);
                kdizi[i] = min + i * h1;
            }
            for (int i = 1; i <= k1; i++)
            {
                listekutu5b.Items.Add((min + i * h1)-1);
                kdizi1[i-1] = ((min + i * h1) - 1);
            }

            for (int i = 0; i < k1; i++)
            {
                listekutu5c.Items.Add((min-0.5) + i * h1);
            }
            for (int i = 1; i <= k1; i++)
            {
                listekutu5d.Items.Add((min + i * h1) - 0.5);
            }
            double sayac1 = 0;

            double sayac2 = 0;
            for (int i = 0; i < k1; i++)
            {
                for (int j = 0; j < adet3; j++)
                {
                    for (double l = kdizi[i]; l <= kdizi1[i]; l++)
                    {
                        if (l == dizi[j])
                        {
                            sayac2 = sayac2 + 1;
                        }
                    }
                }
                listekutu5e.Items.Add(sayac2);
                listekutu5h.Items.Add(sayac2/adet3);
                sayac2 = 0;
            }
            for (int i = 0; i < k1; i++)
            {
                for (int j = 0; j < adet3; j++)
                {
                    for (double l = kdizi[i]; l<= kdizi1[i]; l++)
                    {
                        if (l==dizi[j])
                        {
                            sayac1 = sayac1 + 1;
                        }
                    }
                }
                listekutu5g.Items.Add(sayac1);
                listekutu5ı.Items.Add(sayac1/adet3);
            }
            for (int i = 0; i < k1; i++)
            {
                listekutu5f.Items.Add((kdizi[i]+kdizi1[i])/2);
            }






            /*listekutu5ı.Items.Add(R);
            listekutu5ı.Items.Add(k1);
            listekutu5ı.Items.Add(h1);*/



        }

        private void öDEV4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yazı4a = new Label();
            yazı4a.Size = new Size(100, 25);
            yazı4a.Location = new Point(10, 25);
            yazı4a.Text = "Veri Sayısı ";
            yazı4a.Font = new Font("Microsoft Sans Serif", 14);
            this.Controls.Add(yazı4a);

            kutu4a = new TextBox();
            kutu4a.Size = new Size(50, 60);
            kutu4a.Location = new Point(120, 25);

            this.Controls.Add(kutu4a);

            Button btn4a = new Button();
            btn4a.Text = "Kontrol";
            btn4a.Size = new Size(100, 23);
            btn4a.Location = new Point(250, 25);
            this.Controls.Add(btn4a);
            btn4a.Click += Btn4a_Click;
        }

        private void Btn4a_Click(object sender, EventArgs e)
        {

            yazı4b = new Label();
            yazı4b.Size = new Size(110, 25);
            yazı4b.Location = new Point(350, 580);
            yazı4b.Text = "Xi(Girilen) ";
            yazı4b.Font = new Font("Microsoft Sans Serif", 14);
            this.Controls.Add(yazı4b);

            yazı4c = new Label();
            yazı4c.Size = new Size(110, 25);
            yazı4c.Location = new Point(460, 580);
            yazı4c.Text = "Fi(Tekrar) ";
            yazı4c.Font = new Font("Microsoft Sans Serif", 14);
            this.Controls.Add(yazı4c);

            listekutu4a = new ListBox();
            listekutu4a.Size = new Size(100, 150);
            listekutu4a.Location = new Point(350, 610);
            this.Controls.Add(listekutu4a);
            listekutu4b = new ListBox();
            listekutu4b.Size = new Size(100, 150);
            listekutu4b.Location = new Point(460, 610);
            this.Controls.Add(listekutu4b);
            listekutu4a.Items.Clear();
            listekutu4b.Items.Clear();
            for (int i = 1; i <= adet2; i++)
            {
                this.Controls.Remove(txtSoru2[i - 1]);
                this.Controls.Remove(txtlab2[i - 1]);
            }
            adet2 = Convert.ToInt32(kutu4a.Text);
            string isim2;
            string lab2;
            txtSoru2 = new TextBox[adet2];
            txtlab2 = new Label[adet2];
            int j = 10;
            int a = 1;
            Button btn4b = new Button();
            btn4b.Text = "Hesapla";
            btn4b.Width = 80;
            btn4b.Height = 50;
            btn4b.Location = new Point(230, 630);
            this.Controls.Add(btn4b);
            btn4b.Click += Btn4b_Click;

            Button btn4c = new Button();
            btn4c.Text = "Temizle";
            btn4c.Width = 80;
            btn4c.Height = 50;
            btn4c.Location = new Point(230, 690);
            this.Controls.Add(btn4c);
            btn4c.Click += Btn4c_Click;
            for (int i = 1; i <= adet2; i++)

            {

                txtlab2[i - 1] = new Label();
                txtlab2[i - 1].Location = new Point(j, 28 * (a + 1));
                txtlab2[i - 1].Size = new Size(70, 30);
                txtlab2[i - 1].Text = (i).ToString() + ". veri";
                txtSoru2[i - 1] = new TextBox();


                txtSoru2[i - 1].Location = new Point((j + 70), 28 * (a + 1));

                txtSoru2[i - 1].Size = new Size(70, 30);
                this.Controls.Add(txtlab2[i - 1]);
                this.Controls.Add(txtSoru2[i - 1]);
                txtSoru2[i - 1].Name = "txtBox" + i;
                isim2 = txtSoru2[i - 1].Text;
                txtlab2[i - 1].Name = "txtLab" + i;
                lab2 = txtlab2[i - 1].Text;
                a++;
                if (i % 20 == 0)
                {
                    j = j + 160;
                    a = 1;
                }


            }
        }

        private void Btn4c_Click(object sender, EventArgs e)
        {
            listekutu4a.Items.Clear();
            listekutu4b.Items.Clear();
            for (int i = 1; i <= adet2; i++)
            {
                txtSoru2[i - 1].Clear();
                //this.Controls.Remove(txtSoru[i - 1]);
                //this.Controls.Remove(txtlab[i - 1]);
            }
        }

        private void Btn4b_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            double[] dizi = new double[adet2];
            for (int i = 1; i <= adet2; i++)
            {
                dizi[i - 1] = Convert.ToDouble(txtSoru2[i - 1].Text);
            }
            Array.Sort(dizi);
            for (int j = 0; j < adet2; j++)
            {
                for (int k = 0; k < adet2; k++)
                {
                    //eğer tekrar eden değer bulunursa if'in içindeki kod çalışıyor www.bilisimogretmeni.com
                    if (dizi[j] == dizi[k])
                    {
                        //bu for da, dizinin bütün değerleri için ekranda yazdırmanın önüne geçmek için.
                        //örneğin 2 üç kez tekrar ediyor olabilir ama ekranda sadece bir tane 2nin üç kez girildiğini görmemiz lazım aksi takdirde ekranda kaç kez girildiyse o kadar yazdırıyor. www.bilisimogretmeni.com
                        for (int l = 0; l < j; l++)
                        {
                            //eğer değerin kaç kez girildiğini önceden yazdırmışsam bunu tekrar yazdırmama gerek yok
                            if (dizi[l] == dizi[j])
                                //sayacı -1'e eşitliyorum çünkü sonrasında 1 artıracak 0 olacak ve en son ekrana yazdırırken sayaç 0 değilse yazdıracak www.bilisimogretmeni.com
                                sayac = -1;
                        }
                        sayac++;
                    }
                }
                if (sayac != 0)
                {
                    listekutu4a.Items.Add(dizi[j]+" sayısı");
                    listekutu4b.Items.Add(sayac+" defa terar edildi");
                    //Console.WriteLine(dizi[j] + " sayısı " + sayac + " kez tekrar edildi");
                }

                sayac = 0;
            }
        }

        private void öDEV10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listekutu10a = new ListBox();
            listekutu10a.Size = new Size(300, 180);
            listekutu10a.Location = new Point(80, 400);
            this.Controls.Add(listekutu10a);

            Button btn10a = new Button();
            btn10a.Text = "Hesapla";
            btn10a.Size = new Size(100, 50);
            btn10a.Location = new Point(190, 320);
            this.Controls.Add(btn10a);
            btn10a.Click += Btn10a_Click;

            yazı10a = new Label();
            yazı10a.Size = new Size(200, 30);
            yazı10a.Location = new Point(80, 80);
            yazı10a.Text = "Eleman Sayısı  ";
            yazı10a.Font = new Font("Microsoft Sans Serif", 14);
            this.Controls.Add(yazı10a);

            yazı10b = new Label();
            yazı10b.Size = new Size(200, 30);
            yazı10b.Location = new Point(80, 160);
            yazı10b.Text = "Seçilecek Eleman ";
            yazı10b.Font = new Font("Microsoft Sans Serif", 14);
            this.Controls.Add(yazı10b);

            kutu10a = new TextBox();
            kutu10a.Size = new Size(70, 50);
            kutu10a.Location = new Point(300, 80);

            this.Controls.Add(kutu10a);

            kutu10b = new TextBox();
            kutu10b.Size = new Size(70, 50);
            kutu10b.Location = new Point(300, 160);

            this.Controls.Add(kutu10b);
        }

        private void Btn10a_Click(object sender, EventArgs e)
        {
            int n = 0, r = 0;
            double sonuc = 1, payda = 1;
            n = Convert.ToInt32(kutu10a.Text);
            r = Convert.ToInt32(kutu10b.Text);
           

            for (int i = (n - r) + 1, b = 1; i <= n; b++, i++)
            {
                if (b <= r) payda *= b;

                sonuc *= i;
            }
            //int c = sonuc / payda;
            listekutu10a.Items.Add(sonuc / payda);
            
        }

        private void öDEV3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yazı3a = new Label();
            yazı3a.Size = new Size(100, 25);
            yazı3a.Location = new Point(10, 25);
            yazı3a.Text = "Veri Sayısı ";
            yazı3a.Font = new Font("Microsoft Sans Serif", 14);
            this.Controls.Add(yazı3a);

            kutu3a = new TextBox();
            kutu3a.Size = new Size(50, 60);
            kutu3a.Location = new Point(120, 25);
            
            this.Controls.Add(kutu3a);

            Button btn3a = new Button();
            btn3a.Text = "Kontrol";
            btn3a.Size = new Size(100, 23);
            btn3a.Location = new Point(250, 25);
            this.Controls.Add(btn3a);
            btn3a.Click += Btn3a_Click;

           

        }

        private void öDEV9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listekutu9a = new ListBox();
            listekutu9a.Size = new Size(300, 180);
            listekutu9a.Location = new Point(80, 400);
            this.Controls.Add(listekutu9a);

            Button btn9a = new Button();
            btn9a.Text = "Hesapla";
            btn9a.Size = new Size(100, 50);
            btn9a.Location = new Point(190, 320);
            this.Controls.Add(btn9a);
            btn9a.Click += Btn9a_Click;

            yazı9a = new Label();
            yazı9a.Size = new Size(200, 30);
            yazı9a.Location = new Point(80, 80);
            yazı9a.Text = "Eleman Sayısı  ";
            yazı9a.Font = new Font("Microsoft Sans Serif", 14);
            this.Controls.Add(yazı9a);

            yazı9b = new Label();
            yazı9b.Size = new Size(200, 30);
            yazı9b.Location = new Point(80, 160);
            yazı9b.Text = "Seçilecek Eleman ";
            yazı9b.Font = new Font("Microsoft Sans Serif", 14);
            this.Controls.Add(yazı9b);

            kutu9a = new TextBox();
            kutu9a.Size = new Size(70, 50);
            kutu9a.Location = new Point(300, 80);
            
            this.Controls.Add(kutu9a);

            kutu9b = new TextBox();
            kutu9b.Size = new Size(70, 50);
            kutu9b.Location = new Point(300, 160);
            
            this.Controls.Add(kutu9b);
        }

        private void Btn9a_Click(object sender, EventArgs e)
        {
            int n = 0, r = 0;
            long sonuc = 1;
            
            n = Convert.ToInt32(kutu9a.Text);
            
            r = Convert.ToInt32(kutu9b.Text);

            for (int i = (n - r) + 1; i <= n; i++)
            {
                sonuc *= i;
            }
            listekutu9a.Items.Add(sonuc);
        }

        private void Btn3a_Click(object sender, EventArgs e)
        {
            listekutu3a = new ListBox();
            listekutu3a.Size = new Size(300, 150);
            listekutu3a.Location = new Point(350, 610);
            this.Controls.Add(listekutu3a);
            listekutu3a.Items.Clear();
            for (int i = 1; i <= adet; i++)
            {
                this.Controls.Remove(txtSoru[i - 1]);
                this.Controls.Remove(txtlab[i - 1]);
            }
            adet = Convert.ToInt32(kutu3a.Text);
            string isim;
            string lab;
            txtSoru = new TextBox[adet];
            txtlab = new Label[adet];
            int j = 10;
            int a = 1;
            Button btn3b = new Button();
            btn3b.Text = "Hesapla";
            btn3b.Width = 80;
            btn3b.Height = 50;
            btn3b.Location = new Point(230, 630);
            this.Controls.Add(btn3b);
            btn3b.Click += Btn3b_Click;

            Button btn3c = new Button();
            btn3c.Text = "Temizle";
            btn3c.Width = 80;
            btn3c.Height = 50;
            btn3c.Location = new Point(230, 690);
            this.Controls.Add(btn3c);
            btn3c.Click += Btn3c_Click;
            for (int i = 1; i <= adet; i++)

            {

                txtlab[i - 1] = new Label();
                txtlab[i - 1].Location = new Point(j, 28 * (a + 1));
                txtlab[i - 1].Size = new Size(70, 30);
                txtlab[i - 1].Text = (i).ToString() + ". veri";
                txtSoru[i - 1] = new TextBox();


                txtSoru[i - 1].Location = new Point((j + 70), 28 * (a + 1));

                txtSoru[i - 1].Size = new Size(70, 30);
                this.Controls.Add(txtlab[i - 1]);
                this.Controls.Add(txtSoru[i - 1]);
                txtSoru[i - 1].Name = "txtBox" + i;
                isim = txtSoru[i - 1].Text;
                txtlab[i - 1].Name = "txtLab" + i;
                lab = txtlab[i - 1].Text;
                a++;
                if (i % 20 == 0)
                {
                    j = j + 160;
                    a = 1;
                }


            }
        }

        private void Btn3c_Click(object sender, EventArgs e)
        {
            listekutu3a.Items.Clear();
            for (int i = 1; i <= adet; i++)
            {
                txtSoru[i - 1].Clear();
                //this.Controls.Remove(txtSoru[i - 1]);
                //this.Controls.Remove(txtlab[i - 1]);
            }
        }

        private void Btn3b_Click(object sender, EventArgs e)
        {
            listekutu3a.Items.Clear();
            double [] veriler = new double [adet];
            for (int i = 0; i < adet; i++)
            {
                veriler[i] = Convert.ToDouble(txtSoru[i].Text);
            }
            Array.Sort(veriler);
            for (int i = 0; i < adet; i++)
            {
                listekutu3a.Items.Add(veriler[i]);
            }
        }

        private void yenidenBaşlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        
        private void öDEV1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            // Form1 frm = new Form1();
            //frm.Show();
            yazı1a = new Label();
            yazı1a.Size = new Size(100, 30);
            yazı1a.Location = new Point(80, 80);
            yazı1a.Text = "Başlangıç  ";
            yazı1a.Font = new Font("Microsoft Sans Serif", 14);
            this.Controls.Add(yazı1a);

            yazı1b = new Label();
            yazı1b.Size = new Size(100, 30);
            yazı1b.Location = new Point(80, 160);
            yazı1b.Text = "Bitiş ";
            yazı1b.Font = new Font("Microsoft Sans Serif", 14);
            this.Controls.Add(yazı1b);

            yazı1c = new Label();
            yazı1c.Size = new Size(100, 30);
            yazı1c.Location = new Point(80, 240);
            yazı1c.Text = "Üretilecek Sayı ";
            yazı1c.Font = new Font("Microsoft Sans Serif", 14);
            this.Controls.Add(yazı1c);

            kutu1a = new TextBox();
            kutu1a.Size = new Size(100, 50);
            kutu1a.Location = new Point(190, 80);
            kutu1a.Name = "textBox1";
            this.Controls.Add(kutu1a);

            kutu1b = new TextBox();
            kutu1b.Size = new Size(100, 50);
            kutu1b.Location = new Point(190, 160);
            kutu1b.Name = "textBox2";
            this.Controls.Add(kutu1b);

            kutu1c = new TextBox();
            kutu1c.Size = new Size(100, 50);
            kutu1c.Location = new Point(190, 240);
            kutu1c.Name = "textBox3";
            this.Controls.Add(kutu1c);

            Button btn = new Button();
            btn.Text = "Hesapla";
            btn.Size = new Size(100,50);
            btn.Location = new Point(190, 320);
            this.Controls.Add(btn);

            Button btn1 = new Button();
            btn1.Text = "Temizle";
            btn1.Size = new Size(100, 50);
            btn1.Location = new Point(80, 320);
            this.Controls.Add(btn1);

            btn1.Click += Btn1_Click;
            listekutu1a = new ListBox();
            listekutu1a.Size = new Size(300, 180);
            listekutu1a.Location = new Point(80, 400);
            this.Controls.Add(listekutu1a);
            btn.Click += Btn_Click;

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            listekutu1a.Items.Clear();
            kutu1c.Clear();
            kutu1b.Clear();
            kutu1a.Clear();

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int bas, bit, sayi, uret;
            Random rast = new Random();
            string theText1 = kutu1a.Text;
            string theText2 = kutu1b.Text;
            string theText3 = kutu1c.Text;
            bas = Convert.ToInt32(theText1);
            //MessageBox.Show(theText);
            bit = Convert.ToInt32(theText2);
            sayi = Convert.ToInt32(theText3);
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
            listekutu1a.Items.Clear();

            for (int i = 0; i < sayi; i++)
            {

                listekutu1a.Items.Add(dizi[i]);

            }

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void öDEV2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            yazı2a = new Label();
            yazı2a.Size = new Size(100, 30);
            yazı2a.Location = new Point(80, 80);
            yazı2a.Text = "Büyük N Değeri  ";
            yazı2a.Font = new Font("Microsoft Sans Serif", 14);
            this.Controls.Add(yazı2a);

            yazı2b = new Label();
            yazı2b.Size = new Size(100, 30);
            yazı2b.Location = new Point(80, 160);
            yazı2b.Text = "Küçük n Değeri";
            yazı2b.Font = new Font("Microsoft Sans Serif", 14);
            this.Controls.Add(yazı2b);

            kutu2a = new TextBox();
            kutu2a.Size = new Size(100, 50);
            kutu2a.Location = new Point(190, 80);
            kutu2a.Name = "textBox1";
            this.Controls.Add(kutu2a);

            kutu2b = new TextBox();
            kutu2b.Size = new Size(100, 50);
            kutu2b.Location = new Point(190, 160);
            kutu2b.Name = "textBox2";
            this.Controls.Add(kutu2b);

            listekutu2a = new ListBox();
            listekutu2a.Size = new Size(300, 180);
            listekutu2a.Location = new Point(80, 400);
            this.Controls.Add(listekutu2a);

            Button btn2a = new Button();
            btn2a.Text = "Hesapla";
            btn2a.Size = new Size(100, 50);
            btn2a.Location = new Point(190, 320);
            this.Controls.Add(btn2a);
            btn2a.Click += Btn2a_Click;

            Button btn2b = new Button();
            btn2b.Text = "Temizle";
            btn2b.Size = new Size(100, 50);
            btn2b.Location = new Point(80, 320);
            this.Controls.Add(btn2b);
            btn2b.Click += Btn2b_Click;
        }

        private void Btn2b_Click(object sender, EventArgs e)
        {
            listekutu2a.Items.Clear();
            kutu2b.Clear();
            kutu2a.Clear();
        }

        private void Btn2a_Click(object sender, EventArgs e)
        {
            string Text1 = kutu2a.Text;
            string Text2 = kutu2b.Text;
            int n, kn, k, a;
            n = Convert.ToInt32(Text1);
            kn = Convert.ToInt32(Text2);
            int[] dizi = new int[kn];
            k = n / kn;
            Random rast = new Random();
            a = rast.Next(1, k);
            listekutu2a.Items.Clear();
            for (int i = 0; i < kn; i++)
            {
                dizi[i] = a + i * k;
                listekutu2a.Items.Add(dizi[i]);

            }
        }

        private void dİGERLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Genel frm = new Genel();
            //frm.ShowDialog();

            yazı6a = new Label();
            yazı6a.Size = new Size(100, 25);
            yazı6a.Location = new Point(10, 25);
            yazı6a.Text = "Veri Sayısı ";
            yazı6a.Font = new Font("Microsoft Sans Serif", 14);
            this.Controls.Add(yazı6a);

            kutu6a = new TextBox();
            kutu6a.Size = new Size(50, 60);
            kutu6a.Location = new Point(120, 25);

            this.Controls.Add(kutu6a);

            Button btn6a = new Button();
            btn6a.Text = "Kontrol";
            btn6a.Size = new Size(100, 23);
            btn6a.Location = new Point(250, 25);
            this.Controls.Add(btn6a);
            btn6a.Click += Btn6a_Click;
        }

        private void Btn6a_Click(object sender, EventArgs e)
        {
            //listekutu6a.Items.Clear();
            for (int i = 1; i <= adet1; i++)
            {
                this.Controls.Remove(txtSoru1[i - 1]);
                this.Controls.Remove(txtlab1[i - 1]);

            }
            /* TextBox kutu = new TextBox();
             kutu.Size = new Size(75,36);
             kutu.Location = new Point(800,10);
             this.Controls.Add(kutu);*/
            secim = new CheckBox();
            secim.Size = new Size(200, 20);
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
            yazı.Location = new Point(900, 10);
            yazı.Text = "Yapılacak İşlemleri Seçiniz ";
            this.Controls.Add(yazı);
            listekutu6a = new ListBox();
            listekutu6a.Size = new Size(300, 180);
            listekutu6a.Location = new Point(350, 570);
            this.Controls.Add(listekutu6a);
            listekutu6b = new ListBox();
            listekutu6b.Size = new Size(300, 180);
            listekutu6b.Location = new Point(670, 570);
            this.Controls.Add(listekutu6b);
            adet1 = Convert.ToInt32(kutu6a.Text);
            string isim;
            string lab;
            txtSoru1 = new TextBox[adet1];
            txtlab1 = new Label[adet1];
            int ayar = 10;
            int a = 1;
            btn6b = new Button();
            btn6c = new Button();
            btn6b.Text = "Hesapla";
            btn6b.Width = 80;
            btn6b.Height = 50;
            btn6b.Location = new Point(230, 630);
            this.Controls.Add(btn6b);
            btn6b.Click += Btn6a_Click1;
            btn6c.Text = "Temizle";
            btn6c.Width = 80;
            btn6c.Height = 50;
            btn6c.Location = new Point(230, 690);
            this.Controls.Add(btn6c);
            btn6c.Click += btn6c_Click;
            for (int i = 1; i <= adet1; i++)

            {

                txtlab1[i - 1] = new Label();
                txtlab1[i - 1].Location = new Point(ayar, 32 * (a + 2));
                txtlab1[i - 1].Size = new Size(70, 36);
                txtlab1[i - 1].Text = (i).ToString() + ".Veri";
                txtlab1[i - 1].Font = new Font("Microsoft Sans Serif", 14);
                txtSoru1[i - 1] = new TextBox();


                txtSoru1[i - 1].Location = new Point((ayar + 100), 32 * (a + 2));

                txtSoru1[i - 1].Size = new Size(75, 36);
                this.Controls.Add(txtlab1[i - 1]);
                this.Controls.Add(txtSoru1[i - 1]);
                txtSoru1[i - 1].Name = "txtBox" + i;
                isim = txtSoru1[i - 1].Text;
                txtlab1[i - 1].Name = "txtlab1" + i;
                lab = txtlab1[i - 1].Text;
                a++;
                if (i % 15 == 0)
                {
                    ayar = ayar + 200;
                    a = 1;
                }

            }
        }

        private void btn6c_Click(object sender, EventArgs e)
        {
            //Application.Restart();
            //Thread.Sleep(2000);
            
            //listBox1.Items.Clear();
            for (int i = 1; i <= adet1; i++)
            {
                this.Controls.Remove(txtSoru1[i - 1]);
                this.Controls.Remove(txtlab1[i - 1]);

            }
            this.Controls.Remove(secim);
            this.Controls.Remove(secim1);
            this.Controls.Remove(secim2);
            this.Controls.Remove(secim3);
            this.Controls.Remove(secim4);
            this.Controls.Remove(secim5);
            this.Controls.Remove(secim6);
            this.Controls.Remove(secim7);
            this.Controls.Remove(secim8);
            this.Controls.Remove(secim9);
            this.Controls.Remove(secim10);
            this.Controls.Remove(secim11);
            this.Controls.Remove(secim12);
            this.Controls.Remove(secim13);
            this.Controls.Remove(listekutu6a);
            this.Controls.Remove(listekutu6b);
            this.Controls.Remove(btn6c);
            this.Controls.Remove(btn6b);


            //Genel frm = new Genel();
            //frm.ShowDialog();
            //Thread.Sleep(2000);

        }

        private void Btn6a_Click1(object sender, EventArgs e)
        {
            listekutu6a.Items.Clear();
            listekutu6b.Items.Clear();
            double toplam = 0, geo = 1;
            double[] dizi = new double[adet1];
            double[,] tek = new double[adet1, 2];
            int i1 = 0, i2 = 0, tekrar = 0;
            //sıralama
            int[] veriler = new int[adet1];

            if (secim.Checked)
            {
                for (int i = 0; i < adet1; i++)
                {
                    veriler[i] = Convert.ToInt32(txtSoru1[i].Text);
                }
                Array.Sort(veriler);
                for (int i = 0; i < adet1; i++)
                {
                    listekutu6a.Items.Add(veriler[i]);
                }
            }
            //aritmetik ortalama

            if (secim1.Checked)
            {
                for (int i = 0; i < adet1; i++)
                {
                    dizi[i] = Convert.ToInt32(txtSoru1[i].Text);

                }
                for (int i = 0; i < adet1; i++)
                {
                    toplam = toplam + dizi[i];
                    geo = geo * dizi[i];
                }
                listekutu6b.Items.Add("aritmetik ortalama = " + (double)toplam / adet1);
            }
            //medyan
            if (secim2.Checked)
            {
                if (adet1 % 2 == 0)
                {
                    int orta = adet1 / 2;
                    listekutu6b.Items.Add("Medyan = " + ((double)dizi[orta] + dizi[orta - 1]) / 2);

                }
                else
                {
                    listekutu6b.Items.Add("Medyan = " + (dizi[(adet1 / 2)]));
                }
            }
            //mod
            string gec = "";
            if (secim3.Checked)
            {
                for (int i = 0; i < adet1; i++)
                {

                    for (int j = i; j < adet1; j++)
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

                for (int i = 0; i < adet1; i++)
                {

                    if (tek[i, 1] == i2)
                    {
                        gec = gec + "," + (tek[i, 0] + " ");
                        //listekutu6b.Items.Add("modlar: " + (tek[i, 0] + " "));

                    }
                }
                listekutu6b.Items.Add("Modlar = " + gec);
            }
            //Geometrik ortalama
            if (secim4.Checked)
            {
                listekutu6b.Items.Add("Geometik ortalama = " + Math.Pow(geo, (double)1 / adet1));
            }
            //Harmonik Ortalama
            if (secim5.Checked)
            {
                double degisken = 0;
                for (int i = 0; i < adet1; i++)
                {
                    degisken += (double)1 / dizi[i];
                }
                listekutu6b.Items.Add("Harmonik ortalama = " + adet1 / degisken);
            }
            //varyans starndartsapma  qms q1 q3
            dizi1 = new double[adet1];
            double stand = 0;
            for (int i = 0; i < adet1; i++)
            {
                dizi1[i] = Convert.ToInt32(txtSoru1[i].Text);
            }
            for (int i = 0; i < adet1; i++)
            {
                stand += dizi1[i];
            }
            stand = stand / adet1;
            for (int i = 0; i < adet1; i++)
            {
                çarpıklık += Math.Pow(dizi1[i] - stand, 3);
                basıklık += Math.Pow(dizi1[i] - stand, 4);
                varyans += Math.Pow(dizi1[i] - stand, 2);
                oms += Math.Abs(dizi1[i] - stand);
            }
            oms /= adet1;
            varyans /= adet1 - 1;
            sapma = Math.Sqrt(varyans);
            çarpıklık /= adet1 - 1;
            basıklık /= adet1 - 1;




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



            q1 = hesapla(sfrekansı, sınıfsayısı, adet1 / sınıfsayısı, sınıfgenis);
            q2 = hesapla(sfrekansı, sınıfsayısı, (3 * adet1) / sınıfsayısı, sınıfgenis);
            if (secim6.Checked)
            {
                listekutu6b.Items.Add("Varyans = " + varyans);
            }
            if (secim7.Checked)
            {
                listekutu6b.Items.Add("Standart Sapma = " + sapma);
            }
            if (secim8.Checked)
            {
                listekutu6b.Items.Add("OMS = " + oms);
            }
            if (secim9.Checked)
            {
                listekutu6b.Items.Add("Q1 = " + q1);
            }
            if (secim10.Checked)
            {
                listekutu6b.Items.Add("Q3 = " + q2);
            }
            if (secim11.Checked)
            {
                listekutu6b.Items.Add("carpıklık = " + çarpıklık);
            }
            if (secim12.Checked)
            {
                listekutu6b.Items.Add("Basıklık = " + basıklık);
            }
            if (secim13.Checked)
            {
                listekutu6b.Items.Add("Değişim Katsayısı  =" + (sapma / stand));
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
public class Kume
{
    private int[] intKume; // integer kümesi

    public Kume()
    {
        // COnstructor, intKume = null;
    }

    public int this[int pozisyon]
    {
        get
        {
            return intKume[pozisyon];
        }
    }
    public Kume(int[] parDizi)
    {
        // Constructor, dizi parametre veriliyor, küme oluşturuluyor.
        for (int i = 0; i < parDizi.Length; i++)
            Ekle(parDizi[i]);
    }

    public bool Ekle(int eleman)
    {
        // Kümeye eleman ekliyor. önceden varsa eklemez.
        int adet = 0;
        if (intKume != null)
            adet = intKume.Length;

        if (!VarMi(eleman))
        {
            int[] yeniKume = new int[adet + 1];
            for (int i = 0; i < adet; i++)
                yeniKume[i] = intKume[i];
            yeniKume[adet] = eleman;
            adet++;
            intKume = yeniKume;
            return true;
        }
        return false;
    }

    bool VarMi(int eleman)
    {
        // verilen eleman kümede var mı?
        int adet = 0;
        if (intKume != null)
            adet = intKume.Length;

        for (int i = 0; i < adet; i++)
            if (intKume[i] == eleman)
                return true;
        return false;
    }

    public bool BosKumeMi()
    {
        return ElemanSayisi == 0;
    }

    public int ElemanSayisi
    {
        get
        {
            // Kümenin eleman sayısı
            int adet = 0;
            if (intKume != null)
                adet = intKume.Length;

            return adet;
        }
    }

    public override string ToString()
    {
        // Küme ekrana yazdırılıyor.
        string s = "";
        int adet = 0;
        if (intKume != null)
            adet = intKume.Length;
        s += "{";
        for (int i = 0; i < adet; i++)
        {
            s += intKume[i];
            if (i < adet - 1)
                s += ", ";
        }
        s += "}";
        return s;
    }

    public void Sirala()
    {
        // Küme küçükten büyüğe sıralanıyor.
        // Düzgün ekran çıktıları için kullanıldı.
        int adet = ElemanSayisi;

        for (int i = 0; i < adet - 1; i++)
            for (int j = i + 1; j < adet; j++)
                if (intKume[i] > intKume[j])
                {
                    int temp = intKume[i];
                    intKume[i] = intKume[j];
                    intKume[j] = temp;
                }
    }
    static bool DenkMi(Kume kume1, Kume kume2)
    {
        return kume1.ElemanSayisi == kume2.ElemanSayisi;
    }
    static bool EsitMi(Kume kume1, Kume kume2)
    {
        if (kume1.ElemanSayisi == 0 && kume2.ElemanSayisi == 0) return true;
        if (kume1.ElemanSayisi == 0 || kume2.ElemanSayisi == 0) return false;
        // verilen küme ile kendisini karşılaştırıyor.
        int adet1 = kume1.ElemanSayisi;
        int adet2 = kume2.ElemanSayisi;

        if (adet1 != adet2) return false;

        for (int i = 0; i < adet2; i++)
            if (!kume1.VarMi(kume2[i]))
                return false;
        return true;
    }

    public static Kume operator +(Kume kume1, Kume kume2)
    {
        return kume1 | kume2;
    }

    public static Kume operator |(Kume kume1, Kume kume2)
    {
        return kume1.Birlestir(kume2);
    }

    public static Kume operator &(Kume kume1, Kume kume2)
    {
        return kume1.Kesisim(kume2);
    }

    public static Kume operator /(Kume kume1, Kume kume2)
    {
        Kume yeniKume = new Kume();
        for (int i = 0; i < kume1.ElemanSayisi; i++)
        {
            if (!kume2.VarMi(kume1[i]))
                yeniKume.Ekle(kume1[i]);
        }
        return yeniKume;
    }
    public static bool operator >=(Kume kume1, Kume kume2)
    {
        return Kume.DenkMi(kume1, kume2);
    }
    public static bool operator <=(Kume kume1, Kume kume2)
    {
        return Kume.DenkMi(kume1, kume2);
    }
    public static bool operator ==(Kume kume1, Kume kume2)
    {
        return Kume.EsitMi(kume1, kume2);
    }
    public static bool operator !=(Kume kume1, Kume kume2)
    {
        return !Kume.EsitMi(kume1, kume2);
    }
    public static bool operator >>(Kume kume1, int eleman)
    {
        return kume1.VarMi(eleman);
    }
    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
    Kume Birlestir(Kume kume2)
    {
        // verilen küme ile kendisini birleştirip
        // yeni bir küme elde ediliyor.
        Kume yeniKume = new Kume();

        int adet1 = ElemanSayisi;

        int adet2 = kume2.ElemanSayisi;

        for (int i = 0; i < adet1; i++)
            yeniKume.Ekle(this[i]);

        for (int i = 0; i < adet2; i++)
            if (!VarMi(kume2[i]))
                yeniKume.Ekle(kume2[i]);

        return yeniKume;
    }

    Kume Kesisim(Kume kume2)
    {
        // Verilen küme ile kendisinden
        // Kesişim kümesi elde ediliyor.
        Kume yeniKume = new Kume();

        int adet1 = ElemanSayisi;

        int adet2 = kume2.ElemanSayisi;

        for (int i = 0; i < adet2; i++)
            if (VarMi(kume2[i]))
                yeniKume.Ekle(kume2[i]);
        return yeniKume;
    }

    public Kume[] AltKumeler()
    {
        // Alt kümelerden bir küme dizisi üretiyor.
        int n = this.ElemanSayisi;
        int altKumeSayisi = (int)Math.Pow(2, n);
        Kume[] temp = new Kume[altKumeSayisi];

        for (int i = 0; i < altKumeSayisi; i++)
        {
            temp[i] = new Kume();
            for (int j = 0; j < n; j++)
            {
                if ((i & (int)Math.Pow(2, j)) > 0)
                {
                    temp[i].Ekle(this[j]);
                }
            }
        }
        return temp;
    }

    public static void AltKumeleriYaz(Kume[] altkume)
    {
        // Static method
        // verilen küme dizisini ekrana yazar.
        for (int i = 0; i < altkume.Length; i++)
        {
            bool ilkdefa = true;
            Console.Write("{");
            for (int j = 0; j < altkume[i].ElemanSayisi; j++)
            {
                if (!ilkdefa)
                    Console.Write(", ");
                Console.Write(altkume[i][j]);
                ilkdefa = false;
            }
            Console.WriteLine("}");
        }
    }
}
