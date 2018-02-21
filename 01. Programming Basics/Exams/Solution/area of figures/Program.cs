using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_of_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();


            if (figure == "square")
            {
                double num = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(num * num, 3));
            }

            else if (figure == "rectangle")
            {
                double num = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(num * num2, 3));
            }

            else if (figure == "circle")
            {
                double num = double.Parse(Console.ReadLine());
                var area = Math.PI * num * num;
                Console.WriteLine(Math.Round(area, 3));
            }

            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((a * h) / 2,3));
            }
            }
    }
}
