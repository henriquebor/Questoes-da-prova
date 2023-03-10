using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão___5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Palavra Reversa";
            StringBuilder sb = new StringBuilder();

            for(var i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
