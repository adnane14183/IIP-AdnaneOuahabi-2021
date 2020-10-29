using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDeling
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1 = 0;
            int getal2 = 0;
            

            Console.WriteLine("Bereken de grootst gemeenschappelijk deler");
            Console.WriteLine("==========================================");
            Console.WriteLine(" ");
            Console.Write("Getal 1: ");
            getal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Getal 2: ");
            getal2 = Convert.ToInt32(Console.ReadLine());

            int som1 = getal1 - getal2;
            int som2 = getal2 - getal1;

            if (getal1 == getal2) { Console.WriteLine("Dit is niet mogelijk"); }
            else if (getal1 > getal2) { Console.WriteLine($" De ggd is {som1}"); }
            else
            {
                Console.WriteLine($"de ggd is {som2}");
            }
            Console.ReadKey();
        }
    }
}
