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

            Console.WriteLine("-----------------");

            bool c4 = c2 || c3 && c1;
            // c3 && c1 = false
            // false || c2 (true) = true
            Console.WriteLine(c4);
            
            bool c5 = (c2 || c3) && c1;
            // c2 || c3 = true
            // true && c1 (false) = false
            Console.WriteLine(c5);

        }
    }
}