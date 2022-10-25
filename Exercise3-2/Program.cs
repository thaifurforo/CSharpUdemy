using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;

            do
            {
                string[] coordenadas = Console.ReadLine().Split(' ');
                double x = double.Parse(coordenadas[0]);
                double y = double.Parse(coordenadas[1]);
                
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }
                else
                {
                    loop = false;
                }

            } while (loop);
        }

    }
}