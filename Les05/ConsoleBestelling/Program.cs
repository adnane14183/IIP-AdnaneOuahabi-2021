using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBestelling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PIZZA BESTELLING");
            Console.WriteLine("================");
            Console.WriteLine("");

            Console.WriteLine("kies je pizza:");
            Console.WriteLine("a) Margharita 8 euro"); 
            Console.WriteLine("b) Funghi 10 euro");
            Console.WriteLine("c) Diabolo 11 euro");
            Console.Write(">> wat is je keuze? ");
            string Pizza = Console.ReadLine();
            string Naam1 = "margharita";
            string naam2 = "Funghi";
            string naam3 = "diabolo";

            string pizzanaam = "foute info" ;

            double margharita = 8;
            double funghi = 10;
            double diabolo = 11;
            double totaal = 0;

            if (Pizza == "a") {
                totaal = margharita;
                pizzanaam = Naam1;
                    }
            else if (Pizza == "b") {
                totaal = funghi;
                pizzanaam = naam2;
            }
            else if (Pizza == "c") { totaal = diabolo;
                pizzanaam = naam3;
            }
            Console.WriteLine(totaal);

            Console.WriteLine("kies de grootte:");
            Console.WriteLine("a) 15 cm (klein: - 20%)");
            Console.WriteLine("b) 20 cm (normaal)");
            Console.WriteLine("c) 25 cm (groot: + 20%");
            Console.Write(">> wat is je keuze? ");
            string groote = Console.ReadLine();

            string groote1 = "klein";
            string groote2 = "normaal";
            string groote3 = "groot";
            string pizzagroote = "foute info" ;

            double totaalG = 0;

            if (groote == "a")
            {
                totaalG = (totaal / 1.20);
                pizzagroote =groote1;
            }
            else if (groote == "b")
            {
                totaalG = totaal;
                pizzagroote = groote2;
            }
            else if (groote == "c") { totaalG = (totaal * 1.20); pizzagroote = groote3; }

            Console.Write("Thuis bezorgen (3 euro extra)? Ja/Nee: ");
            string thuis = Console.ReadLine();
            string ophaling = "thuis bezorgd";
            string nietophaling = "niet thuis bezorgd";
            string typeophaling = "foute info";

            if (thuis == "ja" || thuis == "JA" || thuis == "Ja") { totaalG = totaalG + 3; typeophaling = ophaling; }
            else if (thuis == "nee" || thuis == "NEE" || thuis == "Nee") { typeophaling = nietophaling; }
           // else if (thuis != "nee" || thuis != "NEE" || thuis != "Nee" || thuis != "ja" || thuis != "JA" || thuis != "Ja") { 
                //Console.Write("Niet correct "); }



            Console.WriteLine("Jouw bestelling:1 pizza {0} {1}, voor {2} euro, {3}", pizzanaam, pizzagroote,Math.Round(totaalG, 2), typeophaling);
            Console.ReadLine();


        }
    }
}
