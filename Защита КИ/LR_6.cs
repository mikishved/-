using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
namespace Защита_КИ
{
    public partial class LR_6 : Form
    {
        long[] masA;
        long[] masB;
        int dlina;
        double X;
        double P;
        long[] masa;
        long[] masb;

        public LR_6()
        {
            InitializeComponent();
        }
        public bool Prost(double N)
        {
            if (N == 1 || N == 2 || N == 3)
                return true;
            for (int i = 2; i <= (N - 1); i++)
            {
                if (N % i == 0)
                    return false;
            }
            return true;
        }

        public double NOD(double x1, double x2)
        {
            //Алгоритм Евклида: если а = bq + r, то НОД(а,b) = НОД(b,r)
            double max, min;
            if (Math.Abs(x1) > Math.Abs(x2))
            {
                max = Math.Abs(x1);
                min = Math.Abs(x2);
            }
            else
            {
                max = Math.Abs(x2);
                min = Math.Abs(x1);
            }
            double r = max % min;
            if (r == 0)
            {
                return min;
            }
            else
            {
                return NOD(min, r);
            }
        }

        public double Randomchik(int x1, int x2)
        {
            Random rand = new Random();
            return rand.Next(x1, x2);
        }

        public void Shifrovka(double P, double G, double Y, int dlina, long[] masA, long[] masB, int[] Ntext)
        {
            for (int i = 0; i < dlina; i++)
            {
                string dobav = "";
                double K = Randomchik(2, Convert.ToInt32(P - 1));
                while (NOD(K, P - 1) != 1)
                {
                    K = Randomchik(2, Convert.ToInt32(P - 1));
                }
                masA[i] = Convert.ToInt64((Math.Pow(G, K)) % P);
                masB[i] = Convert.ToInt64((Math.Pow(Y, K) * Ntext[i]) % P);
                dobav = Convert.ToString(masA[i]);
                dobav += " ";
                dobav += Convert.ToString(masB[i]);
                listBox1.Items.Add("Число K: " + K);
                listBox1.Items.Add(dobav);
            }
            masa = masA;
            masb = masB;
        }

        public void DeShifrovka(double X, double P, int dlina, long[] masA, long[] masB)
        {
            string[] text = new string[34] { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я", " " };
            //string[] text = new string[67] { "А", "а", "Б", "б", "В", "в", "Г", "г", "Д", "д", "Е", "е", "Ё", "ё", "Ж", "ж", "З", "з", "И", "и", "Й", "й", "К", "к", "Л", "л", "М", "м", "Н", "н", "О", "о", "П", "п", "Р", "р", "С", "с", "Т", "т", "У", "у", "Ф", "ф", "Х", "х", "Ц", "ц", "Ч", "ч", "Ш", "ш", "Щ", "щ", "Ъ", "ъ", "Ы", "ы", "Ь", "ь", "Э", "э", "Ю", "ю", "Я", "я", " ", };
            int[] otvet = new int[dlina];
            for (int i = 0; i < dlina; i++)
            {
                otvet[i] = Convert.ToInt32(masB[i] * Math.Pow(masA[i], P - 1 - X) % P);
                listBox2.Items.Add(text[otvet[i]]);
            }
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            try
            {
                string[] text = new string[34] { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я", " " };
                //string[] text = new string[67] { "А", "а", "Б", "б", "В", "в", "Г", "г", "Д", "д", "Е", "е", "Ё", "ё", "Ж", "ж", "З", "з", "И", "и", "Й", "й", "К", "к", "Л", "л", "М", "м", "Н", "н", "О", "о", "П", "п", "Р", "р", "С", "с", "Т", "т", "У", "у", "Ф", "ф", "Х", "х", "Ц", "ц", "Ч", "ч", "Ш", "ш", "Щ", "щ", "Ъ", "ъ", "Ы", "ы", "Ь", "ь", "Э", "э", "Ю", "ю", "Я", "я", " ", };
                string Shifr = textBox3.Text;
                dlina = Shifr.Length;
                int[] Ntext = new int[Shifr.Length];
                for (int i = 0; i < Shifr.Length; i++)
                {
                    for (int j = 0; j < 34; j++)
                    {
                        if (Convert.ToString(Shifr[i]) == text[j])
                        {
                            Ntext[i] = j;
                        }
                    }
                }
                double G = Convert.ToDouble(textBox1.Text);
                P = Convert.ToDouble(textBox2.Text);
                if (!Prost(P))
                {
                    MessageBox.Show("Ошибка!", "Число P должно быть простым", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Environment.Exit(0);
                }
                if (P <= G)
                {
                    MessageBox.Show("Ошибка!", "Число P должно быть больше числа G", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Environment.Exit(0);
                }
                X = Randomchik(3, Convert.ToInt32(P));
                double Y = Math.Pow(G, X) % P;
                long[] masA = new long[Shifr.Length];
                long[] masB = new long[Shifr.Length];
                listBox1.Items.Add("Секретный ключ: " + X);
                Shifrovka(P, G, Y, dlina, masA, masB, Ntext);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка!", "Введены недопустимые данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void yt_Button2_Click(object sender, EventArgs e)
        {
            DeShifrovka(X, P, dlina, masa, masb);
        }
        //----------------------------------------------------------------------------
        public long E(long d, long m)
        {
            long e1 = 10;
            while (true)
            {
                if ((e1 * d) % m == 1)
                {
                    break;
                }
                else
                {
                    e1++;
                }
            }
            return e1;
        }
        public long D(long m)
        {
            long d = m - 1;
            for (long i = 2; i <= m; i++)
            {
                if ((m % i == 0) && (d % i) == 0)
                {
                    d--;
                    i = 1;
                }
            }
            return d;
        }
        public Random rand = new Random();


        public int[] getArr(string sentense)
        {
            int[] arr = new int[sentense.Length / 2];
            for (int i = 0, j = 0; i < sentense.Length; i+=2, j++)
            {
                string temp = sentense[i] + sentense[i + 1].ToString();
                arr[j] = Convert.ToInt32(temp);
            }
            return arr;
        }

        private void yt_Button4_Click(object sender, EventArgs e)
        {
            this.textBox5.Text = "";
            int p = 4;
            int q = 22;
            int n = p * q;
            long m = (p - 1) * (q - 1);
            long d = D(m);
            long e1 = E(d, m);
            string sentense = this.textBox4.Text;
            int[] mass = new int[sentense.Length];
            for (int i = 0; i < sentense.Length; i++)
            {
                mass[i] = (int)(BigInteger.Pow(sentense[i], (int)e1) % n);
                this.textBox5.Text += mass[i].ToString();
            }

        }

        private void yt_Button3_Click(object sender, EventArgs e)
        {
            this.textBox6.Text = "";
            int p = 4;
            int q = 22;
            int n = p * q;
            long m = (p - 1) * (q - 1);
            long d = D(m);
            string sentense = this.textBox4.Text;
            int[] mass = getArr(this.textBox5.Text);
            int[] dehifr_m = new int[mass.Length];
            for (int i = 0; i < sentense.Length; i++)
            {
                dehifr_m[i] = (int)(BigInteger.Pow(mass[i], (int)d) % n);
                this.textBox6.Text += dehifr_m[i].ToString();
            }

        }
    }
}
