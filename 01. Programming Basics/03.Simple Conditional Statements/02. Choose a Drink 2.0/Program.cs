using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            var totalPrice = 0.00;

            switch (profession)
            {
                case "Athlete":totalPrice = 0.70*quantity; Console.WriteLine($"The Athlete has to pay {totalPrice:F2}."); break;
                case "Businessman": totalPrice = 1.00 * quantity; Console.WriteLine($"The Businessman has to pay {totalPrice:F2}.");break;
                case "Businesswoman": totalPrice = 1.00 * quantity; Console.WriteLine($"The Businesswoman has to pay {totalPrice:F2}."); break;
                case "SoftUni Student": totalPrice = 1.70 * quantity; Console.WriteLine($"The SoftUni Student has to pay {totalPrice:F2}."); break;
                default: totalPrice = 1.20 * quantity; Console.WriteLine($"The {profession} has to pay {totalPrice:F2}."); ; break;
            }
        }
    }
}
