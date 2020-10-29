using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRaden
{
    class Program
    {
        static void Main(string[] args)
        {
            int raadgetal = 6;
            int pogingenOver = 2;
            int welkePoging = 1;

            Console.WriteLine("Raad een getal tussen 1 en 10");
            Console.Write("poging " + welkePoging + " : ");
            int getal = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (raadgetal != getal)
                {
                    Console.WriteLine("Raad een getal tussen 1 en 10");
                    pogingenOver--;
                    welkePoging++;
                    Console.Write("poging " + welkePoging + " : ");
                    getal = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Gewonnen");
                    pogingenOver = 0;
                }
            } while (pogingenOver > 0);
            Console.WriteLine("Jij hebt verloren");
            Console.ReadKey();
             
        }
    }
} 
