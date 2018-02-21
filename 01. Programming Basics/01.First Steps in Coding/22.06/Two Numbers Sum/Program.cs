using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Numbers_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nachalo = int.Parse(Console.ReadLine());
            var krai = int.Parse(Console.ReadLine());
            var magichesko = int.Parse(Console.ReadLine());
            var combinations = 0;
            var firstNumber = 0;
            var secondNumber = 0;
            var check = false;

            for (int i = krai; i >= nachalo; i--)
            {
                for (int a = krai; a >= nachalo; a--)
                {
                    combinations++;
                    if (i + a == magichesko)
                    {
                        firstNumber = i;
                        secondNumber = a;
                        check = true;
                        break;
                    }
                }
                if (check)
                    break;
                Console.WriteLine($"Combination N:{combinations} ({firstNumber} + {secondNumber} = {magichesko})");
                Console.WriteLine($"{combinations} combinations - neither equals {magichesko}");
            }
        }
    }
}
