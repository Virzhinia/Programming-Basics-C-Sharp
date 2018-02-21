using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sum = 0;
            do
            {
                int currentnum = n % 10;
                sum += currentnum;
                n = n / 10;
            } while (n>0);
            Console.WriteLine(sum);
        }
    }
}
