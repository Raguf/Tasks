using System;

namespace Task._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4 dene 6 reqemli eded verilib. 
             * Ededlerin hamisinin 10 faizini tap ve topla. 
             * Sonra hamisinin 15 faizini tap ve topla.
               Sonra yekunda alinanlar iki cavabi vur biri birine. 
               Alinan neticenin evvel 10% tap sonra ise hemin cavabin 11% tap.*/

            uint a = 123456;
            uint b = 234567;
            uint c = 345678;
            uint d = 456789;
            uint e;
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
            uint p;
            uint q;


            if (a >= 100000 && a < 1000000 &&
                b >= 100000 && b < 1000000 &&
                c >= 100000 && c < 1000000 &&
                d >= 100000 && d < 1000000)  // dogru

            {
                e = (a * 10) / 100;           // 12345               
                f = (b * 10) / 100;           // 23456
                g = (c * 10) / 100;           // 34567
                h = (d * 10) / 100;           // 45678
                i = e + f + g + h;            // 116046
                j = (e * 15) / 100;           // 1851
                k = (f * 10) / 100;           // 2345
                l = (g * 10) / 100;           // 3456
                m = (h * 10) / 100;           // 4567
                n = j + k + l + m;            // 12219
                o = i * n;                    // 1417966074
                p = (o * 10) / 100;           // 12947588
                q = (p * 11) / 100;           // 1424234

                Console.WriteLine(e);
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
                Console.WriteLine(p);
                Console.WriteLine(q);

            }

            else

            {
                Console.WriteLine("6 regemli deyil");
            }


        }
    }
}
