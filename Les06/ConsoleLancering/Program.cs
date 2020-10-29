using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLancering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoeveel seconden voor Lancering: ");
            for (int sec = Convert.ToInt32(Console.ReadLine()); sec >= 1; sec--)
            {
                Console.WriteLine(sec + "...");
            }
            Console.WriteLine("Lift off!");
            Console.ReadLine();

        }
    }
}
