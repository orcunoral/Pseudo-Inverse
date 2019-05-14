using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matris
{
    public partial class Form1 : Form
    {
        private List<double> tersList = new List<double>();
        private List<double> matrisList = new List<double>();
        private List<string> islem = new List<string>();

        double[,] Matris;
        double[,] MatrixTranspoze;

        int carpma = 0, toplama = 0, N;
        int satir = 1;
        int sutun = 1;
        int sıra = 0;
        Boolean isCorrect = true;
        List<TextBox> tbx = new List<TextBox>();
        private static readonly Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            pnl.Height = manuel.Height;
            pnl.Top = manuel.Top;
        }

        private void Transpoz()
        {
            Matris = new double[satir, sutun];

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Control ctl = FindControl(this, "tb_" + (i) + "_" + (j));
                    if (ctl.Text.Equals(""))
                    {
                        MessageBox.Show("Lutfen butun degerleri doldurunuz !");
                        isCorrect = false;
                    }
                    else if (!IsDecimalFormat(ctl.Text))
                    {
                        MessageBox.Show("Lutfen sadece rakam giriniz !");
                        isCorrect = false;
                    }
                    else
                    {
                        Matris[i, j] = Convert.ToDouble(ctl.Text);
                    }

                }
            }

            if (isCorrect)
            {
                if (satir != sutun)//Kare matris değilse girer
                {
                    MatrixTranspoze = new double[sutun, satir];
                    //Girilen Matrisin Transpozu
                    for (int i = 0; i < satir; i++)
                    {
                        for (int j = 0; j < sutun; j++)
                        {
                            MatrixTranspoze[j, i] = Matris[i, j];

                        }
                    }

                    double[,] MatrisCarpim = MatrixCarp(Matris, MatrixTranspoze);//A*AT

                    double[,] MatrisCarpim2 = MatrixCarp(MatrixTranspoze, Matris);//AT*A
                    double det1 = DeterminantHesap(MatrisCarpim);
                    double det2 = DeterminantHesap(MatrisCarpim2);
                    Console.WriteLine(det1);
                    Console.WriteLine(det2);
                    //Oluşan matris satir*satir
                    if (satir < sutun)
                    {
                        if (det1 != 0)
                        {
                            N = MatrisCarpim.GetLength(0);
                            sıra = 1;
                            CarpimYazdirma(MatrisCarpim);
                            TersBulma(MatrisCarpim);
                        }
                        else
                        {
                            if (det2 != 0)
                            {
                                N = MatrisCarpim2.GetLength(0);
                                sıra = 2;
                                CarpimYazdirma(MatrisCarpim);
                                TersBulma(MatrisCarpim2);
                            }
                        }
                    }
                    //Oluşan matris sutun*sutun
                    else if (det2 != 0)
                    {
                        N = MatrisCarpim2.GetLength(0);
                        sıra = 2;
                        CarpimYazdirma(MatrisCarpim2);
                        TersBulma(MatrisCarpim2);
                    }
                    else if (det1 != 0)
                    {
                        N = MatrisCarpim.GetLength(0);
                        sıra = 1;
                        CarpimYazdirma(MatrisCarpim);
                        TersBulma(MatrisCarpim);
                    }

                    if (det1 == 0 && det2 == 0)
                    {
                        sıra = -1;
                        text_box_26.Text = "Girilen matrisinin determinantı 0 olduğu için tersi alınamaz.";
                    }
                    TersYazdirma();
                }
                else//Kare matris ters bulma
                {
                    if (DeterminantHesap(Matris) != 0)
                    {
                        N = Matris.GetLength(0);
                        TersBulma(Matris);
                        TersYazdirma();
                        sıra = 3;
                    }
                    else
                    {
                        sıra = -1;
                        text_box_26.Text = "Girilen matrisinin determinantı 0 olduğu için tersi alınamaz.";
                    }
                }
            }
        }

        double[,] MatrixCarp(double[,] Matrix1, double[,] Matrix2)
        {
            int satir = Matrix1.GetLength(0);
            int sutun = Matrix2.GetLength(1);
            Console.WriteLine("satir = " + satir + " sutun = " + sutun);

            double[,] MatrixCarpim = new double[satir, sutun];

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    MatrixCarpim[i, j] = 0;
                    for (int k = 0; k < Matrix1.GetLength(1); k++)
                    {
                        MatrixCarpim[i, j] = MatrixCarpim[i, j] + Matrix1[i, k] * Matrix2[k, j];
                        toplama++;
                        carpma++;
                    }
                    Console.Write(MatrixCarpim[i, j] + "\t");
                }
                Console.WriteLine();
            }
            return MatrixCarpim;
        }

        private double DeterminantHesap(double[,] matris)
        {
            int boyut = Convert.ToInt32(Math.Sqrt(matris.Length));
            double isaret = 1;
            double toplam = 0;
            if (boyut == 1)
                return matris[0, 0];
            for (int i = 0; i < boyut; i++)
            {
                double[,] altMatris = new double[boyut - 1, boyut - 1];
                for (int satir = 1; satir < boyut; satir++)
                {
                    for (int sutun = 0; sutun < boyut; sutun++)
                    {
                        if (sutun < i)
                            altMatris[satir - 1, sutun] = matris[satir, sutun];
                        else if (sutun > i)
                            altMatris[satir - 1, sutun - 1] = matris[satir, sutun];
                    }
                }
                if (i % 2 == 0)
                    isaret = 1;
                else
                    isaret = -1;

                toplam += isaret * matris[0, i] * (DeterminantHesap(altMatris));

            }

            return toplam;
        }

        private void TersBulma(double[,] matris)
        {
            double[,] tersMatris = new double[matris.GetLength(0), matris.GetLength(0)];
            //Ters matrisi birim matrise çevirme
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(0); j++)
                {
                    if (i == j)
                    {
                        tersMatris[i, j] = 1;
                    }
                    else
                    {
                        tersMatris[i, j] = 0;
                    }
                    tersList.Add(tersMatris[i, j]);
                    matrisList.Add(matris[i, j]);
                }
            }

            double a, b;
            //Gauss Jordan yöntemi ile ters bulma
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                a = matris[i, i];

                for (int j = 0; j < matris.GetLength(0); j++)
                {
                    matris[i, j] = matris[i, j] / a;
                    tersMatris[i, j] = tersMatris[i, j] / a;
                    carpma++;
                }
                islem.Add((i + 1) + "S" + " / " + string.Format("{0:0.0##}", a) + " => " + (i + 1) + "S");

                for (int x = 0; x < matris.GetLength(0); x++)
                {
                    if (x != i)
                    {
                        b = matris[x, i];
                        for (int j = 0; j < matris.GetLength(0); j++)
                        {
                            matris[x, j] = matris[x, j] - (matris[i, j] * b);
                            tersMatris[x, j] = tersMatris[x, j] - (tersMatris[i, j] * b);
                            toplama++;
                            carpma++;
                        }
                        islem.Add((x + 1) + "S" + " - " + "(" + (i + 1) + "S" + "*" + string.Format("{0:0.0##}", b) + ")" + " => " + (x + 1) + "S");

                    }
                }
                for (int k = 0; k < matris.GetLength(0); k++)
                {
                    for (int t = 0; t < matris.GetLength(0); t++)
                    {
                        tersList.Add(tersMatris[k, t]);
                        matrisList.Add(matris[k, t]);
                    }
                }
            }
            if (sıra == 1)
            {
                Matris = MatrixCarp(MatrixTranspoze, tersMatris);
            }
            else if (sıra == 2)
            {
                Matris = MatrixCarp(tersMatris, MatrixTranspoze);
            }
            else if (sıra == 3)
            {
                Matris = tersMatris;
            }

        }

        private void CarpimYazdirma(double[,] carpımMatrisi)
        {
            double[,] Dizi1;
            double[,] Dizi2;

            if (sıra == 1)//at*a
            {
                text_box_26.Text += "Girilen Matris İle Transpoz Çarpımı(A*AT)\r\n";
                text_box_26.Text += "-----------------------------------------------------\r\n";
                Dizi1 = Matris;
                Dizi2 = MatrixTranspoze;
            }
            else//a*at
            {
                text_box_26.Text += "Girilen Matris İle Transpoz Çarpımı(AT*A)\r\n";
                text_box_26.Text += "------------------------------------------------------\r\n";
                Dizi1 = MatrixTranspoze;
                Dizi2 = Matris;
            }
            int str = 0, stn = 0;
            if (Dizi1.GetLength(0) < Dizi1.GetLength(1))
            {
                str = Dizi1.GetLength(1);
                stn = Dizi1.GetLength(0);
            }
            else
            {
                str = Dizi1.GetLength(0);
                stn = Dizi1.GetLength(1);
            }
            for (int i = 0; i < str; i++)
            {
                if (i < Dizi1.GetLength(0))
                {
                    text_box_26.Text += "| ";

                    for (int j = 0; j < str; j++)
                    {
                        text_box_26.Text += Dizi1[i, j] + "  ";
                    }
                    text_box_26.Text += "|";
                }
                else
                {
                    text_box_26.Text += "\r\t";
                    if (str > 4)
                        text_box_26.Text += "\r\t";
                }
                if (i == Dizi1.GetLength(0) - 1)
                {
                    text_box_26.Text += "      X      ";
                }
                else
                {
                    text_box_26.Text += "\r\t";
                }
                text_box_26.Text += " | ";
                for (int k = 0; k < stn; k++)
                {
                    text_box_26.Text += Dizi2[i, k] + "  ";
                }
                text_box_26.Text += "|\r\n";
            }

            if (sıra == 1)//at*a
            {
                text_box_26.Text += "\r\n(A*AT)=\r\n";
            }
            else
                text_box_26.Text += "(AT*A)\r\n";
            for(int i = 0; i < carpımMatrisi.GetLength(0); i++)
            {
                text_box_26.Text += "| ";
                for (int j = 0; j < carpımMatrisi.GetLength(1); j++)
                {
                    text_box_26.Text += carpımMatrisi[i, j] + "  ";
                }
                text_box_26.Text += "|\r\n";
            }
        }

        private void TersYazdirma()
        {
            text_box_26.Text += "\r\nGauss Jordan Yöntemi İle Ters Alma İşlemleri \r\n";
            text_box_26.Text += "--------------------------------------------------------------\r\n";
            int j = 0, t = 0;
            text_box_26.Text += "| ";
            for (int i = 1; i <= matrisList.Count; i++)
            {

                text_box_26.Text += matrisList.ElementAt(i - 1).ToString("F1") + "  ";


                if (i % N == 0)
                {
                    text_box_26.Text += "| ";
                    while (j < i)
                    {
                        text_box_26.Text += tersList.ElementAt(j).ToString("F1") + "  ";
                        j++;
                    }

                    j = i;
                    text_box_26.Text += "|";
                    text_box_26.Text += "\r\n";

                    if (i % (N * N) == 0)
                    {
                        text_box_26.Text += "\r\n";
                        if (t < islem.Count)
                        {
                            for (int k = t; k < (islem.Count / N) + t; k++)
                            {
                                text_box_26.Text += islem.ElementAt(k).ToString() + "\r\n";
                            }
                            t += N;
                        }

                        text_box_26.Text += "\r\n";
                    }
                    if (i != matrisList.Count)
                        text_box_26.Text += "| ";
                }
            }

        }

        private void SonucYazdirma()
        {
            text_box_26.Text += "GİRİLEN MATRİSİN SÖZDE TERSİ \r\n";
            text_box_26.Text += "------------------------------------------------\r\n";
            if (sıra == 1)
            {
                text_box_26.Text += "AT * (A*AT)^-1=\r\n";
            }
            else
                text_box_26.Text += "(AT*A)^-1 * AT=\r\n";
            text_box_26.Text += "\r\n";
            for (int i = 0; i < Matris.GetLength(0); i++)
            {
                text_box_26.Text += "| ";
                for (int j = 0; j < Matris.GetLength(1); j++)
                {
                    text_box_26.Text += Matris[i, j].ToString("F3") + "  ";
                }
                text_box_26.Text += "|\r\n";
            }
        }
  
        private void HesaplaBtn_Click(object sender, EventArgs e)
        {
            Matris = new double[0, 0];
            MatrixTranspoze = new double[0,0];
            toplama = 0;
            carpma = 0;
            tersList.Clear();
            matrisList.Clear();
            islem.Clear();
            text_box_26.Clear();

            Transpoz();
            if (sıra != -1)
            {
                text_box_26.Text += "Toplama Sayısı:" + toplama + " / Çarpma Sayısı:" + carpma + "\r\n" + "\r\n";
                SonucYazdirma();
            }
        }

        private void Sutun_arttir_Click(object sender, EventArgs e)
        {
            if (sutun != 5)
            {
                for (int i = 0; i < satir; i++)
                {
                    TextBox tb = new TextBox();
                    Point p = new Point(203 + (sutun * 35), 64 + (i * 25));
                    tb.Location = p;
                    tb.Size = new System.Drawing.Size(30, 20);
                    tb.Name = "tb_" + (i) + "_" + sutun;
                    this.Controls.Add(tb);
                    tbx.Add(tb);
                }
                sutun++;
                matris_size.Text = satir + "x" + sutun;
            }
        }

        private void Sutun_azalt_Click(object sender, EventArgs e)
        {
            if (sutun != 1)
            {            
                foreach (TextBox tb_Control in tbx)
                {
                    string[] subStrings = tb_Control.Name.Split('_');
                    if (subStrings[2].Equals((sutun - 1).ToString()))
                    {
                        this.Controls.Remove(tb_Control);
                    }
                }
                sutun--;
                matris_size.Text = satir + "x" + sutun;
            }
        }

        private void Satir_arttir_Click(object sender, EventArgs e)
        {

            if (satir != 5)
            {
                for (int i = 0; i < sutun; i++)
                {
                    TextBox tb = new TextBox
                    {
                        Location= new Point(203 + (i * 35), 64 + (satir * 25)),
                        Size = new System.Drawing.Size(30, 20),
                        Name = "tb_" + satir + "_" + (i)
                    };            
                    this.Controls.Add(tb);
                    tbx.Add(tb);
                }
                satir++;
                matris_size.Text = satir + "x" + sutun;
            }
        }

        private void Satir_azalt_Click(object sender, EventArgs e)
        {
            if (satir != 1)
            {
                foreach(TextBox tb_Control in tbx)
                {
                    string[] subStrings = tb_Control.Name.Split('_');

                    if (subStrings[1].Equals((satir - 1).ToString()))
                    {
                        this.Controls.Remove(tb_Control);
                    }
                }
                satir--;
                matris_size.Text = satir + "x" + sutun;
            }
        }

        private void Textbox_Olusturma()
        {
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    TextBox tb = new TextBox
                    {
                        Location = new Point(203 + (j * 35), 64 + (i * 25)),
                        Size = new System.Drawing.Size(30, 20),
                        Name = "tb_" + (i) + "_" + (j)
                    };
                    this.Controls.Add(tb);
                    tbx.Add(tb);
                }
            }
            matris_size.Text = satir + "x" + sutun;
        }

        private void Auto_button_Click(object sender, EventArgs e)
        {
            pnl.Height = auto_button.Height;
            pnl.Top = auto_button.Top;
            sutun_arttir.Hide(); sutun_azalt.Hide(); satir_arttir.Hide(); satir_azalt.Hide();
            satir = random.Next(1, 6);
            sutun = random.Next(1, 6);
            foreach (TextBox tb in tbx)
            {
                this.Controls.Remove(tb);
            }
            tbx.Clear();
            Textbox_Olusturma();
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Control ctl = FindControl(this, "tb_" + (i) + "_" + (j));
                    ctl.Text = SayiAralıgı(0, 9).ToString("F1");
                }
            }
        }

        private void Manuel_Click(object sender, EventArgs e)
        {
            pnl.Top = manuel.Top;
            sutun_arttir.Show(); sutun_azalt.Show(); satir_arttir.Show(); satir_azalt.Show();
            satir = 1;
            sutun = 1;
            tb_0_0.Clear();
            foreach (TextBox tb in tbx)
            {
                this.Controls.Remove(tb);
            }
            tbx.Clear(); Textbox_Olusturma();

        }

        private static double SayiAralıgı(double minValue, double maxValue)
        {
            var next = random.NextDouble();

            return minValue + (next * (maxValue - minValue));
        }

        public static Control FindControl(Control parent, string ctlName)
        {
            foreach (Control ctl in parent.Controls)
            {
                if (ctl.Name.Equals(ctlName))
                {
                    return ctl;
                }

                FindControl(ctl, ctlName);
            }
            return null;
        }

        bool IsDecimalFormat(string input)
        {
            Decimal dummy;
            return Decimal.TryParse(input, out dummy);
        }
    }
}
