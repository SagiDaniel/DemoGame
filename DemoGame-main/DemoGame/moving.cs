using System;
using System.Data;
using System.Net.NetworkInformation;
using ConsoleTables;

namespace DemoGame
{
    public class moving
    {
        public static void move(string bekerkarakter, string bekeenemy)
        {
            Random rnd = new Random();
            int rand = rnd.Next(1, 4);
            string kirasa = "";
            for (int i = 0; i < map.palya.Length; i++)
            {
                kirasa = kirasa + map.palya[i];
            }

            var tablea = new ConsoleTable("Heal:", $"{bekerkarakter} {player.jatekos[0]}hp + {armor.GetPlayerarmor}",
                "Armor:");
            tablea.AddRow($"Bandage: {player.inv[0]}", " ", $"Head: {player.inv[4]}");
            tablea.AddRow($"Poti: {player.inv[1]}", kirasa, $"Stomach: {player.inv[5]}");
            tablea.AddRow($"Medkit: {player.inv[2]}", " ", $"Legs: {player.inv[6]}");
            tablea.AddRow($"Jugjug: {player.inv[3]}", $"{bekeenemy} Kingdom: {enemies.Enemy[0]}hp",
                $"Shoes: {player.inv[7]}");
            tablea.Write();
            do
            {
                
                Console.WriteLine(
                    "Adja meg mit szeretne tenni:Mozgás(előre v hátra), támadás(támadás), item haszálni (bandage,poti,medkit,jugjug), menekülés(kilép)");
                
                string beker = Console.ReadLine();
                if (beker == "előre")
                {
                    for (int j = 0; j < map.palya.Length; j++)
                    {
                        if (map.palya[j] == "X")
                        {
                            if (map.palya[j + 1] == "Y" && j < 6)
                            {
                                map.palya[j + 1] = "_";
                                map.palya[j + 2] = "Y";
                                break;
                            }
                            else if (j == 6)
                            {
                                enemies.Enemy[0] -= 10;
                                if (enemies.Enemy[0] <= 0)
                                {
                                    if (map.palya[j] == "Y") {
                                        map.palya[j] = "_";
                                    }
                                }
                            }
                            else
                            {
                                map.palya[j] = "_";
                                map.palya[j + 1] = "X";
                                enemies.En();
                                break;
                            }
                        }
                    }
                }
                else if (beker == "hátra")
                {
                    int ezaz = 0;
                    for (int i = map.palya.Length - 1; i >= 0; i--)
                    {
                        if (ezaz == 1)
                        {
                            map.palya[i] = "X";
                            ezaz = 0;
                            break;
                        }

                        if (map.palya[i] == "X" && i > 1)
                        {
                            ezaz = 1;
                            map.palya[i] = "_";
                        }
                    }

                    enemies.En();
                }
                else if (beker == "bandage")
                {
                    if (player.inv[0] <= 1)
                    {
                        player.jatekos[0] += 5;
                        if (player.jatekos[0] > 130)
                        {
                            player.jatekos[0] = 130;
                        }

                        player.inv[0]--;
                    }
                    else
                    {
                        Console.WriteLine("Nincsen bandaged");
                    }

                    enemies.En();
                }
                else if (beker == "poti")
                {
                    if (player.inv[1] <= 1)
                    {
                        player.jatekos[1] += 10;
                        if (player.jatekos[0] > 130)
                        {
                            player.jatekos[0] = 130;
                        }

                        player.inv[1]--;
                    }
                    else
                    {
                        Console.WriteLine("Nincsen potid");
                    }

                    enemies.En();
                }
                else if (beker == "medkit")
                {
                    if (player.inv[2] <= 1)
                    {
                        player.jatekos[2] += 40;
                        if (player.jatekos[0] > 130)
                        {
                            player.jatekos[0] = 130;
                        }

                        player.inv[2]--;
                    }
                    else
                    {
                        Console.WriteLine("Nincsen medkited");
                    }

                    enemies.En();
                }
                else if (beker == "jugjug")
                {
                    if (player.inv[3] <= 1)
                    {
                        player.jatekos[3] += 60;
                        if (player.jatekos[0] > 130)
                        {
                            player.jatekos[0] = 130;
                        }

                        player.inv[3]--;
                    }
                    else
                    {
                        Console.WriteLine("Nincsen jugjugod");
                    }

                    enemies.En();
                }
                else if (beker == "támadás")
                {
                    if (bekerkarakter == "geralt")
                    {
                        for (int i = 0; i < map.palya.Length; i++)
                        {
                            if (bekeenemy == "fallen")
                            {
                                if (map.palya[i] == "X" && map.palya[i + 1] == "Y")
                                {
                                    if (rand == 1)
                                    {
                                        enemies.Enemy[0] -= Playeratc.GetEros1;
                                        rand = rnd.Next(1, 4);
                                    }
                                    else if (rand == 2)
                                    {
                                        enemies.Enemy[0] -= Playeratc.GetEros2;
                                        rand = rnd.Next(1, 4);
                                    }
                                    else
                                    {
                                        enemies.Enemy[0] -= Playeratc.GetEros3;
                                        rand = rnd.Next(1, 4);
                                    }
                                    break;
                                }
                            }
                            else
                            {
                                if (map.palya[i] == "X" && map.palya[i + 1] == "Y")
                                {
                                    if (rand == 1)
                                    {
                                        enemies.Enemy[0] -= Playeratc.GetGyenge1;
                                        rand = rnd.Next(1, 4);
                                    }
                                    else if (rand == 2)
                                    {
                                        enemies.Enemy[0] -= Playeratc.GetGyenge2;
                                        rand = rnd.Next(1, 4);
                                    }
                                    else
                                    {
                                        enemies.Enemy[0] -= Playeratc.GetGyenge3;
                                        rand = rnd.Next(1, 4);
                                    }
                                }
                            }
                        }
                    }
                    else if(bekerkarakter == "hawk")
                    {
                        if (bekeenemy == "lloyd")
                        {
                            if (rand == 1)
                            {
                                enemies.Enemy[0] -= Playeratc.GetEros1;
                                rand = rnd.Next(1, 4);
                            }
                            else if (rand == 2)
                            {
                                enemies.Enemy[0] -= Playeratc.GetEros2;
                                rand = rnd.Next(1, 4);
                            }
                            else
                            {
                                enemies.Enemy[0] -= Playeratc.GetEros3;
                                rand = rnd.Next(1, 4);
                            }
                        }
                        else
                        {
                            if (rand == 1)
                            { 
                                enemies.Enemy[0] -= Playeratc.GetGyenge1; 
                                rand = rnd.Next(1, 4);
                            }
                            else if (rand == 2)
                            {
                                enemies.Enemy[0] -= Playeratc.GetGyenge2;
                                rand = rnd.Next(1, 4);
                            }
                            else
                            {
                                enemies.Enemy[0] -= Playeratc.GetGyenge3;
                                rand = rnd.Next(1, 4);
                            }
                        }
                    }
                    else if (bekerkarakter == "fiora")
                    {
                        if (bekeenemy == "dwarf")
                        {
                            if (rand == 1)
                            {
                                enemies.Enemy[0] -= Playeratc.GetEros1;
                                rand = rnd.Next(1, 4);
                            }
                            else if (rand == 2)
                            {
                                enemies.Enemy[0] -= Playeratc.GetEros2;
                                rand = rnd.Next(1, 4);
                            }
                            else
                            {
                                enemies.Enemy[0] -= Playeratc.GetEros3;
                                rand = rnd.Next(1, 4);
                            }
                        }
                        else
                        {
                            if (rand == 1)
                            {
                                enemies.Enemy[0] -= Playeratc.GetGyenge1;
                                rand = rnd.Next(1, 4);
                            }
                            else if (rand == 2)
                            {
                                enemies.Enemy[0] -= Playeratc.GetGyenge2;
                                rand = rnd.Next(1, 4);
                            }
                            else
                            {
                                enemies.Enemy[0] -= Playeratc.GetGyenge3;
                                rand = rnd.Next(1, 4);
                            }
                        }
                    } 
                    if (enemies.Enemy[0] <= 0)
                    {
                        for (int i = 0; i < map.palya.Length; i++)
                        {
                            if (map.palya[i] == "Y")
                            {
                                map.palya[i] = "_";
                                enemies.Enemy[0] = 0;
                            }
                        }
                    }

                    enemies.En();
                }
                if (player.jatekos[0] <= 0)
                {
                    for (int i = 0; i < map.palya.Length; i++)
                    {
                        if (map.palya[i] == "X")
                        {
                            map.palya[i] = "_";
                        }
                    }
                }
                if (beker == "kilép")
                {
                    break;
                }
                string kiras = "";
                for (int i = 0; i < map.palya.Length; i++)
                {
                    kiras = kiras + map.palya[i];
                }
                var table = new ConsoleTable("Heal:", $"{bekerkarakter} {player.jatekos[0]}hp + {armor.GetPlayerarmor}",
                    "Armor:");
                table.AddRow($"Bandage: {player.inv[0]}", " ", $"Head: {player.inv[4]}");
                table.AddRow($"Poti: {player.inv[1]}", kiras, $"Stomach: {player.inv[5]}");
                table.AddRow($"Medkit: {player.inv[2]}", " ", $"Legs: {player.inv[6]}");
                table.AddRow($"Jugjug: {player.inv[3]}", $"{bekeenemy} Kingdom: {enemies.Enemy[0]}hp",
                    $"Shoes: {player.inv[7]}");
                table.Write();
                if (player.jatekos[0] <= 0)
                {
                    Console.WriteLine("Vesztettél");
                    player.jatekos[0] = 100;
                    break;
                }

                if (enemies.Enemy[0] <= 0)
                {
                    win.gyozelem(bekeenemy);
                    Console.WriteLine("Win");
                    enemies.Enemylevel(bekeenemy);
                    Skill.GetSkillpont++;
                    break;
                }
            } while (true);
        }
    }
}