using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_camp
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine().ToLower();
            var group = System.Console.ReadLine().ToLower();
            var broi = int.Parse(Console.ReadLine());
            var noshtuvki = int.Parse(Console.ReadLine());

            if (broi>=50) //50%otstypka ot cenata
            {
                if (season=="winter")
                {
                    var cena = broi * noshtuvki * 9.60;
                    var cenaed = cena - cena * 0.50;
                    var cenasmes = (broi * noshtuvki * 10)/2;
                    switch (group)
                    {
                        case "girls": Console.WriteLine($"Gymnastics {cenaed:f2} lv."); break;
                        case "boys": Console.WriteLine($"Judo {cenaed:f2} lv."); break;
                        case "mixed": Console.WriteLine($"Ski {cenasmes:f2} lv."); break;
                    }
                }

                if (season == "spring")
                {
                    var cena = broi * noshtuvki * 7.20;
                    var cenaed = cena - cena * 0.50;
                    var cenasmes = (broi * noshtuvki * 9.50)/2;
                    switch (group)
                    {
                        case "girls": Console.WriteLine($"Athletics {cenaed:f2} lv."); break;
                        case "boys": Console.WriteLine($"Tennis {cenaed:f2} lv."); break;
                        case "mixed": Console.WriteLine($"Cycling {cenasmes:f2} lv."); break;
                    }
                }

                if (season == "summer")
                {
                    var cena = broi * noshtuvki * 15;
                    var cenaed = cena - cena * 0.50;
                    var cenasmes = (broi * noshtuvki * 20) / 2;
                    switch (group)
                    {
                        case "girls": Console.WriteLine($"Volleyball {cenaed:f2} lv."); break;
                        case "boys": Console.WriteLine($"Football {cenaed:f2} lv."); break;
                        case "mixed": Console.WriteLine($"Swimming {cenasmes:f2} lv."); break;
                    }
                }
            }

            else if (broi<50 && broi>=20) //15% ots ot cenata 
            {
                if (season == "winter")
                {
                    var cena = broi * noshtuvki * 9.60;
                    var cenaed = cena - cena * 0.15;
                    var cenasmes = (broi * noshtuvki * 10) - (broi * noshtuvki * 10)*0.15;
                    switch (group)
                    {
                        case "girls": Console.WriteLine($"Gymnastics {cenaed:f2} lv."); break;
                        case "boys": Console.WriteLine($"Judo {cenaed:f2} lv."); break;
                        case "mixed": Console.WriteLine($"Ski {cenasmes:f2} lv."); break;
                    }
                }

                if (season == "spring")
                {
                    var cena = broi * noshtuvki * 7.20;
                    var cenaed = cena - cena * 0.15;
                    var cenasmes = (broi * noshtuvki * 9.50)-(broi * noshtuvki * 9.50)*0.15;
                    switch (group)
                    {
                        case "girls": Console.WriteLine($"Athletics {cenaed:f2} lv."); break;
                        case "boys": Console.WriteLine($"Tennis {cenaed:f2} lv."); break;
                        case "mixed": Console.WriteLine($"Cycling {cenasmes:f2} lv."); break;
                    }
                }

                if (season == "summer")
                {
                    var cena = broi * noshtuvki * 15;
                    var cenaed = cena - cena * 0.15;
                    var cenasmes = (broi * noshtuvki * 20)-(broi * noshtuvki * 20)*0.15;
                    switch (group)
                    {
                        case "girls": Console.WriteLine($"Volleyball {cenaed:f2} lv."); break;
                        case "boys": Console.WriteLine($"Football {cenaed:f2} lv."); break;
                        case "mixed": Console.WriteLine($"Swimming {cenasmes:f2} lv."); break;
                    }
                }
            }


            else if (broi<20 && broi>=10) //5% ots ot cenata
            {
                if (season == "winter")
                {
                    var cena = broi * noshtuvki * 9.60;
                    var cenaed = cena - cena * 0.05;
                    var cenasmes = (broi * noshtuvki * 10) - (broi * noshtuvki * 10) * 0.05;
                    switch (group)
                    {
                        case "girls": Console.WriteLine($"Gymnastics {cenaed:f2} lv."); break;
                        case "boys": Console.WriteLine($"Judo {cenaed:f2} lv."); break;
                        case "mixed": Console.WriteLine($"Ski {cenasmes:f2} lv."); break;
                    }
                }

                if (season == "spring")
                {
                    var cena = broi * noshtuvki * 7.20;
                    var cenaed = cena - cena * 0.05;
                    var cenasmes = (broi * noshtuvki * 9.50) - (broi * noshtuvki * 9.50) * 0.05;
                    switch (group)
                    {
                        case "girls": Console.WriteLine($"Athletics {cenaed:f2} lv."); break;
                        case "boys": Console.WriteLine($"Tennis {cenaed:f2} lv."); break;
                        case "mixed": Console.WriteLine($"Cycling {cenasmes:f2} lv."); break;
                    }
                }

                if (season == "summer")
                {
                    var cena = broi * noshtuvki * 15;
                    var cenaed = cena - cena * 0.05;
                    var cenasmes = (broi * noshtuvki * 20) - (broi * noshtuvki * 20) * 0.05;
                    switch (group)
                    {
                        case "girls": Console.WriteLine($"Volleyball {cenaed:f2} lv."); break;
                        case "boys": Console.WriteLine($"Football {cenaed:f2} lv."); break;
                        case "mixed": Console.WriteLine($"Swimming {cenasmes:f2} lv."); break;
                    }
                }
            }

            else
            {
                if (season == "winter")
                {
                    var cena = broi * noshtuvki * 9.60;
                    var cenasmes = broi * noshtuvki * 10;
                    switch (group)
                    {
                        case "girls": Console.WriteLine($"Gymnastics {cena:f2} lv."); break;
                        case "boys": Console.WriteLine($"Judo {cena:f2} lv."); break;
                        case "mixed": Console.WriteLine($"Ski {cenasmes:f2} lv."); break;
                    }
                }

                if (season == "spring")
                {
                    var cena = broi * noshtuvki * 7.20;
                    var cenasmes = broi * noshtuvki * 9.50;
                    switch (group)
                    {
                        case "girls": Console.WriteLine($"Athletics {cena:f2} lv."); break;
                        case "boys": Console.WriteLine($"Tennis {cena:f2} lv."); break;
                        case "mixed": Console.WriteLine($"Cycling {cenasmes:f2} lv."); break;
                    }
                }

                if (season == "summer")
                {
                    var cena = broi * noshtuvki * 15;
                    var cenasmes = broi * noshtuvki * 20;
                    switch (group)
                    {
                        case "girls": Console.WriteLine($"Volleyball {cena:f2} lv."); break;
                        case "boys": Console.WriteLine($"Football {cena:f2} lv."); break;
                        case "mixed": Console.WriteLine($"Swimming {cenasmes:f2} lv."); break;
                    }
                }
            }
        }
    }
}
