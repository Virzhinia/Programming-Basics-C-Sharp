using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            if (one < two)
            {
                for (int i = one; i <=two; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = two; i <= one; i++)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
