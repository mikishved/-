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
    public partial class LR_9 : Form
    {
        public LR_9()
        {
            InitializeComponent();
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double n = Convert.ToDouble(this.textBox1.Text), k = Convert.ToDouble(this.textBox2.Text), s = Convert.ToDouble(this.textBox3.Text), m = Convert.ToDouble(this.textBox4.Text), v = Convert.ToDouble(this.textBox5.Text);
                double C = Math.Pow(n, k);
                double t = C / 20;
                t /= 86400;
                t /= 365;
                double T = t * 5 / 3;
                double Tend = T + t;
                this.textBox6.Text = Tend.ToString();
            }
            catch { MessageBox.Show("Error"); }
        }

        private void yt_Button2_Click(object sender, EventArgs e)
        {
            try
            {
                double n = Convert.ToDouble(this.textBox10.Text), s = Convert.ToDouble(this.textBox8.Text);
                double t = Convert.ToDouble(this.textBox9.Text);
                t *= 31536000;
                double C = t * s;
                double k = Math.Log10(C);
                this.textBox7.Text = k.ToString();
            }
            catch { MessageBox.Show("Error"); }
        }

        private void yt_Button3_Click(object sender, EventArgs e)
        {
            try
            {
                double k = Convert.ToDouble(this.textBox14.Text), s = Convert.ToDouble(this.textBox12.Text);
                double t = Convert.ToDouble(this.textBox12.Text);

                t *= 31536000;
                double C = t * s;
                double n = Math.Pow(C, 1 / k);
                this.textBox11.Text = n.ToString();
            }
            catch { MessageBox.Show("Error"); }
        }
    }
}
