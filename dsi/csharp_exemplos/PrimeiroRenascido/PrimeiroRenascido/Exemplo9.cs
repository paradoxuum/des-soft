﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeiroRenascido
{
    class Exemplo9
    {
        public static void Logico()
        {
            bool i, j;

            Console.WriteLine("Exemplo - Operadores Lógicos");
            Console.WriteLine("********************************\n\n");
            Console.WriteLine("Digite true (verdadeiro) ou false (falso)\n");

            Console.Write("Valor Lógico 1: "); i = Boolean.Parse(Console.ReadLine());
            Console.Write("Valor Lógico 2: "); j = Boolean.Parse(Console.ReadLine());

            Console.WriteLine("\nResultados testando os operadores lógicos\n");
            Console.WriteLine("{0} AND {1} resulta {2}", i, j, i && j);
            Console.WriteLine("{0} OR {1} resulta {2}", i, j, i || j);
            Console.WriteLine("Valor 1: NOT {0} resulta {1}", i, !i);
            Console.WriteLine("Valor 2: NOT {0} resulta {1}", j, !j);
            Console.ReadKey();
        }
    }
}
