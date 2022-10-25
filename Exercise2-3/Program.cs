using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Digite dois valores inteiros em sequência, separados por espaço");
            string[] numeros = Console.ReadLine().Split(' ');
            
            int num1 = int.Parse(numeros[0]);
            int num2 = int.Parse(numeros[1]);

            bool multiplos;

            if (num1 > num2)
                multiplos = num1 % num2 == 0;
            else
                multiplos = num2 % num1 == 0;

            if (multiplos)
                Console.WriteLine("Sao Multiplos");
            else
                Console.WriteLine("Nao sao Multiplos");
            
        }
    }
}