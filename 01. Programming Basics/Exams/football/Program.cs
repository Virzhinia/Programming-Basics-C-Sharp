using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace football
{
    class Program
    {
        static void Main(string[] args)
        {
            var stadion = int.Parse(Console.ReadLine());
            var vsfen = double.Parse(Console.ReadLine());
            var a = 0.0;
            var b = 0.0;
            var v = 0.0;
            var g = 0.0;
            for (int i = 0; i < vsfen; i++)
            {
                var sektor = Console.ReadLine().ToLower();
                switch (sektor)
                {
                    case "a": a++; break;
                    case "b": b++; break;
                    case "v": v++; break;
                    case "g": g++; break;
                }
            }
            Console.WriteLine($"{a/vsfen*100:f2}%");
            Console.WriteLine($"{b / vsfen*100:f2}%");
            Console.WriteLine($"{ v / vsfen * 100:f2}%");
            Console.WriteLine($"{g / vsfen*100:f2}%");
            Console.WriteLine($"{vsfen/stadion*100:f2}%");
        }
     }
 }

