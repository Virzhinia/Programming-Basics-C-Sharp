
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();

            double meter = 0;
            double final = 0;

            if (from == "mm") {meter = num / 1000;}
            else if (from =="cm") {meter = num / 100;}
            else if (from == "mi") { meter = num / 0.000621371192;}
            else if (from == "in") { meter = num / 39.3700787; }
            else if (from == "km") { meter = num / 0.001; }
            else if (from == "ft") { meter = num / 3.2808399; }
            else if (from == "yd") { meter = num / 1.0936133; }
            else if (from == "m") { meter = num / 1; }

            if (to == "mm") { final = meter * 1000; }
            else if (to == "cm") { final = meter * 100; }
            else if (to == "mi") { final = meter * 0.000621371192; }
            else if (to == "in") { final = meter * 39.3700787;}
            else if (to == "km") { final = meter * 0.001;}
            else if (to == "ft") { final = meter * 3.2808399; }
            else if (to == "yd") { final = meter * 1.0936133; }
            else if (to == "m") { final = meter * 1; }

            Console.WriteLine($"{final} {to}");

        }
    }
}
