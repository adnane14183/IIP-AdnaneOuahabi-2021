using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTemperatuur
{
    class Program
    {
        static void Main(string[] args)
        {
            string keuze = " ";
            Console.WriteLine("temperatuur");
            Console.WriteLine("===========");
            
            do
            {
                Console.WriteLine("a.  Celsius naar fahrenheit");
                Console.WriteLine("b.  fahrenheit naar celcius"); 
                Console.WriteLine("c.  Celsius naar kelvin"); 
                Console.WriteLine("d.  kelvin naar celcius");
                Console.WriteLine("x.  sluiten");
                 keuze = Console.ReadLine();

                if (keuze == "a")
                {
                    Console.WriteLine("Celsius: ");
                    double temp = Convert.ToDouble(Console.ReadLine());
                    double F = temp * 1.8 + 32;
                    Console.WriteLine("fahrenheit: " + F);
                }

                if (keuze == "b")
                {
                    Console.WriteLine("Fahrenheit: ");
                    double temp = Convert.ToDouble(Console.ReadLine());
                    double c = (temp - Convert.ToDouble(32)) / Convert.ToDouble(1.8);
                    Console.WriteLine("Celsius: " + c);
                }

                if (keuze == "c")
                {
                    Console.WriteLine("Celsius: ");
                    double temp = Convert.ToDouble(Console.ReadLine());
                    double k = temp + 273.15;
                    Console.WriteLine("Kelvin: " + k);
                }
                if (keuze == "d")
                {
                    Console.WriteLine("kelvin: ");
                    double temp = Convert.ToDouble(Console.ReadLine());
                    double c = temp - 273.15;
                    Console.WriteLine("celsius: " + c);
                }


            } while (keuze != "x");
        }
    }
}
