using System;
using System.Globalization;

namespace ScopeAndInitialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o preço:");
            double preco = double.Parse(Console.ReadLine());

            double desconto;

            if (preco > 100.0)
                desconto = preco * 0.1;
            else
                desconto = preco * 0.05;

            Console.WriteLine($"O desconto é de {desconto.ToString("C2", CultureInfo.CurrentCulture)}");
            
        
        }
    }    
}

