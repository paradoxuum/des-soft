using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{
    class Ex2
    {
        public static void ExDois()
        {
            int a;

            Console.WriteLine("\nExercicio 2");
            Console.Write("Digite um número para saber o resultado do dobro dele: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\nO resultado é: {0}", a += a);

            Console.ReadKey();
            Console.Clear();
        }
    }
}
