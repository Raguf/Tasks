using System;

namespace Task._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4 reqemli eded verilib. 
             * Bu ededin evvelin 4 reqemi , 
             * axirina ise 44 ededini artir. 
             * Alinan cavabin 44 % tap*/

            int a = 1234;
            int b;
            int c;
            int d;

            if (a >= 1000 && a < 10000) // dogru

            {
                b = 40000 + a;         // 41234
                c = (b * 100) + 44;    // 4123444
                d = (c * 44) / 100;    // 1814315

                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(d);
            }

            else

            {
                Console.WriteLine("4 reqemli deyil");
            }
        }
    }
}
