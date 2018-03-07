using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{
    class Exercicio2
    {
        public static void Dobro()
        {
            int valor, result;

            Console.Write("Digite um valor: ");
            valor = int.Parse(Console.ReadLine());

            result = valor + valor;

            Console.WriteLine("O dobro de {0} é {1}", valor, result);
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
