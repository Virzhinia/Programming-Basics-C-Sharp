using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            double rekordsekundi = double.Parse(Console.ReadLine());
            double razstoqniemetri = double.Parse(Console.ReadLine());
            double sekundizametyrpluvne = double.Parse(Console.ReadLine());

            var razstoqnie = razstoqniemetri * sekundizametyrpluvne;
            var zabawqne = Math.Truncate(razstoqniemetri / 15) * 12.5;
            var obshtovreme = razstoqnie + zabawqne;
            var nepodobril = Math.Abs(rekordsekundi - obshtovreme);

            if(rekordsekundi<=obshtovreme)
            {
                Console.WriteLine($"No, he failed! He was {nepodobril:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {obshtovreme:f2} seconds.");
            }

        }
    }
}
