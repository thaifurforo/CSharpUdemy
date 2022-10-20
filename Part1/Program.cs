using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            Console.WriteLine($"Você digitou {frase}, {x}, {y} e {z}");

            string s = Console.ReadLine();
            string[] vet = s.Split(' ');
            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine(vet[i]);
            }

            string[] vet2 = Console.ReadLine().Split(' ');
            for (int i = 0; i < vet2.Length; i++)
            {
                Console.WriteLine(vet2[i]);
            }


        }
    }
}