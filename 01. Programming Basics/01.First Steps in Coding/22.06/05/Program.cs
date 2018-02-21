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
            int n = int.Parse(Console.ReadLine());
            var shirina = (4 * n) + 1;
            var visochina = (2 * n) + 1;
            var space = 1;
            var tochki = n + 1;

            Console.WriteLine("{0}",new string('#',shirina));
            for (int i = 1; i <= n; i++)
            {
                if (i >= 1 && i!=n/2+1)
                { 
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', i), new string('#', (shirina - 3 * i) / 2), new string(' ', space));
                shirina--;
                space += 2;
                }
                if (i==n/2+1 && i!=1)
                {
                    Console.WriteLine("{0}{1}{2}(@){2}{1}{0}", new string('.', i), new string('#', (shirina - 3 * i) / 2), new string(' ', (space-3)/2));
                    space=(space + 2);
                }
            
            }
            shirina = (4 * n) + 1;
            for (int k = 1; k <= n; k++)
            {
                Console.WriteLine("{0}{1}{0}",new string('.',tochki), new string('#', shirina-(tochki*2)));
                tochki++;
                //shirina--;
            }
        }
    }
}
