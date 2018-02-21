using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var total = a + b + c;
            var minute = total / 60;
            var sec = total % 60;
            Console.WriteLine($"{minute}:{sec:00}");


        }
    }
}
