using System;

namespace Exercise2
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Digite o raio do círuclo");
            double raio = double.Parse(Console.ReadLine());

            string area = (3.14159 * Math.Pow(raio, 2)).ToString("F4");

            Console.WriteLine($"A={area}");

        }
    }
}