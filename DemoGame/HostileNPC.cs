using System;

namespace DemoGame
{
    public class HostileNPC
    {
        public static void bolt()
        {
            string vasarlas = "";
            Console.WriteLine("Áraink:");
            Console.WriteLine("\n Healek: \n \t Bandage \t 5 Coin \n \t Poti \t \t 10 Coin \n \t Medkit \t 25 Coin \n \t Jugjug \t 50 Coin.");
            Console.WriteLine("\n Armor:  \n \t Head \t \t 25 Coin \n \t Stomach \t 50 Coin \n \t Legs \t \t 35 Coin \n \t Shoes \t \t 25 Coin.");
            do
            {
                Console.WriteLine("Mit szeretne vásárolni?Healek(Bandage,Poti,Medkit,Jugjug).");
                Console.WriteLine("Armorok(Head,Stomach,Legs,Shoes)");
                Console.WriteLine("Ka ki szeretne lépni akkor a \"kilép\" kell.");
                Console.WriteLine($"{player.jatekos[3]} coinod van.");
                vasarlas = Console.ReadLine()?.ToLower();
                if (vasarlas!="kilép")
                {
                    switch (vasarlas)
                {
                    case "bandage":
                        if (player.jatekos[3]>=5)
                        {
                            player.inv[0]++;
                            player.jatekos[3] -= 5;
                            Console.WriteLine("Sikeres vásárlás!");
                        }
                        else
                        {
                            Console.WriteLine("Nincs elég pénzed!");
                        }
                        break;
                    case "poti":
                        if (player.jatekos[3]>=10)
                        {
                            player.inv[1]++;
                            player.jatekos[3] -= 10;
                            Console.WriteLine("Sikeres vásárlás!");
                        }
                        else
                        {
                            Console.WriteLine("Nincs elég pénzed!");
                        }
                        break;
                    case "medkit":
                        if (player.jatekos[3]>=25)
                        {
                            player.inv[2]++;
                            player.jatekos[3] -= 25;
                            Console.WriteLine("Sikeres vásárlás!");
                        }
                        else
                        {
                            Console.WriteLine("Nincs elég pénzed!");
                        }
                        break;
                    case "jugjug":
                        if (player.jatekos[3]>=50)
                        {
                            player.inv[3]++;
                            player.jatekos[3] -= 50;
                            Console.WriteLine("Sikeres vásárlás!");
                        }
                        else
                        {
                            Console.WriteLine("Nincs elég pénzed!");
                        }
                        break;
                    case "head":
                        if (player.inv[4]==0)
                        {
                            if (player.jatekos[3]>=25)
                            {
                                player.inv[4]++;
                                player.jatekos[3] -= 25;
                                Console.WriteLine("Sikeres vásárlás!");
                            }
                            else
                            {
                                Console.WriteLine("Nincs elég pénzed!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Van már ilyened!");
                        }
                        break;
                    case "stomach":
                        if (player.inv[5]==0)
                        {
                            if (player.jatekos[3]>=50)
                            {
                                player.inv[5]++;
                                player.jatekos[3] -= 50;
                                Console.WriteLine("Sikeres vásárlás!");
                            }
                            else
                            {
                                Console.WriteLine("Nincs elég pénzed!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Van már ilyened!");
                        }
                        break;
                    case "legs":
                        if (player.inv[6]==0)
                        {
                            if (player.jatekos[3]>=35)
                            {
                                player.inv[6]++;
                                player.jatekos[3] -= 35;
                                Console.WriteLine("Sikeres vásárlás!");
                            }
                            else
                            {
                                Console.WriteLine("Nincs elég pénzed!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Van már ilyened!");
                        }
                        break;
                    case "shoes":
                        if (player.inv[7]==0)
                        {
                            if (player.jatekos[3]>=35)
                            {
                                player.inv[7]++;
                                player.jatekos[3] -= 35;
                                Console.WriteLine("Sikeres vásárlás!");
                            }
                            else
                            {
                                Console.WriteLine("Nincs elég pénzed!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Van már ilyened!");
                        }
                        break;
                    default:
                        Console.WriteLine("Nincs ilyen áru");
                        break;
                } 
                }
                else
                {
                    break;
                }
            } while (vasarlas!="kilép");
        }
    }
}