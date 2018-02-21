using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = char.Parse(Console.ReadLine().ToLower());
            var end = char.Parse(Console.ReadLine().ToLower());
            var bez = char.Parse(Console.ReadLine().ToLower());
            int combination = 0;

            for (char i = start; i <= end; i++)
            {
                for (char j = start; j <= end; j++)
                {
                    for (char k = start; k <= end; k++)
                    {
                        if(i!=bez && j!=bez && k!=bez)
                        {
                            combination++;
                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                }
            }
            Console.WriteLine(combination);

        }
    }
}
