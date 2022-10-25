using System;
using System.Globalization;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While:\n");

            Console.Write("Digite um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            while (x > 0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("---------------\nDo While:\n");

            Console.Write("Digite um número: ");
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            do
            {
                double raiz = Math.Sqrt(y);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número: ");
                y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            } while (y > 0);

            // No do while o primeiro loop é executado independente se é true ou false o valor dentro do while
            // Ele verifica a condição depois da execução, e retorna o loop se for verdadeira

        }

    }
}