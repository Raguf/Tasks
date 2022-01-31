using System;

namespace Task._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4 dene 5 reqemli eded verilib. 
             * I ededin ustune III ededi gel . 
             * II ededin usutune IV eeddi gel.
               Sonra cavablari vur birbirine. 
               Alinan neticeden III ededin 3%-ni cix.*/

            uint a = 12345;
            uint b = 23456;
            uint c = 34567;
            uint d = 45678;
            uint e;
            uint f;
            uint g;
            uint h;
            uint i;

            if (a >= 10000 && a < 100000 &&
                b >= 10000 && b < 100000 &&
                c >= 10000 && c < 100000 &&
                d >= 10000 && d < 100000)  // dogru

            {
                e = a + c;           // 45678                
                f = b + d;           // 46912
                g = e * f;           // 3243214208
                h = (c * 3) / 100;   // 1037
                i = g - h;          // 3243213171

                Console.WriteLine(d);
                Console.WriteLine(e);
                Console.WriteLine(f);
                Console.WriteLine(g);
                Console.WriteLine(h);
                Console.WriteLine(i);

            }

            else

            {
                Console.WriteLine("5 regemli deyil");
            }
        }
    }
}
