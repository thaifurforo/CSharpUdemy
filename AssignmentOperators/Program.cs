using System;

namespace AssignmentOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            
            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            a /= 2;
            Console.WriteLine(a);

            a %= 4;
            Console.WriteLine(a);

            a -= 1;
            Console.WriteLine(a);

            a++;
            ++a;
            Console.WriteLine(a);

            a--;
            --a;
            Console.WriteLine(a);

            string s = "ABC";
            s += "DEF";
            Console.WriteLine(s);

            int x = 10;
            int y = x++;
            Console.WriteLine(x);
            Console.WriteLine(y);

            int xx = 10;
            int yy = ++xx;
            Console.WriteLine(xx);
            Console.WriteLine(yy);
        }
    }
} 