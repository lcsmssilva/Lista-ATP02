using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATP_Lista02
{
    public static class Ex05
    {
        public static void Executar()
        {
            int niu; //declarando a variavel nota informada pelo usuario
            Console.WriteLine("Insira a sua nota de 0 a 10"); // atribuindo valor a variavel
            niu = int.Parse(Console.ReadLine()); // convertendo niu 'string' em niu 'int'

            if (niu >= 8 && niu <= 10) //se niu maior/igual a 8 AND menor/igual a 10
            {
                Console.WriteLine("Sua nota foi ótima\n");
            } else if (niu >= 7 && niu <8) // se niu maior/igual a 7 AND menor que 8 
            {
                Console.WriteLine("Sua nota foi boa\n");
            } else if (niu >= 5 && niu <7) // se niu maior/igual a 5 AND menor que 7
            {
                Console.WriteLine("Sua nota foi regular\n");
            } else if (niu < 5) // se niu menor que 5
            {
                Console.WriteLine("Sua nota foi insatisfatória\n");
            } else if (niu > 10) //se niu maior que 10
            {
                Console.WriteLine("Nota inválida.");
            }
        }
    }
}
