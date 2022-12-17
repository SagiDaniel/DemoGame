using System;
using System.Data;
using ConsoleTables;
namespace DemoGame
{
    public class moving
    {
        public static void move(string bekerkarakter, string bekeenemy)
        {
            Random rnd = new Random();
            int rand = rnd.Next(1, 4);
            do
            {
                string kiras = "";
                for (int i = 0; i < map.palya.Length; i++)
                {
                    kiras = kiras + map.palya[i];
                }
                var table = new ConsoleTable("Heal:",$"{bekerkarakter} {player.jatekos[0]}hp + {armor.GetPlayerarmor}","Armor:");
                table.AddRow($"Bandage: {player.inv[0]}"," " , $"Head: {player.inv[4]}");
                table.AddRow($"Poti: {player.inv[1]}",kiras , $"Stomach: {player.inv[5]}");
                table.AddRow($"Medkit: {player.inv[2]}"," " , $"Legs: {player.inv[6]}");
                table.AddRow($"Jugjug: {player.inv[3]}",$"{bekeenemy} Kingdom: {enemies.Enemy[0]}hp" , $"Shoes: {player.inv[7]}");
                table.Write();
                Console.WriteLine("Adja meg mit szeretne tenni:Mozgás(előre v hátra), támadás(támadás), item haszálni (bandage,poti,medkit,jugjug), menekülés(kilép)");
                Item healek = new Item();
                string beker = Console.ReadLine();
                if (beker=="előre")
                {
                    for (int j = 0; j < map.palya.Length; j++)
                    {
                        if (map.palya[j] == "X")
                        {
                            if (map.palya[j + 1] == "Y"&&j<6)
                            {
                                map.palya[j + 1] = "_";
                                map.palya[j + 2] = "Y";
                                break;
                            }
                            else if (j == 6)
                            {
                                enemies.Enemy[0]-=10;
                                if (enemies.Enemy[0]<=0)
                                {
                                    map.palya[j] = "_";
                                }
                            }
                            else
                            {
                                map.palya[j] = "_";
                                map.palya[j+1] = "X";
                                enemies.En();
                                break;
                            }
                        }
                    }
                }
                else if (beker == "hátra")
                {
                    int ezaz = 0;
                    for (int i =  map.palya.Length-1; i >= 0; i--)
                    {
                        if (ezaz==1)
                        {
                            map.palya[i] = "X";
                            ezaz = 0;
                            break;
                        }
                        if (map.palya[i]=="X"&&i>1)
                        {
                            ezaz = 1;
                            map.palya[i] = "_";
                        }
                    }
                    enemies.En();
                }
                else if (beker=="bandage")
                {
                    if (player.inv[0]<=1)
                    {
                        player.jatekos[0] += healek.GetBandage ;
                        if (player.jatekos[0]>130)
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
                else if (beker=="poti")
                {
                    if (player.inv[1] <= 1)
                    {
                        player.jatekos[1] += healek.GetPoti;
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
                    if (player.inv[2]<=1)
                    {
                        player.jatekos[2] += healek.GetMedkit;
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
                else if (beker=="jugjug")
                {
                    if (player.inv[3] <= 1)
                    {
                        player.jatekos[3] += healek.GetJugjug;
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
                    if (bekerkarakter=="geralt")
                    {
                        for (int i = 0; i < map.palya.Length; i++)
                        {
                            if (map.palya[i]=="X"&&map.palya[i+1]=="Y")
                            {
                                if (rand==1)
                                {
                                    enemies.Enemy[0]-=player.jatekos[4];
                                    rand=rnd.Next(1, 4);
                                }
                                else if (rand==2)
                                {
                                    enemies.Enemy[0]-=player.jatekos[5];
                                    rand=rnd.Next(1, 4);
                                }
                                else
                                {
                                    enemies.Enemy[0]-=player.jatekos[6];
                                    rand=rnd.Next(1, 4);
                                }
                                break; 
                            }
                        }
                    }
                    else
                    {
                        if (rand==1)
                        {
                            enemies.Enemy[0]-=player.jatekos[4];
                            rand=rnd.Next(1, 4);
                        }
                        else if (rand==2)
                        {
                            enemies.Enemy[0]-=player.jatekos[5];
                            rand=rnd.Next(1, 4);
                        }
                        else
                        {
                            enemies.Enemy[0]-=player.jatekos[6];
                            rand=rnd.Next(1, 4);
                        }
                    }
                    if (enemies.Enemy[0]<=0)
                    {
                        for (int i = 0; i < map.palya.Length; i++)
                        {
                            if (map.palya[i]=="Y")
                            {
                                map.palya[i] = "_";
                            }
                        }
                    }
                    enemies.En();
                }
                if (beker=="kilép")
                {
                    break;
                }
                if (player.jatekos[0]<=0)
                {
                    Console.WriteLine("Vesztettél");
                    break;
                }
                if (enemies.Enemy[0]<=0)
                {
                    Console.WriteLine("Win");
                    enemies.Enemylevel(bekeenemy);
                    Skill.skilltree();
                    break;
                }
            } while (true);
        }
    }
}