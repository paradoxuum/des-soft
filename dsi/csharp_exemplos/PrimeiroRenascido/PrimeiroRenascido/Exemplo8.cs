using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeiroRenascido
{
    class Exemplo8
    {
        public static void Relacionais()
        {
            int a, b;
            Console.WriteLine("Exemplo - Operadores Relacionais");
            Console.WriteLine("********************************\n\n");

            Console.Write("Digite um número: "); a = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: "); b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("{0} é igual a {1}?           Resposta: {2}", a, b, (a == b));
            Console.WriteLine("{0} é diferente de {1}?      Resposta: {2}", a, b, (a != b));
            Console.WriteLine("{0} é maior que {1}?         Resposta: {2}", a, b, (a > b));
            Console.WriteLine("{0} é menor que {1}?         Resposta: {2}", a, b, (a < b));
            Console.WriteLine("{0} é maior ou igual {1}?    Resposta: {2}", a, b, (a >= b));
            Console.WriteLine("{0} é menor ou igual {1}?    Resposta: {2}", a, b, (a <= b));
            Console.ReadKey();
        }
    }
}
