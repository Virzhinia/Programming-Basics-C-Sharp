using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end= int.Parse(Console.ReadLine());
            int maxcombinations = int.Parse(Console.ReadLine());
            int combinations = 0;

            for (int firstnumber = start; firstnumber <=end; firstnumber++)
            {
                for (int secondnumber = start; secondnumber<=end; secondnumber++)
                {
                    combinations++;
                    Console.Write($"<{firstnumber}-{secondnumber}>");
                    if (combinations == maxcombinations) break;

                }
                if (combinations == maxcombinations) break;
            }

        }
    }
}
