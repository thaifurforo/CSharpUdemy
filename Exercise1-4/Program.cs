using System;
using System.Globalization;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número do funcionário:");
            int funcionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de horas trabalhadas do funcionário:");
            int horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor recebido por hora pelo funcionário:");
            double valor = double.Parse(Console.ReadLine());
            
            double resultado = horas * valor;

            Console.WriteLine($"NUMBER = {funcionario}\nSALARY = U{resultado.ToString("C", new CultureInfo("en-US"))}");
            
        }
    }
}