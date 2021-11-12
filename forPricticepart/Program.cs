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



/*using System;
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





/*using System;
namespace forPricticepart
{
    class Program
    {


        static void Main(string[] args)
        {
            string ruAlph = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

            string engAlph = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string[,] matrix = new string[4, 8];
            string keyWord = "советник";
            keyWord = keyWord.ToUpper();
            string exeptedAlph = ruAlph;
            int l = 0;
            bool isKWUsed = false;

            for (int i = 0; i < keyWord.Length; i++)
            {
                for (int j = 0; j < ruAlph.Length; j++)
                {
                    if (keyWord[i] == ruAlph[j]) exeptedAlph = exeptedAlph.Remove(i, 1);
                }
            }




            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (!isKWUsed)
                    {
                        for (int k = 0; k < keyWord.Length; k++)
                        {
                            matrix[0, k] = Convert.ToString(Convert.ToChar(keyWord[k]));
                        }
                        isKWUsed = true;
                        j = keyWord.Length;
                    }
                    if (l < exeptedAlph.Length-1)
                    {
                        matrix[i, j] = Convert.ToString(Convert.ToChar(exeptedAlph[l]));
                        l++;
                    }
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