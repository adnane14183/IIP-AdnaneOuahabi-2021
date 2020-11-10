using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSchrikkeljaar
{
    class Program
    {
        static void Main(string[] args)
        {
            int jaar = 0;
            Console.WriteLine("SCHRIKKELJAAR");
            Console.WriteLine("=============");
            
           

            do
            {
                Console.Write("geef een getal: ");

                 jaar = Convert.ToInt32(Console.ReadLine());
                if ((jaar % 4 == 0) && (jaar % 100 != 0) || (jaar % 400 == 0))
                {
                    Console.WriteLine("Dit is een schrikkeljaar");
                }

                else
                {
                    Console.WriteLine("Dit is geen schrikkeljaar");
                }
            } while (jaar != 0 );

            Console.ReadLine();
        }
    }
}
