using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATP_Lista02
{
    public  static class Ex02
    {
        public static void Executar()
        {
            int x = 0; //declarando variavel
            Console.WriteLine("Insira o valor de x: "); //atribuindo valor a x
            x = int.Parse(Console.ReadLine()); //convertendo y 'string' em y 'int'

            int y = 0; //declarando variavel
            Console.WriteLine("Insira o valor de y: "); //atribuindo valor a y
            y = int.Parse(Console.ReadLine()); //convertendo y 'string' em y 'int'

            int soma = x + y; //declarando variavel soma e atribuindo valor
            int rsoma = 0; //declarando variavel resultado da soma (rsoma)

            if (soma >= 10) //se soma for maior ou igual a 10
            {
                rsoma = soma + 5;
            }
            else 
            {
                rsoma = soma + 7;
            }
            Console.WriteLine("O resultado é {0}\n", rsoma);
        }
    }
}
