using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_do_estágio
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1- questão:

            int indice = 13;
            int SOMA = 0;
            int K = 0;

            while (K < indice)
            {
                K += 1;
                SOMA += K;
            }
            Console.WriteLine(SOMA);
            Console.ReadLine();

            // o valor da variavel SOMA sera 91.

        }
    }
}
