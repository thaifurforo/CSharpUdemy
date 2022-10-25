using System;
using System.Globalization;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            string codigo;

            do
            {
                codigo = Console.ReadLine();
                
                if (codigo == "1")
                {
                    alcool += 1;
                }
                else if (codigo == "2")
                {
                    gasolina += 1;
                }
                else if (codigo == "3")
                {
                    diesel += 1;
                }

            } while (codigo != "4");

            Console.WriteLine("MUITO OBRIGADO\n" +
                              $"Alcool: {alcool}\n" +
                              $"Gasolina: {gasolina}\n" +
                              $"Diesel: {diesel}");

        }

    }
}