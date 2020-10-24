using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geeft het aantal seconden: ");
            //
            double uur1 = Convert.ToDouble(Console.ReadLine());
            double uur = Convert.ToInt32(uur1) / Convert.ToInt32(3600); //13
            double uur2 = uur1 / 3600; //13,47....
            //
            double minuten = (uur2 - uur) * Convert.ToInt32(60);//28.5666666
            double minuten1 = Math.Floor(minuten);
            //
            double seconden = (minuten - minuten1) * 60;

            //
            Console.WriteLine($"Omgezet in hms formaat: {uur}: {minuten1} : {Convert.ToInt32(seconden)}");
            Console.ReadLine();
        }
    }
}
