using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace Защита_КИ
{
    public partial class LR_10 : Form
    {
        public LR_10()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        int firstnum = 0;
        int secondnum = 0;
        int module = 0;
        int EilerFunc = 0;
        int exp = 0;
        int secExp = 0;
        string uncript;
        string cript;
        BigInteger[] criptarr;
        BigInteger[] uncriptarr;
        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        public void KeyGen(List<int> list)
        {
            firstnum = list[rand.Next(list.Count)];
            secondnum = list[rand.Next(list.Count)];
            module = firstnum * secondnum;
            EilerFunc = (firstnum - 1) * (secondnum - 1);
            foreach (int nums in list)
            {
                if (nums < EilerFunc && EilerFunc % nums != 0)
                {
                    exp = nums;
                    break;
                }
            }

            for (int i = 0; ; i++)
            {
                if ((i * exp) % EilerFunc == 1) { secExp = i; break; }
            }
            this.textBox5.Text = exp.ToString();
            this.textBox6.Text = module.ToString();

        }

        public bool IsPrimeNumber(int n)
        {
            var result = true;

            if (n > 1)
            {
                for (var i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
        }
        int number = 0;
        public string Cript(int a)
        {
            string end = "";
            for (int i = number; i < criptarr.Length; i++)
            {
                criptarr[i] = BigInteger.Pow(a, exp) % module;
                end=Convert.ToString(criptarr[i]);
                break;
            }
            return end;
        }
        public void UnCript()
        {
            for (int i = number; i < criptarr.Length; i++)
            {
                uncriptarr[i] = BigInteger.Pow(criptarr[i], secExp) % module;
                number++;
                break;
            }
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            this.textBox4.Text = "";
            List<int> SimpleNums = new List<int>();
            string alphabet = "абвгдеёжзийкламнопрстуфхцчшщъыьэюя.,0123456789";
            
            string phraze = this.textBox1.Text;
            phraze = phraze.ToLower();
            string imalive = phraze;
            phraze = GetHash(phraze);
            char[] array = new char[phraze.Length];
            criptarr = new BigInteger[phraze.Length];
            uncriptarr = new BigInteger[phraze.Length];

            array = phraze.ToCharArray();
            for (var i = 0; i < 200; i++)
            {
                if (IsPrimeNumber(i))
                {
                    SimpleNums.Add(i);
                }
            }

            KeyGen(SimpleNums);

            this.textBox2.Text = imalive;
            this.textBox3.Text = phraze;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (array[i] == alphabet[j])
                    {
                        this.textBox4.Text+=Cript(j); UnCript(); break;
                    }
                }
                cript += criptarr[i];
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (uncriptarr[i] == j)
                    {
                        uncript += alphabet[j];
                        break;
                    }
                }
            }
            
            cript = GetHash(cript);
            this.textBox7.Text = uncript = cript;
            this.textBox8.Text = uncript;

        }
    }
}
