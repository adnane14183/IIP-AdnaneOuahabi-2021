using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMI CALCULATOR");
            Console.WriteLine("==============");
            Console.Write("Lengte (in cm): ");
            double getal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gewicht (in kg): ");
            double getal2 = Convert.ToInt32(Console.ReadLine());
            double deling1 = Convert.ToDouble(getal1) / 100;
            double product = deling1 * deling1;
            double deling = Convert.ToDouble(getal2) / Convert.ToDouble(product);
            double deling5 = Math.Round(deling, 1);
            Console.Write("je BMI bedraagt: " + deling5);
            Console.ReadLine();
        }
    }
}
