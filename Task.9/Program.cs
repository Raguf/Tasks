using System;

namespace Task._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 3 dene 6 reqemli eded verilib. 
             * Her birinin 10 faizini tapib neticeleri topla. 
             * Alinan cavabin 10% tap.*/

            int a = 123456;
            int b = 234567;
            int c = 345678;
            int d;
            int e;
            int f;
            int g;
            int h;

            if (a >= 100000 && a < 1000000 &&
                b >= 100000 && b < 1000000 &&
                c >= 100000 && c < 1000000)  // dogru

            {
                d = (a * 10) / 100;       // 12345
                e = (b * 10) / 100;       // 23456
                f = (c * 10) / 100;       // 34567
                g = d + e + f;            // 70368
                h = (g * 10) / 100;       // 7036

                Console.WriteLine(d);
                Console.WriteLine(e);
                Console.WriteLine(f);
                Console.WriteLine(g);
                Console.WriteLine(h);

            }

            else

            {
                Console.WriteLine("6 regemli deyil");
            }
        }
    }
}
