using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATP_Lista02
{
    public static class Ex08
    {
        public static void Executar()
        {

            double s; //declarando a variavel salário
            Console.WriteLine("Insira o sálario: "); //atribuindo o valor a variavél
            s = double.Parse(Console.ReadLine()); //convertendo s 'string' em s 'double'

            double aa = s + (s * 0.08); //declarando a variavel aumento A
            Console.WriteLine("O sálario com o aumento de 8% vai para {0}", aa);

            double ab = s + (s * 0.11); //declarando a variavel aumento B
            Console.WriteLine("O sálario com o aumento de 11% vai para {0}", ab);

            double ac = 0; //declarando a variavel aumento C

            switch (s)
            {
                case 1000: //caso salário (s) for igual a 1000
                    ac = s + 350;
                    Console.WriteLine("O valor do salário com aumento fixo foi para {0}\n", ac);
                    break;

                case > 1000: //caso salário (s) for maior que 1000
                    ac = s + 200;
                    Console.WriteLine("O valor do salário com aumento fixo foi para {0}\n", ac);
                    break;
            }
        }
    }
}
