using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int combinations = 0;

            if (b-a<4)
            {
                Console.WriteLine("No");
            }
            else if (b-a>=5)
            {
                for (int firstNum = a; firstNum <= b; firstNum++)
                {
                    for (int secondNum = a; secondNum <= b; secondNum++)
                    {
                        for (int thirdNum= a; thirdNum <=b; thirdNum++)
                        {
                            for (int forthNum= a; forthNum <= b; forthNum++)
                            {
                                for (int fiveNum = a; fiveNum <=b; fiveNum++)
                                {
                                    if (firstNum < secondNum && secondNum < thirdNum && thirdNum < forthNum && forthNum < fiveNum)
                                        Console.WriteLine($"{firstNum} {secondNum} {thirdNum} {forthNum} {fiveNum}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
