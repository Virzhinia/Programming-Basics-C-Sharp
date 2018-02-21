using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            if (a>b)
            {
                Console.WriteLine($"The bigger num is {a}");
            }
            else
            {
                Console.WriteLine($"The bigger nim is {b}");
            }

        }
    }
}
