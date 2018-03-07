using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{
    class Exercicio3
    {
        public static void Potenciacao()
        {
            int vIn, vOut;

            Console.Write("Digite um número: ");
            vIn = double.Parse(Console.ReadLine());

            vOut = Math.Pow(vIn, 2);

            Console.Write("O quadrado de {0} é: {1}.", vIn, vOut);

            Console.ReadKey();
        }
    }
}
