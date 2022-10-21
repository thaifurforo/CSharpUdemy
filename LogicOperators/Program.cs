using System;

namespace LogicOperators
{
    class Program
    {
        static void Main(string[] args)
        {

            bool c1 = 4 != 5 && 2 > 3;
            Console.WriteLine(c1);

            bool c2 = 4 != 5 || 2 > 3;
            Console.WriteLine(c2);

            bool c3 = 4 != 5 && !(2 > 3);
            Console.WriteLine(c3);

        }
    }
}