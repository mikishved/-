using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Защита_КИ
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        
        private void yt_Button1_Click(object sender, EventArgs e)
        {
            string password = "";
            string passwordSymbols = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM!@#$%^&*;:'`~=+-/.,()_1234567890йцукенгшщзхъфывапролджэячсмитьбюЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";
            Random r = new Random();
            int plength = r.Next(4, 64);
            int symbolNumber;
            for (int i = 0; i < plength; i++)
            {
                symbolNumber = r.Next(passwordSymbols.Length);
                password += passwordSymbols[symbolNumber];
            }
            this.textBox1.ReadOnly = false;
            this.textBox1.Text = password;
            this.textBox1.ReadOnly = true;
        }

        private void yt_Button2_Click(object sender, EventArgs e)
        {
            string password = "";
            string N = this.textBox3.Text;
            int P = N.Length * N.Length % 6;
            if (N == null) N = "someident";
            int Q = N.Length * N.Length * N.Length % 5;
            string pass = "qwertyuiopasdfghjklzxcvbnm";
            string specsymb = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string numb = "1234567890";
            Random r = new Random();


            for (int i = 0; i < 12; i++)
            {
                if (i < (1 + Q))
                {
                    password += pass[r.Next(pass.Length)];
                }
                else if (i < 1 + Q + 1 + P) password += specsymb[r.Next(specsymb.Length)];
                else password += numb[r.Next(numb.Length)];
            }
            this.textBox2.ReadOnly = false;
            this.textBox2.Text = password;
            this.textBox2.ReadOnly = true;
        }

        private void yt_Button3_Click(object sender, EventArgs e)
        {
            string password = "";
            string passwordSymbols = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM!@#$%^&*;:'`~=+-/.,()_1234567890йцукенгшщзхъфывапролджэячсмитьбюЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";
            Random r = new Random();
            int plength = r.Next(4, 64);
            int symbolNumber;
            for (int i = 0; i < plength; i++)
            {
                symbolNumber = r.Next(passwordSymbols.Length);
                password += passwordSymbols[symbolNumber];
            }
            this.textBox4.ReadOnly = false;
            this.textBox4.Text = password;
            this.textBox4.ReadOnly = true;
        }

        private void yt_Button4_Click(object sender, EventArgs e)
        {
            string password = "";
            string N = this.textBox5.Text;
            if (N == null) N = "someident";
            int Q = N.Length % 5;
            string pass = "qwertyuiopasdfghjklzxcvbnm";
            string specsymb = "!”#$%&’(),*";
            Random r = new Random();


            for (int i = 0; i < 9; i++)
            {
                if (i < (1 + Q))
                {
                    password += specsymb[r.Next(specsymb.Length)];
                }
                else if (i == 8) password += Convert.ToString(r.Next(9));
                else password += pass[r.Next(pass.Length)];
            }
            this.textBox6.ReadOnly = false;
            this.textBox6.Text = password;
            this.textBox6.ReadOnly = true;
        }
    }


}
