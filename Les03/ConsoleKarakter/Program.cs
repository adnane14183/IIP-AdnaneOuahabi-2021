using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKarakter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("geef een kleine letter: ");
            char karakter = Convert.ToChar(Console.ReadLine());

            int asciiNr = Convert.ToInt32(karakter);
            char volgendeKar = Convert.ToChar(karakter + 1);
            char vorigekar = Convert.ToChar(karakter - 1);
            char hoofdLetter = Convert.ToChar(karakter - 32);

            Console.WriteLine($"{Environment.NewLine}Het nummer is {asciiNr}");
            Console.WriteLine($"De vorige letter is {vorigekar}");
            Console.WriteLine($"De volgende letter is {volgendeKar}");
            Console.WriteLine($"De hoofdletter is {hoofdLetter}");
            Console.ReadLine();
        }
    }
}
