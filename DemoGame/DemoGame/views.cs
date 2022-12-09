using System;
using System.Xml.XPath;


namespace DemoGame
{
    public class Views : Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Üdv a játékban");
            string karakter;
            do
            {
                Console.WriteLine("Válasz karaktert(Fiora, Hawk, Geralt)");
                karakter = Console.ReadLine()?.ToLower();
                if (karakter=="fiora"||karakter=="hawk"||karakter=="geralt")
                {
                    break;
                }
            } while (true);
            Console.WriteLine(karakter);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}