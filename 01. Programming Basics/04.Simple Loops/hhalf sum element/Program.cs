using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hhalf_sum_element
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var maxnum = 0;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum = num + sum;
                maxnum = Math.Max(num, maxnum);
            }
                if (sum-maxnum==maxnum)
                {
                    Console.WriteLine($"Yes Sum {maxnum}");
                }
                else
                {
                    Console.WriteLine($"No Diff {Math.Abs(maxnum-(sum-maxnum))}");
                }
            }
        }
    }

