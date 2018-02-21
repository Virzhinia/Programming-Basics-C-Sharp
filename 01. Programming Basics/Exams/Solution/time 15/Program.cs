using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace time_15_minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hh = int.Parse(Console.ReadLine());
            var mm = int.Parse(Console.ReadLine());
            var mm15 = mm + 15;
            var hh15 = hh + 1;
            var mm60 = Math.Abs(mm15 - 60);

            if (hh <= 23)
            {
                if (mm15 > 59) Console.WriteLine($"{hh15}:{mm60:00}");
                else Console.WriteLine($"{hh}:{mm15:00}");
            }

            else if (hh > 24)

            {
                var hh23 = hh - 23;
                Console.WriteLine($"{hh23}:{mm60:00}");
            }


            else
                Console.WriteLine($"{hh}:{mm15:00}");

        }

    }
}
