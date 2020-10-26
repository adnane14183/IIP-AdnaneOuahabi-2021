using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEindcijfer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Berekening eindcijfer");
            Console.WriteLine("====================");
            Console.WriteLine("");

            //

            Console.Write("Geef het cijfer dagelijks werk (Op 20): ");
            double DW = Convert.ToDouble(Console.ReadLine()) / Convert.ToDouble(20) * Convert.ToDouble(30);

            Console.Write("Geef het cijfer op het project (Op 20): ");
            double Project = Convert.ToDouble(Console.ReadLine());

            Console.Write("Geef het cijfer op het examen(Op 20): ");
            double EX = Convert.ToDouble(Console.ReadLine()) / Convert.ToDouble(20) * Convert.ToDouble(50);
            double tot = EX + DW + Project;
            //

            Console.WriteLine($"Je eindcijfer is {Math.Round(tot, 1)} %");
            if (Convert.ToDouble(tot) < 49) { Console.WriteLine("Onvoldoende"); }
            if (Convert.ToDouble(tot) >= 50 && tot < 67.5) { Console.WriteLine("Voldoende"); }
            if (Convert.ToDouble(tot) > 67.5 && tot < 75) { Console.WriteLine("Onderscheiding"); }
            if (Convert.ToDouble(tot) >= 75 && tot < 82.5) { Console.WriteLine("Grote onderscheiding"); }
            if (Convert.ToDouble(tot) > 82.5) { Console.WriteLine("Grootste onderscheiding"); }
            Console.ReadLine();





        }
    }
}
