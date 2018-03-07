using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeiroRenascido
{
    class Exemplo3
    {
        public static void Contantes()
        {
            //denifição de uma constante chamada "pi"
            const double pi = 3.14159265358979323846264338327950;
            //declração de variável e atribuição de valor na variável
            double raio = 10, area;

            Console.WriteLine("Calculo da área de um circulo \n");
            Console.WriteLine("Fórmula: area = pi * raio² \n");
            //Math.Pow: exponeciação (igual ao C)
            area = pi * Math.Pow(raio, 2);

            Console.WriteLine("Área = {0}", area); //exibição sem casas decimais
            Console.WriteLine("Área = {0:N}", area); //exibição com duas casas decimais
            Console.WriteLine("Área = {0:N5}", area); //exibição com cinco casas decimais
            Console.ReadKey();
        }
    }
}
