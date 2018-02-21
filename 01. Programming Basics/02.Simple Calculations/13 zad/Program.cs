using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_zad
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = double.Parse(Console.ReadLine());
            var vhvaluta = Console.ReadLine();
            var izhvaluta = Console.ReadLine();
            double result = 1.0;
            if (vhvaluta == "BGN")
            {
                if (izhvaluta == "USD") result = suma / 1.79549;
                if (izhvaluta == "EUR") result = suma / 1.95583;
                if (izhvaluta == "GBP") result = suma / 2.53405;
            }
            if (vhvaluta == "USD")
            {
                suma *= 1.79549;
                if (izhvaluta == "BGN") result = suma / 1.0;
                if (izhvaluta == "EUR") result = suma / 1.95583;
                if (izhvaluta == "GBP") result = suma / 2.53405;
            }
            if (vhvaluta == "EUR")
            {
                suma *= 1.95583;
                if (izhvaluta == "USD") result = suma / 1.79549;
                if (izhvaluta == "BGN") result = suma / 1.0;
                if (izhvaluta == "GBP") result = suma / 2.53405;
            }
            if (vhvaluta == "GBP")
            {
                suma *= 2.53405;
                if (izhvaluta == "USD") result = suma / 1.79549;
                if (izhvaluta == "EUR") result = suma / 1.95583;
                if (izhvaluta == "BGN") result = suma / 1.0;
            }

            Console.WriteLine(Math.Round(result,2));

      
        }
    }
}
