using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Entre seu último nome, idade e altura (Mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');

            string sobrenome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);

        }
    }
}