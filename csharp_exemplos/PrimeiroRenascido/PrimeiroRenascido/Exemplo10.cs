using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeiroRenascido
{
    class Exemplo10
    {
        public static void Ternarios()
        {
            int a, b;
            string verdade = "Sim", falso = "Näo";

            Console.WriteLine("Digite um número inteiro: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número inteiro: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("{0} > {1} ? Resposta: ", a, b);
            Console.WriteLine(a > b ? verdade : falso);
            Console.ReadKey();
        }
    }
}
