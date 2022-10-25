using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Entre com um numero inteiro");
            int numero = int.Parse(Console.ReadLine());
            
            if (numero % 2 == 0)
                Console.WriteLine("PAR");
            else
                Console.WriteLine("IMPAR");
        }
    }
}