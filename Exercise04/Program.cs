using System;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a hora inicial e a hora final do jogo (separados por espaço)");
            string[] numeros = Console.ReadLine().Split(' ');

            int horaInicial = int.Parse(numeros[0]);
            int horaFinal = int.Parse(numeros[1]);

            int duracao;

            if (horaInicial > horaFinal)
            {
                duracao = horaFinal + 24 - horaInicial;
            }
            else if (horaFinal == horaInicial)
            {
                duracao = 24;
            }
            else
            {
                duracao = horaFinal - horaInicial;
            }

            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");

        }
    }
}