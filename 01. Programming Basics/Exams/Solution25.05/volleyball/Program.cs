using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var p = int.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var result = ((48 - h) * 3.0 / 4 + p * 2.0 / 3 + h);

            if (year == "leap")
            {
                var result1 = result + result * 0.15;
                Console.WriteLine(Math.Truncate(result1));
            }
            else
                Console.WriteLine(Math.Truncate(result));
        }
    }
}
