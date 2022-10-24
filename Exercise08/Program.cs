using System;
using System.Globalization;

namespace Exercise08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do salário:");
            double salario = double.Parse(Console.ReadLine());

            string mensagem = "Isento";
            double imposto = 0.0;
            

            if (salario > 2000)
            {
                if (salario <= 3000)
                    imposto += ((salario - 2000) * 0.08);
                else
                {
                    imposto += (1000 * 0.08);
                    if (salario <= 4500)
                        imposto += ((salario - 3000) * 0.18);
                    else
                    {
                        imposto += (1500 * 0.18 + (salario - 4500) * 0.28);
                    }
                }

                mensagem = imposto.ToString("C2", CultureInfo.CurrentCulture);
            }
            
            Console.WriteLine(mensagem);
        }
    }
}