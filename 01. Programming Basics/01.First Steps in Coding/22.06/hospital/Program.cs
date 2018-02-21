using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var period = int.Parse(Console.ReadLine());
            var lekari = 7;
            var pregledani = 0;
            var nepregledani = 0;

            for (int i = 1; i <= period; i++)
            {
                var pacientinaDen = int.Parse(Console.ReadLine());
                
                if(nepregledani>pregledani && i%3==0 && i!=0)
                {
                    lekari++;
                }
                if (pacientinaDen >= lekari)
                {
                    nepregledani += pacientinaDen - lekari;
                    pregledani += lekari;

                }
                else
                {
                    nepregledani += 0;
                    pregledani += pacientinaDen;
                }
                
            }


            Console.WriteLine($"Treated patients: {pregledani}.");
            Console.WriteLine($"Untreated patients: {nepregledani}.");


        }
    }
}
