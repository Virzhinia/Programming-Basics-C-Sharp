using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skorost
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());

            if (num <= 10) Console.WriteLine("slow");
            else if (num <= 50) Console.WriteLine("average");
            else if (num <= 150) Console.WriteLine("fast");
            else if (num <= 1000) Console.WriteLine("ultra fast");
            else Console.WriteLine("extremely fast");





        }
    }
}
