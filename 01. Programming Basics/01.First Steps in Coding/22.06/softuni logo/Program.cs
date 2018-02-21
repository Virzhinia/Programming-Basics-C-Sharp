using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softuni_logo
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var reshetka = 7;
            var tochki = ((12 * n - 5) - reshetka) / 2;
            var tochki2 = 2;
            var reshetka2 = 12 * n - 6 - 2*tochki2;
            
                Console.WriteLine("{0}#{0}", new string('.', ((12 * n-6)/2)));
            
                for (int i = 0; i < 2 * n -1; i++)
                {
                    Console.WriteLine("{0}{1}{0}", new string('.', tochki), new string('#',reshetka));
                reshetka += 6;
               // if(tochki>2)
                    tochki -=3;
                }
                for (int j = 1; j < n-1; j++)
                {
                    Console.WriteLine("|{0}{1}{2}",new string('.',tochki2), new string('#',reshetka2-1),new string('.',tochki2+1));
                    tochki2 += 3;
                    reshetka2 -= 6;
                }
                for (int k = 0; k < n-1; k++)
                {
                Console.WriteLine("|{0}{1}{2}",new string('.',tochki2),new string('#',reshetka2-1), new string('.',tochki2+1));
                }

                Console.WriteLine("@{0}{1}{2}", new string('.', tochki2), new string('#', reshetka2-1), new string('.', tochki2+1));
            
        }
    }
}
