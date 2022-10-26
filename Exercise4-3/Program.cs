using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de valores que serão lidos: ");
            int n = int.Parse(Console.ReadLine());
            int inInterval = 0;
            int outInterval = 0;
            for (int x = 1; x <= n; x++)
            {
                Console.Write($"Digite o {x}º valor: ");
                int i = int.Parse(Console.ReadLine());
                if (i <= 20 && i >= 10)
                    inInterval += 1;
                else
                    outInterval += 1;
            }

            Console.Write($"{inInterval} in\n{outInterval} out");
        }

    }
}