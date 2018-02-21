using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._06
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = uint.Parse(Console.ReadLine());
            int num = 1;
            for (var i = 0; i <= n; i+=2)
            {
                Console.WriteLine(num);
                num = num * 2*2;
            }
        }
    }
}
