using System;

namespace CastingAndConversion
{
    class Program
    {
        static void Main(string[] args)
        {

            float x = 4.5f;
            double y = x;
            // Conversão implícita entre tipos
            Console.WriteLine(y);

            double a = 5.1;
            float b = (float)a;
            Console.WriteLine(a);
            // Casting

            int p = 5;
            int q = 2;
            double resultado = p / q;
            Console.WriteLine(resultado);
            
            resultado = (double)p / q;
            Console.WriteLine(resultado);
            // Necessário fazer casting senão ele considera que int / int = int, mesmo que a variável seja double 

        }
    }

}