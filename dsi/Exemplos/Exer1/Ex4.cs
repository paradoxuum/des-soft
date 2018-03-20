using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{
    class Ex4
    {
        public static void ExQuatro()
        {
            double a, b, c, exp;

            Console.WriteLine("\nExercicio 4");
            Console.WriteLine("Entre com as variáveis e receba o resultado");
            Console.Write("\nA = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("\nB = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("\nC = ");
            c = double.Parse(Console.ReadLine());

            exp = ((Math.Pow(a, 2)) * 5 - c) / (b - (a % 4));

            Console.Write("\n \n O resultado da sua expressão é de: {0}.", exp);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
