using System;

namespace Task._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 5 dene eded verilib. Bunlardan 3 denesi 5 reqemli. 
             * 2 denesi ise 3 reqemlidir. 5 reqemli ededlerin 5% tap ,neticeleri vur bir birine.
               Sonra 3 reqemli ededlerin 3% tap ,neticeleri topla. 
               Sonra yekunda alinan iki cavalarin her birinin 10%-ni tapib topla.*/

            uint a = 123;
            uint b = 234;
            uint c = 34567;
            uint d = 45678;
            uint e = 56789;
            uint f;
            uint g;
            uint h;
            uint i;
            uint j;
            uint k;
            uint l;
            uint m;
            uint n;
            uint o;

            if (a >= 100 && a < 1000 &&
                b >= 100 && b < 1000 &&
                c >= 10000 && c < 100000 &&
                d >= 10000 && d < 100000 &&
                e >= 10000 && e < 100000)  // dogru

            {                          
                f = (c * 5) / 100;           // 1728
                g = (d * 5) / 100;           // 2283
                h = (e * 5) / 100;           // 2839
                i = f * g * h;               // 2609988544
                j = (a * 3) / 100;           // 3
                k = (b * 3) / 100;           // 7
                l = j + k;                   // 10
                m = (i * 10) / 100;          // 3300816
                n = (l * 10) / 100;          // 1
                o = m + n;                   // 3300817

                Console.WriteLine(f);
                Console.WriteLine(g);
                Console.WriteLine(h);
                Console.WriteLine(i);
                Console.WriteLine(j);
                Console.WriteLine(k);
                Console.WriteLine(l);
                Console.WriteLine(m);
                Console.WriteLine(n);
                Console.WriteLine(o);             

            }

            else

            {
                Console.WriteLine("Duzgen deyil");
            }
        }
    }
}
