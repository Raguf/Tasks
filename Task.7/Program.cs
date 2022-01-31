using System;

namespace Task._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 2 dene 5 reqemli eded verilib. 
             * Bu ededleri toplayib. 
             * Alinan cavabin evveline ve axirina 5 artir. 
             * Neticenin 5 % tap*/

            int a = 12345;
            int b = 23456;
            int c;
            int d;
            int e;
            int f;

            if (a >= 10000 && a < 100000 &&
                b >= 10000 && b < 100000) // dogru

            {             
                c = a + b;              // 35801
                d = 500000 + c;         // 535801
                e = d * 10 + 5;         // 5358015
                f = (e * 5) / 100;      // 267900


                Console.WriteLine(c);
                Console.WriteLine(d);
                Console.WriteLine(e);
                Console.WriteLine(f);

            }

            else

            {
                Console.WriteLine("5 regemli deyil");
            }
        }
    }
}
