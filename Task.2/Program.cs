using System;

namespace Task._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 3 reqemli eded verilib. 
               Bu ededin axirina hemin ededdin ozunu yapishdir. 
               example: 333= 333333;*/

            int a = 123;
            int b;
            int c;

            if (a >= 100 && a < 1000) // dogru

            {
                b = 1000 * a;  // 123000
                c = b + a;     // 123123

                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            }

            else

            {
                Console.WriteLine("3 reqemli deyil");
            }
        }
    }
}
