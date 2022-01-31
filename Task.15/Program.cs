using System;

namespace Task._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  7 dene eded verilib.Bunlardan 2 denesi 3 reqemlidir. 
             *  2 denesi 4 reqemlidir. 2 denesi 5 reqemlidir.1 denesi ise 6 reqemlidir.
                3 reqemli ededleri topla , sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.
                Sonra neticenin axirina 7 reqemini artir. Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
                Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
                Sonra alinan cavabin ustune gel 6 reqemli ededi.
                Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
                Sonra alinan cavabin 18% -ni sonra 3%-ni sonra 1% tap.
                Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.*/

            long a = 123;
            long b = 234;
            long c = 3456;
            long d = 4567;
            long e = 56789;
            long f = 67890;
            long g = 789012;
            long h;
            long i;
            long j;
            long k;
            long l;
            long l1;
            long m;
            long n;
            long o;
            long p;
            long q;
            long r;
            long s;
            long t;
            long u;
            long v;
            long w;
            long x;


            if (a >= 100 && a < 1000 &&
                b >= 100 && b < 1000 &&
                c >= 1000 && c < 10000 &&
                d >= 1000 && d < 10000 &&
                e >= 10000 && e < 100000 &&
                f >= 10000 && f < 100000 &&
                g >= 100000 && f < 1000000)  // dogru

            {
                h = a + b;               // 357
                i = c * d;               // 15783552
                j = h + i;               // 15783909
                k = g - i;               //-14994540
                l = (k * 10);            //-149945400
                l1 = l + 7;              //-149945393
                m = e + f;               // 124679
                n = l + m;               //-149820721
                o = a * b;               // 28782
                p = (o * 10) + 1;        // 287821
                q = n - p;               //-150108542
                r = q + g;               //-149319530
                s = d + f;               // 72457
                t = r - (h + s);         //-149392344
                u = (t * 18) / 100;      //-26890621
                v = (u * 3) / 100;       //-806718
                w = (v * 1) / 100;       //-8067
                x = w + m;               // 116612

                Console.WriteLine(h);
                Console.WriteLine(i);
                Console.WriteLine(j);
                Console.WriteLine(k);
                Console.WriteLine(l);
                Console.WriteLine(l1);
                Console.WriteLine(m);
                Console.WriteLine(n);
                Console.WriteLine(o);
                Console.WriteLine(p);
                Console.WriteLine(q);
                Console.WriteLine(r);
                Console.WriteLine(s);
                Console.WriteLine(t);
                Console.WriteLine(u);
                Console.WriteLine(v);
                Console.WriteLine(w);
                Console.WriteLine(x);
 
            }

            else

            {
                Console.WriteLine("Duzgun deyil");
            }
        }
    }
}
