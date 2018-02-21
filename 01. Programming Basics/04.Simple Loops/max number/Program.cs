using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var min =1000000000;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num < min) min = num;
            }
            Console.WriteLine(min);
        }
    }
}
