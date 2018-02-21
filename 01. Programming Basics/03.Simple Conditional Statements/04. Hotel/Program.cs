using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());
            var studio = 0.00;
            var doubleroom = 0.00;
            var suite = 0.00;

            switch (month)
            {
                case "may":
                case "october": studio = 50; doubleroom = 65; suite = 75; break;
                case "june":
                case "september": studio = 60; doubleroom = 72; suite = 82; break;
                case "july":
                case "august":
                case "december": studio = 68; doubleroom = 77; suite = 89; break;
            }

            if (nights > 7 && (month == "may" || month == "october"))
            {
                studio = studio * 0.95;
            }
            else if (nights > 14 && (month == "june" || month == "september"))
            {
                doubleroom = doubleroom * 0.90;
            }
            else if (nights > 14 && (month == "july" || month == "august" || month == "december"))
            {
                suite = suite * 0.85;
            }

            var studioPrice = studio * nights;
            if (nights > 7 && (month == "september" || month == "october"))
            {
                studioPrice =studio*(nights-1);
            }
            var doublePrice = doubleroom * nights;
            var suitePrice = suite * nights;

            Console.WriteLine($"Studio: {studioPrice:F2} lv.");
            Console.WriteLine($"Double: {doublePrice:F2} lv.");
            Console.WriteLine($"Suite: {suitePrice:F2} lv.");
        }
    }
}
