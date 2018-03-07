using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{
    class Exercicio1
    {
        public static void Coleta() 
        {
            string nome, cidade;
            int idade;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write(nome + ", digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Digite onde nasceu: ");
            cidade = Console.ReadLine();

            Console.WriteLine("{0} tem {1} anos de idade e nasceu em {2}.", nome, idade, cidade);
            Console.ReadKey();
            Console.WriteLine();
            
        }
    }
}
