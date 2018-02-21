using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());


            if (a >= 0 && a <= 9)
            {
                if (a == 0)
                {
                    Console.WriteLine("zero");
                }
                else if (a == 1)
                {
                    Console.WriteLine("one");
                }
                else if (a == 2)
                {
                    Console.WriteLine("two");
                }
                else if (a == 3)
                {
                    Console.WriteLine("three");
                }
                else if (a == 4)
                {
                    Console.WriteLine("four");
                }
                else if (a == 5)
                {
                    Console.WriteLine("five");
                }
                else if (a == 6)
                {
                    Console.WriteLine("six");
                }
                else if (a == 7)
                {
                    Console.WriteLine("seven");
                }
                else if (a == 8)
                {
                    Console.WriteLine("eight");
                }
                else if (a == 9)
                {
                    Console.WriteLine("nine");
                }
            }
            else if (a >= 10 && a <= 20)
            {
                if (a == 10)
                {
                    Console.WriteLine("ten");
                }
                else if (a == 11)
                {
                    Console.WriteLine("eleven");
                }
                else if (a == 12)
                {
                    Console.WriteLine("twelve");
                }
                else if (a == 13)
                {
                    Console.WriteLine("Thirteen");
                }
                else if (a == 14)
                {
                    Console.WriteLine("fourteen");
                }
                else if (a == 15)
                {
                    Console.WriteLine("fifteen");
                }
                else if (a == 16)
                {
                    Console.WriteLine("sixteen");
                }
                else if (a == 17)
                {
                    Console.WriteLine("seventeen");
                }
                else if (a == 18)
                {
                    Console.WriteLine("eighteen");
                }
                else if (a == 19)
                {
                    Console.WriteLine("nineteen");
                }
                else if (a == 20)
                {
                    Console.WriteLine("twenty");
                }
            }
            else if (a >= 21 && a <= 99)
            {
                double tens = a / 10;
                double ones = a % 10;
                if (tens == 2)
                {
                    Console.Write("twenty");
                }
                else if (tens == 3)
                {
                    Console.Write("thirty");
                }
                else if (tens == 4)
                {
                    Console.Write("forty");
                }
                else if (tens == 5)
                {
                    Console.Write("fifty");
                }
                else if (tens == 6)
                {
                    Console.Write("sixty");
                }
                else if (tens == 7)
                {
                    Console.Write("seventy");
                }
                else if (tens == 8)
                {
                    Console.Write("eighty");
                }
                else if (tens == 9)
                {
                    Console.Write("ninety");
                }
                if (ones == 1)
                {
                    Console.WriteLine(" one");
                }
                else if (ones == 2)
                {
                    Console.WriteLine(" two");
                }
                else if (ones == 3)
                {
                    Console.WriteLine(" three");
                }
                else if (ones == 4)
                {
                    Console.WriteLine(" four");
                }
                else if (ones == 5)
                {
                    Console.WriteLine(" five");
                }
                else if (ones == 6)
                {
                    Console.WriteLine(" six");
                }
                else if (ones == 7)
                {
                    Console.WriteLine(" seven");
                }
                else if (ones == 8)
                {
                    Console.WriteLine(" eight");
                }
                else if (ones == 9)
                {
                    Console.WriteLine(" nine");
                }
            }

            else if (a == 100)
            {
                Console.WriteLine("one hundred");
            }
            else if (a > 100 || a < 0)
            {
                Console.WriteLine("invalid number");
            }

        }
    }
}