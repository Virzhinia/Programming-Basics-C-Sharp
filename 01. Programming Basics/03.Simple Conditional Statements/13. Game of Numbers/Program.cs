using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstLine = int.Parse(Console.ReadLine());
            int secondLine = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int combinations = 0;
            int sum = 0;

            for (int firstNim = secondLine; firstNim >= firstLine; firstNim--)
            {
                for (int secondNum = secondLine; secondNum >=firstLine; secondNum--)
                {
                    combinations++;
                    sum = firstNim + secondNum;

                    if(sum==magicNum)
                    {
                        Console.WriteLine($"Number found! {firstNim} + {secondNum} = {magicNum}");
                        return;
                    }
                }
            }
            if (sum!=magicNum)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNum}");
            }

        }
    }
}
