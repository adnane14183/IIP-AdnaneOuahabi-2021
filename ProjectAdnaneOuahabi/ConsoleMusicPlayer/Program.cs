using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace ConsoleMusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MEDIAPLAYER");
            Console.WriteLine("============");

            WindowsMediaPlayer Player = new WindowsMediaPlayer();
            Console.Write("Bestand afspelen: ");
            Player.URL = Console.ReadLine();  // C:/Users/Adnan/Music/Test.mp3

            string keuze = "";
            do
            {
                Console.WriteLine("a) Pauze ");
                Console.WriteLine("b) play");
                Console.WriteLine("c) Volume wijzigen");
                Console.WriteLine("d) Volume dempen");
                Console.WriteLine("e) dempen opheffen");
                Console.WriteLine("f) Liedje afspelen(om een ander liedje af te spelen dan het huidige liedje)");
                Console.WriteLine("g) Stoppen(stopt het afspelen van het huidige liedje)");
                Console.WriteLine("h) Afsluiten(sluit de volledige applicatie af)");
                Console.Write("Wat wil je doen? ");
                keuze = Console.ReadLine();
                Console.Clear();

                if (keuze == "a")
                {
                    Player.controls.pause();
                }
                if (keuze == "b")
                {
                    Player.controls.play();
                }
                if (keuze == "c")
                {
                    Console.WriteLine("Hoe luid wil je uw muziek (tussen 0 en 100)? ");
                    int volume = Convert.ToInt32(Console.ReadLine());
                    Player.settings.volume = volume;
                }
                if (keuze == "d")
                {
                    Player.settings.mute = true;
                }
                if (keuze == "e")
                {
                    Player.settings.mute = false;
                }
                if (keuze == "f" )
                {
                    Console.Write("Bestand afspelen: ");
                    Player.URL = Console.ReadLine();  // C:/Users/Adnan/Music/Test.mp3
                }
                if (keuze == "g")
                {
                    Player.controls.stop();
                }
               
               
                if (keuze != "a" && keuze != "b" && keuze != "c" && keuze != "d" && keuze != "e" && keuze != "f" && keuze != "g" && keuze != "h")
                {
                    Console.WriteLine("Kies tussen de actie's a, b, c, d, e, f, g, h en i");
                }

            } while (keuze != "h");
            {
                Player.close();
            }
            
            Console.ReadLine();


        }
    }
}
