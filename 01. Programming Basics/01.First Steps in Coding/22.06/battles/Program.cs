using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstplayer = int.Parse(Console.ReadLine());
            int secondplayer = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());
            int battles = 0;

            for (int firsbattle = 1; firsbattle <= firstplayer; firsbattle++)
            {
                for (int secondbattle = 1; secondbattle <= secondplayer; secondbattle++)
                {
                    Console.Write($"({firsbattle} <-> {secondbattle}) ");
                    battles++;
                    if (battles == maxBattles)
                    {
                    break;
                    }
                }
                if (battles == maxBattles)
                {
                    break;
                }
            }
            Console.WriteLine();

        }
    }
}
