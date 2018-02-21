using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parichki
{
    class Program
    {
        static void Main(string[] args)
        {
            var bit = int.Parse(Console.ReadLine());
            double uan = double.Parse(Console.ReadLine());
            double komisionna = double.Parse(Console.ReadLine());
            var bitlv = bit * 1168;
            var uanlv = uan * 0.15 * 1.76;
            var obshtoevro = (bitlv + uanlv) / 1.95;
            if ((komisionna >= 0 && komisionna <= 5) && (bit>=0 && bit<=20 && uan>=0))
            {
                var komislv = obshtoevro * (komisionna / 100);
                var kraen = obshtoevro - komislv;
                Console.WriteLine($"{kraen:f2}");
            }
        }
    }
}
