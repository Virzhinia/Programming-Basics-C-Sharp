using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace point_in_tthe_figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            if ((x<3*h && y<h && y>0 && x>0) || (x>h && x<2*h && y<4*h && x>0 && y>0))
            {
                Console.WriteLine("inside");
            }

            else if ((x>=0 && x<3*h && y==0) || ((x>=0 && x<=h || (x>=2*h && x<=3*h)) && y==h) || 
                ((y<=h && y>=0) && (x==0 || x==3*h)) || (y<=4*h && y>=h && (x==h || x==2*h)) || (x>=h && x<=2*h && y==4*h))
            {
                Console.WriteLine("Border");
            }

            else 
            {
                
                Console.WriteLine("Outside");
            }

        }
    }
}
