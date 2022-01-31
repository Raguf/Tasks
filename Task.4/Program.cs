using System;

namespace Task._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 3 reqemli eded verilib. 
               Bu ededin axirina 7 artir. 
               Sonra cavabin 7% tap;*/

            int a = 123;
            int b;
            int c;
            int d;

            if (a >= 100 && a < 1000) // dogru

            {
                b = a * 10;         // 1230
                c = b + 7;          // 1237
                d = (c * 7) / 100;  // 86

                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(d);
            }

            else

            {
                Console.WriteLine("3 reqemli deyil");
            }
        }
    }
}
