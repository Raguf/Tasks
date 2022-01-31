using System;

namespace Task._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   4 reqemli eded verilib. 
              Bu ededin eveline 7 reqemini , 
              axirinada 8 reqemini artir. 
               Example1: 333= 73338*/

            int a = 1234;
            int b;
            int c;

            if (a >= 1000 && a < 10000) // dogru

            {

                b = 70000 + a;  // 71234

                c = b * 10 + 8; // 712348

                Console.WriteLine(a);
                Console.WriteLine(b); 
                Console.WriteLine(c);
            }

            else

            {
                Console.WriteLine("4 reqemli deyil");
            }

        }
    }
}
