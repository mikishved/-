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
    
    public partial class LR_5 : Form
    {
        public LR_5()
        {
            InitializeComponent();
        }
        
        private void yt_Button6_Click(object sender, EventArgs e)
        {
            try
            {
                string forCode = this.textBox3.Text;
                forCode.ToUpper();
                forCode = forCode.Replace(" ", "");
                char[,] matrix = new char[6, 6];
                int l = 0;

                //encrypt
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (l < forCode.Length)
                        {
                            matrix[j, i] = forCode[l];
                            l++;
                        }
                    }
                }
                string codedStr = "";
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {

                        codedStr += matrix[i, j];
                    }
                }
                codedStr = codedStr.Replace("\0", " ");
                this.textBox1.Text = codedStr;
            }
            catch (Exception error) { MessageBox.Show("Error\t" + error); }
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            try
            {
                char[,] matrix = new char[6, 6];
                string codedStr = this.textBox1.Text;
                int l = 0;
                //decrypt6
                string decodedStr = "";
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                    if (l < codedStr.Length)
                    {
                        matrix[j, i] = codedStr[l];
                        l++;
                    }
                    }
                }
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        decodedStr += matrix[i, j];
                    }
                }
                decodedStr = decodedStr.Replace(" ", "");
                this.textBox2.Text = decodedStr;
            }
            catch { MessageBox.Show("Error"); }
        }

        private void yt_Button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.textBox6.Text = Shifr2zad(this.textBox4.Text);
            }
            catch { MessageBox.Show("error"); }
        }

        private void yt_Button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.textBox5.Text = DeshifrZad2(this.textBox6.Text);
            }
            catch { MessageBox.Show("error"); }
        }

        private void yt_Button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.textBox9.Text = Shifr3zad(this.textBox7.Text,this.textBox10.Text);
            }
            catch { MessageBox.Show("error"); }
        }

        private void yt_Button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.textBox8.Text = Deshifred3zad(this.textBox9.Text, this.textBox10.Text);
            }
            catch { MessageBox.Show("error"); }
        }
        public string shifred(string str)
        {
            string alphabet = "АБВГДЕ.ЁЖЗИЙК.ЛМНОПР.СТУФХЦ.ЧШЩЪЫЬ.ЭЮЯ_ #";
            string[] tabl = alphabet.Split('.');
            str = str.ToUpper();
            List<string> list = new List<string>();

            int i = 0;
            for (i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < tabl.Length; j++)
                {
                    if (tabl[j].IndexOf(str[i]) != -1)
                    {
                        list.Add(j.ToString() + tabl[j].IndexOf(str[i]));
                        break;
                    }

                }
            }
            Console.WriteLine("Лист 1");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            List<string> list2 = new List<string>();
            int k = 0;
            i = 0;
            bool cc = false;
            if (list.Count % 2 == 1)
                cc = true;
            while (i < list.Count - 1)
            {
                list2.Add(list[i][k].ToString() + list[i + 1][k].ToString());
                i += 2;
                if (i > list.Count - 2 && k == 0 && cc == true)
                {
                    list2.Add(list[i][k].ToString() + list[0][1].ToString());
                    i = 1;
                    k = 1;
                    continue;
                }
                if (k == 0 && list.Count == i)
                {
                    i = 0;
                    k = 1;
                }
            }
            Console.WriteLine("Лист 2");
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
            string str1 = "";
            foreach (var item in list2)
            {
                str1 += tabl[int.Parse(item[0].ToString())][int.Parse(item[1].ToString())];
            }

            Console.WriteLine(str1);


            return str1;
        }
        public string Deshifred(string str)
        {
            string alphabet = "АБВГДЕ.ЁЖЗИЙК.ЛМНОПР.СТУФХЦ.ЧШЩЪЫЬ.ЭЮЯ_ #";
            string[] tabl = alphabet.Split('.');
            List<string> list = new List<string>();
            str = str.ToUpper();
            int i = 0;
            for (i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < tabl.Length; j++)
                {
                    if (tabl[j].IndexOf(str[i]) != -1)
                    {
                        list.Add(j.ToString() + tabl[j].IndexOf(str[i]));
                        break;

                    }

                }
            }
            Console.WriteLine("Лист 1");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            List<string> listDeshifr = new List<string>();

            Console.WriteLine();

            string s = "";
            foreach (var item in list)
            {
                s += item;
            }
            int len = list.Count;


            ///////////
            for (int z = 0; z < len; z++)
            {
                listDeshifr.Add(s[z].ToString() + s[z + len].ToString());
            }
            ////////////
            Console.WriteLine("Лист 2");
            foreach (var item in listDeshifr)
            {
                Console.WriteLine(item);
            }

            string str1 = "";
            foreach (var item in listDeshifr)
            {
                if (tabl[int.Parse(item[0].ToString())][int.Parse(item[1].ToString())] == '_' || tabl[int.Parse(item[0].ToString())][int.Parse(item[1].ToString())] == '#')
                {
                    str1 += ' ';

                }
                else
                {
                    str1 += tabl[int.Parse(item[0].ToString())][int.Parse(item[1].ToString())];
                }
            }
            return str1.ToLower();
        }
        public string Shifr2zad(string str)
        {

            str = shifred(str);
            Console.WriteLine("Шифр 2 задание");
            string alphabet = "АБВГДЕ.ЁЖЗИЙК.ЛМНОПР.СТУФХЦ.ЧШЩЪЫЬ.ЭЮЯ_ #";
            string[] tabl = alphabet.Split('.');
            str = str.ToUpper();
            List<string> list = new List<string>();


            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < tabl.Length; j++)
                {
                    if (tabl[j].IndexOf(str[i]) != -1)
                    {
                        list.Add(j.ToString() + tabl[j].IndexOf(str[i]));
                        break;
                    }

                }
            }
            List<string> list2 = new List<string>();
            for (int i = 0; i < list.Count - 1; i++)
            {

                list2.Add(list[i][1].ToString() + list[i + 1][0].ToString());

            }

            list2.Add(list[list.Count - 1][1].ToString() + list[0][0].ToString());
            Console.WriteLine();
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }


            string str1 = "";
            foreach (var item in list2)
            {
                str1 += tabl[int.Parse(item[0].ToString())][int.Parse(item[1].ToString())];

            }
            return str1.ToUpper();
        }
        public string DeshifrZad2(string str)
        {
            Console.WriteLine("деШифр 2 задание");

            string alphabet = "АБВГДЕ.ЁЖЗИЙК.ЛМНОПР.СТУФХЦ.ЧШЩЪЫЬ.ЭЮЯ_ #";
            string[] tabl = alphabet.Split('.');
            str = str.ToUpper();
            List<string> list = new List<string>();
            List<string> list2 = new List<string>();

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < tabl.Length; j++)
                {
                    if (tabl[j].IndexOf(str[i]) != -1)
                    {
                        list.Add(j.ToString() + tabl[j].IndexOf(str[i]));

                        break;
                    }

                }
            }
            Console.WriteLine();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list2.Add(list[list.Count - 1][1].ToString() + list[0][0]);
            for (int i = 1; i < list.Count; i++)
            {


                list2.Add(list[i - 1][1].ToString() + list[i][0].ToString());


            }
            Console.WriteLine();
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
            string str1 = "";
            foreach (var item in list2)
            {


                str1 += tabl[int.Parse(item[0].ToString())][int.Parse(item[1].ToString())];

            }


            return Deshifred(str1);
        }
        public string Shifr3zad(string str, string key)
        {

            string alfavit = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ_ #";


            key = key.ToUpper();
            string[] mass1 = new string[6];
            int i = 0;
            int j = 0;
            int k = 0;
            for (k = 0; k < key.Length; k++)
            {
                if (j == 6)
                {
                    i++;
                    j = 0;
                }
                if (alfavit.IndexOf(key[k]) != -1)
                {
                    alfavit = alfavit.Remove(alfavit.IndexOf(key[k]), 1);
                    mass1[i] += key[k];
                    j++;
                }
            }

            for (k = 0; k < alfavit.Length; k++)
            {

                if (j == 6)
                {
                    i++;
                    j = 0;
                }
                mass1[i] += alfavit[k];
                j++;


            }

            foreach (var item in mass1)
            {
                Console.WriteLine(item);
            }
            List<string> list = new List<string>();
            str = str.ToUpper();
            for (i = 0; i < str.Length; i++)
            {
                for (j = 0; j < mass1.Length; j++)
                {
                    if (mass1[j].IndexOf(str[i]) != -1)
                    {
                        list.Add(j.ToString() + mass1[j].IndexOf(str[i]));
                        break;
                    }

                }
            }
            Console.WriteLine("Лист 1");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            List<string> list2 = new List<string>();
            k = 0;
            i = 0;
            bool cc = false;
            if (list.Count % 2 == 1)
                cc = true;
            while (i < list.Count - 1)
            {
                list2.Add(list[i][k].ToString() + list[i + 1][k].ToString());
                i += 2;
                if (i > list.Count - 2 && k == 0 && cc == true)
                {
                    list2.Add(list[i][k].ToString() + list[0][1].ToString());
                    i = 1;
                    k = 1;
                    continue;
                }
                if (k == 0 && list.Count == i)
                {
                    i = 0;
                    k = 1;
                }
            }
            Console.WriteLine("Лист 2");
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
            string str1 = "";
            foreach (var item in list2)
            {
                str1 += mass1[int.Parse(item[0].ToString())][int.Parse(item[1].ToString())];
            }

            Console.WriteLine(str1);


            return str1;




        }
        public string Deshifred3zad(string str, string key)
        {

            string alfavit = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ_ #";


            key = key.ToUpper();
            string[] mass1 = new string[6];
            int i = 0;
            int j = 0;
            int k = 0;
            for (k = 0; k < key.Length; k++)
            {
                if (j == 6)
                {
                    i++;
                    j = 0;
                }
                if (alfavit.IndexOf(key[k]) != -1)
                {
                    alfavit = alfavit.Remove(alfavit.IndexOf(key[k]), 1);
                    mass1[i] += key[k];
                    j++;
                }
            }

            for (k = 0; k < alfavit.Length; k++)
            {

                if (j == 6)
                {
                    i++;
                    j = 0;
                }
                mass1[i] += alfavit[k];
                j++;


            }

            foreach (var item in mass1)
            {
                Console.WriteLine(item);
            }

            List<string> list = new List<string>();
            str = str.ToUpper();
            i = 0;
            for (i = 0; i < str.Length; i++)
            {
                for (j = 0; j < mass1.Length; j++)
                {
                    if (mass1[j].IndexOf(str[i]) != -1)
                    {
                        list.Add(j.ToString() + mass1[j].IndexOf(str[i]));
                        break;

                    }

                }
            }
            Console.WriteLine("Лист 1");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            List<string> listDeshifr = new List<string>();

            Console.WriteLine();

            string s = "";
            foreach (var item in list)
            {
                s += item;
            }
            int len = list.Count;


            ///////////
            for (int z = 0; z < len; z++)
            {
                listDeshifr.Add(s[z].ToString() + s[z + len].ToString());
            }
            ////////////
            Console.WriteLine("Лист 2");
            foreach (var item in listDeshifr)
            {
                Console.WriteLine(item);
            }

            string str1 = "";
            foreach (var item in listDeshifr)
            {
                if (mass1[int.Parse(item[0].ToString())][int.Parse(item[1].ToString())] == '_' || mass1[int.Parse(item[0].ToString())][int.Parse(item[1].ToString())] == '#')
                {
                    str1 += ' ';

                }
                else
                {
                    str1 += mass1[int.Parse(item[0].ToString())][int.Parse(item[1].ToString())];
                }
            }
            return str1.ToLower();
        }

        private void yt_Button8_Click(object sender, EventArgs e)
        {
            string text = this.textBox11.Text;
            text = text.ToUpper();
            LetterData[] letter = new LetterData[text.Length];
            string ruAlph = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ ,.";
            char[,] alphMatrix = new char[6, 6];
            int l = 0;
            int[] letArray = new int[text.Length * 2];


            //заполнение матрицы алфавита
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    alphMatrix[i, j] = ruAlph[l];
                    l++;
                }
            }

            //запись в класс для преобразования координат
            for (int k = 0; k < letter.Length; k++)
            {
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (text[k] == alphMatrix[i, j])
                        {
                            letter[k] = new LetterData();
                            letter[k].letX = j;
                            letter[k].letY = i;
                        }
                    }
                }
            }



            //шифрование
            for (int i = 0; i < letArray.Length / 2; i++)
            {
                letArray[i] = letter[i].letX;
            }
            for (int i = letArray.Length / 2, j = 0; i < letArray.Length; i++, j++)
            {
                letArray[i] = letter[j].letY;
            }
            LetterData[] codedLetter = new LetterData[text.Length];
            for (int i = 0, j = 0; i < codedLetter.Length; i++, j += 2)
            {
                codedLetter[i] = new LetterData();
                codedLetter[i].letX = letArray[j];
                codedLetter[i].letY = letArray[j + 1];
                codedLetter[i].letter = alphMatrix[codedLetter[i].letY, codedLetter[i].letX].ToString();
            }

            string codedStr = "";
            for (int i = 0; i < codedLetter.Length; i++)
            {
                codedStr += codedLetter[i].letter;
            }
            this.textBox13.Text = codedStr;
        }

        private void yt_Button7_Click(object sender, EventArgs e)
        {
            string ruAlph = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ ,.";
            char[,] alphMatrix = new char[6, 6];
            int l = 0;


            //заполнение матрицы алфавита
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    alphMatrix[i, j] = ruAlph[l];
                    l++;
                }
            }
            string codedStr = this.textBox13.Text;
            LetterData[] deletter = new LetterData[codedStr.Length];
            for (int k = 0; k < deletter.Length; k++)
            {
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (codedStr[k] == alphMatrix[i, j])
                        {
                            deletter[k] = new LetterData();
                            deletter[k].letX = j;
                            deletter[k].letY = i;
                            goto metka;
                        }
                    }
                }
            metka:
                k++;
                k--;
            }
            int[] deletArray = new int[codedStr.Length * 2];
            for (int i = 0, j = 0; i < deletArray.Length; i += 2, j++)
            {
                deletArray[i] = deletter[j].letX;
                deletArray[i + 1] = deletter[j].letY;
            }
            string decodedString = "";
            for (int i = 0; i < deletArray.Length / 2; i++)
            {
                decodedString += alphMatrix[deletArray[i + deletArray.Length / 2], deletArray[i]];
            }
            this.textBox12.Text = decodedString;
        }
    }
    class LetterData
    {
        public string letter { get; set; }
        public int letX { get; set; }
        public int letY { get; set; }

    }
}
