using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeiroRenascido
{
    class Ex1
    {
        static void Main(string[] args)
        {
            int a, b, total;

            a = 20;
            b = 10;
            total = a - b;

            Console.WriteLine(a+" + "+b+" = " + (a+b));
            Console.WriteLine(a+" - "+b+" = " + (total));
            Console.WriteLine(a+" * "+b+" = " + (a*b));
            Console.WriteLine(a+" / "+b+" = " + (a/b));
            Console.WriteLine(a+" % "+b+" = " + (a%b));
            Console.ReadKey();
        }
    }
}
