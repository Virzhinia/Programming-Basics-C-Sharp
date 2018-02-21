using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());
            var ControlNumber = int.Parse(Console.ReadLine());
            var sum = 0;
            var moves = 0;

            for (int i = 1; i <= N; i++)
            {
                for (int j = M; j >0; j--)
                {
                   
                    if (sum >= ControlNumber)
                    {
                        //var zero = 0;
                       // var teb = 10 / zero;
                        break;
                    }
                    sum += i * 2 + j * 3;
                    moves++;

                }
            }
            if(sum>=ControlNumber)
            {
                Console.WriteLine($"{moves} moves");
                Console.WriteLine($"Score: {sum} >= {ControlNumber}");
                
            }
            else
            {
                Console.WriteLine($"{moves} moves");
            }
        }
    }
}
