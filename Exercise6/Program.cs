using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A, B e C:");
            string[] valores = Console.ReadLine().Split(' ');

            double A = double.Parse(valores[0]);
            double B = double.Parse(valores[1]);
            double C = double.Parse(valores[2]);

            double triangulo = A * (C / 2);
            double circulo = 3.14159 * Math.Pow(C, 2);
            double trapezio = ((A + B) * C) / 2;
            double quadrado = Math.Pow(B, 2);
            double retangulo = A * B;
            
            Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3")}");
            Console.WriteLine($"CIRCULO: {circulo.ToString("F3")}");
            Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3")}");
            Console.WriteLine($"QUADRADO: {quadrado.ToString("F3")}");
            Console.WriteLine($"RETANGULO: {retangulo.ToString("F3")}");
            
        }
    }
}