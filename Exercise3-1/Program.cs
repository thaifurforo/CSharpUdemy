using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha = "2002";
            Console.WriteLine("Digite sua senha:");
            string input = Console.ReadLine();

            while (senha != input)
            {
                Console.WriteLine("Senha Invalida");
                Console.WriteLine("---------------");
                Console.WriteLine("Digite sua senha:");
                input = Console.ReadLine();
            }

            Console.WriteLine("Acesso permitido");
        }

    }
}