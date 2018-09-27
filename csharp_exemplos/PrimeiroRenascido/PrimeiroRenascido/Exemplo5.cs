using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeiroRenascido
{
    class Exemplo5
    {
        public static void Entradas() 
        {
            string nome, cidade;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite o nome da cidade em que nasceu: ");
            cidade = Console.ReadLine();

            Console.WriteLine("\n***INFORMAÇÕES DIGITADAS***\n");
            Console.WriteLine("Seu nome: " + nome);
            Console.WriteLine("Cidade de Nascimento: " + cidade);
            Console.ReadKey();
        }
    }
}
