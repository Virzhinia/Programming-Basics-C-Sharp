using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            var meseci = int.Parse(Console.ReadLine());
            var tok = 0.00;
            var voda = meseci*20.00;
            var net = meseci*15.00;
            var drugi = 0.00;

            for (int i = 0; i <meseci; i++)
            {
                var tok1 = double.Parse(Console.ReadLine());
                tok+=tok1;
                var drugi1 = (tok1 + 20 + 15) + 0.20*(tok1+20+15);
                drugi += drugi1;
            }
            var average =(tok + voda + net + drugi)/meseci;
            Console.WriteLine("Electricity: {0:f2} lv", tok);
            Console.WriteLine("Water: {0:f2} lv",voda);
            Console.WriteLine("Internet: {0:f2} lv",net);
            Console.WriteLine("Other: {0:f2} lv",drugi);
            Console.WriteLine("Average: {0:f2} lv",average);

        }
    }
}
