using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTafels
{
    class Program
    {
        static private void DrukTafel(int getal, int lengte)
        {
            for (int multiplier = 1; multiplier <= lengte; multiplier++)
            {
                Console.WriteLine("{0} * {1} = {2}", getal, multiplier, (getal * multiplier));
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.Write("geef een getal: ");
            int getal = Convert.ToInt32(Console.ReadLine());
            Console.Write("geef een lengte: ");
            int lengte = Convert.ToInt32(Console.ReadLine());
            DrukTafel(getal,lengte);
        }
            
        }
    }
