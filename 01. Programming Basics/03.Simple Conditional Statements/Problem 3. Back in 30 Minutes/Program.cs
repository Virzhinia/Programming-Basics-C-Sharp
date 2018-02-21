using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int hours1 = 0;
            int minutes1 = 0;

            if (minutes>=59)
            {
                if (hours < 23)
                {
                    hours1 = hours + 1;
                    minutes1 = minutes - 30;
                Console.WriteLine($"{hours1}:{minutes1:d2}");
                }
                else
                {
                    hours1 = hours - 23;
                    minutes1 = minutes - 30;
                    Console.WriteLine($"{hours1}:{minutes1:d2}");
                }

            }

            if (minutes<59)
            {
                if(minutes<30 && hours<23)
                {
                    minutes1 = minutes + 30;
                    Console.WriteLine($"{hours}:{minutes1:d2}");
                }
                if (minutes>=30 && hours<23)
                {
                    minutes1 = minutes - 30;
                    hours1 = hours + 1;
                    Console.WriteLine($"{hours1}:{minutes1:d2}");
                }
                if(minutes < 30 && hours >= 23)
                {
                    hours1 = hours - 23;
                    minutes1 = minutes + 30;
                    Console.WriteLine($"{hours1}:{minutes1:d2}");
                }
                if (minutes >= 30 && hours >= 23)
                {
                    hours1 = hours - 23;
                    minutes1 = minutes - 30;
                    Console.WriteLine($"{hours1}:{minutes1:d2}");
                }
            }

        }
    }
}
