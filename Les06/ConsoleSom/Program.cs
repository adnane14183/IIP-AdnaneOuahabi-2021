using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSom
{
    class Program
    {
        static void Main(string[] args)
        {
            int totaal = 0;
            string invoer;

            do
            {
                Console.Write("Geef een getal (q om te stoppen): ");
                invoer = Console.ReadLine();

                if(invoer != "q")
                {
                    int getal = Convert.ToInt32(invoer);
                    totaal = totaal + getal;
                }

            } while (invoer != "q");

            Console.WriteLine($"De som is {totaal}");
            Console.ReadLine();
        }
    }
}
