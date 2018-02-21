using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution25._05
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            var geneder = Console.ReadLine().ToLower();

            if (geneder=="f")
            {
                if (age < 16)
                {
                    Console.WriteLine("Miss");
                }
                else
                {
                    Console.WriteLine("Ms.");
                }
            }

            else
            {
                if (age < 16)
                {
                    Console.WriteLine("Master");
                }
                else
                {
                    Console.WriteLine("Mr.");
                }
            }

        }
    }
}
