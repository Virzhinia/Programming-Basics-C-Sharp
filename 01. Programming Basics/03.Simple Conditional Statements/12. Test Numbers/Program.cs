using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            var combinations = 0;
            var currentSum = 0;

            for (int firstNum = n; firstNum >= 1; firstNum--)
            {
                for (int secondNum = 1; secondNum <= m; secondNum++)
                {
                    combinations++;
                    currentSum += 3 * (firstNum * secondNum);

                    if (currentSum >= maxSum)
                    {
                        Console.WriteLine($"{combinations} combinations");
                        Console.WriteLine($"Sum: {currentSum} >= {maxSum}");
                        return;
                    }
                }
            }
            if (currentSum < maxSum)
            {
                Console.WriteLine($"{combinations} combinations");
                Console.WriteLine($"Sum: {currentSum}");
            }
        }

    }
}
