using System;
using System.Data;
using ConsoleTables;
namespace DemoGame
{
    public class Skill
    {
        private static string[] tamadas=new []{".",".","."};
        private static string[] vedekezes=new []{".",".","."};
        private static string[] maxhap=new []{".",".","."};

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
            var table = new ConsoleTable("Támadás:",GetTamadas[0],GetTamadas[1],GetTamadas[2]);
            table.AddRow("Védekezés:",GetVedekezes[0],GetVedekezes[1],GetVedekezes[2]);
            table.AddRow("Max hp:",GetMaxhap[0],GetMaxhap[1],GetMaxhap[2]);
            Console.WriteLine("Válasszon 1 fejlesztést(hp,támadás,védekezés): \n Jelenlegi skilltree:");
            table.Write();
            string beker = Console.ReadLine()?.ToLower();
            do
            {
                if (beker=="hp")
                {
                    if (maxhap[0]=="-")
                    {
                        maxhap.SetValue("-",1);
                        player.jatekos[0] = 110;
                    }
                    else if(maxhap[1]=="-")
                    {
                        maxhap.SetValue("-",2);
                        player.jatekos[0] = 120;
                    }
                    else if (maxhap[0]==".")
                    {
                        maxhap.SetValue("-",0);
                        player.jatekos[0] = 130;
                    }
                    Console.WriteLine($"Fejlesztette a karakter max hp szintét, mostantól a karakternek:{player.jatekos[0]} életereje lesz");
                    break;
                }
                else if (beker == "támadás")
                {
                    int i = 0;
                    if (tamadas[0]=="-")
                    {
                        tamadas[1] = "-";
                        player.jatekos[4] += 10;
                        player.jatekos[5] += 10;
                        player.jatekos[6] += 10;
                        i = 10;
                    }
                    else if(tamadas[1]=="-")
                    {
                        tamadas[2] = "-";
                        player.jatekos[0] = 120;
                        player.jatekos[4] += 20;
                        player.jatekos[5] += 20;
                        player.jatekos[6] += 20;
                        i = 20;
                    }
                    else if (tamadas[0]==".")
                    {
                        tamadas[0] = "-";
                        player.jatekos[0] = 130;
                        player.jatekos[4] += 30;
                        player.jatekos[5] += 30;
                        player.jatekos[6] += 30;
                        i = 20;
                    }
                    Console.WriteLine($"Fejlesztette a karakter sebzés szintét, mostantól a karakternek:{i} bónusz sebzése lesz");
                    break;
                }
                else if (beker == "védekezés")
                {

                    if (vedekezes[0] == "-")
                    {
                        vedekezes.SetValue("-", 1);
                        player.jatekos[7] = 5;
                    }
                    else if (vedekezes[1] == "-")
                    {
                        vedekezes.SetValue("-", 2);
                        player.jatekos[7] = 10;
                    }
                    else if (vedekezes[0] == ".")
                    {
                        vedekezes.SetValue("-", 0);
                        player.jatekos[7] = 15;
                    }

                    Console.WriteLine(
                        $"Fejlesztette a karakter védekezés szintét, mostantól a karakternek:{player.jatekos[7]}bónusz védekezése lesz");

                    break;
                }
                else 
                {
                    Console.WriteLine("Válasszon 1 fejlesztést(hp,támadás,védekezés)t");
                    beker = Console.ReadLine();
                }
            } while (true); 
            table.Write();
           
        }
    }
}