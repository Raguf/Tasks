using System;

namespace Task._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 3 dene 4 reqemli eded verilib. 
             * I ededin 1%-ni, II ededin 2%, III ededin 3 % tap.
               Neticeleri bir birinden cix. 
               Alinan cavabin ustune III ededin 7% faizini gel*/

            int a = 1234;
            int b = 2345;
            int c = 3456;
            int d;
            int e;
            int f;
            int g;
            int h;
            int i;

            if (a >= 1000 && a < 10000 &&
                b >= 1000 && b < 10000 &&
                c >= 1000 && c < 10000)  // dogru

            {
                d = (a * 1) / 100;       // 12
                e = (b * 2) / 100;       // 46
                f = (c * 3) / 100;       // 103
                g = d - e - f;           // -137
                h = (c * 7) / 100;       // 241
                i = g + h;               // 104

                Console.WriteLine(d);
                Console.WriteLine(e);
                Console.WriteLine(f);
                Console.WriteLine(g);
                Console.WriteLine(h);
                Console.WriteLine(i);

            }

            else

            {
                Console.WriteLine("4 regemli deyil");
            }
        }
    }
}
