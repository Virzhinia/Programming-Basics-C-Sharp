using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var tocki = 2 * n - 1;

            Console.WriteLine("+{0}+{1}", new string('~', n - 2), new string('.',2*n+1));
            Console.WriteLine("|\\{0}\\{1}", new string('~', n - 2), new string('.', 2 * n));

            for (int i = 1; i <= 2*n-1; i++)
            {
                Console.WriteLine("|{0}\\{1}\\{2}",new string('.',i), new string('~',n-2),new string('.',tocki));
                tocki--;
            }

            Console.WriteLine("|{0}\\{1}\\", new string('.', 2*n), new string('~', n - 2));
            Console.WriteLine("\\{0}|{1}|", new string('.', 2*n), new string('~', n - 2));
            var tockii = 2 * n-1;
            for (int j = 1; j <= 2 * n - 1; j++)
            {
                Console.WriteLine("{0}\\{1}|{2}|", new string('.', j), new string('.', tockii), new string('~', n - 2));
                tockii--;
            }
            Console.WriteLine("{1}\\|{0}|", new string('~', n - 2), new string('.', 2 * n));
            Console.WriteLine("{1}+{0}+", new string('~', n - 2), new string('.', 2 * n + 1));

        }
    }
}
