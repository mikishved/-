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
    public partial class ЛР_2 : Form
    {
        public ЛР_2()
        {
            InitializeComponent();
        }
        public char[,] encryptedText = new char[5,5];
        public string word5x5;
        static public int N1 = 5;
        public char[,] word_in_kub5x5 = new char[N1, N1];
        public int[,] kub_5x5 = new int[,] { { 2, 18, 1, 23, 21 }, { 12, 25, 5, 4, 19 }, { 16, 9, 15, 14, 11 }, { 13, 3, 24, 17, 8 }, { 22, 10, 20, 7, 6 } };
        public void greate5x5(string aka)
        {
            try
            {
                if (aka.Length < 25) aka += "                         ";
                word5x5 = aka;
                string encrypted = "";
                for (int i = 0; i < N1; i++)
                {
                    for (int j = 0; j < N1; j++)
                    {
                        int buff = 0;
                        buff = kub_5x5[i, j];
                        word_in_kub5x5[i, j] = word5x5[buff - 1];
                    }

                }
                for (int i = 0; i < N1; i++)
                {
                    for (int j = 0; j < N1; j++)
                    {
                        //if (word_in_kub5x5[i, j] == null) encryptedText[i, j] = ' ';
                        encryptedText[i, j] = word_in_kub5x5[i, j];
                    }
                }
            }
            catch(Exception error) { MessageBox.Show("Error"+error); }
        }
        public string deshifrator5x5()
        {
            string decr = "";
            try
            {
                int size = encryptedText.Length;
                char[] dehifrator_word = new char[size];
                int buff = 1;
                do
                {
                    for (int i = 0; i < N1; i++)
                    {
                        for (int j = 0; j < N1; j++)
                        {
                            if (kub_5x5[i, j] == buff)
                            {
                                dehifrator_word[buff - 1] = encryptedText[i, j];
                                buff++;
                            }
                        }

                    }
                } while (buff != 26);
                
                for (int i = 0; i < size; i++)
                {
                    decr += dehifrator_word[i];
                }
                
            }
            catch (Exception error) { MessageBox.Show("Error"+error); }
            return decr;
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string word;


                int width = Convert.ToInt32(this.textBox2.Text);

                int height = Convert.ToInt32(this.textBox4.Text);


                word = this.textBox3.Text;
                Console.WriteLine("\n", word[0]);

                char[,] Shifr_word = new char[width, height];
                int f = 0;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Shifr_word[j, i] = word[f++];
                    }
                }
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        this.textBox1.Text += Shifr_word[i, j];
                    }
                    this.textBox1.Text += "\t\t\t";

                }
            }
            catch(Exception error) { MessageBox.Show("Error\n" + error); }
        }

        private void yt_Button2_Click(object sender, EventArgs e)
        {
            this.textBox8.Text = "";
            greate5x5(this.textBox7.Text);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    this.textBox8.Text+=encryptedText[i, j].ToString();
                }
                this.textBox8.Text += Environment.NewLine;
            }
        }
        private void yt_Button3_Click(object sender, EventArgs e)
        {
            this.textBox5.Text = deshifrator5x5();
        }

        public char[,] encryptedText6x6 = new char[6, 6];
        public string word6x6;
        static public int N2 = 6;
        public char[,] word_in_kub6x6 = new char[N2, N2];
        public int[,] kub6x6 = new int[,] { { 18, 28, 3, 12, 15, 35 }, { 32, 11, 14, 17, 4, 33 }, { 20, 9, 24, 13, 16, 29 }, { 21, 27, 10, 25, 23, 5 }, { 1, 30, 34, 8, 31, 7 }, { 19, 6, 26, 36, 22, 2 } };
        public void greate6x6(string aka)
        {
            try
            {
                if (aka.Length < 36) aka += "                                   ";
                word6x6 = aka;

                for (int i = 0; i < N2; i++)
                {
                    for (int j = 0; j < N2; j++)
                    {
                        int buff = 0;
                        buff = kub6x6[i, j];
                        word_in_kub6x6[i, j] = word6x6[buff - 1];
                    }

                }
                for (int i = 0; i < N2; i++)
                {
                    for (int j = 0; j < N2; j++)
                    {
                        encryptedText6x6[i, j] = word_in_kub6x6[i, j];
                    }

                }
            }
            catch(Exception error) { MessageBox.Show("Error" + error); }
        }   
        public string deshifrator6x6()
        {
            string decrypted = "";
            try
            {
                int size = encryptedText6x6.Length;
                char[] dehifrator_word = new char[size];
                int buff = 1;
                do
                {
                    for (int i = 0; i < N2; i++)
                    {
                        for (int j = 0; j < N2; j++)
                        {
                            if (kub6x6[i, j] == buff)
                            {
                                dehifrator_word[buff - 1] = word_in_kub6x6[i, j];
                                buff++;
                            }
                        }

                    }
                } while (buff != 37);
                
                for (int i = 0; i < size; i++)
                {
                    decrypted += dehifrator_word[i];
                }
            }
            catch(Exception error) { MessageBox.Show("Error" + error); }
            return decrypted;
        }

        private void yt_Button5_Click(object sender, EventArgs e)
        {
            this.textBox9.Text = "";
            greate6x6(this.textBox10.Text);
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    this.textBox9.Text += encryptedText6x6[i, j].ToString();
                }
                this.textBox9.Text += Environment.NewLine;
            }
        }

        private void yt_Button4_Click(object sender, EventArgs e)
        {
            this.textBox6.Text = deshifrator6x6();
        }
    }
}
