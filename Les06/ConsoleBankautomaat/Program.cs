using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBankautomaat
{
    class Program
    {
        static void Main(string[] args)
        {
            string keuze;
            double afhalen = 0;
            double saldo = 500;
            Console.WriteLine("BANKAUTOMAAT");
            Console.WriteLine("============");

            do
            {
                Console.WriteLine();
                Console.WriteLine("a. afhaling");
                Console.WriteLine("b. storting");
                Console.WriteLine("c. Mijn saldo zien");
                Console.WriteLine("d. stoppen");
                Console.WriteLine();
                keuze = Console.ReadLine();

                if (keuze == "a")
                {
                    Console.Write("Welke bedrag wil je afhalen? ");
                    afhalen = Convert.ToDouble(Console.ReadLine());
                    saldo = saldo - afhalen;
                    Console.WriteLine("Je nieuwe saldo is " + saldo);
                }

                if(saldo < 0)
                {
                    Console.WriteLine("Jij hebt te weinig geld op je rekening");
                    saldo = saldo + afhalen;
                    Console.WriteLine("Je saldo is " + saldo);
                    afhalen = 0;

                }

                if (keuze == "b")
                {
                    Console.Write("Welke bedrag wil je storten? ");
                    double storten = Convert.ToDouble(Console.ReadLine());
                    saldo = saldo + storten;
                    Console.WriteLine("Je nieuwe saldo is " + saldo);
                }
                if (keuze == "c")
                {
                    Console.Write("Jouw saldo bedraagd " + saldo);
                }

                if (keuze != "a" && keuze != "b" && keuze != "c" && keuze != "d")
                {
                    Console.WriteLine("Ongeldige keuzen");
                }
               

            } while (keuze != "d");
            Console.WriteLine("Bedankt en tot zien");
            Console.ReadLine();
        }
    }
}
