using System;
using System.Globalization;

namespace Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os valores de x e y (separados por espaço):");
            string[] numeros = Console.ReadLine().Split(' ');

            double x = double.Parse(numeros[0]);
            double y = double.Parse(numeros[1]);

            string mensagem = "Origem";

            if (x > 0 && y > 0)
            {
                mensagem = "Q1";
            }
            else if (x < 0 && y > 0)
            {
                mensagem = "Q2";
            }
            else if (x < 0 && y < 0)
            {
                mensagem = "Q3";
            }
            else if (x > 0 && y < 0)
            {
                mensagem = "Q4";
            }
            else
            {
                if (x != 0)
                {
                    mensagem = "Eixo Y";
                }
                else if (y != 0)
                {
                    mensagem = "Eixo X";
                }
            }

            Console.WriteLine(mensagem);
        }
    }
}