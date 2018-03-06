using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeiroRenascido
{
    class Exemplo4
    {
        public static void Cadeias()
        {
            string nome = "Eduardo", sobrenome = "Lima", completo;
            completo = nome + " " + sobrenome;

            Console.WriteLine("1) "+nome+sobrenome);
            Console.WriteLine("2) "+completo);
            Console.WriteLine("3) "+nome+" possui "+nome.Length+" caracteres");
            Console.WriteLine("4) "+sobrenome+" possui "+sobrenome.Length+" caracteres");
            Console.WriteLine("5) "+completo+" possui "+completo.Length+" caracteres incluindo os espaços em branco");
            Console.WriteLine("6) "+nome+" em minusculo "+nome.ToLower());
            Console.WriteLine("7) "+nome+" em maiusculo "+nome.ToUpper());
            Console.WriteLine("8) "+nome+" é igual a "+sobrenome+" = "+nome.Equals(sobrenome));
            Console.WriteLine("9) "+nome+" Substring iniciando na posição 2 e pegando = "+nome.Substring(2,2));
            Console.ReadKey();
        }
    }
}
