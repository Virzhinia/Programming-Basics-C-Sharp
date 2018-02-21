using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._06
{
    class Program
    {
        static void Main(string[] args)
        {
            var planchashi = int.Parse(Console.ReadLine());
            var rabotnici = int.Parse(Console.ReadLine());
            var dni = int.Parse(Console.ReadLine());

            var rabotnichasa = rabotnici * dni*8;
            var chashi =Math.Floor(rabotnichasa / 5.00);

            if(planchashi>chashi)
            {
                var ostatyk = (planchashi - chashi)*4.2;
                Console.WriteLine("Losses: {0:f2}",ostatyk);
            }
            else
            {
                var ostatyk = (chashi-planchashi) * 4.2;
                Console.WriteLine("{0:f2} extra money", ostatyk);
            }
        }
    }
}
