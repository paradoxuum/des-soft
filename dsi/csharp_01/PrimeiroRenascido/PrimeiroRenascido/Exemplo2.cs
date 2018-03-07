using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeiroRenascido
{
    class Exemplo2
    {
        static void Main(string[] args)
        {
            int a, b, total;

            a = 20;
            b = 10;
            total = a - b;

            Console.WriteLine("Exemplo 2-------------------------------\n");
            Console.WriteLine(a+" + "+b+" = " + (a+b));
            Console.WriteLine(a+" - "+b+" = " + (total));
            Console.WriteLine(a+" * "+b+" = " + (a*b));
            Console.WriteLine(a+" / "+b+" = " + (a/b));
            Console.WriteLine(a+" % "+b+" = " + (a%b));
            Console.ReadKey();

            //Outros exemplos
            Console.WriteLine("\nExemplo 3-------------------------------\n");
            Exemplo3.Contantes();
            Console.WriteLine("\nExemplo 4-------------------------------\n");
            Exemplo4.Cadeias();
            Console.WriteLine("\nExemplo 5-------------------------------\n");
            Exemplo5.Entradas();
            Console.WriteLine("\nExemplo 6-------------------------------\n");
            Exemplo6.Conversao();
            Console.WriteLine("\nExemplo 7-------------------------------\n");
            Exemplo7.Adicoes();
            Console.WriteLine("\nExemplo 8-------------------------------\n");
            Exemplo8.Relacionais();
            Console.WriteLine("\nExemplo 9-------------------------------\n");
            Exemplo9.Logico();
            Console.WriteLine("\nExemplo 10------------------------------\n");
            Exemplo10.Ternarios();
            Console.WriteLine("\nExemplo 10------------------------------\n");
            Exemplo11.Atribuicao();

        }
    }
}
