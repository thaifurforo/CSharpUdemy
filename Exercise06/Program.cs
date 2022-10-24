using System;
using System.Globalization;

namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número qualquer");
            double numero = double.Parse(Console.ReadLine());

            string intervalo = "Fora de intervalo";

            if (numero >= 0 && numero <= 25)
            {
                intervalo = "Intervalo [0, 25]";
            }
            else if (numero > 25 && numero <= 50)
            {
                intervalo = "Intervalo (25, 50]";
            }
            else if (numero > 50 && numero <= 75)
            {
                intervalo = "Intervalo (50, 75]";
            }
            else if (numero > 75 && numero <= 100)
            {
                intervalo = "Intervalo (75, 100]";
            }
            Console.WriteLine(intervalo);
        }
    }
}