using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfCircle
{
    internal class AOC
    {
        static void Main(string[] args)
        {
            decimal radius = 0;
            decimal area = 0;
            double pi = 0;

            Console.WriteLine("Enter the radius of circle");
            radius = Convert.ToDecimal(Console.ReadLine());

            pi = 3.14;

            area = Convert.ToDecimal(pi) * radius * radius;
            Console.WriteLine("Area of the circle with radius {0} is {1}", radius, area);
            Console.WriteLine("Press any key to Exit");
            Console.ReadKey();

        }
        
    }
}
