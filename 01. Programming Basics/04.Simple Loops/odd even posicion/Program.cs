using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_even_posicion
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var oddsum = 0.00;
            var evensum = 0.00;
            var maxodd = double.MaxValue;
            var minodd = double.MinValue;
            var maxeven = double.MaxValue;
            var mineven = double.MinValue;

            for (int i = 0; i < n; i++)
            {
                var num = double.Parse(Console.ReadLine());
                if(i%2==0)
                {
                    evensum = num + evensum;
                    maxeven = Math.Max(num, maxeven);
                    mineven = Math.Min(num, num);
                }
                else
                {
                    oddsum = num + oddsum;
                    maxodd = Math.Max(num, maxodd);
                    minodd = Math.Min(num, num);
                }
            }
            Console.WriteLine($"OddSum = {oddsum}");
            Console.WriteLine($"OddMin = {minodd}");
            Console.WriteLine($"OddMax = {maxodd}");
            Console.WriteLine($"EvenSum = {evensum}");
            Console.WriteLine($"EvenMin = {mineven}");
            Console.WriteLine($"EvenMax = {maxeven}");


        }
    }
}
