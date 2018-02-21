using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine().ToLower();
            var km = double.Parse(Console.ReadLine());
            var pari = 0.00;

            if (season=="spring" || season=="autumn")
            {
                if(km<=5000)
                {
                    pari = km * 0.75*4;
                    var chisto = pari - pari * 0.10;
                    Console.WriteLine("{0:f2}",chisto);
                }
                else if(km>5000 && km<=10000)
                {
                    pari = km * 0.95 * 4;
                    var chisto = pari - pari * 0.10;
                    Console.WriteLine("{0:f2}", chisto);
                }
                else if(km>10000 && km<=20000)
                {
                    pari = km * 1.45 * 4;
                    var chisto = pari - pari * 0.10;
                    Console.WriteLine("{0:f2}", chisto);
                }
            }

            if (season == "summer")
            {
                if (km <= 5000)
                {
                    pari = km * 0.90 * 4;
                    var chisto = pari - pari * 0.10;
                    Console.WriteLine("{0:f2}", chisto);
                }
                else if (km > 5000 && km <= 10000)
                {
                    pari = km * 1.10 * 4;
                    var chisto = pari - pari * 0.10;
                    Console.WriteLine("{0:f2}", chisto);
                }
                else if (km > 10000 && km <= 20000)
                {
                    pari = km * 1.45 * 4;
                    var chisto = pari - pari * 0.10;
                    Console.WriteLine("{0:f2}", chisto);
                }
            }

            if (season == "winter")
            {
                if (km <= 5000)
                {
                    pari = km * 1.05 * 4;
                    var chisto = pari - pari * 0.10;
                    Console.WriteLine("{0:f2}", chisto);
                }
                else if (km > 5000 && km <= 10000)
                {
                    pari = km * 1.25 * 4;
                    var chisto = pari - pari * 0.10;
                    Console.WriteLine("{0:f2}", chisto);
                }
                else if (km > 10000 && km <= 20000)
                {
                    pari = km * 1.45 * 4;
                    var chisto = pari - pari * 0.10;
                    Console.WriteLine("{0:f2}", chisto);
                }
            }
        }
    }
}
