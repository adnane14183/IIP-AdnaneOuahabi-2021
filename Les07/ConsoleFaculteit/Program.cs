using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFaculteit
{
    class Program
    {
        static void Main(string[] args)
        {
            int fac = 1;

            Console.WriteLine("bereken faculteit");
            Console.WriteLine();
            Console.Write("geef een geheel getal: ");
            int getal = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= getal; i++)
            {
                fac = fac * i;
            }
            Console.WriteLine("De faculteit is " + fac);
            Console.ReadLine();
        }
        }
}