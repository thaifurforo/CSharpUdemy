using System;
using System.Threading.Channels;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 127;
            x++;
            // sbyte vai de -128 a 127
            // Quando incrementa em 1 no limite 127, volta ao limite oposto, portanto 127 + 1 = -128
            Console.WriteLine(x);

            byte y = 255;
            y++;
            // byte vai de 0 a 255 (not signed - não tem sinal de negativo)
            // Quando incrementa em 1 no limite, volta ao limite 255, volta ao limite oposto, portanto 255 + 1 = 0
            Console.WriteLine(y);

            int n1 = 1235697001;
            // No long precisa colocar L no final do número
            long n2 = 1235948927397213L;

            char genero = 'F';
            Console.WriteLine(genero);
            
            char letra = '\u0041';
            Console.WriteLine(letra);
            
            char letra2 = (char)41;
            Console.WriteLine(letra2);

            // No final do float precisa colocar f 
            float n3 = 12.345f;
            Console.WriteLine(n3);

            double n4 = 1.234;
            Console.WriteLine(n4);
            
            // No final do decimal precisa colocar m
            decimal n5 = 1.232412513524624234m;
            Console.WriteLine(n5);

            // string é imutável
            string nome = "Maria Green";
            Console.WriteLine(nome);
            nome = "João Yellow";
            Console.WriteLine(nome);
            
            // object - objeto genérico
            // toda subclasse é um object
            // pode receber qualquer tipo de valor
            object obj1 = "Alex Brown";
            object obj2 = 1.23f;
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            int menorNumero = int.MinValue;
            Console.WriteLine(menorNumero);

            int maiorNumero = int.MaxValue;
            Console.WriteLine(maiorNumero);

            decimal maiorValor = decimal.MaxValue;
            Console.WriteLine(maiorValor);

        }
    }
}