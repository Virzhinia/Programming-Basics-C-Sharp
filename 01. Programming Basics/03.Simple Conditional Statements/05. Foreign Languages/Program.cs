using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            var countryName = Console.ReadLine().ToLower();

            if (countryName == "usa" || countryName == "england") Console.WriteLine("English");
            else if (countryName == "spain" || countryName == "argentina" || countryName == "mexico") Console.WriteLine("Spanish");
            else Console.WriteLine("unknown");

        }
    }
}
