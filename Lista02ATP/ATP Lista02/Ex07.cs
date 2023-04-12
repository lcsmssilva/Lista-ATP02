using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATP_Lista02
{
    public static class Ex07
    {
        public static void Executar()
        {
            double y, x; // declarando a variavel dos dois pontos
            Console.WriteLine("Insira o valor de x: "); // atribuindo valor a variavel x
            x = double.Parse(Console.ReadLine());// convertendo x 'string' em x 'double'

            double fun = 0;// declarando a variavel function

            if (x<=1) //se x é menor ou igual a 1
            {
                fun = 1;
            } else if ( x > 1 && x <= 2) //se x maior que um and menor/igual a 2
            {
                fun = 2;
            } else if ( x > 2 && x <= 3) // se x maior que 2 and menor/igual a 3
            {
                fun = Math.Pow(x,2); //math.pow elemento c# para fazer calculo de potencia
            } else if ( x > 3) // se x maior que 3
            {
                fun = Math.Pow(x,3); //math.pow elemento c# para fazer calculo de potencia
            }

            y = fun; // resultado de y

            Console.WriteLine("O valor de y dado o valor de x é {0}\n", y);
        }
    }
}
