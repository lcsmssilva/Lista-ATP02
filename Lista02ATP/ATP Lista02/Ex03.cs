using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATP_Lista02
{
    public static class Ex03
    {
        public static void Executar()
        {
            double a = 0;
            Console.WriteLine("Insira o valor de a: ");
            a = double.Parse(Console.ReadLine());

            double b = 0;
            Console.WriteLine("Insira o valor de b: ");
            b = double.Parse(Console.ReadLine());

            double x = -b / a;

            Console.WriteLine("A raiz da equação é {0:f2}\n", x);
        }
    }
}
