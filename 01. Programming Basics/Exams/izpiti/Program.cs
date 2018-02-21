using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpiti
{
    class Program
    {
        static void Main(string[] args)
        {
            var uiskilv = double.Parse(Console.ReadLine());
            var beer = double.Parse(Console.ReadLine());
            var vino = double.Parse(Console.ReadLine());
            var rakia = double.Parse(Console.ReadLine());
            var uiski = double.Parse(Console.ReadLine());

            var cenauiski = uiskilv * uiski;
            var cenarakia = uiskilv / 2.00;
            var cenabeer = beer* (cenarakia - (cenarakia * 0.8));
            var cenavino = vino * (cenarakia - (cenarakia * 0.4));
            var price = cenauiski + rakia*cenarakia + cenabeer + cenavino;

            Console.WriteLine("{0:f2}",price);


        }
    }
}
