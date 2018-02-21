using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magazin
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower();
            var n = double.Parse(Console.ReadLine());

            if(town=="sofia")
            {
                if (product == "coffee") Console.WriteLine(n*0.5);
                if (product == "water") Console.WriteLine(n * 0.8);
                if (product == "beer") Console.WriteLine(n * 1.2);
                if (product == "sweets") Console.WriteLine(n * 1.45);
                if (product == "peanuts") Console.WriteLine(n * 1.60);
            }
            if (town == "plovdiv")
            {
                if (product == "coffee") Console.WriteLine(n * 0.4);
                if (product == "water") Console.WriteLine(n * 0.7);
                if (product == "beer") Console.WriteLine(n * 1.15);
                if (product == "sweets") Console.WriteLine(n * 1.30);
                if (product == "peanuts") Console.WriteLine(n * 1.50);
            }
            if (town == "varna")
            {
                if (product == "coffee") Console.WriteLine(n * 0.45);
                if (product == "water") Console.WriteLine(n * 0.7);
                if (product == "beer") Console.WriteLine(n * 1.1);
                if (product == "sweets") Console.WriteLine(n * 1.35);
                if (product == "peanuts") Console.WriteLine(n * 1.55);
            }

        }
    }
}
