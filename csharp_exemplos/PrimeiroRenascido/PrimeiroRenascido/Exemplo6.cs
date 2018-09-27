using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeiroRenascido
{
    class Exemplo6
    {
        public static void Conversao()
        {
            string nome;
            int idade;
            double peso;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write(nome + ", digite sua idade: ");
            idade = int.Parse(Console.ReadLine()); //ou idade = Convert.ToInt32(Console.Readline());

            Console.Write(nome + ", digite seu peso: ");
            peso = double.Parse(Console.ReadLine()); //ou idade = Convert.ToDouble(Console.Readline());

            Console.WriteLine("\n***INFORMAÇÕES DIGITADAS***\n");
            Console.WriteLine("{0} tem {1} anos de idade e pesa {2:N3}kg", nome, idade, peso);
            Console.ReadKey();
        }
    }
}
