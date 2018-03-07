using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeiroRenascido
{
    class Exemplo11
    {
        public static void Atribuicao() 
        {
            int num1 = 10, num2 = 2;

            Console.WriteLine("Valores de inicialização das váriaveis");
            Console.WriteLine("num1 = {0} e o num2 = {1}", num1, num2);

            num1 += num2;

            Console.WriteLine();
            Console.WriteLine("Valores após a operação num1 + num2");
            Console.WriteLine("num1 = {0} e o num2 = {1}", num1, num2);
            Console.ReadKey();
        }
    }
}
