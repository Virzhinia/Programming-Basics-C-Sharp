using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruit_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var number = double.Parse(Console.ReadLine());


                if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (fruit == "banana") Console.WriteLine(number * 2.50);
                else if (fruit == "apple") Console.WriteLine(number * 1.20);
                else if (fruit == "orange") Console.WriteLine(number * 0.85);
                else if (fruit == "grapefruit") Console.WriteLine(number * 1.45);
                else if (fruit == "kiwi") Console.WriteLine(number * 2.70);
                else if (fruit == "pineapple") Console.WriteLine(number * 5.50);
                else if (fruit == "grapes") Console.WriteLine(number * 3.85);
                else Console.WriteLine("error");
            }

            else if (day == "saturday" || day == "sunday")
            {
                if (fruit == "banana") Console.WriteLine(number * 2.70);
                else if (fruit == "apple") Console.WriteLine(number * 1.25);
                else if (fruit == "orange") Console.WriteLine(number * 0.90);
                else if (fruit == "grapefruit") Console.WriteLine(number * 1.60);
                else if (fruit == "kiwi") Console.WriteLine(number * 3.00);
                else if (fruit == "pineapple") Console.WriteLine(number * 5.60);
                else if (fruit == "grapes") Console.WriteLine(number * 4.20);
                else Console.WriteLine("error");
            }
            else
                Console.WriteLine("error");
        }
    }
}
