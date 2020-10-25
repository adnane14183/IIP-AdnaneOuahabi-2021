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
            Console.ReadLine();


        }
    }
}
