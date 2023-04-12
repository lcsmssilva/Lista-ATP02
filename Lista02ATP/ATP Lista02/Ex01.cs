using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATP_Lista02
{
    public static class Ex01
    {
        public static void Executar()
        {
            int x; //declarando variavel x
            Console.WriteLine("Insira o valor x: "); //atribuindo valor de x
            x = int.Parse(Console.ReadLine()); //convertendo x string em x int

            int y; //declarando variavel y
            Console.WriteLine("Insira o valor de y: "); //atribuindo valor de y
            y = int.Parse(Console.ReadLine()); //convertendo y string em y int

            if (x > y) //se x for maior que y
            {
                Console.WriteLine("Dentre os números {0} e {1}, {0} é maior", x, y);
            }
            else if (x < y) //se x for menor que y
            {
                Console.WriteLine("Dentre os números {1} e {0}, {1} é maior", x, y);
            }
            else
            {
                Console.WriteLine("Os numeros são iguais.\n");
            }
        }
    }
}
