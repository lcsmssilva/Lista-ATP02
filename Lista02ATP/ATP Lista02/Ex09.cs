using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATP_Lista02
{
    public static class Ex09
    {
        public static void Executar()
        {
            char sim;
            Console.WriteLine(" Insira um símbolo do teclado: ");
            sim = char.Parse(Console.ReadLine());

            switch (sim)
            {
                case '-':
                    Console.WriteLine("Sinal de menor\n");
                    break;

                case '+':
                    Console.WriteLine("Sinal de maior\n");
                    break;

                case '=':
                    Console.WriteLine("Sinal de igual\n");
                    break;

                default:
                    Console.WriteLine("Outro sinal\n");
                    break;

            }
        }
    }
}
