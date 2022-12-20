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
            //amelyiket valasztottuk
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

            //playeratc-bol meghivjuk a tamadast
            Playeratc.playerattack(bekerellenfel, bekerkarakter);
            //playerbol meghivjuk a karakter dolgait
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
                    //felruhazas
                    armor.Heroarmor();
                    //szemtol szembe lesznek egymassal
                    map.maps(bekerkarakter, bekerellenfel);
                }
                else if (mitcsinal == "kilép")
                {
                    System.Environment.Exit(0);
                }
                else if (mitcsinal == "coin")
                {
                    //1000coint kap a jatekos
                    player.jatekos[3] += 1000;
                    //skill pontot kap
                    Skill.GetSkillpont++;
                }
                else if (mitcsinal == "skill")
                {
                    //bonuszt kap(hp,tamadas)
                     Skill.skilltree();
                }
                else
                {
                    //hibauzenet
                    Console.WriteLine("Nem jót adott meg");
                }
                //ha nem jot adott meg akkor ujra fut az egesz
                Console.WriteLine("Mit szeretne csinálni(bolt,harc,skill,kilép)");
            } while (true);
        }
    }
}