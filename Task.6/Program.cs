using System;

namespace Task._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4 reqemli eded verilib.
             * Bu ededin evvel 20 % -ni , 
             * sonra ise cavabin 10 % tap.
             * Alinan cavabin kvadratini tap.*/

            int a = 1234;
            int b;
            int c;
            int d;

            if (a >= 1000 && a < 10000) // dogru

            {
                b = (a * 20) / 100;    // 246
                c = (b * 10) / 100;    // 24
                d = c*c;               // 576

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
