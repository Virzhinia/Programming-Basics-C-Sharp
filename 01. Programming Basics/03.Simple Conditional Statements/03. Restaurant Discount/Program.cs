using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine().ToLower();
            var price = 0.00;
            var totalPrice = 0.00;

            if (groupSize <= 50)
            {
                price = 2500;
                switch (package)
                {
                    case "normal":
                        totalPrice = ((price + 500) * 0.95) / groupSize; Console.WriteLine("We can offer you the Small Hall");
                        Console.WriteLine($"The price per person is {totalPrice:F2}$"); break;
                    case "gold":
                        totalPrice = ((price + 750) * 0.90) / groupSize; Console.WriteLine("We can offer you the Small Hall");
                        Console.WriteLine($"The price per person is {totalPrice:F2}$"); break;
                    case "platinum":
                        totalPrice = ((price + 1000) * 0.85) / groupSize; Console.WriteLine("We can offer you the Small Hall");
                        Console.WriteLine($"The price per person is {totalPrice:F2}$"); break;
                }
            }

            else if (groupSize > 50 && groupSize<=100)
            {
                price = 5000;
                switch (package)
                {
                    case "normal":
                        totalPrice = ((price + 500) * 0.95) / groupSize; Console.WriteLine("We can offer you the Terrace");
                        Console.WriteLine($"The price per person is {totalPrice:F2}$"); break;
                    case "gold":
                        totalPrice = ((price + 750) * 0.90) / groupSize; Console.WriteLine("We can offer you the Terrace");
                        Console.WriteLine($"The price per person is {totalPrice:F2}$"); break;
                    case "platinum":
                        totalPrice = ((price + 1000) * 0.85) / groupSize; Console.WriteLine("We can offer you the Terrace");
                        Console.WriteLine($"The price per person is {totalPrice:F2}$"); break;
                }
            }
            else if (groupSize > 100 && groupSize<=120)
            {
                price = 7500;
                switch (package)
                {
                    case "normal":
                        totalPrice = ((price + 500) * 0.95) / groupSize; Console.WriteLine("We can offer you the Great Hall");
                        Console.WriteLine($"The price per person is {totalPrice:F2}$"); break;
                    case "gold":
                        totalPrice = ((price + 750) * 0.90) / groupSize; Console.WriteLine("We can offer you the Great Hall");
                        Console.WriteLine($"The price per person is {totalPrice:F2}$"); break;
                    case "platinum":
                        totalPrice = ((price + 1000) * 0.85) / groupSize; Console.WriteLine("We can offer you the Great Hall");
                        Console.WriteLine($"The price per person is {totalPrice:F2}$"); break;
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
