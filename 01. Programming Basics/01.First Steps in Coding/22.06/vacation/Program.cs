using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var budjet = double.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();

            if(budjet<=1000)
            {
                if (season=="summer")
                {
                    var cena = budjet * 0.65;
                    Console.WriteLine("Alaska - Camp - {0:f2}",cena);
                }
                else
                {
                    var cena = budjet * 0.45;
                    Console.WriteLine("Morocco - Camp - {0:f2}", cena);
                }
            }

            else if (budjet > 1000 && budjet<=3000)
            {
                if (season == "summer")
                {
                    var cena = budjet * 0.80;
                    Console.WriteLine("Alaska - Hut - {0:f2}", cena);
                }
                else
                {
                    var cena = budjet * 0.60;
                    Console.WriteLine("Morocco - Hut - {0:f2}", cena);
                }
            }

            else if (budjet > 3000)
            {
                if (season == "summer")
                {
                    var cena = budjet * 0.90;
                    Console.WriteLine("Alaska - Hotel - {0:f2}", cena);
                }
                else
                {
                    var cena = budjet * 0.90;
                    Console.WriteLine("Morocco - Hotel - {0:f2}", cena);
                }
            }
        }
    }
}
