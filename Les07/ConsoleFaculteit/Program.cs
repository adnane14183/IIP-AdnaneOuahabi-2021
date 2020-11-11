using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFaculteit
{
    class Program
    {private static int  Faculteit (int n)
        {
            int fac = 1;

            Console.WriteLine("bereken faculteit");
            Console.WriteLine();
            Console.Write("geef een geheel getal: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                fac = fac * i;
            }
            return n;
        }
        static void Main(string[] args)
        {
            int n = Faculteit();

            Console.WriteLine("De faculteit is " + facn);
            Console.ReadLine();
        }
        
        }
    }