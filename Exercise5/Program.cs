using System;
using System.Globalization;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Código, número de peças e valor unitário de cada peça 1:");
            string[] peca1 = Console.ReadLine().Split(' ');

            Console.WriteLine("Código, número de peças e valor unitário de cada peça 2:");
            string[] peca2 = Console.ReadLine().Split(' ');

            int qtd1 = int.Parse(peca1[1]);
            double valor1 = double.Parse(peca1[2]);
            
            int qtd2 = int.Parse(peca2[1]);
            double valor2 = double.Parse(peca2[2]);

            double valor = qtd1 * valor1 + qtd2 * valor2;
            
            Console.WriteLine($"VALOR A PAGAR = {valor.ToString("C", CultureInfo.CurrentCulture)}");
            
        }
    }
}