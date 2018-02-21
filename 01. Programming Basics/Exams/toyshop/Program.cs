using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toyshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var ekskurzia = double.Parse(Console.ReadLine());
            var puzel = int.Parse(Console.ReadLine());
            var kukli = int.Parse(Console.ReadLine());
            var mecheta = int.Parse(Console.ReadLine());
            var minions = int.Parse(Console.ReadLine());
            var kamioni = int.Parse(Console.ReadLine());

            var broi = puzel + kukli + mecheta + minions + kamioni;
            var price = puzel * 2.60 + kukli * 3 + mecheta * 4.10 + minions * 8.20 + kamioni * 2;
            var price50 = price - (price * 0.25);
            var pechalba50 = price50 - (price50 * 0.10);
            var pechalba = price - (price * 0.10);
            if (broi >= 50)
            {
                if (pechalba50 >= ekskurzia)
                {
                    var ost = Math.Round(pechalba50 - ekskurzia, 2);
                    Console.WriteLine($"Yes! {ost:f2} lv left.");
                }
                else if (pechalba50<ekskurzia)
                { 
                    Console.WriteLine($"Not enough money! {Math.Round(ekskurzia - (price50 - (price50 * 0.10)), 2):f2} lv needed.");
                }
            }
            else
            {
                if (pechalba >= ekskurzia)
                {
                    Console.WriteLine($"Yes! {Math.Round(price - ((price * 0.10) + ekskurzia), 2):f2} lv left.");
                }
                else if (pechalba<ekskurzia)
                    Console.WriteLine($"Not enough money! {Math.Round(ekskurzia - (price - (price * 0.10)), 2):f2} lv needed.");
                
            }
        }
    }
}
