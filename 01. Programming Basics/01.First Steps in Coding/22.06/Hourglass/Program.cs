using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
             var a = 2 * n + 1 - 6;
            var tocki = 2;

            Console.WriteLine("{0}",new string('*', 2*n+1));
            Console.WriteLine(".*{0}*.", new string(' ',2*n-3));

            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",new string('.',tocki++),
                                                new string('@',a--));
                a--;
            }
            Console.WriteLine("{0}*{0}",new string('.',n));
            Console.WriteLine("{0}*@*{0}",new string('.',n-1));
            var tocki2 = n-2;
            for (int i = 1; i < n - 2; i++)
            {
                Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', tocki2),
                                                new string(' ', i));
                tocki2--;
            }

            Console.WriteLine(".*{0}*.", new string('@', 2 * n - 3));
            Console.WriteLine("{0}",new string('*', 2*n+1));
        }
    }
}
