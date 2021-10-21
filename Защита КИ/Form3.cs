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
    }


    
}
