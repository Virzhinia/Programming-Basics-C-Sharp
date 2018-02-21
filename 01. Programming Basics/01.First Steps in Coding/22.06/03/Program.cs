using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string razmer = Console.ReadLine().ToLower();
            var broipitieta = int.Parse(Console.ReadLine());
            var result = 0.00;

            if(razmer=="small")
            {
                switch(fruit)
                {
                    case "watermelon":result = broipitieta * 2*56;break;
                    case "mango":result = broipitieta * 2*36.66;break;
                    case "pineapple":result = broipitieta * 2*42.10; break;
                    case "raspberry":result = broipitieta * 2*20; break;

                }
            }

            else if(razmer=="big")
            {
                switch (fruit)
                {
                    case "watermelon":result = broipitieta * 5*28.70; break;
                    case "mango":result = broipitieta * 5*19.60; break;
                    case "pineapple": result = broipitieta * 5*24.80; break;
                    case "raspberry": result = broipitieta * 5*15.20; break;

                }
            }
            if(result>1000)
            {
                result = result / 2;
            }
            else if (result>=400 && result<=1000)
            {
                result = result - result * 0.15;
            }
           

            Console.WriteLine($"{result:f2} lv.");
        }
    }
}
