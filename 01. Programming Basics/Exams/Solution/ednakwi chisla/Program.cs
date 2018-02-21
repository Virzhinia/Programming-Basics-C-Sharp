using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ednakwi_chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            if (a == b)
            {
                if (b == c) Console.WriteLine("yes");
                else if (a == c) Console.WriteLine("yes");
                else Console.WriteLine("no");
            }

            else Console.WriteLine("no");
        }
    }
}
