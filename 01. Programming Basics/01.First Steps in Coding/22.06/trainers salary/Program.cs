using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainers_salary
{
    class Program
    {
        static void Main(string[] args)
        {
            var lekcii = int.Parse(Console.ReadLine());
            var budjet = double.Parse(Console.ReadLine());
            var jelev = 0.00;
            var royal = 0.00;
            var roli = 0.00;
            var trofon = 0.00;
            var sino = 0.00;
            var others = 0.00;

            for (int i = 0; i < lekcii; i++)
            {
                var lektor = Console.ReadLine().ToLower();
                switch (lektor)
                {
                    case "jelev": jelev++; break;
                    case "royal": royal++; break;
                    case "roli": roli++; break;
                    case "trofon": trofon++; break;
                    case "sino": sino++; break;
                }
                if (lektor != "jelev" && lektor != "royal" && lektor != "roli" && lektor != "trofon" && lektor != "sino")
                {
                    others++;
                }
            }
            var zaplata = budjet / lekcii;
            Console.WriteLine($"Jelev salary: {zaplata*jelev:f2} lv");
            Console.WriteLine($"RoYaL salary: {zaplata * royal:f2} lv");
            Console.WriteLine($"Roli salary: {zaplata * roli:f2} lv");
            Console.WriteLine($"Trofon salary: {zaplata * trofon:f2} lv");
            Console.WriteLine($"Sino salary: {zaplata * sino:f2} lv");
            Console.WriteLine($"Others salary: {zaplata * others:f2} lv");

        }
    }
}
