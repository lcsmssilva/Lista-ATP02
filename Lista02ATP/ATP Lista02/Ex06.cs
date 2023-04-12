using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATP_Lista02
{
    public static class Ex06
    {
        public static void Executar()
        {
            int vdn; //declarando a variavel valor da diaria normal
            Console.WriteLine("Insira o valor da diária"); // atribuindo valor a diaria
            vdn = int.Parse(Console.ReadLine()); // convertendo vdn 'string' em vdn 'int'

            double vdp; //declarando a variavel valor da diaria promocional
            vdp = vdn - (vdn * 0.25) ; //atribuindo valor a diaria promocional
            Console.WriteLine("O valor promocional é de:{0}", vdp);

            double odp; //declarando variavel ocupação da diaria promocional
            odp = (75 * 0.8) * vdp; // atribuindo valor a ocupação da diaria promocional
            Console.WriteLine("O valor promocional total arrecadado com ocupação de 80% é de {0} ", odp);

            double odn; ////declarando variavel ocupação da diaria normal
            odn = (75 * 0.5) * vdn;// atribuindo valor a ocupação da diaria normal
            Console.WriteLine("O valor total arrecadado com ocupação de 50% é de {0} ", odn);


            double dif; // declarando variavel diferença

            if (odp > odn) // se ocupação diaria promocional maior que ocupação diaria normal
            {
                dif = odp - odn; // atribuindo valor a dif
                Console.WriteLine("A diferença do valor total arrecadado é de {0} \n", dif);
            }
            else // se ocupação diaria promocional menor que ocupação diaria normal
            {
                dif = odn - odp; // atribuindo valor a dif
                Console.WriteLine("A diferença do valor total arrecadado é de {0} \n", dif);
            }
        }
    }
}
