using System;
using System.Globalization;

namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o código do produto e a quantidade (separados por espaço)");
            string[] numeros = Console.ReadLine().Split(' ');

            int codigo = int.Parse(numeros[0]);
            int quantidade = int.Parse(numeros[1]);

            double preco = 0;

            if (codigo == 1)
            {
                preco = 4.0;
            }
            else if (codigo == 2)
            {
                preco = 4.5;
            }
            else if (codigo == 3)
            {
                preco = 5.0;
            }
            else if (codigo == 4)
            {
                preco = 2.0;
            }
            else if (codigo == 5)
            {
                preco = 1.5;
            }

            double valorConta = preco * quantidade;

            Console.WriteLine($"Total: {valorConta.ToString("C2", CultureInfo.CurrentCulture)}");
        }
    }
}