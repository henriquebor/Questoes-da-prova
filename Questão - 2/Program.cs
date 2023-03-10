using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão___2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Questão - 2

            int a, b, auxiliar, i, n;

            a = 0;
            b = 1;

            Console.WriteLine("digite um numero: ");
            n = int.Parse(Console.ReadLine());

            for ( i = 0; i < n; i++)
            {
                auxiliar = a + b;
                a = b;
                b = auxiliar;


                Console.WriteLine(b);
              
                
            }

            
  



        }
    }
}
