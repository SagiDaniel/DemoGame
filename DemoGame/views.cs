using System;
using System.Data;
using System.Xml.XPath;
using DemoGame;

namespace DemoGame
{
    public class Views
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Üdv a játékban");
            string bekerkarakter;
            do
            {
                Console.WriteLine("Válasz karaktert(Fiora, Hawk, Geralt)");
                bekerkarakter = Console.ReadLine()?.ToLower();
                if (bekerkarakter=="fiora"||bekerkarakter=="hawk"||bekerkarakter=="geralt")
                {
                    break;
                }
            } while (true);

            string bekerellenfel;
            do
            {
                Console.WriteLine("Válasz ellenfelet(Lloyd, Fallen, Dwarf)");
                bekerellenfel = Console.ReadLine()?.ToLower();
                if (bekerellenfel=="dwarf"||bekerellenfel=="fallen"||bekerellenfel=="lloyd")
                {
                    break;
                }
            } while (true);

            Console.WriteLine("Adja meg a nevet");
            string bekerplayer = Console.ReadLine();
            Map.maps(bekerellenfel,bekerkarakter);
            player.karakter(bekerkarakter);
            viewhelp.viewhelps();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}