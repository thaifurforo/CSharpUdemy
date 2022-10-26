using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor inteiro para saber o seu fatorial: ");
            int n = int.Parse(Console.ReadLine());
            int fatorial = 1;
            for (int i = 0; i < n; i++)
            {
                fatorial *= (n - i);
            }

            Console.Write(fatorial);
        }

    }
}