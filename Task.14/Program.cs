using System;

namespace Task._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 6 dene 6 reqemli eded verilib. 
             * Evvel hamisini topla . 
             * Sonra I ve III ededi bir birine yapishdir ve bir eded al.
               I neticeden II neticeni cix. Alinan cavabin 10% tap. 
               Neticenin uzerine V ve VI ededleri gel. Yekunda alinan cavabin 11% tap.*/

            long a = 123456;
            long b = 234567;
            long c = 345678;
            long d = 456789;
            long e = 567890;
            long f = 678901;
            long g;
            long h;
            long i;
            long j;
            long k;
            long l;
            long m;


            if (a >= 100000 && a < 1000000 &&
                b >= 100000 && b < 1000000 &&
                c >= 100000 && c < 1000000 &&
                d >= 100000 && d < 1000000 &&
                e >= 100000 && e < 1000000 &&
                f >= 100000 && f < 1000000)  // dogru

            {              
                g = a + b + c + d + e + f;     // 2407281
                h = a * 1000000;               // 123456000000
                i = h + c;                     // 123456345678
                j = g - i;                     //-123453938397
                k = (j * 10) / 100;            //-12345393839
                l = k + e + f;                 //-12344147048
                m = (l * 11) / 100;            //-1357856175

                Console.WriteLine(g);
                Console.WriteLine(h);
                Console.WriteLine(i);
                Console.WriteLine(j);
                Console.WriteLine(k);
                Console.WriteLine(l);
                Console.WriteLine(m);


            }

            else

            {
                Console.WriteLine("6 regemli deyil");
            }
        }
    }
}
