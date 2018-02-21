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
            bool no = true;
           int first = 0;
            int second = 0;
            int third = 0;

            for (int firstNum = start;firstNum <=stop; firstNum++)
            {
                for (int secondNum = start; secondNum <= stop; secondNum++)
                {
                    for (int thirdNum= start; thirdNum <=stop; thirdNum++)
                    {
                        if (firstNum + secondNum + thirdNum == ControlNum && firstNum < secondNum && secondNum < thirdNum)
                        {
                            firstNum = first;
                            secondNum = second;
                            thirdNum = third;
                        }
                        if (firstNum * secondNum * thirdNum == ControlNum && firstNum > secondNum && secondNum > thirdNum)
                        {
                            firstNum = first;
                            secondNum = second;
                            thirdNum = third;
                        }
                     if((firstNum + secondNum + thirdNum != ControlNum && firstNum < secondNum && secondNum < thirdNum)
                        && (firstNum * secondNum * thirdNum != ControlNum && firstNum > secondNum && secondNum > thirdNum))
                            no =true;
                    }
                }
            }
            if (no = false)
            {
                Console.WriteLine($"{first} * {second} * {third} = {ControlNum}");
                Console.WriteLine($"{first} + {second} + {third} = {ControlNum}");
            }
            if(no=true)
            Console.WriteLine("No!");
        }
    }
}
