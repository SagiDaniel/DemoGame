using System;
namespace DemoGame
{
    public class moving
    {
        public static void move()
        {
            /*
             mozgas(elore,hatra)
             tamaddas(1,2,3)
             bandage
             poti
             medkit
             jugjug
             */
            do
            {
                Console.WriteLine(
                    "Adja meg mit szeretne tenni:Mozgás(előre v hátra), támadás(1,2,3), item haszálni (bandage,poti,medkit,jugjug)");
                Item healek = new Item();
                string beker = Console.ReadLine();
                if (beker=="előre")
                {
                    int ezaz = 0;
                    int lokes = 0;
                    for (int j = 0; j < viewhelp.palya.Length; j++)
                    {
                        if (lokes!=0)
                        {
                            
                            viewhelp.palya[j+1] = "Y";
                            break;
                        }
                        if (ezaz==1)
                        {
                            viewhelp.palya[j] = "X";
                            ezaz = 0;
                            break;
                        }

                        if (viewhelp.palya[j] == "X")
                        {
                            if (viewhelp.palya[j + 1] == "Y"&&j<6)
                            {
                                viewhelp.palya[j + 1] = "_";
                                lokes++;
                            }
                            else if (j==6) {}
                            else
                            {
                                ezaz++;
                                viewhelp.palya[j] = "_";
                            }
                        }
                    }
                }
                else if (beker == "hátra")
                {
                    int ezaz = 0;
                    for (int i =  viewhelp.palya.Length-1; i >= 0; i--)
                    {
                        if (ezaz==1)
                        {
                            viewhelp.palya[i] = "X";
                            ezaz = 0;
                            break;
                        }
                        if (viewhelp.palya[i]=="X"&&i>1)
                        {
                            ezaz = 1;
                            viewhelp.palya[i] = "_";
                        }
                    }
                }
                else if (beker=="bandage")
                {
                    if (player.inv[0]<=1)
                    {
                        player.jatekos[0] += healek.GetBandage ;
                        if (player.jatekos[0]>100)
                        {
                            player.jatekos[0] = 100;
                        }
                        player.inv[0]--;
                    }
                    else
                    {
                        Console.WriteLine("Nincsen bandaged");
                        
                    }
                }
                else if (beker=="poti")
                {
                    if (player.inv[1] <= 1)
                    {
                        player.jatekos[1] += healek.GetPoti;
                        if (player.jatekos[0] > 100)
                        {
                            player.jatekos[0] = 100;
                        }

                        player.inv[1]--;
                    }
                    else
                    {
                        Console.WriteLine("Nincsen potid");
                        
                    }
                }
                else if (beker == "medkit")
                {
                    if (player.inv[2]<=1)
                    {
                        player.jatekos[2] += healek.GetMedkit;
                        if (player.jatekos[0] > 100)
                        {
                            player.jatekos[0] = 100;
                        }
                        player.inv[2]--;
                    }
                    else
                    {
                        Console.WriteLine("Nincsen medkited");
                    }
                }
                else if (beker=="jugjug")
                {
                    if (player.inv[3] <= 1)
                    {
                        player.jatekos[3] += healek.GetJugjug;
                        if (player.jatekos[0] > 100)
                        {
                            player.jatekos[0] = 100;
                        }

                        player.inv[3]--;
                    }
                    else
                    {
                        Console.WriteLine("Nincsen jugjugod");
                    }
                }
                


                for (int i = 0; i < viewhelp.palya.Length; i++)
                {
                    Console.Write(viewhelp.palya[i]);
                }

                Console.WriteLine();
            } while (true);
            
        }
    }
}