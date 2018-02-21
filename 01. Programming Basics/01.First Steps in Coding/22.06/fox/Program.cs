using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var zvezda = n;
            var n2 = ((2*n+3)-4-n)/2;
            var n3 = (2 * n + 3) - 2;
            //if (n % 2 != 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("{0}\\{1}/{0}", new string('*', i), new string('-', (2 * n + 3) - 2 - 2 * i));
                }
                for (int j = 0; j < n/3; j++)
                {
                    Console.WriteLine("|{0}\\{1}/{0}|", new string('*', n2), new string('*', zvezda));
                    n2++;
                    zvezda -= 2;
                }
                for (int k = 1; k <= n; k++)
                {
                    Console.WriteLine("{0}\\{1}/{0}", new string('-', k), new string('*', n3 - 2 * k));
                }
            }
            
        }
    }
}
