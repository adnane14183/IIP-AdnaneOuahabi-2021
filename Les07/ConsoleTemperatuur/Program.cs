using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTemperatuur
{
    class Program
    {
        private static double cNaarf (double celsius)
        {
           
            double fahrenheit = celsius * 1.8 + 32;
            return fahrenheit;
            
        }
        private static double fnaarc (double fahrenheit)
        {
            double celsius = ( fahrenheit - Convert.ToDouble(32)) / Convert.ToDouble(1.8);
            return celsius;
        }
        private static double cNaark (double celsius)
        {
           double kelvin = celsius + 273.15;
            return kelvin;
        }
        private static double knaarc ( double kelvin)
        {
            double celsius = kelvin - 273.15;
            return celsius;
        }
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
                    double celsius = Convert.ToDouble(Console.ReadLine());
                    double fahrenheit = cNaarf(celsius);
                    Console.WriteLine("fahrenheit: " + fahrenheit);

                }

                if (keuze == "b")
                {
                    Console.WriteLine("Fahrenheit: ");
                    double fahrenheit = Convert.ToDouble(Console.ReadLine());
                    double celsius = fnaarc(fahrenheit);
                    Console.WriteLine("Celsius: " + celsius);
                }

                if (keuze == "c")
                {
                    Console.WriteLine("Celsius: ");
                    double celsius = Convert.ToDouble(Console.ReadLine());
                    double kelvin = cNaark(celsius);
                    Console.WriteLine("Kelvin: " + kelvin);
                }
                if (keuze == "d")
                {
                    Console.WriteLine("kelvin: ");
                    double kelvin  = Convert.ToDouble(Console.ReadLine());
                    double celsius = knaarc(kelvin);
                    Console.WriteLine("celsius: " + celsius);
                }

                //
            } while (keuze != "x");
        }
    }
}
