using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{
    class Ex3
    {
        public static void ExTres()
        {
            double num, result;

            Console.WriteLine("\nExercicio 3");
            Console.Write("Raiz Quadrada");
            Console.Write("\n\nDigite um número: ");
            num = int.Parse(Console.ReadLine());

            result = Math.Pow(num, 2);

            Console.Write("\n\nO quadrado de {0} é: {1}.", num, result);

            Console.ReadKey();
            Console.Clear();
        }
    }
}
