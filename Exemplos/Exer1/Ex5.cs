using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{
    class Ex5
    {
        public static void ExCinco()
        {
            int idade;
            string V = "maior de idade", F = "menor de idade";

            Console.WriteLine("\nExercicio 5");
            Console.Write("\n Decubra se você é maior de idade!\n\n");
            Console.Write("Digite a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("\n \n Sua idade é de {0} anos. \n \n Você é ", idade);
            Console.Write(idade >= 18 ? V : F);

            Console.ReadKey();
            Console.Clear();
        }
    }
}
