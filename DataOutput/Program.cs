using System;

namespace DataOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.Write("Boa noite!");
            Console.WriteLine("Olá!");

            decimal x = 1.233456m;
            Console.WriteLine(x.ToString("F2"));

            int idade = 32;
            double saldo = 10.35783;
            string nome = "Maria";
            
            Console.WriteLine("{0} tem {1} anos e {2:F2} reais em sua conta.", nome, idade, saldo);
            
            Console.WriteLine($"{nome} tem {idade} e {saldo:F2} reais em sua conta.");

            Console.WriteLine(nome + " tem " + idade + " e " + saldo.ToString("F2") + " reais em sua conta.");
        }
    }
}