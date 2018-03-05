using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeiroRenascido
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, total;

            a = 20;
            b = 10;
            total = a - b;

            Console.WriteLine("Exemplos 2-------------------------------\n");
            Console.WriteLine(a+" + "+b+" = " + (a+b));
            Console.WriteLine(a+" - "+b+" = " + (total));
            Console.WriteLine(a+" * "+b+" = " + (a*b));
            Console.WriteLine(a+" / "+b+" = " + (a/b));
            Console.WriteLine(a+" % "+b+" = " + (a%b));
            Console.ReadKey();

            Console.WriteLine("\nExemplos 3-------------------------------\n");
            Contantes.Contante();
            Console.WriteLine("\nExemplos 4-------------------------------\n");
            Cadeia.Cadeias();
            Console.WriteLine("\nExemplos 5-------------------------------\n");
            Entrada_de_dados.Entradas();
        }
    }
}
