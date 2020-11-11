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

            for (int i = 1; i <= n; i++)
            {
                fac = fac * i;
            }
            return fac;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("bereken faculteit");
            Console.WriteLine();
            Console.Write("geef een geheel getal: ");
            int n = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("De faculteit is " + Faculteit(n));
            Console.ReadLine();
        }
        


        }
    }