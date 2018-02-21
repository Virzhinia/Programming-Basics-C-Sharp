using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int broidni = int.Parse(Console.ReadLine());
            int broisladkari = int.Parse(Console.ReadLine());
            int broitorti = int.Parse(Console.ReadLine());
            int broigofreti = int.Parse(Console.ReadLine());
            int broipalachinki = int.Parse(Console.ReadLine());

            var torti = broitorti * 45;
            var gofreti = broigofreti * 5.80;
            var palachinki = broipalachinki * 3.20;

            var den = (torti + gofreti + palachinki) * broisladkari;
            var subranasuma = den * broidni;
            var result = subranasuma - (subranasuma * 0.125);

            Console.WriteLine($"{result:f2}");

        }
    }
}
