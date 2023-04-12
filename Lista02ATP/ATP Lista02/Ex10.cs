using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATP_Lista02
{
    public class Ex10
    {
        public static void Executar()
        {
            int vp; // declarando variavel velocidade permitida na avenida
            Console.WriteLine("Insira a velocidade permitida na avenida: ");
            vp = int.Parse(Console.ReadLine());

            int vm; //declarando variavel velocidade do motorista
            Console.WriteLine("Insira a velocidade que o motorista estava: ");
            vm = int.Parse(Console.ReadLine());

            int r; // declarando variavel resultado
            r = vm - vp; //atribuindo valor de resultado

            if (r == 0) //compara se resultado é 0, se for executado essa linha do codigo
            {

                Console.WriteLine("Motorista respeitou a lei.\n"); //se for igual a 0 executa esse comando

            } else if(r <= 10) //compara se resultado é igual ou menor que 10, se for executado essa linha do codigo
            {

                Console.WriteLine("Você ultrapassou o limite permitido e terá de pagar R$50,00 de multa.\n"); //se for menor ou igual a 10 executa esse comando

            } else if (r < 30) //compara se resultado é menor a 30
            {

                Console.WriteLine("Você ultrapassou o limite permitido e terá de pagar R$100,00 de multa.\n"); //se for menor que 30 executa esse comando

            } else //se não for nenhuma das alternativas acimao, executa esse comando abaixo
            {

                Console.WriteLine("Você ultrapassou o limite permitido e terá de pagar R$200,00 de multa.\n");

            }
        }
    }
}