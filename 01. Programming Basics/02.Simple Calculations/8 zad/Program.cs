using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_zad
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var perimeter = Math.Abs(x2 - x1) * 2 + Math.Abs(y1 - y2) * 2;
            var area = Math.Abs(x2 - x1) * Math.Abs(y1 - y2);
            Console.WriteLine($"Area = {area}");
            Console.WriteLine($"Perimeter = {perimeter}");
        }
    }
}
