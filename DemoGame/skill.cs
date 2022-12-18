using System;
using System.Data;
using ConsoleTables;

namespace DemoGame
{
    public class Skill
    {
        private static int skillpont = 0;
        private static string[] tamadas = new[] { ".", ".", "." };
        private static string[] vedekezes = new[] { ".", ".", "." };
        private static string[] maxhap = new[] { ".", ".", "." };

        public static int GetSkillpont
        {
            get => skillpont;
            set => skillpont = value;
        }

        public static string[] GetTamadas
        {
            get => tamadas;
            set => tamadas = value;
        }

        public static string[] GetVedekezes
        {
            get => vedekezes;
            set => vedekezes = value;
        }

        public static string[] GetMaxhap
        {
            get => maxhap;
            set => maxhap = value;
        }

        public static void skilltree()
        {
            var table = new ConsoleTable("Támadás:", GetTamadas[0], GetTamadas[1], GetTamadas[2]);
            table.AddRow("Védekezés:", GetVedekezes[0], GetVedekezes[1], GetVedekezes[2]);
            table.AddRow("Max hp:", GetMaxhap[0], GetMaxhap[1], GetMaxhap[2]);
            Console.WriteLine("Válasszon 1 fejlesztést(hp,támadás,védekezés): \n Jelenlegi skilltree:");
            table.Write();
            string beker;
            do
            {
                beker = Console.ReadLine()?.ToLower();
                if (beker == "hp")
                {
                    if (maxhap[0] != "-")
                    {
                        GetMaxhap[0] = "-";
                        player.jatekos[0] = 110;
                    }
                    else if (maxhap[1] != "-")
                    {
                        GetMaxhap[1] = "-";
                        player.jatekos[0] = 120;
                    }
                    else if (maxhap[0] == ".")
                    {
                        GetMaxhap[0] = "-";
                        player.jatekos[0] = 130;
                    }

                    skillpont--;
                    Console.WriteLine(
                        $"Fejlesztette a karakter max hp szintét, mostantól a karakternek:{player.jatekos[0]} életereje lesz");
                    
                }
                else if (beker == "támadás")
                {
                    int i = 0;
                    if (tamadas[0] != "-")
                    {
                        GetTamadas[0] = "-";
                        player.jatekos[4] += 10;
                        player.jatekos[5] += 10;
                        player.jatekos[6] += 10;
                        i = 10;
                    }
                    else if (tamadas[1] != "-")
                    {
                        GetTamadas[1] = "-";
                        player.jatekos[0] = 120;
                        player.jatekos[4] += 20;
                        player.jatekos[5] += 20;
                        player.jatekos[6] += 20;
                        i = 20;
                    }
                    else if (tamadas[2] == ".")
                    {
                        tamadas[2] = "-";
                        player.jatekos[0] = 130;
                        player.jatekos[4] += 30;
                        player.jatekos[5] += 30;
                        player.jatekos[6] += 30;
                        i = 30;
                    }

                    skillpont--;
                    Console.WriteLine(
                        $"Fejlesztette a karakter sebzés szintét, mostantól a karakternek:{i} bónusz sebzése lesz");
                    
                }
                else if (beker == "védekezés")
                {
                    if (vedekezes[0] != "-")
                    {
                        GetVedekezes[0] = "-";
                        player.jatekos[7] = 5;
                    }
                    else if (vedekezes[1] != "-")
                    {
                        GetVedekezes[1] = "-";
                        player.jatekos[7] = 10;
                    }
                    else if (vedekezes[0] == ".")
                    {
                        GetVedekezes[0] = "-";
                        player.jatekos[7] = 15;
                    }

                    Console.WriteLine(
                        $"Fejlesztette a karakter védekezés szintét, mostantól a karakternek:{player.jatekos[7]}bónusz védekezése lesz");
                    skillpont--;
                    
                }
                else if (beker=="kilép")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Válasszon 1 fejlesztést(hp,támadás,védekezés)t");
                    
                }

               table.Write();
            } while (true);

            
        }
    }
}