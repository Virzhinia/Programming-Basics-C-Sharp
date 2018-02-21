using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var sum = 0.00;

            for (int i = 0; i < count; i++)
            {
                var currentSum = sum;
                var product =Console.ReadLine().ToLower();
                if (product == "cheese") sum += 500;
                if (product == "tomato sauce") sum += 150;
                if (product == "salami") sum += 600;
                if (product == "pepper") sum += 50;
                currentSum=sum;
            }

            Console.WriteLine($"Total calories: {sum}");

        }
    }
}
