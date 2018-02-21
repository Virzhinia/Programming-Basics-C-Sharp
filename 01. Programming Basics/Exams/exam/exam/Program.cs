using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var plosht = double.Parse(Console.ReadLine());
            var kgkvm = double.Parse(Console.ReadLine());
            var brak = double.Parse(Console.ReadLine());
            var grozde = plosht * kgkvm;
            var chisto = grozde - brak;
            var rakia = 0.45 * chisto;
            var prihodrakia = (rakia / 7.5) * 9.80;
            var zaprodan = 0.55 * chisto * 1.50;

            Console.WriteLine("{0:f2}",prihodrakia);
            Console.WriteLine("{0:f2}",zaprodan);

        }
    }
}
