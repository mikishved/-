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
    public partial class Form3 : Form
    {

        

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                Form1 f1 = new Form1();
                this.Close();
                f1.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void LR_1_Button_Click(object sender, EventArgs e)
        {

            Form4 f4 = new Form4();
            f4.Show();

        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            ЛР_3 lr3 = new ЛР_3();
            lr3.Show();
        }

        private void yt_Button2_Click(object sender, EventArgs e)
        {
            LR_5 lr5 = new LR_5();
            lr5.Show();
        }

        private void lr_2_button_Click(object sender, EventArgs e)
        {
            ЛР_2 lr2 = new ЛР_2();
            lr2.Show();
        }

        private void yt_Button3_Click(object sender, EventArgs e)
        {
            LR_9 lr9 = new LR_9();
            lr9.Show();
        }

        private void yt_Button4_Click(object sender, EventArgs e)
        {
            LR_4 lr4 = new LR_4();
            lr4.Show();
        }

        private void yt_Button5_Click(object sender, EventArgs e)
        {
            LR_7 lr7 = new LR_7();
            lr7.Show();
        }

        private void yt_Button6_Click(object sender, EventArgs e)
        {
            LR_6 lr6 = new LR_6();
            lr6.Show();
        }

        private void yt_Button7_Click(object sender, EventArgs e)
        {
            LR_10 lr10 = new LR_10();
            lr10.Show();
        }
    }


    
}
