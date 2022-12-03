using System;
namespace forPricticePart
{
    class Prog
    {

        static void Main(string[] args)
        {



        }

    }
}









/* 1
 double n = 66, k = 7, s = 20, m = 10, v = 3;
double t = 70;
double C = Math.Pow(n, k);
double t = C / 20;
t /= 86400;
t /= 365;
double T = t * 5 / 3;
double Tend = T + t;
*/
/* 2
double t = 70;
t *= 31536000;
double C = t * s;
k = Math.Log10(C);
*/
/*n = 0;
t *= 31536000;
double C = t * s;
n = Math.Pow(C, 1 / k);
*/














/*
 * lr5.1
using System;
namespace forPricticepart
{

    class LetterData
    {
        public string letter { get; set; }
        public int letX { get; set; }
        public int letY { get; set; }

    }




    class Program
    {
        static void Main(string[] args)
        {

            string text = "кабинет";
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
            for (int i = 0,j = 0; i < codedLetter.Length; i++, j+=2)
            {
                codedLetter[i] = new LetterData();
                codedLetter[i].letX = letArray[j];
                codedLetter[i].letY = letArray[j+1];
                codedLetter[i].letter = alphMatrix[codedLetter[i].letY, codedLetter[i].letX].ToString();
            }

            string codedStr = "";
            for (int i = 0; i < codedLetter.Length; i++)
            {
                codedStr += codedLetter[i].letter;
            }



            //дешифрование
            LetterData[] deletter = new LetterData[codedStr.Length];
            for (int k = 0; k < deletter.Length; k++)
            {
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if(codedStr[k]==alphMatrix[i,j])
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
            for (int i = 0, j = 0; i < deletArray.Length; i+=2, j++)
            {
                deletArray[i] = deletter[j].letX;
                deletArray[i + 1] = deletter[j].letY;
            }
            string decodedString = "";
            for (int i = 0; i < deletArray.Length/2; i++)
            {
                decodedString += alphMatrix[deletArray[i + deletArray.Length / 2], deletArray[i]];
            }


        }
    }
}
*/
//5013251
//1001203

/*
            string forCode = "ТЕРМИНАТОР";
            forCode = forCode.Replace(" ", "");
            char[,] matrix = new char[5, 7];
            int l = 0;
            
            //encrypt
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (l >= forCode.Length) break;
                    
                    matrix[j, i] = forCode[l];
                    l++;
                }
            }
            string codedStr = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                     
                    codedStr += matrix[i, j];
                }
            }
            
            
            
            //decrypt
            l = 0;
            string decodedStr = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    matrix[i, j] = codedStr[l];
                    l++;
                }
            }
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    decodedStr += matrix[j, i];
                }
            }
            Console.WriteLine(codedStr);
            Console.WriteLine(decodedStr);
 */
/*
 
            int coordI_1 = 0, coordJ_1 = 0;
            int coordI_2 = 0, coordJ_2 = 0;
            string ruAlph = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ ,";
            string forCode = "это шифрр";
            string codedString = "";
            string engAlph = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string[,] matrix = new string[5, 7];
            string keyWord = "архив";
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

            string decodedString = "";
            char[] charForDecode = codedString.ToCharArray();
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
 
 
 */








/*













using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            var array = new char[n, m];
            a: Console.WriteLine("Введите фразу которую хотите зашифровать\n");
            string s = Console.ReadLine();
            Console.WriteLine("\n");

            if (s.Length > 36)
            {
                Console.WriteLine("Введенная фраза велика для магичсекого квадрата 5x5, попробуйте снова");
                Thread.Sleep(3000);
                goto a;
            }

            for (int i = 0; i < s.Length; i++)
            {
                array[i / m, i % m] = s[i];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0}", array[j, i]);
                }
                Console.WriteLine();
            }
        }
    }
}
*/





/*
using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int m = 5;
            char[,] array = new char[n, m];
        a: Console.WriteLine("\nВведите фразу которую хотите зашифровать в квадрате 5x5\n");

            string s = Console.ReadLine(); //"я же говорил делать лабы";
            if (s.Length > 25)
            {
                Console.WriteLine("Введенная фраза велика для магичсекого квадрата 5x5, попробуйте снова");
                Thread.Sleep(3000);
                goto a;
            }
            Console.WriteLine("\n");

            for (int i = 0; i < s.Length; i++)
            {
                array[i / m, i % m] = s[i];
            }

            Console.Write(array[0, 1]);
            Console.Write(array[3, 2]);
            Console.Write(array[0, 0]);
            Console.Write(array[4, 2]);
            Console.WriteLine(array[4, 0]);
            Console.Write(array[2, 1]);
            Console.Write(array[4, 4]);
            Console.Write(array[0, 4]);
            Console.Write(array[0, 3]);
            Console.WriteLine(array[3, 3]);
            Console.Write(array[3, 0]);
            Console.Write(array[1, 3]);
            Console.Write(array[2, 4]);
            Console.Write(array[2, 3]);
            Console.WriteLine(array[2, 0]);
            Console.Write(array[2, 2]);
            Console.Write(array[0, 2]);
            Console.Write(array[4, 3]);
            Console.Write(array[3, 1]);
            Console.WriteLine(array[1, 2]);
            Console.Write(array[4, 1]);
            Console.Write(array[1, 4]);
            Console.Write(array[3, 4]);
            Console.Write(array[1, 1]);
            Console.Write(array[1, 0]);
            Console.WriteLine("\n");
            

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0}", array[i, j]);
                }

            }
        }
    }
}
*/




/*
 * шифрование трисемуса
static public int kCalc(int p)
        {
            return Convert.ToInt32(2 * Math.Pow(p, 2) + 5 * p + 2);
        }


string fC = "Защита компъютерной информации";
            fC = fC.ToUpper();
            string alph = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ ,.";
            string codedString = "";
            string decodedString = "";
            //ctypt
            for (int i = 0; i < fC.Length; i++)
            {
                int m = alph.IndexOf(fC[i]);
                int k = kCalc(i);
                int codedLetterIndex = (m + k) % alph.Length;                
                codedString += alph[codedLetterIndex];  
                
            }
            Console.WriteLine(codedString);
            //decrypt
            for (int i = 0; i < codedString.Length; i++)
            {
                int k = kCalc(i);
                int m = (alph.IndexOf(codedString[i]) - k) % alph.Length;
                if (m < 0) m += alph.Length;
                decodedString += alph[m];
                
            }
            Console.WriteLine(decodedString);
















 * string passwordSymbols = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM!@#$%^&*;:'`~=+-/.,()_1234567890йцукенгшщзхъфывапролджэячсмитьбюЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";
            Random r = new Random();
            int plength = r.Next(4,64);
            int symbolNumber;
            for(int i = 0; i<plength; i++)
            {
                symbolNumber = r.Next(passwordSymbols.Length);
                password += passwordSymbols[symbolNumber];
            }
            Console.WriteLine(password);

            double S = Math.Ceiling(11 * 4 / Math.Pow(10, -7));
            




            string password = "";
            string N ="CAH9l";
            int Q = N.Length % 5;
            string pass = "qwertyuiopasdfghjklzxcvbnm";
            string specsymb = "!,”,#,$,%,&,’,(,),*";
            Random r = new Random();


            for(int i = 0; i<9;i++)
            {
                if (i < (1 + Q))
                {
                    password += pass[r.Next(specsymb.Length)];
                }
                else if (i == 8) password += Convert.ToString(r.Next(9));
                else password += pass[r.Next(pass.Length)];
            }
            */