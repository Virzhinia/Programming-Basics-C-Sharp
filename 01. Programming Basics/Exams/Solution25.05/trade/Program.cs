using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trade
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine().ToLower();
            var vpr = double.Parse(Console.ReadLine());
            var per = 0.00;

            if (town == "sofia")
            {

                if (vpr >= 0 && vpr <= 500) per = 0.05;
                else if (vpr >= 500 && vpr <= 1000) per = 0.07;
                else if (vpr >= 1000 && vpr <= 10000) per = 0.08;
                else if (vpr >= 10000) per = 0.12;
            }
            else if (town == "varna")
            {
                if (vpr >= 0 && vpr <= 500) per = 0.045;
                else if (vpr >= 500 && vpr <= 1000) per = 0.075;
                else if (vpr >= 1000 && vpr <= 10000) per = 0.1;
                else if (vpr >= 10000) per = 0.13;
            }
                else if (town == "plovdiv")
            {
                if (vpr >= 0 && vpr <= 500) per = 0.055;
                else if (vpr >= 500 && vpr <= 1000) per = 0.08;
                else if (vpr >= 1000 && vpr <= 10000) per = 0.12;
                else if (vpr >= 10000) per = 0.145;
            }
            if (vpr >= 0 && (town == "sofia" || town == "varna" || town == "plovdiv"))
            {
                Console.WriteLine("{0:f2}", vpr * per);
            }
            else Console.WriteLine("error");
        }
    }
}
