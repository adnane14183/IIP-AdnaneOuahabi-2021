using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRaden
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Raad een getal tussen 1 en 10: ");
             double getal = Convert.ToDouble(Console.ReadLine());
            if (Convert.ToInt32(getal) >= 7) { Console.WriteLine("De gok was te hoog"); }
            if (Convert.ToInt32(getal) == 6) { Console.WriteLine("de gok is juist"); }
            if (Convert.ToInt32(getal) <= 5) { Console.WriteLine("de gok was te laag"); }

            Console.ReadLine();

        }
    }
}
