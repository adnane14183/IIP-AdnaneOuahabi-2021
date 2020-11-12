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
        private static void schrikkeljaar(int jaartal)
        {
                if ((jaartal % 4 == 0) && (jaartal % 100 != 0) || (jaartal % 400 == 0))
                {
                    Console.WriteLine("Dit is een schrikkeljaar");
                }

                else
                {
                    Console.WriteLine("Dit is geen schrikkeljaar");
                }
        }
        static void Main(string[] args)
        {
             int jaartal = 0;

            Console.WriteLine("SCHRIKKELJAAR");
            Console.WriteLine("=============");
            do
            {
                Console.Write("geef een jaartal: ");
                jaartal = Convert.ToInt32(Console.ReadLine());
                schrikkeljaar(jaartal);

            } while ( jaartal != 0);
           
            Console.ReadLine();
        }
    }
}
