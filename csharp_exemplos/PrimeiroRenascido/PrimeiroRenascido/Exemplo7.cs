using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeiroRenascido
{
    class Exemplo7
    {
        public static void Adicoes()
        {
            int a, b, c;
            Console.Write("Digite um número: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            b = int.Parse(Console.ReadLine());

            c = a + b;

            Console.Write(a + " + " + b + " = " + c);
            Console.ReadKey();

        }
    }
}
