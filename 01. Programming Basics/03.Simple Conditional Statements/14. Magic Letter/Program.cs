﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            string skipLetter = Console.ReadLine();
            string result = "";

            for (char i = startLetter; i <= endLetter; i++)
            {
                for (char j = startLetter; j <= endLetter; j++)
                {
                    for (char k = startLetter; k <= endLetter; k++)
                    {
                        result = $"{i}{j}{k}";
                        if (!result.Contains(skipLetter))
                        {
                            Console.Write(result + " ");
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
