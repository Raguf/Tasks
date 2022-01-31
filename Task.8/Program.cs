using System;

namespace Task._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2 dene eded verilib. 
             * I eded 4 reqemli II eded 7 reqemlidir.
               I ededin 4%-ni tap.
               Sonra II ededin 9% ni tap.
               Sonra Cavalari toplayib 10 %ni tap.*/

            int a = 1234;
            int b = 2345678;
            int c;
            int d;
            int e;
            int f;

            if (a >= 1000 && a < 10000 &&
                b >= 1000000 && b < 10000000) // dogru

            {
                c = (a * 4) / 100;       // 49
                d = (b * 9) / 100;       // 211111
                e = c + d;               // 211160
                f = (e * 10) / 100;      // 21116


                Console.WriteLine(c);
                Console.WriteLine(d);
                Console.WriteLine(e);
                Console.WriteLine(f);

            }

            else

            {
                Console.WriteLine("Duzgun deyil");
            }
        }
    }
}
