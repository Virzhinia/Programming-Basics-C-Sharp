using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invalid
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool valid = number == 0 || (number >= 100 && number <= 200);

            if (valid==false)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
