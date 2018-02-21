using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace point2
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            var checkonx = (x == x1 || x == x2);
            var checkony = (y == y1 || y == y2);

            var checkinx = (x >= x1 && x <= x2);
            var checkiny = (y >= y1 && y <= y2);

            if ((checkonx && checkiny ) || (checkony&&checkinx))
                    {
                Console.WriteLine("Border");
                    }
            else  
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
