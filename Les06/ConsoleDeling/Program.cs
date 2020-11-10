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

            int ggd = Math.Min(getal1, getal2);

            while (getal1 % ggd != 0 || getal2 % ggd != 0)
            {
                ggd--;
            }
            

            Console.WriteLine($"De ggd is {ggd}");

            Console.ReadLine();
        }
    }
}
