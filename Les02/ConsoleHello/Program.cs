using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo wereld!");
            Console.Write("Hoe heet je: ");
            string name = Console.ReadLine();
            Console.WriteLine("Aangename kennismaking " + name);
            Console.WriteLine("Druk een toets op verder te gaan ...");
            Console.ReadLine();

        }
    }
}
