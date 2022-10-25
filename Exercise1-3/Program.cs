using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor inteiro");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor inteiro");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor inteiro");
            int C = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quarto valor inteiro");
            int D = int.Parse(Console.ReadLine());

            int resultado = A * B - C * D;

            Console.WriteLine($"DIFERENCA = {resultado}");
            
        }
    }
}