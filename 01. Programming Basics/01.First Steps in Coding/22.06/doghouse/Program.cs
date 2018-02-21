using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doghouse
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = double.Parse(Console.ReadLine());
            var B = double.Parse(Console.ReadLine());

            var stranici = A * (A / 2) * 2;
            var zadnaStena = (A / 2) * (A / 2) + ((A / 2 * (B - A / 2)) / 2);
            var vhod = (A / 5) * (A / 5);
            var prednaStena = zadnaStena - vhod;
            var vsSteni = stranici + zadnaStena + prednaStena;
            var zelena = vsSteni / 3;
            var pokriv = A * (A / 2) * 2;
            var chervena = pokriv / 5;

            Console.WriteLine($"{zelena:f2}");
            Console.WriteLine($"{chervena:f2}");

        }
    }
}
