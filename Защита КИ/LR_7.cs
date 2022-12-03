using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Numerics;
namespace Защита_КИ
{
    public partial class LR_7 : Form
    {
        public LR_7()
        {
            InitializeComponent();
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = GetHash(this.textBox1.Text);
        }
        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        private void yt_Button2_Click(object sender, EventArgs e)
        {
            double p = Convert.ToDouble(this.textBox4.Text);
            double g = Convert.ToDouble(this.textBox3.Text);
            Random r = new Random();
            uint a = Convert.ToUInt32(r.Next(1, 20));
            uint b = Convert.ToUInt32(r.Next(1, 20));
            uint A = Convert.ToUInt32(Math.Pow(g, a));
            uint B = Convert.ToUInt32(Math.Pow(g, b));
            uint A1 = power(B, a, Convert.ToUInt32(p));
            uint B1 = power(A, b, Convert.ToUInt32(p));

            this.textBox7.Text = A1.ToString();
            this.textBox5.Text = B1.ToString();
        }



        public uint power(uint a, uint b, uint n)
        {// a^b mod n
            uint tmp = a;
            uint sum = tmp;
            for (int i = 1; i < b; i++)
            {
                for (int j = 1; j < a; j++)
                {
                    sum += tmp;
                    if (sum >= n)
                    {
                        sum -= n;
                    }
                }
                tmp = sum;
            }
            return tmp;
        }

    }
}
