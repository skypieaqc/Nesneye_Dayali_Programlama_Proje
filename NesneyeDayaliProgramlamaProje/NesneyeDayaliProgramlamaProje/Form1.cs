/****************************************************************************
**                          SAKARYA ÜNÝVERSÝTESÝ
**                   BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
**                      BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**                      PROGRAMLAMAYA GÝRÝÞÝ DERSÝ
**
**          ÖDEV NUMARASI: 1
**          ÖÐRENCÝ ADI: Ahmet Yunus Çavuþ
**          ÖÐRENCÝ NUMARASI: B221210082
**          DERS GRUBU:1. Öðretim B Grubu
**          YOUTUBE LÝNKÝ: ******************
**
**
**
****************************************************************************/


namespace NesneyeDayaliProgramlamaProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioCember1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCember1.Checked == true)
            {
                panel1.Controls.Clear();
                panel1.Refresh();

                Graphics g = panel1.CreateGraphics();

                Pen p = new Pen(Color.Red);

                g.DrawEllipse(p, 50, 50, 200, 200);
            }



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioKure1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioKure1.Checked == true)
            {
                panel1.Controls.Clear();
                panel1.Refresh();

                Graphics g = panel1.CreateGraphics();

                Pen p = new Pen(Color.Red);

                g.DrawEllipse(p, 50, 50, 200, 200);

                g.DrawEllipse(p, 50, 100, 200, 90);
            }
        }

        private void radioDikd1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioDikd1.Checked == true)
            {
                panel1.Controls.Clear();
                panel1.Refresh();

                Graphics g = panel1.CreateGraphics();

                Pen p = new Pen(Color.Red);

                g.DrawRectangle(p, 50, 50, 200, 250);
            }
        }

        private void radioDikdPrizma1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDikdPrizma1.Checked == true)
            {
                panel1.Controls.Clear();
                panel1.Refresh();

                Graphics g = panel1.CreateGraphics();

                Pen p = new Pen(Color.Red);

                g.DrawRectangle(p, 50, 50, 100, 100);

                g.DrawRectangle(p, 200, 200, 100, 100);

                g.DrawLine(p, 50, 50, 200, 200);
                g.DrawLine(p, 150, 50, 300, 200);
                g.DrawLine(p, 50, 150, 200, 300);
                g.DrawLine(p, 150, 150, 300, 300);
            }
        }

        private void radioSilindir1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSilindir1.Checked == true)
            {
                panel1.Controls.Clear();
                panel1.Refresh();

                Graphics g = panel1.CreateGraphics();

                Pen p = new Pen(Color.Red);

                g.DrawEllipse(p, 50, 50, 150, 50);

                g.DrawEllipse(p, 50, 200, 150, 50);

                g.DrawLine(p, 50, 73, 50, 225);

                g.DrawLine(p, 200, 73, 200, 225);
            }
        }

        private void radioNokta1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNokta1.Checked == true)
            {
                panel1.Controls.Clear();
                panel1.Refresh();

                Graphics g = panel1.CreateGraphics();

                Pen p = new Pen(Color.Red);

                g.DrawRectangle(p, 150, 150, 1, 1);
                g.DrawRectangle(p, 148, 148, 3, 3);
                g.DrawRectangle(p, 149, 149, 2, 2);
            }
        }

        private void radioCember2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCember2.Checked == true)
            {
                panel2.Controls.Clear();
                panel2.Refresh();

                Graphics g = panel2.CreateGraphics();

                Pen p = new Pen(Color.Red);

                g.DrawEllipse(p, 50, 50, 200, 200);
            }
        }

        private void radioKure2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioKure2.Checked == true)
            {
                panel2.Controls.Clear();
                panel2.Refresh();

                Graphics g = panel2.CreateGraphics();

                Pen p = new Pen(Color.Red);

                g.DrawEllipse(p, 50, 50, 200, 200);

                g.DrawEllipse(p, 50, 100, 200, 90);

            }
        }

        private void radioDikd2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDikd2.Checked == true)
            {
                panel2.Controls.Clear();
                panel2.Refresh();

                Graphics g = panel2.CreateGraphics();

                Pen p = new Pen(Color.Red);

                g.DrawRectangle(p, 50, 50, 200, 250);
            }
        }

        private void radioDikdPrizma2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDikdPrizma2.Checked == true)
            {
                panel2.Controls.Clear();
                panel2.Refresh();

                Graphics g = panel2.CreateGraphics();

                Pen p = new Pen(Color.Red);

                g.DrawRectangle(p, 50, 50, 100, 100);

                g.DrawRectangle(p, 200, 200, 100, 100);

                g.DrawLine(p, 50, 50, 200, 200);
                g.DrawLine(p, 150, 50, 300, 200);
                g.DrawLine(p, 50, 150, 200, 300);
                g.DrawLine(p, 150, 150, 300, 300);

            }
        }

        private void radioSilindir2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSilindir2.Checked == true)
            {
                panel2.Controls.Clear();
                panel2.Refresh();

                Graphics g = panel2.CreateGraphics();

                Pen p = new Pen(Color.Red);

                g.DrawEllipse(p, 50, 50, 150, 50);

                g.DrawEllipse(p, 50, 200, 150, 50);

                g.DrawLine(p, 50, 73, 50, 225);

                g.DrawLine(p, 200, 73, 200, 225);
            }
        }

        private void radioNokta2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNokta2.Checked == true)
            {
                panel2.Controls.Clear();
                panel2.Refresh();

                Graphics g = panel2.CreateGraphics();

                Pen p = new Pen(Color.Red);

                g.DrawRectangle(p, 150, 150, 1, 1);
                g.DrawRectangle(p, 148, 148, 3, 3);
                g.DrawRectangle(p, 149, 149, 2, 2);
            }
        }

        private void butonTEST_Click(object sender, EventArgs e)
        {
            dikdortgen d1 = new dikdortgen();
            dikdortgen d2 = new dikdortgen();

            DikdortgenlerPrizma dp1 = new DikdortgenlerPrizma();
            DikdortgenlerPrizma dp2 = new DikdortgenlerPrizma();

            cember c1 = new cember();
            cember c2 = new cember();

            Kure k1 = new Kure();
            Kure k2 = new Kure();

            Silindir s1 = new Silindir();
            Silindir s2 = new Silindir();

            Point p1 = new Point();
            Point p2 = new Point();

            Point3D p3d1 = new Point3D();
            Point3D p3d2 = new Point3D();

            if (radioCember1.Checked == true && radioCember2.Checked == true)
            {
                c1.R = Convert.ToInt32(textR1.Text);
                c1.P.X = Convert.ToInt32(textX1.Text);
                c1.P.Y = Convert.ToInt32(textY1.Text);

                c2.R = Convert.ToInt32(textR2.Text);
                c2.P.X = Convert.ToInt32(textX2.Text);
                c2.P.Y = Convert.ToInt32(textY2.Text);

                if (Carpisma.CemberCemberCarpisma(c1, c2))
                    textBox1.Text = "CARPISMA GERCEKLESTI";
                else
                    textBox1.Text = "carpisma gerceklesmedi";
            }

            else if (radioCember1.Checked == true && radioDikd2.Checked == true)
            {
                c1.R = Convert.ToInt32(textR1.Text);
                c1.P.X = Convert.ToInt32(textX1.Text);
                c1.P.Y = Convert.ToInt32(textY1.Text);

                d2.EN = Convert.ToInt32(textEn2.Text);
                d2.BOY = Convert.ToInt32(textBoy2.Text);

                d2.P.X = Convert.ToInt32(textX2.Text);
                d2.P.Y = Convert.ToInt32(textY2.Text);

                if (Carpisma.CemberDikdortgenCarpisma(c1, d2))
                    textBox1.Text = "CARPISMA GERCEKLESTI";
                else
                    textBox1.Text = "carpisma gerceklesmedi";
            }

            else if (radioCember1.Checked == true && radioNokta2.Checked == true)
            {
                c1.R = Convert.ToInt32(textR1.Text);
                c1.P.X = Convert.ToInt32(textX1.Text);
                c1.P.Y = Convert.ToInt32(textY1.Text);

                p2.X = Convert.ToInt32(textX2.Text);
                p2.Y = Convert.ToInt32(textY2.Text);

                if (Carpisma.NoktaCemberCarpisma(p1, c1))
                    textBox1.Text = "CARPISMA GERCEKLESTI";
                else
                    textBox1.Text = "carpisma gerceklesmedi";
            }

            else if (radioCember2.Checked == true && radioDikd1.Checked == true)
            {
                c2.R = Convert.ToInt32(textR2.Text);
                c2.P.X = Convert.ToInt32(textX2.Text);
                c2.P.Y = Convert.ToInt32(textY2.Text);

                d1.EN = Convert.ToInt32(textEn1.Text);
                d1.BOY = Convert.ToInt32(textBoy1.Text);

                d1.P.X = Convert.ToInt32(textX1.Text);
                d1.P.Y = Convert.ToInt32(textY1.Text);

                if (Carpisma.CemberDikdortgenCarpisma(c2, d1))
                    textBox1.Text = "CARPISMA GERCEKLESTI";
                else
                    textBox1.Text = "carpisma gerceklesmedi";
            }

            else if (radioCember2.Checked == true && radioNokta1.Checked == true)
            {
                c2.R = Convert.ToInt32(textR2.Text);
                c2.P.X = Convert.ToInt32(textX2.Text);
                c2.P.Y = Convert.ToInt32(textY2.Text);

                p1.X = Convert.ToInt32(textX1.Text);
                p1.Y = Convert.ToInt32(textY1.Text);

                if (Carpisma.NoktaCemberCarpisma(p1, c2))
                    textBox1.Text = "CARPISMA GERCEKLESTI";
                else
                    textBox1.Text = "carpisma gerceklesmedi";
            }

            else if (radioKure1.Checked == true && radioKure2.Checked == true)
            {
                k1.P.X = Convert.ToInt32(textX1.Text);
                k1.P.Y = Convert.ToInt32(textY1.Text);
                k1.P.Z = Convert.ToInt32(textZ1.Text);
                k1.R = Convert.ToInt32(textR1.Text);

                k2.R = Convert.ToInt32(textR2.Text);
                k2.P.X = Convert.ToInt32(textX2.Text);
                k2.P.Y = Convert.ToInt32(textY2.Text);
                k2.P.Z = Convert.ToInt32(textZ2.Text);

                if (Carpisma.KureKureCarpisma(k1, k2))
                    textBox1.Text = "CARPISMA GERCEKLESTI";
                else
                    textBox1.Text = "carpisma gerceklesmedi";
            }

            else if (radioKure1.Checked == true && radioDikdPrizma2.Checked == true)
            {
                k1.P.X = Convert.ToInt32(textX1.Text);
                k1.P.Y = Convert.ToInt32(textY1.Text);
                k1.P.Z = Convert.ToInt32(textZ1.Text);
                k1.R = Convert.ToInt32(textR1.Text);

                dp2.EN = Convert.ToInt32(textEn2.Text);
                dp2.BOY = Convert.ToInt32(textBoy2.Text);
                dp2.DERINLIK = Convert.ToInt32(textDerinlik2.Text);

                dp2.P.X = Convert.ToInt32(textX2.Text);
                dp2.P.Y = Convert.ToInt32(textY2.Text);
                dp2.P.Z = Convert.ToInt32(textZ2.Text);

                if (Carpisma.KureDikdortgenPCarpisma(k1, dp2))
                    textBox1.Text = "CARPISMA GERCEKLESTI";
                else
                    textBox1.Text = "carpisma gerceklesmedi";
            }

            else if (radioKure1.Checked == true && radioNokta2.Checked == true)
            {
                k1.P.X = Convert.ToInt32(textX1.Text);
                k1.P.Y = Convert.ToInt32(textY1.Text);
                k1.P.Z = Convert.ToInt32(textZ1.Text);
                k1.R = Convert.ToInt32(textR1.Text);

                p3d2.X = Convert.ToInt32(textX2.Text);
                p3d2.Y = Convert.ToInt32(textY2.Text);
                p3d2.Z = Convert.ToInt32(textZ2.Text);
                if (Carpisma.NoktaKureCarpisma(p3d2, k1))
                    textBox1.Text = "CARPISMA GERCEKLESTI";
                else
                    textBox1.Text = "carpisma gerceklesmedi";
            }

            else if (radioKure2.Checked == true && radioDikdPrizma1.Checked == true)
            {
                k2.R = Convert.ToInt32(textR2.Text);
                k2.P.X = Convert.ToInt32(textX2.Text);
                k2.P.Y = Convert.ToInt32(textY2.Text);
                k2.P.Z = Convert.ToInt32(textZ2.Text);

                dp1.EN = Convert.ToInt32(textEn1.Text);
                dp1.BOY = Convert.ToInt32(textBoy1.Text);
                dp1.DERINLIK = Convert.ToInt32(textDerinlik1.Text);

                dp1.P.X = Convert.ToInt32(textX1.Text);
                dp1.P.Y = Convert.ToInt32(textY1.Text);
                dp1.P.Z = Convert.ToInt32(textZ1.Text);

                if (Carpisma.KureDikdortgenPCarpisma(k2, dp1))
                    textBox1.Text = "CARPISMA GERCEKLESTI";
                else
                    textBox1.Text = "carpisma gerceklesmedi";

            }

            else if (radioKure2.Checked == true && radioNokta1.Checked == true)
            {
                k2.R = Convert.ToInt32(textR2.Text);
                k2.P.X = Convert.ToInt32(textX2.Text);
                k2.P.Y = Convert.ToInt32(textY2.Text);
                k2.P.Z = Convert.ToInt32(textZ2.Text);

                p3d1.X = Convert.ToInt32(textX1.Text);
                p3d1.Y = Convert.ToInt32(textY1.Text);
                p3d1.Z = Convert.ToInt32(textZ1.Text);

                if (Carpisma.NoktaKureCarpisma(p3d1, k1))
                    textBox1.Text = "CARPISMA GERCEKLESTI";
                else
                    textBox1.Text = "carpisma gerceklesmedi";
            }

            else if (radioDikd1.Checked == true && radioDikd2.Checked == true)
            {
                d1.EN = Convert.ToInt32(textEn1.Text);
                d1.BOY = Convert.ToInt32(textBoy1.Text);

                d1.P.X = Convert.ToInt32(textX1.Text);
                d1.P.Y = Convert.ToInt32(textY1.Text);

                d2.EN = Convert.ToInt32(textEn2.Text);
                d2.BOY = Convert.ToInt32(textBoy2.Text);

                d2.P.X = Convert.ToInt32(textX2.Text);
                d2.P.Y = Convert.ToInt32(textY2.Text);

                if (Carpisma.DikdortgenDikdortgenCarpisma(d1, d2))
                    textBox1.Text = "CARPISMA GERCEKLESTI";
                else
                    textBox1.Text = "carpisma gerceklesmedi";
            }

            else if (radioDikd1.Checked == true && radioNokta2.Checked == true)
            {
                d1.EN = Convert.ToInt32(textEn1.Text);
                d1.BOY = Convert.ToInt32(textBoy1.Text);

                d1.P.X = Convert.ToInt32(textX1.Text);
                d1.P.Y = Convert.ToInt32(textY1.Text);

                p2.X = Convert.ToInt32(textX2.Text);
                p2.Y = Convert.ToInt32(textY2.Text);

                if(Carpisma.NoktaDikdortgenCarpisma(p2,d1))
                    textBox1.Text = "CARPISMA GERCEKLESTI";
                else
                    textBox1.Text = "carpisma gerceklesmedi";
            }

            else if (radioDikd2.Checked == true && radioNokta1.Checked == true)
            {
                d2.EN = Convert.ToInt32(textEn2.Text);
                d2.BOY = Convert.ToInt32(textBoy2.Text);

                d2.P.X = Convert.ToInt32(textX2.Text);
                d2.P.Y = Convert.ToInt32(textY2.Text);

                p1.X = Convert.ToInt32(textX1.Text);
                p1.Y = Convert.ToInt32(textY1.Text);

                if (Carpisma.NoktaDikdortgenCarpisma(p1, d2))
                    textBox1.Text = "CARPISMA GERCEKLESTI";
                else
                    textBox1.Text = "carpisma gerceklesmedi";
            }

            else if(radioDikdPrizma1.Checked==true && radioDikdPrizma2.Checked == true)
            {
                dp1.EN = Convert.ToInt32(textEn1.Text);
                dp1.BOY = Convert.ToInt32(textBoy1.Text);
                dp1.DERINLIK = Convert.ToInt32(textDerinlik1.Text);

                dp1.P.X = Convert.ToInt32(textX1.Text);
                dp1.P.Y = Convert.ToInt32(textY1.Text);
                dp1.P.Z = Convert.ToInt32(textZ1.Text);

                dp2.EN = Convert.ToInt32(textEn2.Text);
                dp2.BOY = Convert.ToInt32(textBoy2.Text);
                dp2.DERINLIK = Convert.ToInt32(textDerinlik2.Text);

                dp2.P.X = Convert.ToInt32(textX2.Text);
                dp2.P.Y = Convert.ToInt32(textY2.Text);
                dp2.P.Z = Convert.ToInt32(textZ2.Text);

                if(Carpisma.DikdortgenPDikdortgenPCarpisma(dp1,dp2))
                    textBox1.Text = "CARPISMA GERCEKLESTI";
                else
                    textBox1.Text = "carpisma gerceklesmedi";

            }
             
            else if(radioDikdPrizma1.Checked==true && radioNokta2.Checked == true)
            {
                dp1.EN = Convert.ToInt32(textEn1.Text);
                dp1.BOY = Convert.ToInt32(textBoy1.Text);
                dp1.DERINLIK = Convert.ToInt32(textDerinlik1.Text);

                dp1.P.X = Convert.ToInt32(textX1.Text);
                dp1.P.Y = Convert.ToInt32(textY1.Text);
                dp1.P.Z = Convert.ToInt32(textZ1.Text);

                p3d2.X = Convert.ToInt32(textX2.Text);
                p3d2.Y = Convert.ToInt32(textY2.Text);
                p3d2.Z = Convert.ToInt32(textZ2.Text);

                if(Carpisma.NoktaDikdortgenPrizmaCarpisma(p3d2, dp1))
                    textBox1.Text = "CARPISMA GERCEKLESTI";
                else
                    textBox1.Text = "carpisma gerceklesmedi";

            }

            else if (radioDikdPrizma2.Checked == true && radioNokta1.Checked == true)
            {
                dp2.EN = Convert.ToInt32(textEn2.Text);
                dp2.BOY = Convert.ToInt32(textBoy2.Text);
                dp2.DERINLIK = Convert.ToInt32(textDerinlik2.Text);

                dp2.P.X = Convert.ToInt32(textX2.Text);
                dp2.P.Y = Convert.ToInt32(textY2.Text);
                dp2.P.Z = Convert.ToInt32(textZ2.Text);

                p3d1.X = Convert.ToInt32(textX1.Text);
                p3d1.Y = Convert.ToInt32(textY1.Text);
                p3d1.Z = Convert.ToInt32(textZ1.Text);

                if (Carpisma.NoktaDikdortgenPrizmaCarpisma(p3d1, dp2))
                    textBox1.Text = "CARPISMA GERCEKLESTI";
                else
                    textBox1.Text = "carpisma gerceklesmedi";

            }

            else if (radioSilindir1.Checked==true && radioSilindir2.Checked == true)
            {
                s1.R = Convert.ToInt32(textR1.Text);
                s1.H = Convert.ToInt32(textH1.Text);

                s1.P.X = Convert.ToInt32(textX1.Text);
                s1.P.Y = Convert.ToInt32(textY1.Text);
                s1.P.Z = Convert.ToInt32(textZ1.Text);

                s2.R = Convert.ToInt32(textR2.Text);
                s2.H = Convert.ToInt32(textH2.Text);

                s2.P.X = Convert.ToInt32(textX2.Text);
                s2.P.Y = Convert.ToInt32(textY2.Text);
                s2.P.Z = Convert.ToInt32(textZ2.Text);

                if (Carpisma.SilindirSilindirCarpisma(s1, s2))
                    textBox1.Text = "Carpisma Gerceklesmistir";
                else
                    textBox1.Text = "Carpisma Gerceklesmemistir";

            }
        }
    }
}