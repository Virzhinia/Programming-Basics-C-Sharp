﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace left_right
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var leftsum = 0;
            var rightsum = 0;

            for (int i = 0; i < n; i++)
            {
                leftsum = leftsum + int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                rightsum = rightsum + int.Parse(Console.ReadLine());
            }
            if(leftsum==rightsum)
            {
                Console.WriteLine($"Yes, sum = {leftsum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftsum-rightsum)}");
            }
        }
    }
}
