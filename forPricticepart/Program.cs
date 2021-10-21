using System;

namespace forPricticepart
{
    class Program
    {
        static public string password = "";
        static void Main(string[] args)
        {

            /*string passwordSymbols = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM!@#$%^&*;:'`~=+-/.,()_1234567890йцукенгшщзхъфывапролджэячсмитьбюЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";
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
            */
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
        }
    }
}
