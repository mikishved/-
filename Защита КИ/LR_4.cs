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
    public partial class LR_4 : Form
    {

        public LR_4()
        {
            InitializeComponent();
        }
        string puzzleword = "";
        const int wordlength = 4;
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool IsValid(string userword)
        {
            if (userword.Length != wordlength)
            {
                MessageBox.Show("Введено более 4 символов");
                return false;
            }

            for (int i = 0; i < wordlength; i++)
            {
                if (!char.IsDigit(userword[i]))
                {
                    MessageBox.Show("Введенное значение должно содержать только цифры!");
                    return false;
                }
            }

            for (int i = 0; i < userword.Length; i++)
            {
                for (int j = i + 1; j < userword.Length; j++)
                {
                    if (userword[i] == userword[j])
                    {
                        MessageBox.Show("Повторяющиейся значения");
                        return false;
                    }
                }
            }
            return true;
        }

        private int CalculateBullsCount(string userword)
        {
            int bullscount = 0;
            for (int i = 0; i < wordlength; i++)
            {
                if (puzzleword[i] == userword[i])
                {
                    bullscount++;
                }
            }
            return bullscount;
        }


        private int CalculateCowsCount(string userword)
        {
            int cowscount = 0;
            for (int i = 0; i < wordlength; i++)
            {
                for (int j = 0; j < wordlength; j++)
                {
                    if (i == j)
                        continue;
                    if (puzzleword[i] == userword[j])
                    {
                        cowscount++;
                    }
                }
            }
            return cowscount;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userword = userWordtextBox.Text;

            if (!IsValid(userword))
            {
                return;
            }

            int bullsCount = CalculateBullsCount(userword);
            int cowsCount = CalculateCowsCount(userword);

            bulscountlabel.Text = "Быков = " + bullsCount;
            cowscountlabel.Text = "Коров = " + cowsCount;

            dataGridView1.Rows.Add(userword, bullsCount, cowsCount);

            if (bullsCount == wordlength)
            {
                MessageBox.Show("Вы победили!");
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string randomnumber = "";
            List<int> List1 = new List<int> { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            Random random = new Random();
            for (int i = 0; i < 9; i++)
            {
                int digitIndex = random.Next(0, List1.Count);
                randomnumber += List1[digitIndex].ToString() + " ";
                label1.Text = randomnumber;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string randomnumber = "";
            List<int> List1 = new List<int> { -3, 0, 6, 9, 12, 15 };

            Random random = new Random();
            for (int i = 0; i < 9; i++)
            {
                int digitIndex = random.Next(0, List1.Count);
                randomnumber += List1[digitIndex].ToString() + " ";
                label2.Text = randomnumber;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            double[] arr = new double[131];
            int count = 0;
            string randomnumber = "";
            for (double i = 3; i < 12; i += 0.1)
                arr[count++] = Math.Round(i, 1);
            for (double i = 0; i < 10; i++)
                randomnumber += arr[random.Next(0, arr.Length)].ToString() + " ";
            label3.Text = randomnumber;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            double[] arr = new double[131];
            int count = 0;
            string randomnumber = "";
            for (double i = -2.3; i < 10.7; i += 0.1)
                arr[count++] = Math.Round(i, 1);
            for (int i = 0; i < 10; i++)
                randomnumber += arr[random.Next(0, arr.Length)].ToString() + " ";
            label4.Text = randomnumber;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string randomnumber = "";
            List<int> List1 = new List<int> { -30, 10, 63, 59, 120, 175 };

            Random random = new Random();
            for (int i = 0; i < 9; i++)
            {
                int digitIndex = random.Next(0, List1.Count);
                randomnumber += List1[digitIndex].ToString() + " ";
                label5.Text = randomnumber;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string randomnumber = "";
            List<string> List1 = new List<string> { "1", "1^-1", "1^-2", "1^-3", "1^-4", "1^-5", "1^-6", "1^-7", "1^-8", "1^-9", "1^-10", "1^-11", "1^-12", "1^-13", "1^-14", "1^-15", "1^-16" };
            Random random = new Random();

            for (int i = 0; i < 9; i++)
            {
                int digitIndex = random.Next(0, List1.Count);
                randomnumber += List1[digitIndex].ToString() + "   ";
                label6.Text = randomnumber;
            }
        }

        private void LR_4_Load(object sender, EventArgs e)
        {
            List<int> digits = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            Random random = new Random();
            for (int i = 0; i < wordlength; i++)
            {
                int digitIndex = random.Next(0, digits.Count);
                puzzleword += digits[digitIndex].ToString();
                digits.RemoveAt(digitIndex);
            }
            WordLabel.Text = puzzleword;
        }
    }
}
