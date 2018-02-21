using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var project = System.Console.ReadLine().ToLower();
            var r = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var price = 0.0;
            var result = r*c;

            switch (project)
            {
                case "premiere": price = 12; System.Console.WriteLine("{0:f2}",price*result); break;
                case "normal": price = 7.50; System.Console.WriteLine("{0:f2}", price*result); break;
                case "discount":price = 5.00; System.Console.WriteLine("{0:f2}",price*result); break;
            }
        }
    }
}
