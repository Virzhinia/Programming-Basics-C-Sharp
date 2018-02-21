using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int chasti = int.Parse(Console.ReadLine());
            double parizaEdnatochka = double.Parse(Console.ReadLine());
            var result = 0.00;
            int tochkibe = 0;

            for (int i = 1; i <= chasti; i++)
            {
                var tochki = int.Parse(Console.ReadLine());
                if(i%2==0 && i!=1)
                {
                    tochki=tochki * 2;
                }
                tochkibe+=tochki;
            }
                result = parizaEdnatochka * tochkibe;
            Console.WriteLine($"The project prize was {result:f2} lv.");
        }
    }
}
