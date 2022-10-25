using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você irá digitar? ");
            int n = int.Parse(Console.ReadLine());
            int soma = 0; 
            for (int x = 1; x <= n; x++)
            {
                Console.Write($"Digite o {x}º número inteiro: ");
                soma += int.Parse(Console.ReadLine());
            }

            Console.Write($"Soma = {soma}");
        }

    }
}