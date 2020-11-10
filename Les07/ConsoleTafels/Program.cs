using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTafels
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal = 0;
            int lengte = 0;

            Console.Write("geef een getal: ");
            getal = Convert.ToInt32(Console.ReadLine());
            Console.Write("geef een lengte: ");
            lengte = Convert.ToInt32(Console.ReadLine());

            for ( int multiplier = 1; multiplier <= lengte; multiplier++ )
            {
                Console.WriteLine("{0} * {1} = {2}", getal, multiplier, (getal * multiplier));
            }
            Console.ReadKey();

        }
    }
}
