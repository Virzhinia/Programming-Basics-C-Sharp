using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            var budjet = double.Parse(Console.ReadLine());
            var plosht = double.Parse(Console.ReadLine());
            var broiprozorci = double.Parse(Console.ReadLine());
            var sterioporv1paket = double.Parse(Console.ReadLine());
            var cena1paket = double.Parse(Console.ReadLine());

            var plostbezprozorci = plosht - broiprozorci * 2.4;
            var plostifira = plostbezprozorci + plostbezprozorci * 0.10;
            var nujnipaketi = Math.Ceiling(plostifira / sterioporv1paket);
            var cenapaketi = cena1paket * nujnipaketi;
            var ostatyk = Math.Abs(budjet - cenapaketi);
            if(budjet>=cenapaketi)
            {
                Console.WriteLine("Spent: {0:f2}",cenapaketi);
                Console.WriteLine("Left: {0:f2}", ostatyk);
            }
            else
            {
                Console.WriteLine("Need more: {0:f2}", ostatyk);
            }

        }
    }
}
