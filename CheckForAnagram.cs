using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string b;

            Console.WriteLine(" Write word 1");
            a = Console.ReadLine();
            Console.WriteLine(" Write word 2");
            b = Console.ReadLine();

            string aa = String.Concat(a.OrderBy(c => c)).ToLower();
            string bb = String.Concat(b.OrderBy(c => c)).ToLower();

            if (aa == bb)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadKey();
        }
    }
}
