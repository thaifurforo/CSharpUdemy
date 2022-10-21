using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor inteiro:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor inteiro:");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"SOMA = {x+y}");
        }
    }
}