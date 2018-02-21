using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("@{0}@{0}@", new string(' ', n - 2));
            Console.WriteLine("**{0}*{0}**",new string(' ',n-3));
            int offset = 1;

            for (int i = 0; i <= (n/2)-2; i++)
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.',i), new string(' ',n-5-offset), 
                                                            new string('.', offset+1));
                offset += 2;
            }
            Console.WriteLine("*{0}*{1}*{0}*", new string('.',(n/2)-1), new string('.',offset+1));
            Console.WriteLine("*{0}{1}.{1}{0}", new string('.',n/2), new string('*",);
        }
    }
}
