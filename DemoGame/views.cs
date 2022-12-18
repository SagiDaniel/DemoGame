using System;
using System.Data;
using System.Net.Mime;
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
                if (bekerkarakter == "fiora" || bekerkarakter == "hawk" || bekerkarakter == "geralt")
                {
                    break;
                }
            } while (true);

            string bekerellenfel;
            do
            {
                Console.WriteLine("Válasz ellenfelet(Lloyd, Fallen, Dwarf)");
                bekerellenfel = Console.ReadLine()?.ToLower();
                if (bekerellenfel == "dwarf" || bekerellenfel == "fallen" || bekerellenfel == "lloyd")
                {
                    break;
                }
            } while (true);

            Playeratc.playerattack(bekerellenfel, bekerkarakter);
            player.karakter(bekerkarakter);
            Console.WriteLine("Mit szeretne csinálni(bolt,harc,skill,kilép)");
            string mitcsinal = "";
            do
            {
                mitcsinal = Console.ReadLine()?.ToLower();
                if (mitcsinal == "bolt")
                {
                    HostileNPC.bolt();
                }
                else if (mitcsinal == "harc")
                {
                    armor.Heroarmor();
                    map.maps(bekerkarakter, bekerellenfel);
                }
                else if (mitcsinal == "kilép")
                {
                    System.Environment.Exit(0);
                }
                else if (mitcsinal == "coin")
                {
                    player.jatekos[3] += 1000;
                    Skill.GetSkillpont++;
                }
                else if (mitcsinal == "skill")
                {
                     Skill.skilltree();
                }
                else
                {
                    Console.WriteLine("Nem jót adott meg");
                }

                Console.WriteLine("Mit szeretne csinálni(bolt,harc,skill,kilép)");
            } while (true);
        }
    }
}