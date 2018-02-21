using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_zad
{
    class Program
    {
        static void Main(string[] args)
        {
            var birth = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            var answer = birth.AddDays(999);
            Console.WriteLine("{0:dd-MM-yyyy}", answer);
        }
    }
}
