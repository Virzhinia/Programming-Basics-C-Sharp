using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_evensum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var oddsum = 0;
            var evensum = 0;

            for (int i = 0; i < n; i++)
            {
                if(i%2==0)
                {
                    oddsum = oddsum + int.Parse(Console.ReadLine());
                }
                else
                {
                    evensum = evensum + int.Parse(Console.ReadLine());
                }
            }
            if(oddsum==evensum)
            {
                Console.WriteLine($"yes sum {oddsum}");
            }
            else
            {
                Console.WriteLine($"No diff {Math.Abs(oddsum-evensum)}");
            }
        }
    }
}
