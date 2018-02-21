using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string single = Console.ReadLine();

            bool wordY= single.EndsWith("y");
            bool wordO= single.EndsWith("o") || single.EndsWith("s") 
                || single.EndsWith("x") || single.EndsWith("z") ||single.EndsWith("ch") || single.EndsWith("sh");

            if (wordY==true)
            {
                int plural = single.Length - 1;
                single = single.Remove(plural, 1);    
                Console.WriteLine($"{single}ies");
            }
            else if (wordO == true)
            {
                Console.WriteLine($"{single}es");
            }
            else
            {
                Console.WriteLine($"{single}s");
            }
        }
    }
}
