using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGreenhouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** WELKOM BIJ GREENHOUSE RESTAURANT ***");
            Console.WriteLine("=========================================");
            Console.WriteLine();
            Console.Write("Kies een grootte (kleine of grote):");
            string name = Console.ReadLine();
            Console.Write("Kies een basis (quinoa, rijst, salade):");
            string name2 = Console.ReadLine();
            Console.Write("kies een soort (vegan, zalm, kip):");
            string name3 = Console.ReadLine();
            Console.Write("Je bestelling: een " + name);
            Console.Write(" " + name2);
            Console.Write(" met " + name3);
            Console.ReadLine();
        }
    }
}
