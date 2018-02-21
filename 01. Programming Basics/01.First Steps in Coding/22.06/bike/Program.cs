using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bike
{
    class Program
    {
        static void Main(string[] args)
        {
            var juniors = int.Parse(Console.ReadLine());
            var seniors = int.Parse(Console.ReadLine());
            var trase = Console.ReadLine().ToLower();
            var sybranaSuma = 0.00;
            switch (trase)
            {
                case "trail": sybranaSuma = 5.50 * juniors + 7 * seniors; break;
                case "downhill": sybranaSuma = 12.25 * juniors + 13.75 * seniors; break;
                case "road": sybranaSuma = 20 * juniors + 21.50 * seniors; break;
            }
            if (trase == "cross-country" && (juniors + seniors) >= 50)
            {
                sybranaSuma = (8 - 0.25*8) * juniors + (9.50 - 0.25*9.50) * seniors;
            }
            else if(trase=="cross-country"&&(juniors+seniors)<50)
            {
                sybranaSuma = 8 * juniors + 9.50 * seniors;
            }
            var result = sybranaSuma - (sybranaSuma * 0.05);
            Console.WriteLine($"{result:f2}");
        }
    }
}
