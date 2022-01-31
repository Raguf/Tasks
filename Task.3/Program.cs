using System;

namespace Task._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 5 reqemli eded verilib. 
               Bu ededin evvel 18 % 
               sonra ise 3 % tap.*/

            int a = 12345;
            int b;
            int c;

            if (a >= 10000 && a < 100000) // dogru

            {

                b = (a * 18) / 100;  // 2222
                c = (b * 3) / 100;  // 66

                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            }

            else

            {
                Console.WriteLine("5 reqemli deyil");
            }
        }
    }
}
