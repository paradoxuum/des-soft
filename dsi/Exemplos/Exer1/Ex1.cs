using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{
    class Ex1
    {
        public static void ExUm()
        {
            string nome, cidade;
            int idade;
            Console.WriteLine("\nExercicio 1");
            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.Write("\nDigite a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("\nDigite a cidade em que você reside: ");
            cidade = Console.ReadLine();

            Console.WriteLine("\n{0} tem {1} anos e reside em {2}.", nome, idade, cidade);

            Console.ReadKey();
            Console.Clear();

        }
    }
}
