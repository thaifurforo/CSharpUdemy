using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor inteiro: ");
            int n = int.Parse(Console.ReadLine());
            for (int x = 1; x <= n; x++)
            {
                bool impar = x % 2 != 0;
                if (impar)
                {
                    Console.WriteLine(x);
                }
            }
        }

    }
}