using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de testes que serão realizados: ");
            int n = int.Parse(Console.ReadLine());
            for (int x = 1; x <= n; x++)
            {
                Console.Write($"Digite os 3 valores do {x}º teste: ");
                string[] valores = Console.ReadLine().Split(' ');
                double a = double.Parse(valores[0]) * 2;
                double b = double.Parse(valores[1]) * 3;
                double c = double.Parse(valores[2]) * 5;
                double media = (a + b + c) / 10;
                Console.WriteLine(media);
            }
        }

    }
}