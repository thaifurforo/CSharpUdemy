using System;

namespace ConditionalStrucutre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que horas são? Digite um número inteiro entre 0 e 23");
            int hora = int.Parse(Console.ReadLine());
            
            if (hora >= 18 || hora < 6)
            {
                Console.WriteLine("Boa noite");
            }
            else if (hora >= 12 && hora < 18)
            {
                Console.WriteLine("Boa tarde");
            }
            else
            {
                Console.WriteLine("Bom dia");    
            }

            Console.WriteLine("--------------");

            Console.WriteLine("Entre com um número inteiro");
            int numero = int.Parse(Console.ReadLine());
            
            if (numero % 2 == 0)
                Console.WriteLine("Este número é par!");
            else
                Console.WriteLine("Este número é ímpar!");


        }
    }
}