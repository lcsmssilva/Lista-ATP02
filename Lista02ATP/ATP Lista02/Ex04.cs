using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATP_Lista02
{
    public class Ex04
    {
        public static void Executar()
        {
            int an = 0; // declarando a variavel ano de nascimento
            Console.WriteLine("Digite o ano de seu nascimento: "); //atribuindo valor a variavel
            an = int.Parse(Console.ReadLine()); //convertendo an 'string' em an 'int'

            int aa = 0; //declarando a variavel ano atual
            Console.WriteLine("Digite o ano atual: "); //atribuindo valor a variavel
            aa = int.Parse(Console.ReadLine()); //convertendo aa 'string' em aa 'int'          

            
            char r; //declarando a variavel caractere r
            Console.WriteLine("Você já fez aniversário este ano? [s]sim e [n] não."); //atribuindo valor a variavel
            r = char.Parse(Console.ReadLine()); // convertendo r 'string' em r 'char'

            int se = 0; // declarando variavel se (resposta)

            switch (r) //switch sobre a variavel r
            {
                case 's': //caso a variavel r = s
                    se = aa - an; //resposta = ano atual - ano do nascimento
                    break; 
                case 'n': //caso a variavel r = n
                    se = aa - an - 1; //resposta = ano atual - ano do nascimento - 1 (pelo fato de ainda não ter feito aniversario no ano atual)
                    break;

            }
            if (se < 18) //se a variavel 'se' for menor que 18
            {
                Console.WriteLine("Sua idade é {0} e você ainda não pode tirar sua habilitação \n", se);
            } else // se a variavel 'se' for maior que 18
            {
                Console.WriteLine("Sua idade é {0} e você já pode tirar sua habilitação \n", se);
            }
        }
    }
}