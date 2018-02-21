using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            try
            {
                int intiger = int.Parse(Console.ReadLine());
                while (true)
                {
                    sum++;
                    intiger = int.Parse(Console.ReadLine());
                }
            }
            catch 
            {
                Console.WriteLine($"{sum}");
            }
         
        }
    }
}
