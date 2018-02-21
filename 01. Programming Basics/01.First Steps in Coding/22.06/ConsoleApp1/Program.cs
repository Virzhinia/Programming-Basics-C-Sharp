using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int ControlNum = int.Parse(Console.ReadLine());
            int start = 1;
            int stop = 30;
            bool no = false;

            for (int firstNum = start; firstNum <= stop; firstNum++)
            {
                for (int secondNum = start; secondNum <= stop; secondNum++)
                {
                    for (int thirdNum = start; thirdNum <= stop; thirdNum++)
                    {
                        if (firstNum + secondNum + thirdNum == ControlNum && firstNum < secondNum && secondNum < thirdNum)
                        {
                            no = true;
                            Console.WriteLine($"{firstNum} + {secondNum} + {thirdNum} = {ControlNum}");
                        }
                        if (firstNum * secondNum * thirdNum == ControlNum && firstNum > secondNum && secondNum > thirdNum)
                        {
                            no = true;
                            Console.WriteLine($"{firstNum} * {secondNum} * {thirdNum} = {ControlNum}");
                        }
                        if ((firstNum + secondNum + thirdNum != ControlNum && firstNum < secondNum && secondNum < thirdNum)
                           && (firstNum * secondNum * thirdNum != ControlNum && firstNum > secondNum && secondNum > thirdNum))
                            no = false;
                    }
                }
            }
            if (no == false)
                Console.WriteLine("No!");
        }
    }
}
