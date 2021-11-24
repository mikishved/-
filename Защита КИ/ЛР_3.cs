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
    public partial class ЛР_3 : Form
    {
        public ЛР_3()
        {
            InitializeComponent();
        }







        //шифрование плейфера
        private void yt_Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int coordI_1 = 0, coordJ_1 = 0;
                int coordI_2 = 0, coordJ_2 = 0;



                string ruAlph = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ ,";
                string forCode = this.textForCode.Text;
                if (forCode == "") forCode = "это шифр";
                string codedString = "";
                string engAlph = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string[,] matrix = new string[5, 7];
                string keyWord = this.key.Text;
                if (keyWord == "") keyWord = "архив";
                keyWord = keyWord.ToUpper();
                string exeptedAlph = ruAlph;
                int l = 0;
                bool isKWUsed = false;
                //убираем символы из алфавита
                for (int i = 0; i < keyWord.Length; i++)
                {
                    for (int j = 0; j < ruAlph.Length; j++)
                    {
                        if (keyWord[i] == ruAlph[j]) exeptedAlph = exeptedAlph.Replace(ruAlph[j].ToString(), "");
                    }
                }

                //заполняем матрицу
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        if (!isKWUsed)
                        {
                            for (int k = 0; k < keyWord.Length; k++)
                            {
                                if (k >= 7) { k = 0; i++; }
                                matrix[i, k] = keyWord[l].ToString();
                                l++;
                                j = k;
                                if (l >= keyWord.Length) break;

                            }

                            isKWUsed = true;
                            l = 0;
                            j++;
                        }

                        if (j > 7) { j = 0; i++; }
                        if (l < exeptedAlph.Length)
                        {
                            matrix[i, j] = Convert.ToString(exeptedAlph[l]);
                            l++;
                        }

                    }

                }



                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        Console.Write(matrix[i, j]);
                    }
                    Console.WriteLine();
                }



                //делим фразу на биограммы
                forCode = forCode.ToUpper();
                string Newstring = "";

                for (int i = 0; i < forCode.Length; i++)
                {
                    Newstring += forCode[i];
                    if (i < forCode.Length - 1)
                        if (forCode[i] == forCode[i + 1]) Newstring += "Х";
                }

                if (Newstring.Length % 2 != 0)
                {
                    Newstring += " ";
                }

                char[] charForCode = Newstring.ToCharArray();
                l = 0;
                for (int osn = 0; osn < charForCode.Length; osn += 2)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            if (charForCode[osn].ToString() == matrix[i, j])
                            {
                                coordI_1 = i;
                                coordJ_1 = j;
                            }
                        }
                    }

                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            if (charForCode[osn + 1].ToString() == matrix[i, j])
                            {
                                coordI_2 = i;
                                coordJ_2 = j;
                            }
                        }
                    }

                    codedString += matrix[coordI_2, coordJ_1].ToString() + matrix[coordI_1, coordJ_2].ToString();

                }
                this.codedText.Text = codedString;
            }
            catch { MessageBox.Show("error"); }
        }
        //дешифрование плейфера
        private void yt_Button2_Click(object sender, EventArgs e)
            {
            try { 
                int coordI_1 = 0, coordJ_1 = 0;
                int coordI_2 = 0, coordJ_2 = 0;



                string ruAlph = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ ,";
                string forCode = this.textForCode.Text;
                if (forCode == "") forCode = "это шифр";
                string codedString = "";
                string engAlph = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string[,] matrix = new string[5, 7];
                string keyWord = this.key.Text;
                if (keyWord == "") keyWord = "архив";
                keyWord = keyWord.ToUpper();
                string exeptedAlph = ruAlph;
                int l = 0;
                bool isKWUsed = false;
                //убираем символы из алфавита
                for (int i = 0; i < keyWord.Length; i++)
                {
                    for (int j = 0; j < ruAlph.Length; j++)
                    {
                        if (keyWord[i] == ruAlph[j]) exeptedAlph = exeptedAlph.Replace(ruAlph[j].ToString(), "");
                    }
                }

                //заполняем матрицу
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        if (!isKWUsed)
                        {
                            for (int k = 0; k < keyWord.Length; k++)
                            {
                                if (k >= 7) { k = 0; i++; }
                                matrix[i, k] = keyWord[l].ToString();
                                l++;
                                j = k;
                                if (l >= keyWord.Length) break;

                            }

                            isKWUsed = true;
                            l = 0;
                            j++;
                        }

                        if (j > 7) { j = 0; i++; }
                        if (l < exeptedAlph.Length)
                        {
                            matrix[i, j] = Convert.ToString(exeptedAlph[l]);
                            l++;
                        }

                    }

                }



                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        Console.Write(matrix[i, j]);
                    }
                    Console.WriteLine();
                }



                //делим фразу на биограммы
                forCode = forCode.ToUpper();
                string Newstring = "";

                for (int i = 0; i < forCode.Length; i++)
                {
                    Newstring += forCode[i];
                    if (i < forCode.Length - 1)
                        if (forCode[i] == forCode[i + 1]) Newstring += "Х";
                }

                string decodedString = "";
                char[] charForDecode = this.codedText.Text.ToCharArray();
                l = 0;
                coordI_1 = 0;
                coordJ_1 = 0;
                coordI_2 = 0;
                coordJ_2 = 0;
                for (int osn = 0; osn < charForDecode.Length; osn += 2)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            if (charForDecode[osn].ToString() == matrix[i, j])
                            {
                                coordI_1 = i;
                                coordJ_1 = j;

                            }
                        }
                    }

                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            if (charForDecode[osn + 1].ToString() == matrix[i, j])
                            {
                                coordI_2 = i;
                                coordJ_2 = j;
                            }
                        }
                    }

                    decodedString += matrix[coordI_2, coordJ_1].ToString() + matrix[coordI_1, coordJ_2].ToString();

                }


                for (int i = 0; i < decodedString.Length - 2; i++)
                {
                    if (decodedString[i] == decodedString[i + 2] && decodedString[i + 1].ToString() == "Х".ToString()) { decodedString = decodedString.Remove(i + 1, 1); }
                }



                this.decodedText.Text = decodedString;
            }
            catch{ MessageBox.Show("error"); }
        }

        //шифрование методом цезаря
        private void yt_Button4_Click(object sender, EventArgs e)
        {
            string alphUP = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ ,.";
            string alphLOW = alphUP.ToLower();
            string codedalphLOW = "";
            string codedalphUP = "";
            string forCode = this.textBox2.Text;
            if (forCode == "") forCode = "Данилевич Илья";
            int key = Convert.ToInt32(this.textBox4.Text);
            if (key == null) key = 4;
            if (key > alphLOW.Length) MessageBox.Show("netu!");
            else
            {
                string coded = "";
                string decoded = "";
                //Создание зашифрованного альфавита (маленькие буквы)
                for (int i = 0; i < alphLOW.Length; i++)
                {
                    if (i < alphLOW.Length - key) codedalphLOW += alphLOW[i + key];
                    else codedalphLOW += alphLOW[i + key - alphLOW.Length];
                }
                //СОздание зашифрованного алфавита (большие буквы)
                for (int i = 0; i < alphUP.Length; i++)
                {
                    if (i < alphUP.Length - key) codedalphUP += alphUP[i + key];
                    else codedalphUP += alphUP[i + key - alphUP.Length];
                }
                //Шифровка
                for (int i = 0; i < forCode.Length; i++)
                {
                    for (int j = 0; j < alphLOW.Length; j++)
                    {
                        if (forCode[i] == alphLOW[j]) coded += codedalphLOW[j];
                        else if (forCode[i] == alphUP[j]) coded += codedalphUP[j];
                    }
                }
                this.textBox3.Text = coded;
            }
        }
        //дешифрование методом цезаря
        private void yt_Button3_Click(object sender, EventArgs e)
        {
            string alphUP = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ ,.";
            string alphLOW = alphUP.ToLower();
            string codedalphLOW = "";
            string codedalphUP = "";
            string forCode = this.textBox2.Text;
            if (forCode == "") forCode = "Данилевич Илья";
            int key = Convert.ToInt32(this.textBox4.Text);
            if (key == 0) key = 4;
            string coded = "";
            string decoded = "";
            //Создание зашифрованного альфавита (маленькие буквы)
            for (int i = 0; i < alphLOW.Length; i++)
            {
                if (i < alphLOW.Length - key) codedalphLOW += alphLOW[i + key];
                else codedalphLOW += alphLOW[i + key - alphLOW.Length];
            }
            //СОздание зашифрованного алфавита (большие буквы)
            for (int i = 0; i < alphUP.Length; i++)
            {
                if (i < alphUP.Length - key) codedalphUP += alphUP[i + key];
                else codedalphUP += alphUP[i + key - alphUP.Length];
            }

            coded = this.textBox3.Text;
            if (coded == "") MessageBox.Show("netu!");
            //Дешифровка
            else
            for (int i = 0; i < coded.Length; i++)
            {
                for (int j = 0; j < alphLOW.Length; j++)
                {
                    if (coded[i] == codedalphLOW[j]) decoded += alphLOW[j];
                    else if (coded[i] == codedalphUP[j]) decoded += alphUP[j];
                }
            }
            this.textBox1.Text = decoded;
        }

        //шифрование методом трисемуса
        private int kCalc(int p, int a, int b, int c)
        {
            return a * Convert.ToInt32(Math.Pow(p, 2)) + b * p + c;
        }
        private void yt_Button6_Click(object sender, EventArgs e)
        {
            int key1;
            int key2;
            int key3;
            if (this.textBox8.Text == "" || this.textBox9.Text == "" || this.textBox10.Text == "" || this.textBox8.Text == null || this.textBox9.Text == null || this.textBox10.Text == null)
            {
                key1 = 2;
                key2 = 5;
                key3 = 2;
            }
            key1 = Convert.ToInt32(this.textBox8.Text);
            key2 = Convert.ToInt32(this.textBox9.Text);
            key3 = Convert.ToInt32(this.textBox10.Text);
            if (this.textBox8.Text == "") key1 = 2;
            if (this.textBox9.Text == "") key1 = 5;
            if (this.textBox10.Text == "") key1 = 2;

            string fC = this.textBox6.Text;
            if (fC == "" || fC == null) fC = "Защита компьютерной информации";
            fC = fC.ToUpper();
            string alph = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ ,.";
            string codedString = "";
            //ctypt
            for (int i = 0; i < fC.Length; i++)
            {
                int m = alph.IndexOf(fC[i]);
                int k = kCalc(i,key1,key2,key3);
                int codedLetterIndex = (m + k) % alph.Length;
                codedString += alph[codedLetterIndex];

            }
            this.textBox7.Text = codedString;
          
        }
        //дешифрование методом трисемуса
        private void yt_Button5_Click(object sender, EventArgs e)
        {
            string fC = this.textBox6.Text;
            int key1 = Convert.ToInt32(this.textBox8.Text);
            int key2 = Convert.ToInt32(this.textBox9.Text);
            int key3 = Convert.ToInt32(this.textBox10.Text);
            fC = fC.ToUpper();
            string alph = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ ,.";
            string codedString = this.textBox7.Text;
            string decodedString = "";
            //decrypt
            for (int i = 0; i < codedString.Length; i++)
            {
                int k = kCalc(i, key1, key2, key3);
                int m = (alph.IndexOf(codedString[i]) - k) % alph.Length;
                if (m < 0) m += alph.Length;
                decodedString += alph[m];

            }
            this.textBox5.Text = decodedString;
        }
    }
}
