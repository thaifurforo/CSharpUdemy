using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
            { 
                Console.WriteLine("Digite um numero inteiro");
                int x = int.Parse(Console.ReadLine());
                
                if (x < 0)
                    Console.WriteLine("NEGATIVO");
                else
                    Console.WriteLine("NAO NEGATIVO");
            }
    }
}