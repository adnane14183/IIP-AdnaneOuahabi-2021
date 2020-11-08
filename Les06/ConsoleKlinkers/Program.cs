using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKlinkers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef een tekst: ");
            string tekst = Console.ReadLine();
            int klinkers = 0;
            char volgende = 'a';
            foreach (char c in tekst)
            {
             

                if ( c == 'a')
                {
                    klinkers++;
                }
                if (c == 'e')
                {
                    klinkers++;
                }
                if (c == 'i')
                {
                    klinkers++;
                }
                if (c == 'o')
                {
                    klinkers++;
                }
                if (c == 'u')
                {
                    klinkers++;
                }
            }

            foreach ( char g in tekst)
            {
                volgende = Convert.ToChar( g + 1);
            }
           

            Console.WriteLine($"Deze tekst bevat {klinkers} klinkers");
            Console.WriteLine("In geheimeschrift " +  volgende);
            Console.ReadLine();
        }
    }
}
